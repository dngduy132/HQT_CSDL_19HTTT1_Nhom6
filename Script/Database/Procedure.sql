﻿--KH1
CREATE OR ALTER PROCEDURE KH_XEM_TATCA_DN
AS 
	SELECT MADN, TEN_DN,THANH_PHO,QUAN,DIA_CHI
	FROM DOANH_NGHIEP
GO

--KH2 
CREATE OR ALTER PROCEDURE KH_XEM_SP_THEO_MADN
( 
@MADN CHAR(10)
)
AS 
	SELECT SP.MA_SP,SP.TEN_SP,SP.GIA,SP.SO_LUONG,SP.MO_TA
	FROM  DOANH_NGHIEP  DN JOIN CHI_NHANH  CN
		  ON (DN.MADN=CN.MADN) 
		  JOIN CHINHANH_SANPHAM CN_SP
		  ON (CN.MA_CN=CN_SP.MA_CN)
		  JOIN SAN_PHAM SP
		  ON (CN_SP.MA_SP=SP.MA_SP)
	WHERE DN.MADN=@MADN
GO

--KH3
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

 --KH4
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


 --KH5
 CREATE OR ALTER PROCEDURE KH_THONGKE_DN_SP
(
@TENDN NVARCHAR(50)
)
AS 
SELECT SP.MA_SP,SP.TEN_SP,SP.GIA,SP.SO_LUONG
FROM  DOANH_NGHIEP  DN JOIN CHI_NHANH  CN
ON (DN.MADN=CN.MADN) 
JOIN CHINHANH_SANPHAM CN_SP
ON (CN.MA_CN=CN_SP.MA_CN)
JOIN SAN_PHAM SP
ON (CN_SP.MA_SP=SP.MA_SP)
WHERE DN.TEN_DN LIKE @TENDN 
ORDER BY SP.SO_LUONG DESC
GO

 --KH6
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
INSERT INTO DON_DAT_HANG
VALUES (@MADON,@MAKV,@MADN,NULL,@MAKH,GETDATE(),N'CHỜ XÁC NHẬN',NULL,NULL,10000,@HINHTHUCTHANHTOAN)
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

 --TX1

 CREATE OR ALTER PROCEDURE TX_XEM_DH
 AS 
 SELECT * FROM DON_DAT_HANG
 WHERE MA_TX=NULL
 GO

 --TX2
 CREATE OR ALTER PROCEDURE TX_NHAN_DH
 (
 @MATX CHAR(10),
 @MADH CHAR(10)
 )
 AS 
	UPDATE DON_DAT_HANG
    SET MA_TX=@MATX
    WHERE MA_DON=@MADH

GO

-- DN1: Xem danh sách hóa đơn của doanh nghiệp
CREATE OR ALTER PROCEDURE DN_XEM_DS_HD
(
	@MADN CHAR(10)
)
AS 
	SELECT * FROM DON_DAT_HANG WHERE MADN = @MADN
GO

-- DN2: Xem danh sách sản phẩm của doanh nghiệp
CREATE OR ALTER PROCEDURE DN_XEM_DS_SP
(
	@MADN CHAR(10)
)
AS
	SELECT SP.MA_SP,SP.TEN_SP,SP.GIA,SP.SO_LUONG,SP.MO_TA
	FROM  DOANH_NGHIEP  DN JOIN CHI_NHANH  CN
		  ON (DN.MADN=CN.MADN) 
		  JOIN CHINHANH_SANPHAM CN_SP
		  ON (CN.MA_CN=CN_SP.MA_CN)
		  JOIN SAN_PHAM SP
		  ON (CN_SP.MA_SP=SP.MA_SP)
	WHERE DN.MADN=@MADN
GO 

 --DN3
 CREATE OR ALTER PROCEDURE CAPNHAP_GIA_TEN_SP
 (
@MASP  CHAR(10),
@GIA INT,
@TENSP NVARCHAR(50)
 )
 AS  UPDATE SAN_PHAM 
 SET GIA=@GIA,
 TEN_SP=@TENSP
 WHERE MA_SP=@MASP


 --DN4
 GO 

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

 GO


 --QT1
 CREATE OR ALTER PROCEDURE AD_XEM_DN
 AS 
 SELECT * 
 FROM DOANH_NGHIEP
 GO

 --QT2
 CREATE OR ALTER PROCEDURE CAPNHAT_DN
 (
 @MADN CHAR(10),
 @QUAN  NVARCHAR(50)
 )
 AS UPDATE DOANH_NGHIEP 
 SET QUAN=@QUAN
 WHERE MADN=@MADN

 GO