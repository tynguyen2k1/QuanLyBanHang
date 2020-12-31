﻿CREATE DATABASE QL_BAN_HANG
GO
	USE QL_BAN_HANG
GO
	CREATE TABLE DANH_MUC (
		Ma_DM CHAR(10) NOT NULL PRIMARY KEY,
		TEN_DM NVARCHAR(100) NOT NULL UNIQUE,
		MO_TA NVARCHAR(200),
		TRANG_THAI TINYINT DEFAULT 0,
	)
GO
INSERT INTO
	Danh_muc(MA_DM, Ten_dm, mo_ta)
VALUES
	('QB000002', N'Quần Bò', N'Tôn Vóc Dáng'),
	('QB000003', N'Quần Cộc', N'Măc Thoáng mát'),
	('QB000004', N'Bộ Quần Áo Adidass', N'Mặc Mát Mẻ');

GO
	CREATE TABLE SAN_PHAM (
		MA_SP CHAR(10) NOT NULL PRIMARY KEY,
		TEN_SP NVARCHAR(200) NOT NULL,
		GIA_NHAP FLOAT NOT NULL,
		GIA_BAN FLOAT NOT NULL,
		SO_LUONG INT DEFAULT 0,
		GIAM_GIA INT DEFAULT 0,
		GHI_CHU NVARCHAR(255),
		MA_DM CHAR(10) NOT NULL,
		TRANG_THAI TINYINT DEFAULT 0,
		CONSTRAINT FK_SP_DM FOREIGN KEY (MA_DM) REFERENCES DANH_MUC(MA_DM),
	)
GO
INSERT INTO
	San_Pham(
		Ma_sp,
		Ten_sp,
		gia_nhap,
		gia_ban,
		So_luong,
		giam_gia,
		ghi_chu,
		ma_dm
	)
VALUES
	(
		'SP00000001',
		N'Quần Jean ABC',
		1100000,
		1300000,
		5,
		10,
		N'đẹp',
		'QB000003'
	),
	(
		'SP00000002',
		N'Quần Jean DEF',
		1200000,
		1400000,
		12,
		0,
		N'đẹp',
		'QB000002'
	),
	(
		'SP00000003',
		N'Quần Jean GHI',
		1300000,
		1500000,
		12,
		20,
		N'đẹp',
		'QB000004'
	),
	(
		'SP00000004',
		N'Quần Jean HIK',
		1400000,
		1600000,
		12,
		10,
		N'đẹp',
		'QB000004'
	),
	(
		'SP00000005',
		N 'Quần Jean KMN',
		1500000,
		1700000,
		12,
		0,
		N'đẹp',
		'QB000003'
	),
	(
		'SP00000006',
		N 'Quần Jean NOP',
		1600000,
		1800000,
		12,
		10,
		N'đẹp',
		'QB000002'
	),
	(
		'SP00000007',
		N 'Quần Jean OPN',
		1700000,
		1900000,
		12,
		0,
		N'đẹp',
		'QB000002'
	),
	(
		'SP00000008',
		N 'Quần Jean MON',
		1800000,
		2000000,
		12,
		10,
		N'đẹp',
		'QB000003'
	),
	(
		'SP00000009',
		N 'Quần Jean PNG',
		1900000,
		2100000,
		12,
		10,
		N'đẹp',
		'QB000004'
	),
	(
		'SP00000010',
		N'Quần Jean SYX',
		2000000,
		2200000,
		12,
		0,
		N'đẹp',
		'QB000004'
	),
	(
		'SP00000011',
		N 'Quần Jean YZN',
		2100000,
		2300000,
		12,
		0,
		N'đẹp',
		'QB000003'
	),
	(
		'SP00000012',
		N'Quần Jean CBD',
		2200000,
		2400000,
		12,
		10,
		N'đẹp',
		'QB000002'
	);

GO
	CREATE TABLE KHACH_HANG (
		MA_KH INT IDENTITY(1, 1) PRIMARY KEY,
		TEN_KH NVARCHAR(55) NOT NULL,
		SDT CHAR(12) NOT NULL,
		DIA_CHI NVARCHAR(100) NOT NULL,
		GIOI_TINH BIT DEFAULT 0,
		NGAY_SINH DATE NOT NULL,
	)
GO
INSERT INTO
	khach_hang(Ten_kh, sdt, dia_chi, gioi_tinh, ngay_Sinh)
VALUES
	('ABC', '0123456789', 'dvdsgvds', 0, '02/11/2000')
GO
	CREATE TABLE NHAN_VIEN (
		MA_NV CHAR(20) PRIMARY KEY,
		TEN_NV NVARCHAR(55) NOT NULL,
		SDT CHAR(12) NOT NULL,
		DIA_CHI NVARCHAR(100) NOT NULL,
		GIOI_TINH BIT DEFAULT 0,
		NGAY_VL DATETIME,
		EMAIL CHAR(100) NOT NULL,
		TAI_KHOAN NVARCHAR(50) NOT NULL,
		MAT_KHAU NVARCHAR(50) NOT NULL,
		CHUC_VU TINYINT DEFAULT 0,
		TRANG_THAI TINYINT DEFAULT 0,
	)
GO
INSERT INTO
	NHAN_VIEN (
		MA_NV,
		TEN_NV,
		SDT,
		DIA_CHI,
		GIOI_TINH,
		NGAY_VL,
		EMAIL,
		TAI_KHOAN,
		MAT_KHAU,
		CHUC_VU
	)
VALUES
	(
		'QL00000001',
		N 'CHU MINH HIỆP',
		'0394599501',
		N'BA-VÌ',
		0,
		'1/1/2020',
		'ADMIN@GMAIL.COM',
		'nv00001',
		'123456',
		2
	),
	(
		'KT00000001',
		N 'CHU MINH HIỆP 1',
		'0394599502',
		N 'Hà Nội',
		1,
		'1/1/2020',
		'ADMIN1@GMAIL.COM',
		'nv0002',
		'123456',
		1
	),
	(
		'NV00000001',
		N 'CHU MINH HIỆP 2',
		'0394599503',
		N'Hồ Chí Minh',
		0,
		'1/1/2020',
		'ADMIN2@GMAIL.COM',
		'nv0002',
		'123456',
		0
	);

GO
	CREATE TABLE HOA_DON(
		MA_HD INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
		MA_NV CHAR(20) NOT NULL,
		NGAY_BAN DATETIME NOT NULL,
		MA_KH INT NOT NULL,
		TONG_TIEN FLOAT NOT NULL,
		CONSTRAINT FK_HD_NV FOREIGN KEY (MA_NV) REFERENCES NHAN_VIEN(MA_NV),
		CONSTRAINT FK_HD_KH FOREIGN KEY (MA_KH) REFERENCES KHACH_HANG(MA_KH),
	)
GO
	CREATE TABLE HOA_DON_NHAP(
		MA_HD_NHAP INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
		MA_NV CHAR(20) NOT NULL,
		NGAY_NHAP DATETIME NOT NULL,
		TONG_TIEN FLOAT NOT NULL,
		CONSTRAINT FK_HDN_NV FOREIGN KEY (MA_NV) REFERENCES NHAN_VIEN(MA_NV),
	)
GO
	CREATE TABLE CT_HOA_DON_NHAP (
		MA_CTHD_NHAP INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
		MA_SP CHAR(10) NOT NULL,
		GIA_NHAP FLOAT NOT NULL,
		GIAM_GIA FLOAT NOT NULL,
		SO_LUONG INT NOT NULL,
		THANH_TIEN FLOAT NOT NULL,
		MA_HD_NHAP INT NOT NULL,
		CONSTRAINT FK_HDN_CTHD FOREIGN KEY (MA_HD_NHAP) REFERENCES HOA_DON_NHAP(MA_HD_NHAP),
		CONSTRAINT FK_CTHD_N_SP FOREIGN KEY (MA_SP) REFERENCES SAN_PHAM(MA_SP),
	)
GO
	CREATE TABLE CT_HOA_DON (
		MA_CTHD INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
		MA_SP CHAR(10) NOT NULL,
		GIA_BAN FLOAT NOT NULL,
		GIAM_GIA FLOAT NOT NULL,
		SO_LUONG INT NOT NULL,
		THANH_TIEN FLOAT NOT NULL,
		MA_HD INT NOT NULL,
		CONSTRAINT FK_HD_CTHD FOREIGN KEY (MA_HD) REFERENCES HOA_DON(MA_HD),
		CONSTRAINT FK_CTHD_SP FOREIGN KEY (MA_SP) REFERENCES SAN_PHAM(MA_SP),
	)
GO
	CREATE PROC GET_ALL_DANH_MUC AS BEGIN
SELECT
	Ma_DM,
	TEN_DM,
	MO_TA
FROM
	DANH_MUC
END
GO
	CREATE PROC GET_ALL_SAN_PHAM AS BEGIN
SELECT
	SAN_PHAM.MA_SP,
	SAN_PHAM.TEN_SP,
	SAN_PHAM.SO_LUONG,
	SAN_PHAM.GIA_NHAP,
	SAN_PHAM.GIA_BAN,
	SAN_PHAM.GIAM_GIA,
	SAN_PHAM.GHI_CHU,
	SAN_PHAM.MA_DM,
	DANH_MUC.TEN_DM
FROM
	SAN_PHAM
	INNER JOIN DANH_MUC ON SAN_PHAM.MA_DM = DANH_MUC.Ma_DM
WHERE
	SAN_PHAM.TRANG_THAI = 0;

END
GO
	CREATE PROC GET_ALL_KHACHHANG AS BEGIN
SELECT
	MA_KH,
	TEN_KH,
	SDT,
	CASE
		KHACH_HANG.GIOI_TINH
		WHEN 'False' THEN N 'Nam'
		WHEN 'True' THEN N 'Nữ'
	END AS Gioi_Tinh,
	KHACH_HANG.DIA_CHI,
	KHACH_HANG.NGAY_SINH
FROM
	KHACH_HANG;

END
GO
	CREATE PROC SEARCH_KHACH_HANG @MA_KH VARCHAR(12),
	@TEN_KH NVARCHAR(55),
	@SDT VARCHAR(12),
	@DIA_CHI NVARCHAR(100) AS BEGIN
SELECT
	MA_KH,
	TEN_KH,
	SDT,
	CASE
		KHACH_HANG.GIOI_TINH
		WHEN 'False' THEN N 'Nam'
		WHEN 'True' THEN N 'Nữ'
	END AS Gioi_Tinh,
	KHACH_HANG.DIA_CHI,
	KHACH_HANG.NGAY_SINH
FROM
	KHACH_HANG
WHERE
	KHACH_HANG.MA_KH LIKE N'%' + @MA_KH + '%'
	AND KHACH_HANG.TEN_KH LIKE '%' + @TEN_KH + '%'
	AND KHACH_HANG.DIA_CHI LIKE N'%' + @DIA_CHI + '%'
	AND KHACH_HANG.SDT LIKE N'%' + @SDT + '%'
END
GO
	CREATE PROC SEARCH_NHAN_VIEN @MA_NV VARCHAR(20),
	@TEN_NV NVARCHAR(55),
	@SDT VARCHAR(12),
	@NGAY_VL VARCHAR(30),
	@DIA_CHI NVARCHAR(100),
	@GIOI_TINH VARCHAR(5),
	@EMAIL VARCHAR(100),
	@TAI_KHOAN NVARCHAR(50),
	@CHUC_VU VARCHAR(5) AS BEGIN
SELECT
	NHAN_VIEN.MA_NV,
	NHAN_VIEN.TEN_NV,
	CASE
		NHAN_VIEN.GIOI_TINH
		WHEN 'False' THEN N 'Nam'
		WHEN 'True' THEN N 'Nữ'
	END AS GIOI_TINH,
	NHAN_VIEN.DIA_CHI,
	NHAN_VIEN.SDT,
	NHAN_VIEN.EMAIL,
	NHAN_VIEN.NGAY_VL,
	NHAN_VIEN.TAI_KHOAN,
	NHAN_VIEN.MAT_KHAU,
	CASE
		NHAN_VIEN.CHUC_VU
		WHEN 0 THEN N 'Nhân Viên'
		WHEN 1 THEN N'Kế Toán'
		ELSE N'Quản Lý'
	END AS CHUC_VU,
	CASE
		NHAN_VIEN.TRANG_THAI
		WHEN 0 THEN N'Hoạt Động'
		WHEN 1 THEN N'Đã Tắt'
		WHEN 2 THEN N'Đang làm'
		WHEN 3 THEN N 'Nghỉ Việc'
		ELSE N'Đã Chặn !!!'
	END AS TRANG_THAI
FROM
	NHAN_VIEN
WHERE
	NHAN_VIEN.TAI_KHOAN LIKE N'%' + @TAI_KHOAN + '%'
	AND NHAN_VIEN.DIA_CHI LIKE N'%' + @DIA_CHI + '%'
	AND NHAN_VIEN.GIOI_TINH LIKE '%' + @GIOI_TINH + '%'
	AND NHAN_VIEN.EMAIL LIKE N'%' + @EMAIL + '%'
	AND NHAN_VIEN.MA_NV LIKE N'%' + @MA_NV + '%'
	AND NHAN_VIEN.NGAY_VL LIKE N'%' + @NGAY_VL + '%'
	AND NHAN_VIEN.CHUC_VU LIKE N'%' + @CHUC_VU + '%'
	AND NHAN_VIEN.TEN_NV LIKE N'%' + @TEN_NV + '%'
	AND NHAN_VIEN.SDT LIKE N'%' + @SDT + '%';

END
GO
	EXEC SEARCH_NHAN_VIEN '',
	N'',
	'',
	'',
	N'',
	'',
	'',
	N'',
	'';

CREATE PROC GET_ALL_NHAN_VIEN AS BEGIN
SELECT
	NHAN_VIEN.MA_NV,
	NHAN_VIEN.TEN_NV,
	CASE
		NHAN_VIEN.GIOI_TINH
		WHEN 'False' THEN N 'Nam'
		WHEN 'True' THEN N 'Nữ'
	END AS GIOI_TINH,
	NHAN_VIEN.DIA_CHI,
	NHAN_VIEN.SDT,
	NHAN_VIEN.EMAIL,
	NHAN_VIEN.NGAY_VL,
	NHAN_VIEN.TAI_KHOAN,
	NHAN_VIEN.MAT_KHAU,
	CASE
		NHAN_VIEN.CHUC_VU
		WHEN 0 THEN N 'Nhân Viên'
		WHEN 1 THEN N'Kế Toán'
		ELSE N'Quản Lý'
	END AS CHUC_VU,
	CASE
		NHAN_VIEN.TRANG_THAI
		WHEN 0 THEN N'Hoạt Động'
		WHEN 1 THEN N'Đã Tắt'
		WHEN 2 THEN N'Đang làm'
		WHEN 3 THEN N 'Nghỉ Việc'
		ELSE N'Đã Chặn !!!'
	END AS TRANG_THAI
FROM
	NHAN_VIEN
END
GO
	/*CREATE PROC UPDATE_DANH_MUC
	 @MA_NV INT ,
	 @TEN_NV NVARCHAR(55) ,
	 @SDT CHAR(12) ,
	 @DIA_CHI NVARCHAR(100),
	 @GIOI_TINH BIT ,
	 @EMAIL CHAR(100),
	 @MAT_KHAU NVARCHAR(50),
	 @CHUC_VU TINYINT,
	 @TRANG_THAI TINYINT
	 AS
	 BEGIN
	 UPDATE NHAN_VIEN SET
	 TEN_NV=@TEN_NV,
	 SDT = @SDT,
	 EMAIL =@EMAIL,
	 GIOI_TINH= @GIOI_TINH,
	 MAT_KHAU =@MAT_KHAU,
	 DIA_CHI =@DIA_CHI,
	 CHUC_VU = @CHUC_VU,
	 TRANG_THAI = @TRANG_THAI
	 WHERE MA_NV=@MA_NV;
	 END
	 GO*/
	CREATE PROC PRD_INSERT_CTHD @MA_SP CHAR(10),
	@SO_LUONG INT,
	@GIA_BAN FLOAT,
	@THANH_TIEN FLOAT,
	@GIAM_GIA FLOAT,
	@MA_HD INT AS BEGIN
INSERT INTO
	CT_HOA_DON (
		MA_SP,
		MA_HD,
		GIAM_GIA,
		GIA_BAN,
		SO_LUONG,
		THANH_TIEN
	)
VALUES
	(
		@MA_SP,
		@SO_LUONG,
		@GIA_BAN,
		@THANH_TIEN,
		@GIAM_GIA,
		@MA_HD
	)
END
GO
	CREATE PROC GETALLHOADON @nv VARCHAR(20) AS BEGIN IF(@nv = 1) BEGIN
SELECT
	HOA_DON.MA_HD,
	HOA_DON.MA_KH,
	KHACH_HANG.TEN_KH,
	HOA_DON.NGAY_BAN,
	HOA_DON.TONG_TIEN,
	HOA_DON.MA_NV
FROM
	HOA_DON,
	KHACH_HANG
WHERE
	HOA_DON.MA_KH = KHACH_HANG.MA_KH
	AND HOA_DON.MA_NV = @nv
END
ELSE BEGIN
SELECT
	HOA_DON.MA_HD,
	HOA_DON.MA_KH,
	KHACH_HANG.TEN_KH,
	HOA_DON.NGAY_BAN,
	HOA_DON.TONG_TIEN,
	HOA_DON.MA_NV
FROM
	HOA_DON,
	KHACH_HANG
WHERE
	HOA_DON.MA_KH = KHACH_HANG.MA_KH
END
END
GO
	CREATE PROC LOC_HOA_DON @manv VARCHAR(20),
	@START DATE,
	@END DATE AS BEGIN IF (@manv = 1) BEGIN
SELECT
	HOA_DON.MA_HD,
	HOA_DON.MA_KH,
	KHACH_HANG.TEN_KH,
	HOA_DON.NGAY_BAN,
	HOA_DON.TONG_TIEN,
	HOA_DON.MA_NV
FROM
	HOA_DON
	JOIN KHACH_HANG ON HOA_DON.MA_KH = KHACH_HANG.MA_KH
WHERE
	HOA_DON.MA_NV = @manv
	AND HOA_DON.NGAY_BAN IN(
		SELECT
			NGAY_BAN
		FROM
			HOA_DON
		WHERE
			@START <= CONVERT(DATE, HOA_DON.NGAY_BAN)
			AND CONVERT(DATE, HOA_DON.NGAY_BAN) <= @END
	);

END
ELSE BEGIN
SELECT
	HOA_DON.MA_HD,
	HOA_DON.MA_KH,
	KHACH_HANG.TEN_KH,
	HOA_DON.NGAY_BAN,
	HOA_DON.TONG_TIEN,
	HOA_DON.MA_NV
FROM
	HOA_DON
	JOIN KHACH_HANG ON HOA_DON.MA_KH = KHACH_HANG.MA_KH
WHERE
	@START <= CONVERT(DATE, HOA_DON.NGAY_BAN)
	AND CONVERT(DATE, HOA_DON.NGAY_BAN) <= @END;

END
END
GO
	CREATE PROC GETALLHOADONNHAP @manv VARCHAR(20) AS BEGIN IF (@manv = 1) BEGIN
SELECT
	HOA_DON_NHAP.MA_HD_NHAP,
	HOA_DON_NHAP.NGAY_NHAP,
	HOA_DON_NHAP.TONG_TIEN,
	NHAN_VIEN.MA_NV,
	NHAN_VIEN.TEN_NV
FROM
	HOA_DON_NHAP,
	NHAN_VIEN
WHERE
	HOA_DON_NHAP.MA_NV = NHAN_VIEN.MA_NV
	AND HOA_DON_NHAP.MA_NV = @manv;

END
ELSE BEGIN
SELECT
	HOA_DON_NHAP.MA_HD_NHAP,
	HOA_DON_NHAP.NGAY_NHAP,
	HOA_DON_NHAP.TONG_TIEN,
	NHAN_VIEN.MA_NV,
	NHAN_VIEN.TEN_NV
FROM
	HOA_DON_NHAP,
	NHAN_VIEN
WHERE
	HOA_DON_NHAP.MA_NV = NHAN_VIEN.MA_NV
END
END
GO
	CREATE PROC LOC_HOA_DON_NHAP @MANV VARCHAR(20),
	@START DATE,
	@END DATE AS BEGIN IF (@MANV = 1) BEGIN
SELECT
	HOA_DON_NHAP.MA_HD_NHAP,
	HOA_DON_NHAP.NGAY_NHAP,
	HOA_DON_NHAP.TONG_TIEN,
	HOA_DON_NHAP.MA_NV,
	NHAN_VIEN.TEN_NV
FROM
	HOA_DON_NHAP
	JOIN NHAN_VIEN ON HOA_DON_NHAP.MA_NV = NHAN_VIEN.MA_NV
WHERE
	@START <= CONVERT(DATE, HOA_DON_NHAP.NGAY_NHAP)
	AND CONVERT(DATE, HOA_DON_NHAP.NGAY_NHAP) <= @END
	AND HOA_DON_NHAP.MA_NV = @MANV;

END
ELSE BEGIN
SELECT
	HOA_DON_NHAP.MA_HD_NHAP,
	HOA_DON_NHAP.NGAY_NHAP,
	HOA_DON_NHAP.TONG_TIEN,
	HOA_DON_NHAP.MA_NV,
	NHAN_VIEN.TEN_NV
FROM
	HOA_DON_NHAP
	JOIN NHAN_VIEN ON HOA_DON_NHAP.MA_NV = NHAN_VIEN.MA_NV
WHERE
	@START <= CONVERT(DATE, HOA_DON_NHAP.NGAY_NHAP)
	AND CONVERT(DATE, HOA_DON_NHAP.NGAY_NHAP) <= @END;

END
END
GO
	CREATE PROC CT_INSERT_HOADONNHAP @MA_SP CHAR(10),
	@SO_LUONG INT,
	@GIA_NHAP FLOAT,
	@THANH_TIEN FLOAT,
	@GIAM_GIA FLOAT,
	@MA_HD INT AS BEGIN
INSERT INTO
	CT_HOA_DON_NHAP(
		MA_SP,
		GIA_NHAP,
		GIAM_GIA,
		SO_LUONG,
		THANH_TIEN,
		MA_HD_NHAP
	)
VALUES
	(
		@MA_SP,
		@GIA_NHAP,
		@GIAM_GIA,
		@SO_LUONG,
		@THANH_TIEN,
		@MA_HD
	)
END
GO
	CREATE proc GETALLCTHD_BAN @ma_hd INT AS BEGIN
SELECT
	CT_HOA_DON.MA_CTHD,
	CT_HOA_DON.MA_SP,
	SAN_PHAM.TEN_SP,
	CT_HOA_DON.SO_LUONG,
	CT_HOA_DON.GIA_BAN,
	CT_HOA_DON.GIAM_GIA,
	CT_HOA_DON.THANH_TIEN,
	CT_HOA_DON.MA_HD
FROM
	CT_HOA_DON
	INNER JOIN SAN_PHAM ON CT_HOA_DON.MA_SP = SAN_PHAM.MA_SP
WHERE
	CT_HOA_DON.MA_HD = @ma_hd
END
GO
	CREATE proc GETALLCTHD_NHAP @ma_hd INT AS BEGIN
SELECT
	CT_HOA_DON_NHAP.MA_CTHD_NHAP,
	CT_HOA_DON_NHAP.MA_SP,
	SAN_PHAM.TEN_SP,
	CT_HOA_DON_NHAP.SO_LUONG,
	CT_HOA_DON_NHAP.GIA_NHAP,
	CT_HOA_DON_NHAP.GIAM_GIA,
	CT_HOA_DON_NHAP.THANH_TIEN,
	CT_HOA_DON_NHAP.MA_HD_NHAP
FROM
	CT_HOA_DON_NHAP
	INNER JOIN SAN_PHAM ON CT_HOA_DON_NHAP.MA_SP = SAN_PHAM.MA_SP
WHERE
	CT_HOA_DON_NHAP.MA_HD_NHAP = @ma_hd
END
GO
	CREATE PROC DELETE_HOA_DON @MA_HD INT AS BEGIN
DELETE FROM
	CT_HOA_DON
WHERE
	CT_HOA_DON.MA_HD = @MA_HD
DELETE FROM
	HOA_DON
WHERE
	HOA_DON.MA_HD = @MA_HD
END
GO
SELECT
	*
FROM
	KHACH_HANG
WHERE
	ma_kh LIKE '%%';