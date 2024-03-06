create database SOF205_PS31516;
use SOF205_PS31516;
go

create table NhanVien(
	ID int IDENTITY(1,1),
	MaNV varchar(10) primary key,
	Email varchar(255),
	TenNV nvarchar(255),
	Diachi nvarchar(255),
	ChucVu bit,
	TinhTrang bit,
);

create table KhachHang(
	TenKH nvarchar(255),
	SDT char(10) primary key,
	Diachi nvarchar(255),
	GioiTinh bit
);

create table SanPham(
	MaSP int primary key identity(1,1),
	TenSP nvarchar(255),
	SoLuong int,
	GiaNhap int,
	GiaBan int,
	HinhAnh VARBINARY(Max),
	GhiChu nvarchar(255),
	MaNV varchar(10) constraint FK_MaNV foreign key (MaNV) references NhanVien(MaNV)
);

create table Login(
	UserID varchar(255) primary key,
	UserPW varchar(255),
	UserRole bit,
	RequirePasswordChange bit
);
create table NhapKho
(TenSP varchar(255) primary key,
SoLuong int,
NgayNhap date,
MaNV varchar(10) constraint FK_MaNVK foreign key (MaNV) references NhanVien(MaNV)
);
go

-- Khách hàng
CREATE  or ALTER PROCEDURE UpdateKH
    @TenKH nvarchar(255),
	@SDT char(10),
	@Diachi nvarchar(255),
	@GioiTinh bit
AS
BEGIN
    UPDATE KhachHang
    SET 
	TenKH = @TenKH,
	SDT = @SDT,
	Diachi = @Diachi,
	GioiTinh = @GioiTinh
    WHERE SDT = @SDT;
END;
go

CREATE or ALTER PROCEDURE DeleteKH
    @SDT char(10)
AS
BEGIN
    DELETE FROM KhachHang
    WHERE SDT = @SDT;
END;

go
CREATE or ALTER PROCEDURE UpsertKH
    @TenKH nvarchar(255),
	@SDT char(10),
	@Diachi nvarchar(255),
	@GioiTinh bit
AS
BEGIN
    MERGE INTO KhachHang AS target
    USING (SELECT @SDT AS SDT) AS source
    ON target.SDT = source.SDT
    WHEN MATCHED THEN
        UPDATE SET TenKH = @TenKH,
			SDT = @SDT,
			Diachi = @Diachi,
			GioiTinh = @GioiTinh
    WHEN NOT MATCHED THEN
        INSERT (TenKH,SDT,Diachi,GioiTinh)
        VALUES (@TenKH,@SDT,@Diachi,@GioiTinh);
END;
go

CREATE or Alter PROCEDURE SearchCustomerByName
    @CustomerName NVARCHAR(255)
AS
BEGIN
   select TenKH,SDT,Diachi,  CASE WHEN Gioitinh = 1 THEN 'Nam' ELSE N'Nữ' END AS GioiTinh from KhachHang
    WHERE TenKH LIKE '%' + @CustomerName + '%'
END
go

--Nhân viên
create or alter procedure SearchStaffByName
@StaffName nvarchar(255)
as
begin
	select ID ,
	MaNV ,
	Email ,
	TenNV ,
	Diachi ,
	Case When ChucVu = 0 then N'Nhân viên' else N'Quản Lý' end as ChucVu,
	Case when TinhTrang	= 0 then N'Đang hợp tác' else N'Ngưng hợp tác' end as TinhTrang
	from NhanVien
	where TenNV like '%' + @StaffName + '%'
end
go

CREATE or ALTER PROCEDURE DeleteNV
    @MaNV nvarchar(255)
AS
BEGIN
    DELETE FROM NhanVien
    WHERE MaNV = @MaNV;
END;
go
CREATE  or ALTER PROCEDURE UpdateNV
	@MaNV varchar(255),
	@Email varchar(255),
    @TenNV nvarchar(255),
	@Diachi nvarchar(255),
	@ChucVu bit,
	@TinhTrang bit
AS
BEGIN
    UPDATE NhanVien
    SET 
	Email = @Email,
	TenNV = @TenNV,
	Diachi = @Diachi,
	ChucVu = @ChucVu,
	TinhTrang = @TinhTrang
    WHERE MaNV = @MaNV;
END;

go
CREATE  or alter PROCEDURE ChangePassword
    @UserID varchar(255),
    @NewPassword VARCHAR(255) 
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ExistingPassword VARCHAR(255)

    SELECT @ExistingPassword = UserPW
    FROM Login
    WHERE UserID = @UserID;

    IF @ExistingPassword IS NOT NULL
    BEGIN
        UPDATE Login
        SET UserPW = @NewPassword, RequirePasswordChange = 1
        WHERE UserID = @UserID
	END
END
go

--Sản phẩm
go
CREATE OR ALTER PROCEDURE InsertOrUpdateSanPham
	@tensp NVARCHAR(255),
	@soluong INT,
	@gianhap MONEY,
	@giaban MONEY,
	@hinhanh VARBINARY(MAX),
	@ghichu NVARCHAR(255),
	@email VARCHAR(50)
AS
BEGIN
	-- Kiểm tra xem sản phẩm đã tồn tại trong bảng SanPham chưa
	DECLARE @manv VARCHAR(10)
	DECLARE @existingProductId INT

	SELECT @manv = MaNV FROM NhanVien WHERE Email = @email
	SELECT @existingProductId = MaSP FROM SanPham WHERE TenSP = @tensp

	IF @existingProductId IS NULL
	BEGIN
		-- Nếu sản phẩm chưa tồn tại, thêm mới vào bảng SanPham
		INSERT INTO SanPham (TenSP, SoLuong, GiaNhap, GiaBan, HinhAnh, GhiChu, MaNV)
		VALUES (@tensp, @soluong, @gianhap, @giaban, @hinhanh, @ghichu, @manv)
	END
	ELSE
	BEGIN
		-- Nếu sản phẩm đã tồn tại, cập nhật thông tin sản phẩm
		UPDATE SanPham
		SET SoLuong = SoLuong + @soluong, GiaNhap = @gianhap, GiaBan = @giaban, HinhAnh = @hinhanh, GhiChu = @ghichu, MaNV = @manv
		WHERE MaSP = @existingProductId
	END
END

go 


create or alter procedure SearchProByName
@ProName nvarchar(255)
as
begin
	select 
	MaSP,
	TenSP,
	SoLuong,
	GiaNhap,
	GiaBan,
	HinhAnh,
	GhiChu,
	MaNV
	from SanPham
	where TenSP like '%' + @ProName	 + '%'
end

go
CREATE or alter PROCEDURE InsertKho
    @TenSP NVARCHAR(255),
    @Soluong INT,
    @email VARCHAR(255)
AS
BEGIN
    declare @manv varchar(10)
	select @manv = MaNV from NhanVien where Email = @email
    INSERT INTO NhapKho(TenSP,SoLuong,NgayNhap,MaNV)
    VALUES (@TenSP, @Soluong, GETDATE(), @manv);
END
go
CREATE or ALTER PROCEDURE DeleteSP
    @MaSP int
AS
BEGIN
    DELETE FROM SanPham
    WHERE MaSP = @MaSP;
END;

go
create or alter proc UpdateSP
	@masp int,
	@tensp NVARCHAR(255),
	@soluong INT,
	@gianhap MONEY,
	@giaban MONEY,
	@hinhanh VARBINARY(MAX),
	@ghichu NVARCHAR(255),
	@email VARCHAR(50)
	as
	begin
	DECLARE @manv VARCHAR(10)
	SELECT @manv = MaNV FROM NhanVien WHERE Email = @email
	UPDATE SanPham
		SET SoLuong = SoLuong + @soluong, GiaNhap = @gianhap, GiaBan = @giaban, HinhAnh = @hinhanh, GhiChu = @ghichu, MaNV = @manv
		WHERE MaSP = @masp
	end

insert into Login values ('admin','admin123',1,1)

go
CREATE OR ALTER PROCEDURE CheckRPC
    @Email VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @RequirePasswordChange BIT, @UserRole BIT

    -- Kiểm tra xem email có tồn tại trong bảng Login không
    IF EXISTS (SELECT 1 FROM Login WHERE UserID = @Email)
    BEGIN
        -- Nếu tồn tại, trả về giá trị từ cột RequirePasswordChange và UserRole
        SELECT @RequirePasswordChange = RequirePasswordChange, @UserRole = UserRole
        FROM Login
        WHERE UserID = @Email;

        -- Trả về giá trị từ cột RequirePasswordChange và UserRole
        SELECT @RequirePasswordChange AS RequirePasswordChange, @UserRole AS UserRole;
    END
    ELSE
    BEGIN
        SELECT 0 AS RequirePasswordChange, 0 AS UserRole;
    END
END
go
CREATE OR ALTER PROCEDURE CheckEmailAndPassword
    @Email VARCHAR(255),
    @Password VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @IsValid BIT = 0

    -- Kiểm tra xem email và mật khẩu có khớp với dữ liệu trong bảng Login không
    IF EXISTS (
        SELECT 1
        FROM Login
        WHERE UserID = @Email AND UserPW = @Password
    )
    BEGIN
        SET @IsValid = 1; -- Gán giá trị 1 (true) nếu tìm thấy khớp
    END

    -- Trả về giá trị true hoặc false
    SELECT @IsValid AS IsValid;
END

go
