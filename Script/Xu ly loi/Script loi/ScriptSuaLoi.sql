
--Tran_1_DirtyRead_Case_1_Fix
-- T1: Doanh nghiệp cập nhật giá sản phẩm có mã là SP26049509
-- T2: Khách hàng xem giá sản phẩm có mã là SP26049509
-- Doanh nghiệp cập nhật giá nhưng không commit => Khách hàng đọc dữ liệu rác

BEGIN TRAN
	UPDATE dbo.SAN_PHAM 
	SET GIA = 500000 
	WHERE MA_SP = 'SP26049509'
	
	WAITFOR DELAY '00:00:05'
	ROLLBACK

GO
--Tran_2_DirtyRead_Case_1_Fix
-- T1: Doanh nghiệp cập nhật giá sản phẩm có mã là SP26049509
-- T2: Khách hàng xem giá sản phẩm có mã là SP26049509
-- Doanh nghiệp cập nhật giá nhưng không commit => Khách hàng đọc dữ liệu rác

BEGIN TRAN
	SELECT GIA 
	FROM dbo.SAN_PHAM  
	WHERE MA_SP = 'SP26049509'
COMMIT TRAN

GO
----Tran_1_DirtyRead_Case_2_Fix
-- T1: Doanh nghiệp cập nhật số lượng sản phẩm có mã là SP26049509
-- T2: Khách hàng xem số lượng sản phẩm có mã là SP26049509
-- Doanh nghiệp cập nhật số lượng nhưng không commit => Khách hàng đọc dữ liệu rác

BEGIN TRAN
	UPDATE dbo.SAN_PHAM 
	SET SO_LUONG = 5 
	WHERE MA_SP = 'SP26049509'
	
	WAITFOR DELAY '00:00:05'
	ROLLBACK

	GO
----Tran_2_DirtyRead_Case_2_Fix
-- T1: Doanh nghiệp cập nhật số lượng sản phẩm có mã là SP26049509
-- T2: Khách hàng xem số lượng sản phẩm có mã là SP26049509
-- Doanh nghiệp cập nhật số lượng nhưng không commit => Khách hàng đọc dữ liệu rác

BEGIN TRAN
	SELECT SO_LUONG 
	FROM dbo.SAN_PHAM 
	WHERE MA_SP = 'SP26049509'
COMMIT TRAN

GO
--Tran_1_LostUpdate_DeadLock_Fix
-- T1: Khách hàng 1 xác nhận mua sản phẩm có mã SP26049509
-- T2: Khách hàng 2 xác nhận mua sản phẩm có mã SP26049509

BEGIN TRAN
	DECLARE @SL INT 
	SET @SL = (SELECT SO_LUONG FROM dbo.SAN_PHAM WITH(UPDLOCK) WHERE MA_SP = 'SP26049509')
	IF (@SL > 0)
	BEGIN	
		WAITFOR DELAY '00:00:05'
		UPDATE dbo.SAN_PHAM SET SO_LUONG = @SL - 1 WHERE MA_SP = 'SP26049509'
	END 
	ELSE 
	BEGIN 
		RAISERROR(N'Hết hàng',15,1)
		ROLLBACK
	END 
COMMIT TRAN

GO
--Tran_2_LostUpdate_DeadLock_Fix

-- T1: Khách hàng 1 xác nhận mua sản phẩm có mã SP26049509
-- T2: Khách hàng 2 xác nhận mua sản phẩm có mã SP26049509

BEGIN TRAN
	DECLARE @SL INT 
	SET @SL = (SELECT SO_LUONG FROM dbo.SAN_PHAM WITH(UPDLOCK) WHERE MA_SP = 'SP26049509')
	IF (@SL > 0)
	BEGIN	
		WAITFOR DELAY '00:00:05'
		UPDATE dbo.SAN_PHAM SET SO_LUONG = @SL - 1 WHERE MA_SP = 'SP26049509'
	END 
	ELSE 
	BEGIN 
		RAISERROR(N'Hết hàng',15,1)
		ROLLBACK
	END 
COMMIT TRAN

GO
--Tran_1_LostUpdate_Fix
-- T1: Khách hàng 1 xác nhận mua sản phẩm có mã SP26049509
-- T2: Khách hàng 2 xác nhận mua sản phẩm có mã SP26049509

BEGIN TRAN
	DECLARE @SL INT 
	SET @SL = (SELECT SO_LUONG FROM dbo.SAN_PHAM WITH(UPDLOCK) WHERE MA_SP = 'SP26049509')
	IF (@SL > 0)
	BEGIN	
		WAITFOR DELAY '00:00:05'
		UPDATE dbo.SAN_PHAM SET SO_LUONG = @SL - 1 WHERE MA_SP = 'SP26049509'
	END 
	ELSE 
	BEGIN 
		RAISERROR(N'Hết hàng',15,1)
		ROLLBACK
	END 
COMMIT TRAN

GO
--Tran_2_LostUpdate_Fix
-- T1: Khách hàng 1 xác nhận mua sản phẩm có mã SP26049509
-- T2: Khách hàng 2 xác nhận mua sản phẩm có mã SP26049509

BEGIN TRAN
	DECLARE @SL INT 
	SET @SL = (SELECT SO_LUONG FROM dbo.SAN_PHAM WITH(UPDLOCK) WHERE MA_SP = 'SP26049509')
	IF (@SL > 0)
	BEGIN	
		WAITFOR DELAY '00:00:05'
		UPDATE dbo.SAN_PHAM SET SO_LUONG = @SL - 1 WHERE MA_SP = 'SP26049509'
	END 
	ELSE 
	BEGIN 
		RAISERROR(N'Hết hàng',15,1)
		ROLLBACK
	END 
COMMIT TRAN


GO
--Tran_1_LostUpdate
-- T1: Tài xế 1 (TX11736641) xác nhận giao hóa đơn có mã hóa đơn  HD56451566
-- T2: Tài xế 2 (TX23114712) đồng thời xác nhận giao hóa đơn có mã hóa đơn  HD56451566
-- Số lượng tài xế tối đa của 1 hóa đơn là 1


BEGIN TRAN
	IF(SELECT MA_TX FROM dbo.DON_DAT_HANG WHERE MA_DON='HD56451566')  IS NULL
	BEGIN	
		WAITFOR DELAY '00:00:05'
		UPDATE dbo.DON_DAT_HANG SET MA_TX = 'TX23114712' WHERE MA_DON = 'HD56451566'
	END 
	ELSE 
	BEGIN 
		RAISERROR(N'ĐƠN HÀNG ĐÃ ĐƯỢC NHẬN',15,1)
		ROLLBACK
	END 
COMMIT TRAN


GO
--Tran_2_LostUpdate
-- T1: Tài xế 1 (TX11736641) xác nhận giao hóa đơn có mã hóa đơn  HD56451566
-- T2: Tài xế 2 (TX23114712) đồng thời xác nhận giao hóa đơn có mã hóa đơn  HD56451566
-- Số lượng tài xế tối đa của 1 hóa đơn là 1

BEGIN TRAN
	IF(SELECT MA_TX FROM dbo.DON_DAT_HANG WHERE MA_DON='HD56451566')  IS NULL
	BEGIN	
		UPDATE dbo.DON_DAT_HANG SET MA_TX = 'TX11736641' WHERE MA_DON = 'HD56451566'
	END 
	ELSE 
	BEGIN 
		RAISERROR(N'ĐƠN HÀNG ĐÃ ĐƯỢC NHẬN',15,1)
		ROLLBACK
	END 
COMMIT TRAN

GO
--Tran_1_LostUpdate_DeadLock_Fix
-- T1: Tài xế 1 (TX11736641) xác nhận giao hóa đơn có mã hóa đơn  HD56451566
-- T2: Tài xế 2 (TX23114712) đồng thời xác nhận giao hóa đơn có mã hóa đơn  HD56451566

BEGIN TRAN
	DECLARE @MATX CHAR(10)
	SET @MATX = (SELECT MA_TX 
				 FROM dbo.DON_DAT_HANG WITH (UPDLOCK)
				 WHERE MA_DON='HD56451566')
	IF @MATX IS NULL
	BEGIN	
		WAITFOR DELAY '00:00:05'
		UPDATE dbo.DON_DAT_HANG 
		SET MA_TX = 'TX23114712' 
		WHERE MA_DON = 'HD56451566'
	END 
	ELSE 
	BEGIN 
		RAISERROR(N'ĐƠN HÀNG ĐÃ ĐƯỢC NHẬN',15,1)
		ROLLBACK
	END 
COMMIT TRAN

GO
--Tran_2_LostUpdate_DeadLock_Fix
-- T1: Tài xế 1 (TX11736641) xác nhận giao hóa đơn có mã hóa đơn  HD56451566
-- T2: Tài xế 2 (TX23114712) đồng thời xác nhận giao hóa đơn có mã hóa đơn  HD56451566

BEGIN TRAN
	DECLARE @MATX CHAR(10)
	SET @MATX = (SELECT MA_TX 
				 FROM dbo.DON_DAT_HANG WITH (UPDLOCK)
				 WHERE MA_DON='HD56451566')
	IF @MATX IS NULL
	BEGIN	
		WAITFOR DELAY '00:00:05'
		UPDATE dbo.DON_DAT_HANG 
		SET MA_TX = 'TX23114712' 
		WHERE MA_DON = 'HD56451566'
	END 
	ELSE 
	BEGIN 
		RAISERROR(N'ĐƠN HÀNG ĐÃ ĐƯỢC NHẬN',15,1)
		ROLLBACK
	END 
COMMIT TRAN

GO
--Tran_1_UnrepeatableRead_1
--T1 : Khách hàng tìm xem có tồn tại sản phẩm có mã là SP26049509 và tên là Ly uống nước
--T2 : Doanh nghiệp đổi tên sản phẩm có mã là SP26049509

BEGIN TRANSACTION
	SELECT COUNT(MA_SP) FROM dbo.SAN_PHAM WHERE MA_SP = 'SP26049509' AND TEN_SP = N'Ly uống nước'
	WAITFOR DELAY '00:00:5'
	SELECT * FROM SAN_PHAM WHERE MA_SP = 'SP26049509' AND TEN_SP = N'Ly uống nước'
COMMIT TRANSACTION

GO
--Tran_2_UnrepeatableRead_1
--T1 : Khách hàng tìm xem có tồn tại sản phẩm có mã là SP26049509 và tên là Ly uống nước
--T2 : Doanh nghiệp đổi tên sản phẩm có mã là SP26049509

BEGIN TRANSACTION
	UPDATE dbo.SAN_PHAM
	SET TEN_SP = N'Ly uống trà'
	WHERE MA_SP = 'SP26049509'
COMMIT TRANSACTION

GO
--Tran_1_UnrepeatableRead_2
--T1 : Khách hàng tìm xem có tồn tại doanh nghiệp có tên Trupebistor Direct ở Quận Tân Bình
--và truy xuất thông tin doanh nghiệp 
--T2 : Quản trị đổi quận của doanh nghiệp 

BEGIN TRAN
	SELECT COUNT(MADN)
	FROM dbo.DOANH_NGHIEP
	WHERE TEN_DN = 'Trupebistor Direct' AND QUAN = N'Quận Tân Bình'
	WAITFOR DELAY '00:00:05'
	SELECT * 
	FROM dbo.DOANH_NGHIEP
	WHERE TEN_DN = 'Trupebistor Direct' AND QUAN = N'Quận Tân Bình'
COMMIT TRAN

GO
--Tran_2_UnrepeatableRead_2
--T1 : Khách hàng tìm xem có tồn tại doanh nghiệp có tên Trupebistor Direct ở Quận Tân Bình
--và truy xuất thông tin doanh nghiệp 
--T2 : Quản trị đổi quận của doanh nghiệp 

BEGIN TRAN
	UPDATE dbo.DOANH_NGHIEP
	SET QUAN = N'Quận 5'
	WHERE TEN_DN = 'Trupebistor Direct' AND QUAN = N'Quận Tân Bình'
COMMIT TRAN


GO
--Tran_1_PhanTom_Case_1_Fix
--T1: Khách hàng xem số lượng các sản phẩm có số lượng = 100 của doanh nghiệp có mã 'DN83267769'
--T2: Doanh nghiệp thêm sản phẩm có số lượng = 100

BEGIN TRAN
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
	SELECT  COUNT(DISTINCT SP.MA_SP)
	FROM SAN_PHAM SP, DOANH_NGHIEP DN, CHI_NHANH CN, CHINHANH_SANPHAM CNSP 
	WHERE DN.MADN = N'DN83267769' AND SP.SO_LUONG = 100 AND CN.MADN = DN.MADN AND SP.MA_SP = CNSP.MA_SP AND CN.MA_CN = CNSP.MA_CN

	WAITFOR DELAY '00:00:05'

	SELECT  DISTINCT SP.MA_SP, SP.TEN_SP, SP.SO_LUONG
	FROM SAN_PHAM SP, DOANH_NGHIEP DN, CHI_NHANH CN, CHINHANH_SANPHAM CNSP 
	WHERE DN.MADN = N'DN83267769' AND SP.SO_LUONG = 100 AND CN.MADN = DN.MADN AND SP.MA_SP = CNSP.MA_SP AND CN.MA_CN = CNSP.MA_CN
COMMIT TRAN


GO
--Tran_2_PhanTom_Case_1_Fix
--T1: Khách hàng xem số lượng các sản phẩm có số lượng = 100 của doanh nghiệp có mã 'DN83267769'
--T2: Doanh nghiệp thêm sản phẩm có số lượng = 100

BEGIN TRAN
	INSERT INTO SAN_PHAM values (N'SP00000001', N'Mì chua cay', 15000, 100, N'Vừa chua vừa cay')
	INSERT INTO CHINHANH_SANPHAM VALUES (N'CN97887052', N'SP00000001')
COMMIT TRAN

GO
--Tran_1_PhanTom_Case_2_Fix
--T1: Doanh nghiệp 'DN71715083' xem số lượng đơn hàng của mình.
--T2: Thêm đơn đặt hàng mới.

BEGIN TRAN
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
	SELECT COUNT( DDH.MA_DON)
	FROM DOANH_NGHIEP DN, DON_DAT_HANG DDH
	WHERE DN.MADN = N'DN71715083' AND DDH.MADN = DN.MADN

	WAITFOR DELAY '00:00:05'

	SELECT DDH.MA_DON, DDH.MA_KV, DDH.MA_TX, DDH.MA_KH, DDH.NGAY_LAP, DDH.TINH_TRANG, DDH.TONG_TIEN_, DDH.PHI_SAN_PHAM, DDH.PHI_VAN_CHUYEN, DDH.HINH_THUC_THANH_TOAN
	FROM DOANH_NGHIEP DN, DON_DAT_HANG DDH
	WHERE DN.MADN = N'DN71715083' AND DDH.MADN = DN.MADN
COMMIT TRAN

GO
--Tran_2_PhanTom_Case_2_Fix
--T1: Doanh nghiệp 'DN71715083' xem số lượng đơn hàng của mình.
--T2: Thêm đơn đặt hàng mới.

BEGIN TRAN
	INSERT INTO DON_DAT_HANG values (N'HD12192021', N'KV69501076', N'DN71715083', N'TX57516577', N'KH30426466', '2021-11-14', N'Chờ lấy hàng', 0, 0, 0, N'Chuyển khoản')
	UPDATE DOANH_NGHIEP SET SL_DON_HANG = SL_DON_HANG + 1 WHERE MADN = N'DN71715083';
COMMIT TRAN

GO
--Tran_1_PhanTom_Case_3_Fix
--T1: Khách hàng xem số lượng sản phẩm có giá > 10000 của doanh nghiệp
--T2: Doanh nghiệp cập nhật giá sản phẩm.

BEGIN TRAN
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
	SELECT  COUNT(DISTINCT SP.MA_SP)
	FROM SAN_PHAM SP, DOANH_NGHIEP DN, CHI_NHANH CN, CHINHANH_SANPHAM CNSP 
	WHERE DN.MADN = N'DN26568168' AND SP.GIA > 10000 AND CN.MADN = DN.MADN AND SP.MA_SP = CNSP.MA_SP AND CN.MA_CN = CNSP.MA_CN

	WAITFOR DELAY '00:00:05'

	SELECT  DISTINCT SP.MA_SP, SP.TEN_SP, SP.SO_LUONG, SP.GIA
	FROM SAN_PHAM SP, DOANH_NGHIEP DN, CHI_NHANH CN, CHINHANH_SANPHAM CNSP 
	WHERE DN.MADN = N'DN26568168' AND SP.GIA > 10000 AND CN.MADN = DN.MADN AND SP.MA_SP = CNSP.MA_SP AND CN.MA_CN = CNSP.MA_CN
COMMIT TRAN

GO
--Tran_2_PhanTom_Case_3_Fix
--T1: Khách hàng xem số lượng sản phẩm có giá > 10000 của doanh nghiệp
--T2: Doanh nghiệp cập nhật giá sản phẩm.

BEGIN TRAN
	UPDATE SAN_PHAM SET GIA = 15000 WHERE MA_SP = N'SP26049509';
COMMIT TRAN