CREATE DATABASE DuLieu_NhanSu;
GO

USE DuLieu_NhanSu;
GO

CREATE TABLE NhanVien
(
MaNhanVien NVARCHAR(10) PRIMARY KEY,
TenNhanVien nText NOT NULL,
LuongCoBan NVARCHAR(12) NOT NULL
);

GO

INSERT INTO NhanVien(MaNhanVien,TenNhanVien,LuongCoBan)
VALUES
(N'NV001','Nguyen Van A',N'100000'),
(N'NV002','Nguyen Van B',N'200000');
GO

SELECT *FROM NhanVien

