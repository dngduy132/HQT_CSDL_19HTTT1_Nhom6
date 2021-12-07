﻿--Phân hệ khách hàng 
--Chức năng xem danh sách doanh nghiệp 
CREATE OR ALTER PROCEDURE KH_XEM_TATCA_DN
AS 
	SELECT MADN, TEN_DN,THANH_PHO,QUAN,DIA_CHI
	FROM DOANH_NGHIEP
GO

--Chức năng xem danh sách sản phẩm của doanh nghiệp
CREATE OR ALTER PROCEDURE KH_XEM_SP_THEO_MADN
( 
	@MADN CHAR(10)
)
AS 
	SELECT SP.MA_SP,SP.TEN_SP,SP.GIA,SP.SO_LUONG,SP.MO_TA
	FROM  DOANH_NGHIEP DN JOIN CHI_NHANH CN 
		  ON (DN.MADN=CN.MADN) 
		  JOIN CHINHANH_SANPHAM CN_SP
		  ON (CN.MA_CN=CN_SP.MA_CN)
		  JOIN SAN_PHAM SP
		  ON (CN_SP.MA_SP=SP.MA_SP)
	WHERE DN.MADN=@MADN
GO

--Chức năng tìm sản phẩm theo tên doanh nghiệp và tên sản phẩm 
CREATE OR ALTER PROCEDURE KH_TIM_SP_THEO_TENDN_TENSP
(
	@TENDN NVARCHAR(50),
	@TENSP NVARCHAR(50)
)
AS 
	SELECT SP.MA_SP,SP.TEN_SP,SP.GIA,SP.SO_LUONG,SP.MO_TA
	FROM  DOANH_NGHIEP  DN JOIN CHI_NHANH  CN
		  ON (DN.MADN=CN.MADN) 
		  JOIN CHINHANH_SANPHAM CN_SP
		  ON (CN.MA_CN=CN_SP.MA_CN)
		  JOIN SAN_PHAM SP
		  ON (CN_SP.MA_SP=SP.MA_SP)
	WHERE DN.TEN_DN LIKE @TENDN 
		  AND SP.TEN_SP LIKE @TENSP
GO

 --Chức năng tìm kiếm doanh nghiệp theo tên doanh nghiệp và tên quận 
 CREATE OR ALTER PROCEDURE TIMDN_THEO_TEN_QUAN  
 (
	@TEN NVARCHAR(50),
	@QUAN NVARCHAR(50)
 )
 AS 
	SELECT * 
	FROM DOANH_NGHIEP DN
	WHERE DN.TEN_DN LIKE  @TEN 
		  AND DN.QUAN LIKE @QUAN
 GO

--Chức năng thống kê sản phẩm theo giá
CREATE OR ALTER PROCEDURE KH_THONGKE_SP_GIA
(
	@TENDN NVARCHAR(50),
	@GIA INT 
)
AS 
	--Thống kê số lượng sản phẩm thỏa điều kiện 
	SELECT COUNT(SP.MA_SP)
	FROM  DOANH_NGHIEP  DN JOIN CHI_NHANH  CN
		  ON (DN.MADN=CN.MADN) 
		  JOIN CHINHANH_SANPHAM CN_SP
		  ON (CN.MA_CN=CN_SP.MA_CN)
		  JOIN SAN_PHAM SP
		  ON (CN_SP.MA_SP=SP.MA_SP)
	WHERE DN.TEN_DN LIKE @TENDN AND SP.GIA >= @GIA

	--Hiển thị thông tin sản phẩm thỏa điều kiện 
	SELECT SP.MA_SP,SP.TEN_SP, SP.MO_TA, SP.GIA
	FROM  DOANH_NGHIEP  DN JOIN CHI_NHANH  CN
		  ON (DN.MADN=CN.MADN) 
		  JOIN CHINHANH_SANPHAM CN_SP
		  ON (CN.MA_CN=CN_SP.MA_CN)
		  JOIN SAN_PHAM SP
		  ON (CN_SP.MA_SP=SP.MA_SP)
	WHERE DN.TEN_DN LIKE @TENDN AND SP.GIA >= @GIA
	ORDER BY SP.GIA DESC
GO

-- Chức năng thống kê sản phẩm theo số lượng 
CREATE OR ALTER PROCEDURE KH_THONGKE_SP_SLUONG
(
	@TENDN NVARCHAR(50),
	@SLUONG INT 
)
AS 
	--Thống kê số lượng sản phẩm thỏa điều kiện 
	SELECT COUNT(SP.MA_SP)
	FROM  DOANH_NGHIEP  DN JOIN CHI_NHANH  CN
		  ON (DN.MADN=CN.MADN) 
		  JOIN CHINHANH_SANPHAM CN_SP
		  ON (CN.MA_CN=CN_SP.MA_CN)
		  JOIN SAN_PHAM SP
		  ON (CN_SP.MA_SP=SP.MA_SP)
	WHERE DN.TEN_DN LIKE @TENDN AND SP.SO_LUONG >= @SLUONG

	--Hiển thị thông tin sản phẩm thỏa điều kiện 
	SELECT SP.MA_SP,SP.TEN_SP, SP.MO_TA, SP.SO_LUONG
	FROM  DOANH_NGHIEP  DN JOIN CHI_NHANH  CN
		  ON (DN.MADN=CN.MADN) 
		  JOIN CHINHANH_SANPHAM CN_SP
		  ON (CN.MA_CN=CN_SP.MA_CN)
		  JOIN SAN_PHAM SP
		  ON (CN_SP.MA_SP=SP.MA_SP)
	WHERE DN.TEN_DN LIKE @TENDN AND SP.SO_LUONG >= @SLUONG
	ORDER BY SP.SO_LUONG DESC
GO

 --Chức năng mua hàng
CREATE OR ALTER PROCEDURE KH_MUA_HANG
( 
	@MADON CHAR(10),
	@MAKV CHAR(10),
	@MADN CHAR(10),
	@MAKH CHAR(10),
	@HINHTHUCTHANHTOAN NVARCHAR(50),
	@SOLUONG INT,
	@MASP CHAR(10)
)
AS 
	--Thêm mới một đơn đặt hàng  
	INSERT INTO	dbo.DON_DAT_HANG
	(
	    MA_DON,
	    MA_KV,
	    MADN,
	    MA_TX,
	    MA_KH,
	    NGAY_LAP,
	    TINH_TRANG,
	    TONG_TIEN_,
	    PHI_SAN_PHAM,
	    PHI_VAN_CHUYEN,
	    HINH_THUC_THANH_TOAN
	)
	VALUES
	(   @MADON,   -- MA_DON - char(10)
	    @MAKV,   -- MA_KV - char(10)
	    @MADN,   -- MADN - char(10)
	    NULL, -- MA_TX - char(10)
	    @MAKH,   -- MA_KH - char(10)
	    GETDATE(), -- NGAY_LAP - date
	    N'Chờ nhận đơn', -- TINH_TRANG - nvarchar(50)
	    NULL, -- TONG_TIEN_ - bigint
	    NULL, -- PHI_SAN_PHAM - int
	    25000, -- PHI_VAN_CHUYEN - int
	    @HINHTHUCTHANHTOAN  -- HINH_THUC_THANH_TOAN - nvarchar(50)
	)

	--Thêm mới chi tiết đơn hàng
	DECLARE @GIA INT
	SET @GIA = (SELECT GIA FROM dbo.SAN_PHAM WHERE MA_SP = @MASP)
	INSERT INTO dbo.CT_DON_HANG
	(
		MA_SP,
		MA_DON,
		SO_LUONG,
		GIA_BAN,
		THANH_TIEN_
	)
	VALUES
	(   @MASP,   -- MA_SP - char(10)
	    @MADON,   -- MA_DON - char(10)
	    @SOLUONG, -- SO_LUONG - int
	    @GIA, -- GIA_BAN - int
	    @SOLUONG * @GIA  -- THANH_TIEN_ - int
	)
GO

--Phân hệ tài xế 
--Chức năng xem danh sách đơn đặt hàng
 CREATE OR ALTER PROCEDURE TX_XEM_DH
 (
	@MATX CHAR(10)
 )
 AS 
	DECLARE @KHUVUC CHAR(10)
	SET @KHUVUC = (SELECT MA_KV FROM dbo.TAI_XE WHERE MA_TX = @MATX)
	SELECT * FROM DON_DAT_HANG
	WHERE MA_TX=NULL AND MA_KV = @KHUVUC
 GO

 --Chức năng nhận đơn hàng 
 CREATE OR ALTER PROCEDURE TX_NHAN_DH
 (
	@MATX CHAR(10),
	@MADH CHAR(10)
 )
 AS 
	UPDATE DON_DAT_HANG
    SET MA_TX=@MATX, TINH_TRANG = 'Đang lấy hàng'
    WHERE MA_DON=@MADH
GO

--Phân hệ doanh nghiệp
-- Chức năng thống kê hóa đơn 
CREATE OR ALTER PROCEDURE DN_TKE_DON_DAT_HANG
(
	@MADN CHAR(10)
)
AS 
	-- Đếm số hóa đơn của doanh nghiệp
	SELECT COUNT(HD.MA_DON) 
	FROM dbo.DOANH_NGHIEP DN JOIN dbo.DON_DAT_HANG HD ON (HD.MADN = DN.MADN)
	WHERE DN.MADN = @MADN

	-- Hiển thị thông tin hóa đơn của doanh nghiệp
	SELECT * FROM DON_DAT_HANG WHERE MADN = @MADN
GO 

 --Chức năng cập nhật thông tin sản phẩm 
 CREATE OR ALTER PROCEDURE CAPNHAP_TTIN_SP
 (
	@MASP CHAR(10),
	@TENSP CHAR(50),
	@GIA INT, 
	@SOLUONG INT
 )
 AS  
	BEGIN TRAN
		UPDATE SAN_PHAM 
		SET TEN_SP = @TENSP, SO_LUONG = @SOLUONG, GIA=@GIA
		WHERE MA_SP=@MASP
		WAITFOR DELAY '00:00:07'
		--ROLLBACK
		COMMIT
 GO 
 EXEC CAPNHAP_TTIN_SP 'SP26049509', N'Ly uống trà', 500000, 1
 
 --Chức năng thêm mới sản phẩm 
 go
CREATE OR ALTER PROCEDURE THEM_SP
(
	@MASP CHAR(10),
	@TENSP NVARCHAR(50),
	@GIA INT,
	@SOLUONG INT,
	@MOTA NVARCHAR(100)
)
 AS 
	INSERT INTO SAN_PHAM VALUES( @MASP,@TENSP,@GIA,@SOLUONG,@MOTA)
	--Sai--
 GO

--Phân hệ quản trị 
--Chức năng xem danh sách doanh nghiệp 
 CREATE OR ALTER PROCEDURE AD_XEM_DN
 AS 
 SELECT * 
 FROM DOANH_NGHIEP
 
 GO

 --Chức năng cập nhật thông tin sản phẩm
 CREATE OR ALTER PROCEDURE CAPNHAT_DN
 (
	 @MADN CHAR(10),
	 @QUAN NVARCHAR(50)
 )
 AS 
	 UPDATE DOANH_NGHIEP 
	 SET QUAN=@QUAN
	 WHERE MADN=@MADN
GO

--Phân hệ nhân viên 
--Chức năng cập nhật thông tin doanh nghiệp
CREATE OR ALTER PROCEDURE CAPNHAT_DN_NGUOIDAIDIEN
 (
	 @MADN CHAR(10),
	 @NGUOIDAIDIEN NVARCHAR(50)
 )
 AS 
	 UPDATE DOANH_NGHIEP 
	 SET NGUOI_DAI_DIEN = @NGUOIDAIDIEN
	 WHERE MADN=@MADN

GO 

--Chức năng cập nhật thông tin hợp đồng
CREATE OR ALTER PROCEDURE CAPNHAT_HD_NGUOIDAIDIEN
 (
	 @MADN CHAR(10),
	 @NGUOIDAIDIEN NVARCHAR(50)
 )
 AS 
	 UPDATE dbo.HOP_DONG 
	 SET NGUOI_DAI_DIEN = @NGUOIDAIDIEN
	 WHERE MADN=@MADN