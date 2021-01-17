﻿CREATE DATABASE QL_BAN_HANG
USE  QL_BAN_HANG
GO
CREATE TABLE DANH_MUC
(
	Ma_DM char(10) NOT NULL PRIMARY KEY,
	TEN_DM NVARCHAR(100) NOT NULL unique,
	MO_TA NVARCHAR(200) ,
	TRANG_THAI TINYINT DEFAULT 0,
)

insert into Danh_muc(MA_DM,Ten_dm,mo_ta) values
('QS000001',N'Quần Sort Ống Xuông',N'Tôn Vóc Dáng'),
('QS000002',N'Quần Sort Việt Nam',N'Tôn Vóc Dáng'),
('QS000003',N'Quần Sort Trung Quốc',N'Tôn Vóc Dáng'),
('Qs000004',N'Quần Sort Đức',N'Tôn Vóc Dáng'),
('QB000007',N'Quần Bò Ý',N'Tôn Vóc Dáng'),
('QB000001',N'Quần Bò Ống Xuông',N'Tôn Vóc Dáng'),
('QB000008',N'Quần Bò Việt Nam',N'Tôn Vóc Dáng'),
('QB000005',N'Quần Bò Trung Quốc',N'Tôn Vóc Dáng'),
('QB000006',N'Quần Bò Đức',N'Tôn Vóc Dáng'),
('QB000007',N'Quần Bò Ý',N'Tôn Vóc Dáng'),
('QB000002',N'Quần Bò',N'Tôn Vóc Dáng'),
('QB000003',N'Quần Cộc',N'Măc Thoáng mát'),
('QB000004',N'Bộ Quần Áo Adidass',N'Mặc Mát Mẻ');




GO
CREATE TABLE SAN_PHAM
(
	MA_SP CHAR(10) NOT NULL PRIMARY KEY,
	TEN_SP NVARCHAR(200) NOT NULL,
	GIA_NHAP float NOT NULL,
	GIA_BAN float NOT NULL,
	SO_LUONG INT DEFAULT 0,
	GIAM_GIA int DEFAULT 0,
	GHI_CHU NVARCHAR(255) ,
	MA_DM char(10) NOT NULL,
	TRANG_THAI TINYINT DEFAULT 0,
	CONSTRAINT FK_SP_DM FOREIGN KEY (MA_DM) REFERENCES DANH_MUC(MA_DM),
)
insert into San_Pham(Ma_sp , Ten_sp , gia_nhap , gia_ban , So_luong , giam_gia  , ghi_chu , ma_dm)values
('SP00000001' , N'Quần Jean ABC', 1100000, 1300000 , 5 , 10, N'đẹp','QB000003'),
('SP00000002' , N'Quần Jean DEF', 1200000, 1400000 , 12 , 0  , N'đẹp','QB000002'),
('SP00000003' , N'Quần Jean GHI', 1300000, 1500000 , 12 , 20  , N'đẹp','QB000004'),
('SP00000004' , N'Quần Jean HIK', 1400000, 1600000 , 12 , 10  , N'đẹp','QB000004'),
('SP00000005' , N'Quần Jean KMN', 1500000, 1700000 , 12 , 0  , N'đẹp','QB000003'),
('SP00000006' , N'Quần Jean NOP', 1600000, 1800000 , 12 , 10  , N'đẹp','QB000002'),
('SP00000007' , N'Quần Jean OPN', 1700000, 1900000 , 12 , 0  , N'đẹp','QB000002'),
('SP00000008' , N'Quần Jean MON', 1800000, 2000000 , 12 , 10  , N'đẹp','QB000003'),
('SP00000009' , N'Quần Jean PNG', 1900000, 2100000 , 12 , 10  , N'đẹp','QB000004'),
('SP00000010' , N'Quần Jean SYX', 2000000, 2200000 , 12 , 0  , N'đẹp','QB000004'),
('SP00000011' , N'Quần Jean YZN', 2100000, 2300000 , 12 , 0  , N'đẹp','QB000003'),
('SP00000012' , N'Quần Jean CBD', 2200000, 2400000 , 12 , 10 , N'đẹp','QB000002');

GO
CREATE TABLE KHACH_HANG
(
	MA_KH INT IDENTITY(1,1) PRIMARY KEY,
	TEN_KH NVARCHAR(55) NOT NULL,
	SDT CHAR(12) NOT NULL,
	DIA_CHI NVARCHAR(100) NOT NULL,
	GIOI_TINH BIT DEFAULT 0,
	NGAY_SINH DATE NOT NULL,
)


CREATE TABLE NHAN_VIEN
(
	MA_NV CHAR(20) PRIMARY KEY,
	TEN_NV NVARCHAR(55) NOT NULL,
	SDT CHAR(12) NOT NULL,
	DIA_CHI NVARCHAR(100) NOT NULL,
	GIOI_TINH BIT DEFAULT 0,
	NGAY_VL DATETIME ,
	EMAIL CHAR(100) NOT NULL,
	TAI_KHOAN NVARCHAR(50) NOT NULL,
	MAT_KHAU NVARCHAR(50) NOT NULL,
	CHUC_VU TINYINT DEFAULT 0,
	TRANG_THAI TINYINT DEFAULT 0,
)
INSERT INTO NHAN_VIEN (MA_NV,TEN_NV,SDT,DIA_CHI,GIOI_TINH,NGAY_VL,EMAIL,TAI_KHOAN,MAT_KHAU,CHUC_VU) 
VALUES 
	('QL00000001',N'CHU MINH HIỆP','0394599501',N'BA-VÌ',0,'1/1/2020','ADMIN@GMAIL.COM','ql00001','123456',1),
	('QL00000002',N'CHU MINH HIỆP 1','0394599502',N'Hà Nội',1,'1/1/2020','ADMIN1@GMAIL.COM','ql00002','123456',1),
	('NV00000001',N'CHU MINH HIỆP 2','0394599503',N'Hồ Chí Minh',0,'1/1/2020','ADMIN2@GMAIL.COM','nv00002','123456',0),
	('NV00000003',N'CHU MINH HIỆP 3','0394599503',N'Hồ Chí Minh',0,'3/1/2020','ADMIN2@GMAIL.COM','nv00003','123456',0),
	('NV00000004',N'CHU MINH HIỆP 4','0394599503',N'Hồ Chí Minh',0,'4/1/2020','ADMIN2@GMAIL.COM','nv00004','123456',0),
	('NV00000005',N'CHU MINH HIỆP 5','0394599503',N'Hồ Chí Minh',0,'5/1/2020','ADMIN2@GMAIL.COM','nv00005','123456',0),
	('NV00000006',N'CHU MINH HIỆP 6','0394599503',N'Hồ Chí Minh',0,'6/1/2020','ADMIN2@GMAIL.COM','nv00006','123456',0),
	('NV00000007',N'CHU MINH HIỆP 7','0394599503',N'Hồ Chí Minh',0,'7/1/2020','ADMIN2@GMAIL.COM','nv00007','123456',0),
	('NV00000008',N'CHU MINH HIỆP 8','0394599503',N'Hồ Chí Minh',0,'8/1/2020','ADMIN2@GMAIL.COM','nv00008','123456',0),
	('NV00000009',N'CHU MINH HIỆP 9','0394599503',N'Hồ Chí Minh',0,'9/1/2020','ADMIN2@GMAIL.COM','nv00009','123456',0),
	('NV00000010',N'CHU MINH HIỆP 10','0394599503',N'Hồ Chí Minh',0,'10/1/2020','ADMIN2@GMAIL.COM','nv000010','123456',0),
	('NV00000011',N'CHU MINH HIỆP 11','0394599503',N'Hồ Chí Minh',0,'11/1/2020','ADMIN2@GMAIL.COM','nv000011','123456',0),
	('NV00000012',N'CHU MINH HIỆP 12','0394599503',N'Hồ Chí Minh',0,'12/1/2020','ADMIN2@GMAIL.COM','nv000012','123456',0),
	('NV00000013',N'CHU MINH HIỆP 13','0394599503',N'Hồ Chí Minh',0,'13/1/2020','ADMIN2@GMAIL.COM','nv000013','123456',0);
SET DATEFORMAT DMY
CREATE TABLE HOA_DON(
	MA_HD INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	MA_NV CHAR(20) NOT NULL,
	NGAY_BAN DATETIME NOT NULL,
	MA_KH INT not null,
	TONG_TIEN FLOAT NOT NULL,
	CONSTRAINT FK_HD_NV FOREIGN KEY (MA_NV) REFERENCES NHAN_VIEN(MA_NV),
	CONSTRAINT FK_HD_KH FOREIGN KEY (MA_KH) REFERENCES KHACH_HANG(MA_KH),
)

CREATE TABLE HOA_DON_NHAP(
	MA_HD_NHAP INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	MA_NV CHAR(20) NOT NULL,
	NGAY_NHAP DATETIME NOT NULL,
	TONG_TIEN FLOAT NOT NULL,
	CONSTRAINT FK_HDN_NV FOREIGN KEY (MA_NV) REFERENCES NHAN_VIEN(MA_NV),
)

CREATE TABLE CT_HOA_DON_NHAP (
	MA_CTHD_NHAP INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	MA_SP CHAR(10) NOT NULL ,
	GIA_NHAP FLOAT NOT NULL,
	GIAM_GIA FLOAT NOT NULL,
	SO_LUONG INT NOT NULL,
	THANH_TIEN FLOAT NOT NULL, 
	MA_HD_NHAP INT NOT NULL ,
	CONSTRAINT FK_HDN_CTHD FOREIGN KEY (MA_HD_NHAP) REFERENCES HOA_DON_NHAP(MA_HD_NHAP)
)

CREATE TABLE CT_HOA_DON (
	MA_CTHD INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	MA_SP CHAR(10) NOT NULL ,
	GIA_BAN FLOAT NOT NULL,
	GIAM_GIA FLOAT NOT NULL,
	SO_LUONG INT NOT NULL,
	THANH_TIEN FLOAT NOT NULL, 
	MA_HD INT NOT NULL ,
	CONSTRAINT FK_HD_CTHD FOREIGN KEY (MA_HD) REFERENCES HOA_DON(MA_HD)
)
GO

create PROC GET_ALL_DANH_MUC_TON_TAI
AS 
BEGIN
	SELECT Ma_DM,TEN_DM,MO_TA , case DANH_MUC.TRANG_THAI when 0 then N'Tồn Tại' else 'Đã Xoá' end as TRANG_THAI FROM DANH_MUC WHERE DANH_MUC.TRANG_THAI = 0;
END
GO

CREATE PROC GET_ALL_DANH_MUC_DELETE
AS 
BEGIN
	SELECT Ma_DM,TEN_DM,MO_TA , case DANH_MUC.TRANG_THAI when 0 then N'Tồn Tại' else 'Đã Xoá' end as TRANG_THAI FROM DANH_MUC WHERE DANH_MUC.TRANG_THAI = 1;
END
GO

CREATE PROC SEARCH_DANH_MUC_TON_TAI
@MA_DM VARCHAR(10),
@TEN_DM VARCHAR(100),
@MO_TA VARCHAR(200)
AS 
BEGIN
	SELECT Ma_DM,TEN_DM,MO_TA , case DANH_MUC.TRANG_THAI when 0 then N'Tồn Tại' else 'Đã Xoá' end as TRANG_THAI FROM DANH_MUC
	WHERE DANH_MUC.Ma_DM LIKE '%'+@MA_DM+'%' AND DANH_MUC.TEN_DM LIKE '%'+@TEN_DM+'%' AND DANH_MUC.MO_TA LIKE '%'+@MO_TA+'%' AND DANH_MUC.TRANG_THAI=0;
END
GO

CREATE PROC SEARCH_DANH_MUC_DELETE
@MA_DM VARCHAR(10),
@TEN_DM VARCHAR(100),
@MO_TA VARCHAR(200)
AS 
BEGIN
	SELECT Ma_DM,TEN_DM,MO_TA , case DANH_MUC.TRANG_THAI when 0 then N'Tồn Tại' else 'Đã Xoá' end as TRANG_THAI FROM DANH_MUC
	WHERE DANH_MUC.Ma_DM LIKE '%'+@MA_DM+'%' AND DANH_MUC.TEN_DM LIKE '%'+@TEN_DM+'%' AND DANH_MUC.MO_TA LIKE '%'+@MO_TA+'%' AND DANH_MUC.TRANG_THAI=1;
END
GO

CREATE PROC GET_ALL_SAN_PHAM
AS
BEGIN
	SELECT SAN_PHAM.MA_SP , SAN_PHAM.TEN_SP , SAN_PHAM.SO_LUONG,SAN_PHAM.GIA_NHAP,SAN_PHAM.GIA_BAN ,SAN_PHAM.GIAM_GIA , SAN_PHAM.GHI_CHU ,SAN_PHAM.MA_DM,DANH_MUC.TEN_DM 
	FROM SAN_PHAM INNER JOIN DANH_MUC ON SAN_PHAM.MA_DM = DANH_MUC.Ma_DM WHERE SAN_PHAM.TRANG_THAI = 0;
END
GO

ALTER PROC SEARCH_SAN_PHAM
    @MA_SP VARCHAR(10),
	@TEN_SP NVARCHAR(200),
	@GIA_NHAP VARCHAR(20),
	@GIA_BAN VARCHAR(20) ,
	@SO_LUONG VARCHAR(20) ,
	@GIAM_GIA VARCHAR(20) ,
	@GHI_CHU NVARCHAR(255) ,
	@MA_DM VARCHAR(10)
AS
BEGIN
	SELECT SAN_PHAM.MA_SP , SAN_PHAM.TEN_SP , SAN_PHAM.SO_LUONG,SAN_PHAM.GIA_NHAP,SAN_PHAM.GIA_BAN ,SAN_PHAM.GIAM_GIA , SAN_PHAM.GHI_CHU ,SAN_PHAM.MA_DM,DANH_MUC.TEN_DM 
	FROM SAN_PHAM INNER JOIN DANH_MUC ON SAN_PHAM.MA_DM = DANH_MUC.Ma_DM 
	WHERE SAN_PHAM.MA_SP LIKE '%'+@MA_SP+'%' 
	AND SAN_PHAM.TEN_SP LIKE N'%'+@TEN_SP+'%' 
	AND SAN_PHAM.GIA_BAN LIKE '%'+@GIA_BAN+'%' 
	AND SAN_PHAM.GIA_NHAP LIKE '%'+@GIA_NHAP+'%' 
	AND SAN_PHAM.SO_LUONG LIKE '%'+@SO_LUONG+'%' 
	AND SAN_PHAM.GIAM_GIA LIKE '%'+@GIAM_GIA+'%'
	AND SAN_PHAM.GHI_CHU LIKE N'%'+@GHI_CHU+'%'  
	AND SAN_PHAM.MA_DM LIKE '%'+@MA_DM+'%';
END

GO

CREATE PROC GET_ALL_KHACHHANG
AS
BEGIN
	SELECT MA_KH,TEN_KH,SDT,case KHACH_HANG.GIOI_TINH when 'False' then N'Nam' when 'True' then N'Nữ' end as Gioi_Tinh,KHACH_HANG.DIA_CHI,KHACH_HANG.NGAY_SINH FROM KHACH_HANG;
END
GO

CREATE PROC SEARCH_KHACH_HANG
@MA_KH VARCHAR(12),
@TEN_KH NVARCHAR(55),
@SDT VARCHAR(12),
@DIA_CHI NVARCHAR(100)
AS
BEGIN
	SELECT MA_KH,TEN_KH,SDT,case KHACH_HANG.GIOI_TINH when 'False' then N'Nam' when 'True' then N'Nữ' end as Gioi_Tinh,KHACH_HANG.DIA_CHI,KHACH_HANG.NGAY_SINH FROM KHACH_HANG
	WHERE KHACH_HANG.MA_KH LIKE N'%'+@MA_KH+'%' AND KHACH_HANG.TEN_KH LIKE '%'+@TEN_KH+'%' AND KHACH_HANG.DIA_CHI LIKE N'%'+@DIA_CHI+'%' AND KHACH_HANG.SDT LIKE N'%'+@SDT+'%'
END
GO 
 

Create PROC SEARCH_NHAN_VIEN 
    @MA_NV VARCHAR(20),
	@TEN_NV NVARCHAR(55),
	@SDT VARCHAR(12) ,
	@NGAY_VL VARCHAR(30),
	@DIA_CHI NVARCHAR(100) ,
	@GIOI_TINH  VARCHAR(5) ,
	@EMAIL VARCHAR(100) ,
	@TAI_KHOAN NVARCHAR(50),
	@CHUC_VU VARCHAR(5)
AS

BEGIN
	SELECT NHAN_VIEN.MA_NV,NHAN_VIEN.TEN_NV,
	CASE NHAN_VIEN.GIOI_TINH when 'False' then N'Nam' when 'True' then N'Nữ' end as GIOI_TINH,
	NHAN_VIEN.DIA_CHI,NHAN_VIEN.SDT,NHAN_VIEN.EMAIL,NHAN_VIEN.NGAY_VL, NHAN_VIEN.TAI_KHOAN , NHAN_VIEN.MAT_KHAU ,
	CASE NHAN_VIEN.CHUC_VU when 0 then N'Nhân Viên Bán Hàng' else N'Quản Lý' end as CHUC_VU ,
	CASE NHAN_VIEN.TRANG_THAI  when 0 then N'Đang làm' when 1 then N'Nghỉ việc' else N'Đã chặn !!!'  end as TRANG_THAI
	FROM NHAN_VIEN 
	WHERE NHAN_VIEN.TAI_KHOAN LIKE N'%'+@TAI_KHOAN+'%' 
	AND NHAN_VIEN.DIA_CHI LIKE N'%'+@DIA_CHI+'%' 
	AND NHAN_VIEN.GIOI_TINH LIKE '%'+@GIOI_TINH+'%' 
	AND NHAN_VIEN.EMAIL LIKE N'%'+@EMAIL+'%' 
	AND NHAN_VIEN.MA_NV LIKE N'%'+@MA_NV+'%' 
	AND NHAN_VIEN.NGAY_VL LIKE N'%'+@NGAY_VL+'%'
	AND NHAN_VIEN.CHUC_VU LIKE N'%'+@CHUC_VU+'%'  
	AND NHAN_VIEN.TEN_NV LIKE N'%'+@TEN_NV+'%'
	AND NHAN_VIEN.SDT LIKE N'%'+@SDT+'%';
END
GO
EXEC SEARCH_NHAN_VIEN '',N'','','',N'','','',N'','';
GO

create PROC GET_ALL_NHAN_VIEN 
AS
BEGIN
	SELECT NHAN_VIEN.MA_NV,NHAN_VIEN.TEN_NV,
	CASE NHAN_VIEN.GIOI_TINH when 'False' then N'Nam' when 'True' then N'Nữ' end as GIOI_TINH,
	NHAN_VIEN.DIA_CHI,NHAN_VIEN.SDT,NHAN_VIEN.EMAIL,NHAN_VIEN.NGAY_VL, NHAN_VIEN.TAI_KHOAN , NHAN_VIEN.MAT_KHAU ,
	CASE NHAN_VIEN.CHUC_VU when 0 then N'Nhân Viên Bán Hàng' else N'Quản Lý' end as CHUC_VU ,
	CASE NHAN_VIEN.TRANG_THAI  when 0 then N'Đang làm' when 1 then N'Nghỉ việc' else N'Đã chặn !!!'  end as TRANG_THAI
	FROM NHAN_VIEN
END
GO


CREATE PROC DELETE_NHAN_VIEN
@MANV CHAR(20)
AS
BEGIN
	UPDATE NHAN_VIEN SET TRANG_THAI = 3 WHERE MA_NV = @MANV;
END

CREATE PROC PRD_INSERT_CTHD

	@MA_SP CHAR(10) ,
	@SO_LUONG INT ,
	@GIA_BAN FLOAT,
	@THANH_TIEN FLOAT , 
	@GIAM_GIA FLOAT ,
	@MA_HD INT
AS
BEGIN 
	INSERT INTO CT_HOA_DON (MA_SP,MA_HD,GIAM_GIA,GIA_BAN,SO_LUONG,THANH_TIEN)
	VALUES (@MA_SP  ,
	@SO_LUONG  ,
	@GIA_BAN ,
	@THANH_TIEN  , 
	@GIAM_GIA  ,
	@MA_HD
	)
END 
GO

CREATE PROC GETALLHOADON
@nv varchar(20)
AS
BEGIN
	if ( SELECT NHAN_VIEN.CHUC_VU FROM NHAN_VIEN WHERE NHAN_VIEN.MA_NV = @NV ) = 0
	begin 
		SELECT HOA_DON.MA_HD , HOA_DON.MA_KH ,KHACH_HANG.TEN_KH , HOA_DON.NGAY_BAN , HOA_DON.TONG_TIEN , HOA_DON.MA_NV  FROM HOA_DON , KHACH_HANG WHERE HOA_DON.MA_KH = KHACH_HANG.MA_KH AND HOA_DON.MA_NV = @nv
	end
	else
	begin
		SELECT HOA_DON.MA_HD , HOA_DON.MA_KH ,KHACH_HANG.TEN_KH , HOA_DON.NGAY_BAN , HOA_DON.TONG_TIEN , HOA_DON.MA_NV  FROM HOA_DON , KHACH_HANG WHERE HOA_DON.MA_KH = KHACH_HANG.MA_KH
	end
END
GO

CREATE PROC LOC_HOA_DON
@manv varchar(20),
@START DATE,
@END DATE
AS
BEGIN
	IF (SELECT NHAN_VIEN.CHUC_VU FROM NHAN_VIEN WHERE NHAN_VIEN.MA_NV = @manv ) = 0
		BEGIN 
		SELECT HOA_DON.MA_HD , HOA_DON.MA_KH ,KHACH_HANG.TEN_KH , HOA_DON.NGAY_BAN , HOA_DON.TONG_TIEN , HOA_DON.MA_NV  FROM HOA_DON JOIN KHACH_HANG ON HOA_DON.MA_KH = KHACH_HANG.MA_KH
		WHERE HOA_DON.MA_NV=@manv AND HOA_DON.NGAY_BAN IN( SELECT NGAY_BAN FROM HOA_DON WHERE  @START <= convert(date,HOA_DON.NGAY_BAN) and convert(date,HOA_DON.NGAY_BAN) <=@END ); 
		END 
	ELSE 
	BEGIN
		SELECT HOA_DON.MA_HD , HOA_DON.MA_KH ,KHACH_HANG.TEN_KH , HOA_DON.NGAY_BAN , HOA_DON.TONG_TIEN , HOA_DON.MA_NV  FROM HOA_DON JOIN KHACH_HANG ON HOA_DON.MA_KH = KHACH_HANG.MA_KH
		WHERE @START <= convert(date,HOA_DON.NGAY_BAN) and convert(date,HOA_DON.NGAY_BAN) <=@END; 
	END
END
GO

CREATE PROC GETALLHOADONNHAP
@manv varchar(20)
AS
BEGIN
	IF (SELECT NHAN_VIEN.CHUC_VU FROM NHAN_VIEN WHERE NHAN_VIEN.MA_NV = @manv ) = 0
		BEGIN 
			SELECT HOA_DON_NHAP.MA_HD_NHAP  , HOA_DON_NHAP.NGAY_NHAP , HOA_DON_NHAP.TONG_TIEN , NHAN_VIEN.MA_NV , NHAN_VIEN.TEN_NV FROM HOA_DON_NHAP , NHAN_VIEN WHERE HOA_DON_NHAP.MA_NV = NHAN_VIEN.MA_NV and HOA_DON_NHAP.MA_NV=@manv;
		END 
	ELSE 
		BEGIN
			SELECT HOA_DON_NHAP.MA_HD_NHAP  , HOA_DON_NHAP.NGAY_NHAP , HOA_DON_NHAP.TONG_TIEN , NHAN_VIEN.MA_NV , NHAN_VIEN.TEN_NV FROM HOA_DON_NHAP , NHAN_VIEN WHERE HOA_DON_NHAP.MA_NV = NHAN_VIEN.MA_NV
		END
END
GO

CREATE PROC LOC_HOA_DON_NHAP
@MANV varchar(20),
@START DATE,
@END DATE
AS
BEGIN
    IF (SELECT NHAN_VIEN.CHUC_VU FROM NHAN_VIEN WHERE NHAN_VIEN.MA_NV = @MANV ) = 0
		BEGIN 
			SELECT HOA_DON_NHAP.MA_HD_NHAP , HOA_DON_NHAP.NGAY_NHAP , HOA_DON_NHAP.TONG_TIEN , HOA_DON_NHAP.MA_NV,NHAN_VIEN.TEN_NV   FROM HOA_DON_NHAP JOIN NHAN_VIEN ON HOA_DON_NHAP.MA_NV = NHAN_VIEN.MA_NV
			WHERE @START <= convert(date,HOA_DON_NHAP.NGAY_NHAP) and convert(date,HOA_DON_NHAP.NGAY_NHAP) <=@END AND HOA_DON_NHAP.MA_NV=@MANV;
		END 
	ELSE 
		BEGIN
			SELECT HOA_DON_NHAP.MA_HD_NHAP , HOA_DON_NHAP.NGAY_NHAP , HOA_DON_NHAP.TONG_TIEN , HOA_DON_NHAP.MA_NV,NHAN_VIEN.TEN_NV   FROM HOA_DON_NHAP JOIN NHAN_VIEN ON HOA_DON_NHAP.MA_NV = NHAN_VIEN.MA_NV
			WHERE @START <= convert(date,HOA_DON_NHAP.NGAY_NHAP) and convert(date,HOA_DON_NHAP.NGAY_NHAP) <=@END;
		END
END
GO

CREATE PROC CT_INSERT_HOADONNHAP
	@MA_SP CHAR(10) ,
	@SO_LUONG INT ,
	@GIA_NHAP FLOAT,
	@THANH_TIEN FLOAT , 
	@GIAM_GIA FLOAT ,
	@MA_HD INT
AS 
BEGIN
	INSERT INTO CT_HOA_DON_NHAP(MA_SP,GIA_NHAP,GIAM_GIA,SO_LUONG,THANH_TIEN , MA_HD_NHAP)
	VALUES (
	@MA_SP  ,
	@GIA_NHAP ,
	@GIAM_GIA  ,
	@SO_LUONG  ,
	@THANH_TIEN  ,
	@MA_HD
	)
END
GO

create proc GETALLCTHD_BAN
@ma_hd int
as
BEGIN 
	SELECT CT_HOA_DON.MA_CTHD , CT_HOA_DON.MA_SP , SAN_PHAM.TEN_SP , CT_HOA_DON.SO_LUONG, CT_HOA_DON.GIA_BAN,CT_HOA_DON.GIAM_GIA , CT_HOA_DON.THANH_TIEN , CT_HOA_DON.MA_HD 
	FROM CT_HOA_DON INNER JOIN SAN_PHAM ON CT_HOA_DON.MA_SP = SAN_PHAM.MA_SP where CT_HOA_DON.MA_HD=@ma_hd
END
GO

create proc GETALLCTHD_NHAP
@ma_hd int
as
BEGIN 
	SELECT CT_HOA_DON_NHAP.MA_CTHD_NHAP , CT_HOA_DON_NHAP.MA_SP , SAN_PHAM.TEN_SP , CT_HOA_DON_NHAP.SO_LUONG, CT_HOA_DON_NHAP.GIA_NHAP,CT_HOA_DON_NHAP.GIAM_GIA , CT_HOA_DON_NHAP.THANH_TIEN , CT_HOA_DON_NHAP.MA_HD_NHAP 
	FROM CT_HOA_DON_NHAP INNER JOIN SAN_PHAM ON CT_HOA_DON_NHAP.MA_SP = SAN_PHAM.MA_SP where CT_HOA_DON_NHAP.MA_HD_NHAP = @ma_hd
END
GO

create PROC SEARCH_HOA_DON 
@MA_NV VARCHAR(20) ,
@MA_HD VARCHAR(10)
AS 
BEGIN 
	IF (SELECT NHAN_VIEN.CHUC_VU FROM NHAN_VIEN WHERE NHAN_VIEN.MA_NV = @MA_NV ) = 0
		BEGIN 
		SELECT HOA_DON.MA_HD , HOA_DON.MA_KH ,KHACH_HANG.TEN_KH , HOA_DON.NGAY_BAN , HOA_DON.TONG_TIEN , HOA_DON.MA_NV  FROM HOA_DON JOIN KHACH_HANG ON HOA_DON.MA_KH = KHACH_HANG.MA_KH
		WHERE HOA_DON.MA_NV=@MA_NV AND HOA_DON.MA_HD LIKE '%'+@MA_HD+'%'; 
		END 
	ELSE 
	BEGIN
		SELECT HOA_DON.MA_HD , HOA_DON.MA_KH ,KHACH_HANG.TEN_KH , HOA_DON.NGAY_BAN , HOA_DON.TONG_TIEN , HOA_DON.MA_NV  FROM HOA_DON JOIN KHACH_HANG ON HOA_DON.MA_KH = KHACH_HANG.MA_KH
		WHERE HOA_DON.MA_HD LIKE '%'+@MA_HD+'%'; 
	END
END
GO
select * from NHAN_VIEN
search_hoa_don 'QL00000001' , '3';

Create proc SEARCH_HOA_DON_NHAP
@ma_hd varchar(10) ,
@manv varchar(20)
as 
begin
	IF (SELECT NHAN_VIEN.CHUC_VU FROM NHAN_VIEN WHERE NHAN_VIEN.MA_NV = @manv ) = 0
		BEGIN 
			SELECT HOA_DON_NHAP.MA_HD_NHAP  , HOA_DON_NHAP.NGAY_NHAP , HOA_DON_NHAP.TONG_TIEN , NHAN_VIEN.MA_NV , NHAN_VIEN.TEN_NV FROM HOA_DON_NHAP , NHAN_VIEN WHERE HOA_DON_NHAP.MA_NV = NHAN_VIEN.MA_NV and HOA_DON_NHAP.MA_NV=@manv and HOA_DON_NHAP.MA_HD_NHAP like '%'+@ma_hd+'%';
		END 
	ELSE 
		BEGIN
			SELECT HOA_DON_NHAP.MA_HD_NHAP  , HOA_DON_NHAP.NGAY_NHAP , HOA_DON_NHAP.TONG_TIEN , NHAN_VIEN.MA_NV , NHAN_VIEN.TEN_NV FROM HOA_DON_NHAP , NHAN_VIEN WHERE HOA_DON_NHAP.MA_NV = NHAN_VIEN.MA_NV and HOA_DON_NHAP.MA_HD_NHAP like '%'+@ma_hd+'%';
		END
end
GO

CREATE PROC DELETE_HOA_DON
@MA_HD INT 
AS 
BEGIN
	DELETE FROM CT_HOA_DON WHERE CT_HOA_DON.MA_HD=@MA_HD
	DELETE FROM HOA_DON WHERE HOA_DON.MA_HD=@MA_HD
END
GO
Select * from HOA_DON
CREATE PROC DELETE_HOA_DON_NHAP
@MA_HD INT 
AS 
BEGIN
	DELETE FROM CT_HOA_DON_NHAP WHERE CT_HOA_DON_NHAP.MA_HD_NHAP=@MA_HD
	DELETE FROM HOA_DON_NHAP WHERE HOA_DON_NHAP.MA_HD_NHAP=@MA_HD
END
GO

CREATE PROC UPDATE_SO_LUONG_SAN_PHAM
@MASP VARCHAR(20) ,
@SL INT
AS 
BEGIN
	UPDATE SAN_PHAM SET SAN_PHAM.SO_LUONG = SAN_PHAM.SO_LUONG + @SL WHERE SAN_PHAM.MA_SP=@MASP;
END
GO
SELECT * FROM SAN_PHAM

CREATE PROC THONG_KE_SAN_PHAM_BAN_CHAY
@NGAY VARCHAR(10),
@THANG VARCHAR(10),
@NAM VARCHAR(10),
@MA_SP VARCHAR(20)
AS
BEGIN 
	Select CT_HOA_DON.MA_SP , Sum(CT_HOA_DON.SO_LUONG) AS N'TONG_SL_BAN' ,SAN_PHAM.TEN_SP , SAN_PHAM.SO_LUONG AS 'SL_CON' from SAN_PHAM 
	inner join CT_HOA_DON on SAN_PHAM.MA_SP = CT_HOA_DON.MA_SP
	where SAN_PHAM.MA_SP LIKE '%'+@MA_SP+'%' AND CT_HOA_DON.MA_HD IN (select MA_HD from HOA_DON where DAY(HOA_DON.NGAY_BAN) LIKE '%'+@NGAY+'%' 
	AND MONTH(HOA_DON.NGAY_BAN) LIKE '%'+@THANG+'%'  AND  YEAR(HOA_DON.NGAY_BAN) LIKE '%'+@NAM+'%')
	Group by CT_HOA_DON.MA_SP , SAN_PHAM.TEN_SP ,SAN_PHAM.SO_LUONG 
	ORDER BY Sum(CT_HOA_DON.SO_LUONG) DESC;
END

GO


CREATE PROC THONG_KE_SAN_PHAM_TON
AS
BEGIN 
	Select SAN_PHAM.MA_SP , 0 AS N'TONG_SL_BAN' ,SAN_PHAM.TEN_SP , SAN_PHAM.SO_LUONG AS 'SL_CON' from SAN_PHAM 
	WHERE MA_SP NOT IN (SELECT DISTINCT CT_HOA_DON.MA_SP FROM CT_HOA_DON);
END

CREATE PROC THONG_KE_SAN_PHAM_NHAP
@NGAY VARCHAR(10),
@THANG VARCHAR(10),
@NAM VARCHAR(10),
@MA_SP VARCHAR(20)
AS
BEGIN 
	Select CT_HOA_DON_NHAP.MA_SP , Sum(CT_HOA_DON_NHAP.SO_LUONG) AS N'TONG_SL_NHAP' ,SAN_PHAM.TEN_SP , SAN_PHAM.SO_LUONG AS 'SL_CON' from SAN_PHAM 
	inner join CT_HOA_DON_NHAP on SAN_PHAM.MA_SP = CT_HOA_DON_NHAP.MA_SP
	where SAN_PHAM.MA_SP LIKE '%'+@MA_SP+'%' AND CT_HOA_DON_NHAP.MA_HD_NHAP IN (select MA_HD_NHAP from HOA_DON_NHAP where DAY(HOA_DON_NHAP.NGAY_NHAP) LIKE '%'+@NGAY+'%' 
	AND MONTH(HOA_DON_NHAP.NGAY_NHAP) LIKE '%'+@THANG+'%'  AND  YEAR(HOA_DON_NHAP.NGAY_NHAP) LIKE '%'+@NAM+'%')
	Group by CT_HOA_DON_NHAP.MA_SP , SAN_PHAM.TEN_SP ,SAN_PHAM.SO_LUONG 
	ORDER BY Sum(CT_HOA_DON_NHAP.SO_LUONG) DESC;
END

