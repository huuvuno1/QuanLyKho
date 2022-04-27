IF NOT EXISTS (
        SELECT *
        FROM sys.databases
        WHERE name = 'quanlykho'
)
BEGIN
    CREATE DATABASE quanlykho
END



USE quanlykho

CREATE TABLE NhanVien (
	MaNv int IDENTITY(0,1) NOT NULL,
	Ten nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	SDT varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Email varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	DiaChi nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	GioiTinh nvarchar(5) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Username varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Password varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CONSTRAINT PK__NhanVien__2725D76AC703FCB9 PRIMARY KEY (MaNv),
	CONSTRAINT UQ__NhanVien__536C85E41C514F83 UNIQUE (Username)
);
CREATE UNIQUE NONCLUSTERED INDEX UQ__NhanVien__536C85E41C514F83 ON quanlykho.dbo.NhanVien (Username);


CREATE TABLE NhaCungCap (
	MaNcc int IDENTITY(0,1) NOT NULL,
	Ten nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	DiaChi nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Email varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	SDT varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK__NhaCungC__3A1951E3E2E55C23 PRIMARY KEY (MaNcc)
);

-- quanlykho.dbo.SanPham definition

-- Drop table

-- DROP TABLE quanlykho.dbo.SanPham;

CREATE TABLE SanPham (
	MaSp int IDENTITY(0,1) NOT NULL,
	Ten nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	MoTa nvarchar(500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	DonViTinh nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK__SanPham__2725087C29FDD160 PRIMARY KEY (MaSp)
);


-- quanlykho.dbo.CuaHang definition

-- Drop table

-- DROP TABLE quanlykho.dbo.CuaHang;

CREATE TABLE CuaHang (
	MaCh int IDENTITY(0,1) NOT NULL,
	Ten nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	DiaChi nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Email varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	SDT varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK__CuaHang__27258E60AB9A095B PRIMARY KEY (MaCh)
);

-- quanlykho.dbo.ChiTietSanPham definition

-- Drop table

-- DROP TABLE quanlykho.dbo.ChiTietSanPham;

CREATE TABLE ChiTietSanPham (
	GiaTien float NULL,
	MaSp int NOT NULL,
	SoLuongTrongKho float NULL,
	MaChiTietSp int IDENTITY(0,1) NOT NULL,
	CONSTRAINT ChiTietSanPham_PK PRIMARY KEY (MaChiTietSp)
);


-- quanlykho.dbo.ChiTietSanPham foreign keys

ALTER TABLE quanlykho.dbo.ChiTietSanPham ADD CONSTRAINT ChiTietSanPham_FK FOREIGN KEY (MaSp) REFERENCES SanPham(MaSp);


-- quanlykho.dbo.HoaDonXuat definition

-- Drop table

-- DROP TABLE quanlykho.dbo.HoaDonXuat;

CREATE TABLE HoaDonXuat (
	MaHD int IDENTITY(0,1) NOT NULL,
	NgayLap datetime NULL,
	MaNv int NOT NULL,
	MaCH int NOT NULL,
	CONSTRAINT HoaDonXuat_PK PRIMARY KEY (MaHD)
);


-- quanlykho.dbo.HoaDonXuat foreign keys

ALTER TABLE quanlykho.dbo.HoaDonXuat ADD CONSTRAINT HoaDonXuat_FK FOREIGN KEY (MaCH) REFERENCES CuaHang(MaCh);
ALTER TABLE quanlykho.dbo.HoaDonXuat ADD CONSTRAINT HoaDonXuat_FK_1 FOREIGN KEY (MaNv) REFERENCES NhanVien(MaNv);

-- quanlykho.dbo.ChiTietHoaDonXuat definition

-- Drop table

-- DROP TABLE quanlykho.dbo.ChiTietHoaDonXuat;

CREATE TABLE ChiTietHoaDonXuat (
	MaHd int NOT NULL,
	SoLuongXuat float NULL,
	MaChiTietSp int NOT NULL,
	CONSTRAINT ChiTietHoaDonXuat_PK PRIMARY KEY (MaHd,MaChiTietSp)
);


-- quanlykho.dbo.ChiTietHoaDonXuat foreign keys

ALTER TABLE quanlykho.dbo.ChiTietHoaDonXuat ADD CONSTRAINT ChiTietHoaDonXuat_FK22 FOREIGN KEY (MaChiTietSp) REFERENCES ChiTietSanPham(MaChiTietSp);
ALTER TABLE quanlykho.dbo.ChiTietHoaDonXuat ADD CONSTRAINT ChiTietHoaDonXuat_FK_2 FOREIGN KEY (MaHd) REFERENCES HoaDonXuat(MaHD);

-- quanlykho.dbo.HoaDonNhap definition

-- Drop table

-- DROP TABLE quanlykho.dbo.HoaDonNhap;

CREATE TABLE HoaDonNhap (
	MaHd int IDENTITY(0,1) NOT NULL,
	NgayLap datetime NULL,
	MaNv int NOT NULL,
	MaNcc int NOT NULL,
	CONSTRAINT PK__HoaDon__2725A6C05BD7A61F PRIMARY KEY (MaHd)
);


-- quanlykho.dbo.HoaDonNhap foreign keys

ALTER TABLE quanlykho.dbo.HoaDonNhap ADD CONSTRAINT FK__HoaDon__MaNv__6D0D32F4 FOREIGN KEY (MaNv) REFERENCES NhanVien(MaNv);
ALTER TABLE quanlykho.dbo.HoaDonNhap ADD CONSTRAINT HoaDonNhap_FK FOREIGN KEY (MaNcc) REFERENCES NhaCungCap(MaNcc);


-- quanlykho.dbo.ChiTietHoaDonNhap definition

-- Drop table

-- DROP TABLE quanlykho.dbo.ChiTietHoaDonNhap;

CREATE TABLE ChiTietHoaDonNhap (
	MaHD int NOT NULL,
	MaSp int NOT NULL,
	SoLuong float NULL,
	GiaNhap float NULL,
	CONSTRAINT PK__ChiTietH__F557F66736360002 PRIMARY KEY (MaHD,MaSp)
);


-- quanlykho.dbo.ChiTietHoaDonNhap foreign keys

ALTER TABLE quanlykho.dbo.ChiTietHoaDonNhap ADD CONSTRAINT FK__ChiTietHoa__MaHD__778AC167 FOREIGN KEY (MaHD) REFERENCES HoaDonNhap(MaHd);
ALTER TABLE quanlykho.dbo.ChiTietHoaDonNhap ADD CONSTRAINT FK__ChiTietHoa__MaSp__787EE5A0 FOREIGN KEY (MaSp) REFERENCES SanPham(MaSp);


-------------------------

-- get hoa don nhap
alter PROC get_hoa_don 
AS
BEGIN
	Select hdn.MaHd, hdn.NgayLap, hdn.MaNv, nv.Ten as TenNhanVien, ncc.MaNcc, ncc.Ten as TenNCC, (
		select COUNT(cthdn.MaHD) from ChiTietHoaDonNhap cthdn 
			WHERE cthdn.MaHD = hdn.MaHd 
	) as SoLoaiSanPham, (
		select sum(cthdn.SoLuong * cthdn.GiaNhap) from ChiTietHoaDonNhap cthdn 
			WHERE cthdn.MaHD = hdn.MaHd 
	) as TongTien FROM HoaDonNhap hdn 
	inner join NhaCungCap ncc on hdn.MaNcc = ncc.MaNcc 
	INNER JOIN NhanVien nv on nv.MaNv = hdn.MaNv 
END


-- view hoa don nhap
create view get_hoa_don_nhap_view
AS
	Select hdn.MaHd, hdn.NgayLap, hdn.MaNv, nv.Ten as TenNhanVien, ncc.MaNcc, ncc.Ten as TenNCC, (
		select COUNT(cthdn.MaHD) from ChiTietHoaDonNhap cthdn 
			WHERE cthdn.MaHD = hdn.MaHd 
	) as SoLoaiSanPham, (
		select sum(cthdn.SoLuong * cthdn.GiaNhap) from ChiTietHoaDonNhap cthdn 
			WHERE cthdn.MaHD = hdn.MaHd 
	) as TongTien FROM HoaDonNhap hdn 
	inner join NhaCungCap ncc on hdn.MaNcc = ncc.MaNcc 
	INNER JOIN NhanVien nv on nv.MaNv = hdn.MaNv 

SELECT * FROM get_hoa_don_nhap_view
-- get hoa don xuat
CREATE PROC get_hoa_don_xuat
AS 
BEGIN 
	SELECT hdx.MaHD, NgayLap, hdx.MaNv, nv.Ten as TenNhanVien, ch.MaCh, ch.Ten as TenCuaHang, 
	(
		SELECT COUNT(cthdx.MaHd) FROM ChiTietHoaDonXuat cthdx 
		WHERE cthdx.MaHd = hdx.MaHD 
		GROUP BY (cthdx.MaHd)
	) as SoLoaiSanPham,
	(
		SELECT SUM(SoLuongXuat * giatien) FROM ChiTietHoaDonXuat cthdx2 
		INNER JOIN ChiTietSanPham ctsp ON cthdx2.MaChiTietSp = ctsp.MaChiTietSp 
		WHERE cthdx2.MaHd = hdx.MaHD 
		GROUP BY (cthdx2.MaHd)
	) as TongTien
	FROM HoaDonXuat hdx 
	inner join NhanVien nv on hdx.MaNv = nv.MaNv 
	INNER JOIN CuaHang ch on ch.MaCh = hdx.MaCH 
END



-- get hoa don xuat
CREATE VIEW get_hoa_don_xuat_view
AS 
	SELECT hdx.MaHD, NgayLap, hdx.MaNv, nv.Ten as TenNhanVien, ch.MaCh, ch.Ten as TenCuaHang, 
	(
		SELECT COUNT(cthdx.MaHd) FROM ChiTietHoaDonXuat cthdx 
		WHERE cthdx.MaHd = hdx.MaHD 
		GROUP BY (cthdx.MaHd)
	) as SoLoaiSanPham,
	(
		SELECT SUM(SoLuongXuat * giatien) FROM ChiTietHoaDonXuat cthdx2 
		INNER JOIN ChiTietSanPham ctsp ON cthdx2.MaChiTietSp = ctsp.MaChiTietSp 
		WHERE cthdx2.MaHd = hdx.MaHD 
		GROUP BY (cthdx2.MaHd)
	) as TongTien
	FROM HoaDonXuat hdx 
	inner join NhanVien nv on hdx.MaNv = nv.MaNv 
	INNER JOIN CuaHang ch on ch.MaCh = hdx.MaCH 

	
SELECT * FROM get_hoa_don_xuat_view WHERE tennhanvien='Vu'




-- trigger cap nhat sp trong kho
alter TRIGGER update_sp_trong_kho ON chitiethoadonnhap
FOR INSERT
AS 
BEGIN 
	DECLARE @masp int
	DECLARE @maspct int
	DECLARE @gia float
	DECLARE @soluong float
	SELECT @masp=MaSp, @gia=GiaNhap, @soluong=SoLuong FROM inserted
	
	select @maspct=MaChiTietSp FROM ChiTietSanPham ctsp WHERE GiaTien = @gia and MaSp = @masp
	
	if (@maspct is NULL) 
		INSERT INTO ChiTietSanPham (GiaTien, MaSp, SoLuongTrongKho)
		VALUES(@gia, @masp, @soluong);
	else
	begin
		UPDATE ChiTietSanPham
		SET SoLuongTrongKho=SoLuongTrongKho + @soluong
		WHERE MaChiTietSp=@maspct;
	end
END


INSERT INTO ChiTietHoaDonNhap
(MaHD, MaSp, SoLuong, GiaNhap)
VALUES(1006, 1004, 80, 15000);
INSERT INTO ChiTietHoaDonNhap
(MaHD, MaSp, SoLuong, GiaNhap)
VALUES(1004, 2, 130, 10000);


CREATE trigger nv on nhanvien
for insert 
AS 
BEGIN 
	SELECT 1
END


INSERT INTO NhanVien(Ten, SDT, Email, DiaChi, GioiTinh, Username, Password)
VALUES('1', '1', '1', '1', '1', '1', '1');

UPDATE NhanVien
SET Ten='muoi'
WHERE Username='1';



-- lay danh sach san pham trong hoa don nhap
CREATE PROC get_sp_in_hoa_don_nhap @ma_hd int
as
begin
	SELECT * FROM ChiTietHoaDonNhap cthdn 
	INNER JOIN SanPham sp ON cthdn.MaSp = sp.MaSp 
	WHERE MaHD = @ma_hd
end

-- lay danh sach san pham trong hoa don nhap
CREATE PROC get_sp_in_hoa_don_xuat @ma_hd int
as
begin
	SELECT sp.MaSp, cthdx.SoLuongXuat, ctsp.GiaTien as GiaXuat, cthdx.MaChiTietSp, sp.Ten as TenSanPham FROM ChiTietHoaDonXuat cthdx 
	INNER JOIN ChiTietSanPham ctsp ON cthdx.MaChiTietSp = ctsp.MaChiTietSp 
	INNER JOIN SanPham sp ON sp.MaSp = ctsp.MaSp 
	WHERE MaHD = @ma_hd
end

SELECT * from SanPham sp 
inner join ChiTietSanPham ctsp on sp.MaSp =ctsp.MaSp 
WHERE ten like '%%'



SELECT MaChiTietSp, GiaTien, MaSp, SoLuongTrongKho                            
FROM ChiTietSanPham WHERE MaSp = 1


create TRIGGER update_soluong_xuatkho on chitiethoadonxuat
for insert
AS 
BEGIN 
	DECLARE @machitiet int 
	DECLARE @soluongxuat int
	
	select @machitiet=MaChiTietSp, @soluongxuat=SoLuongXuat from inserted
	
	UPDATE ChiTietSanPham
	SET SoLuongTrongKho = SoLuongTrongKho - @soluongxuat
	WHERE MaChiTietSp=@machitiet;
END

select SoLuongXuat from ChiTietHoaDonXuat cthdx 
















