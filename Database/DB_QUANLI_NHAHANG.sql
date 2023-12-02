CREATE DATABASE QUANLI_NHAHANG
-- Bảng KhachHang
CREATE TABLE KhachHang (
    MaKhachHang INT PRIMARY KEY,
    Ten NVARCHAR(255),
    DienThoai NVARCHAR(15),
    Email NVARCHAR(255),
    DiaChi NVARCHAR(255)
);

-- Bảng MonAn
CREATE TABLE MonAn (
    MaMonAn INT PRIMARY KEY,
    TenMon NVARCHAR(255),
    Gia DECIMAL(10, 2),
    DanhMuc NVARCHAR(50)
);

-- Bảng DatBan
CREATE TABLE DatBan (
    MaDatBan INT PRIMARY KEY,
    MaKhachHang INT FOREIGN KEY REFERENCES KhachHang(MaKhachHang),
    SoLuongKhach INT,
    ThoiGianDatBan DATETIME,
    TrangThai NVARCHAR(20)
);

-- Bảng HoaDon
CREATE TABLE HoaDon (
    MaHoaDon INT PRIMARY KEY,
    MaDatBan INT FOREIGN KEY REFERENCES DatBan(MaDatBan),
    TongTien DECIMAL(10, 2),
    ThoiGianThanhToan DATETIME
);

-- Bảng ChiTietHoaDon
CREATE TABLE ChiTietHoaDon (
    MaChiTiet INT PRIMARY KEY,
    MaHoaDon INT FOREIGN KEY REFERENCES HoaDon(MaHoaDon),
    MaMonAn INT FOREIGN KEY REFERENCES MonAn(MaMonAn),
    SoLuong INT
);

-- Bảng NhanVien
CREATE TABLE NhanVien (
    MaNhanVien INT PRIMARY KEY,
    Ten NVARCHAR(255),
    ChucVu NVARCHAR(50),
    Luong DECIMAL(10, 2)
);

-- Bảng TaiKhoan
CREATE TABLE TaiKhoan (
    TaiKhoanID INT PRIMARY KEY,
    TenDangNhap NVARCHAR(50) UNIQUE,
    MatKhau NVARCHAR(255),
    LoaiTaiKhoan NVARCHAR(20)
);
-- Thêm dữ liệu cho bảng KhachHang
INSERT INTO KhachHang (MaKhachHang, Ten, DienThoai, Email, DiaChi)
VALUES
    (1, N'Nguyễn Văn A', '0123456789', 'nguyenvana@gmail.com', N'123 Đường ABC'),
    (2, N'Trần Thị B', '0987654321', 'tranthib@gmail.com', N'456 Đường XYZ');

-- Thêm dữ liệu cho bảng MonAn
INSERT INTO MonAn (MaMonAn, TenMon, Gia, DanhMuc)
VALUES
    (1, N'Phở Gà', 45000, N'Phở'),
    (2, N'Bún Riêu', 50000, N'Bún'),
    (3, N'Cơm Gà Xối Mỡ', 60000, N'Cơm');

-- Thêm dữ liệu cho bảng DatBan
INSERT INTO DatBan (MaDatBan, MaKhachHang, SoLuongKhach, ThoiGianDatBan, TrangThai)
VALUES
    (1, 1, 5, '2023-12-01 12:30:00', N'Đã xác nhận'),
    (2, 2, 3, '2023-12-02 18:00:00', N'Chưa xác nhận');

-- Thêm dữ liệu cho bảng HoaDon
INSERT INTO HoaDon (MaHoaDon, MaDatBan, TongTien, ThoiGianThanhToan)
VALUES
    (1, 1, 150000, '2023-12-01 14:00:00'),
    (2, 2, 150000, '2023-12-02 19:30:00');

-- Thêm dữ liệu cho bảng ChiTietHoaDon
INSERT INTO ChiTietHoaDon (MaChiTiet, MaHoaDon, MaMonAn, SoLuong)
VALUES
    (1, 1, 1, 3),
    (2, 1, 2, 2),
    (3, 2, 3, 3);

-- Thêm dữ liệu cho bảng NhanVien
INSERT INTO NhanVien (MaNhanVien, Ten, ChucVu, Luong)
VALUES
    (1, N'Nguyễn Văn N', N'Quản lý', 20000000),
    (2, N'Trần Thị M', N'Nhân viên phục vụ', 10000000);

-- Thêm dữ liệu cho bảng TaiKhoan
INSERT INTO TaiKhoan (TaiKhoanID, TenDangNhap, MatKhau, LoaiTaiKhoan)
VALUES
    (1, 'admin', 'admin123', N'QuanTri'),
    (2, 'nhanvien1', 'nhanvien123', N'NhanVien');
