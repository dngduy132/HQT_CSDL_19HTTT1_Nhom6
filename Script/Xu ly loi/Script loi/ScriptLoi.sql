﻿--DIRTY READ

--Case 1
-- T1: Doanh nghiệp cập nhật giá sản phẩm có mã là SP26049509
-- T2: Khách hàng xem giá sản phẩm có mã là SP26049509
-- Doanh nghiệp cập nhật giá nhưng không commit => Khách hàng đọc dữ liệu rác
 --T1
BEGIN TRAN
	UPDATE dbo.SAN_PHAM SET GIA = 500000 WHERE MA_SP = 'SP26049509'
	WAITFOR DELAY '00:00:05'
	ROLLBACK

--T2
BEGIN TRAN
	SELECT GIA FROM dbo.SAN_PHAM WITH(NOLOCK) WHERE MA_SP = 'SP26049509'
COMMIT TRAN

--Case 2
-- T1: Doanh nghiệp cập nhật số lượng sản phẩm có mã là SP26049509
-- T2: Khách hàng xem số lượng sản phẩm có mã là SP26049509
-- Doanh nghiệp cập nhật số lượng nhưng không commit => Khách hàng đọc dữ liệu rác
--T1 
BEGIN TRAN
	UPDATE dbo.SAN_PHAM SET SO_LUONG = 5 WHERE MA_SP = 'SP26049509'
	WAITFOR DELAY '00:00:05'
	ROLLBACK
--T2
BEGIN TRAN
	SELECT SO_LUONG FROM dbo.SAN_PHAM WITH(NOLOCK) WHERE MA_SP = 'SP26049509'
COMMIT TRAN

--UNREPEATABLE READ
--Case 1
--T1 : Khách hàng tìm xem có tồn tại sản phẩm có mã là SP26049509 và tên là Ly uống nước
--T2 : Doanh nghiệp đổi tên sản phẩm có mã là SP26049509
--T1
BEGIN TRANSACTION
	SELECT COUNT(MA_SP) FROM dbo.SAN_PHAM WHERE MA_SP = 'SP26049509' AND TEN_SP = N'Ly uống nước'
	WAITFOR DELAY '00:00:5'
	SELECT * FROM SAN_PHAM WHERE MA_SP = 'SP26049509' AND TEN_SP = N'Ly uống nước'
COMMIT TRANSACTION
--T2
BEGIN TRANSACTION
	UPDATE dbo.SAN_PHAM
	SET TEN_SP = N'Ly uống trà'
	WHERE MA_SP = 'SP26049509'
COMMIT TRANSACTION

--Case 2
--T1 : Khách hàng tìm xem có tồn tại doanh nghiệp có tên Trupebistor Direct ở Quận Tân Bình
--và truy xuất thông tin doanh nghiệp 
--T2 : Quản trị đổi quận của doanh nghiệp 
--T1
BEGIN TRAN
	SELECT COUNT(MADN)
	FROM dbo.DOANH_NGHIEP
	WHERE TEN_DN = 'Trupebistor Direct' AND QUAN = N'Quận Tân Bình'
	WAITFOR DELAY '00:00:05'
	SELECT * 
	FROM dbo.DOANH_NGHIEP
	WHERE TEN_DN = 'Trupebistor Direct' AND QUAN = N'Quận Tân Bình'
COMMIT TRAN

--T2
BEGIN TRAN
	UPDATE dbo.DOANH_NGHIEP
	SET QUAN = N'Quận 5'
	WHERE TEN_DN = 'Trupebistor Direct' AND QUAN = N'Quận Tân Bình'
COMMIT TRAN



--LOST UPDATE

--Case 1
-- T1: Khách hàng 1 xác nhận mua sản phẩm có mã SP26049509
-- T2: Khách hàng 2 xác nhận mua sản phẩm có mã SP26049509
-- Số lượng sản phẩm hiện tại là 1
-- Số lượng sản phẩm mong muốn sau khi chạy các giao tác: 0

--T1
BEGIN TRAN
	IF(SELECT SO_LUONG FROM dbo.SAN_PHAM WHERE MA_SP = 'SP26049509') > 0
	BEGIN	
		WAITFOR DELAY '00:00:05'
		UPDATE dbo.SAN_PHAM SET SO_LUONG = SO_LUONG - 1 WHERE MA_SP = 'SP26049509'
	END 
	ELSE 
	BEGIN 
		RAISERROR(N'Hết hàng',15,1)
		ROLLBACK
	END 
COMMIT TRAN

--T2 

BEGIN TRAN
	IF(SELECT SO_LUONG FROM dbo.SAN_PHAM WHERE MA_SP = 'SP26049509') > 0
	BEGIN	
		WAITFOR DELAY '00:00:05'
		UPDATE dbo.SAN_PHAM SET SO_LUONG = SO_LUONG - 1 WHERE MA_SP = 'SP26049509'
	END 
	ELSE 
	BEGIN 
		RAISERROR(N'Hết hàng',15,1)
		ROLLBACK
	END 
COMMIT TRAN

--Case 2
-- T1: Tài xế 1 (TX11736641) xác nhận giao hóa đơn có mã hóa đơn  HD56451566
-- T2: Tài xế 2 (TX23114712) đồng thời xác nhận giao hóa đơn có mã hóa đơn  HD56451566
-- Số lượng tài xế tối đa của 1 hóa đơn là 1

--T1 
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

--T2 
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


--PHANTOM:
--Case 1
--T1: Khách hàng xem số lượng các sản phẩm có số lượng = 10 của doanh nghiệp có mã 'DN83267769'
--T2: Doanh nghiệp thêm sản phẩm có số lượng = 10
--Khách hàng xem số lượng các sản phẩm có số lượng = 10 của doanh nghiệp có mã 'DN83267769' lần 1 có 3 sản phẩm
--Khách hàng xem số lượng các sản phẩm có số lượng = 10 của doanh nghiệp có mã 'DN83267769' lần 2 có 4 sản phẩm, danh sách của các sản phẩm đó
--T1
BEGIN TRAN
	SELECT  COUNT(DISTINCT SP.MA_SP)
	from SAN_PHAM SP, DOANH_NGHIEP DN, CHI_NHANH CN, CHINHANH_SANPHAM CNSP 
	WHERE DN.MADN = N'DN83267769' AND SP.SO_LUONG = 10 AND CN.MADN = DN.MADN AND SP.MA_SP = CNSP.MA_SP

	WAITFOR DELAY '00:00:10'

	SELECT  COUNT(DISTINCT SP.MA_SP)
	from SAN_PHAM SP, DOANH_NGHIEP DN, CHI_NHANH CN, CHINHANH_SANPHAM CNSP 
	WHERE DN.MADN = N'DN83267769' AND SP.SO_LUONG = 10 AND CN.MADN = DN.MADN AND SP.MA_SP = CNSP.MA_SP
	SELECT  DISTINCT SP.MA_SP, SP.TEN_SP, SP.SO_LUONG
	from SAN_PHAM SP, DOANH_NGHIEP DN, CHI_NHANH CN, CHINHANH_SANPHAM CNSP 
	WHERE DN.MADN = N'DN83267769' AND SP.SO_LUONG = 10 AND CN.MADN = DN.MADN AND SP.MA_SP = CNSP.MA_SP
COMMIT TRAN


--T2
BEGIN TRAN
	INSERT INTO SAN_PHAM values (N'SP00000001', N'Mì chua cay', 15000, 10, N'Vừa chua vừa cay')
	INSERT INTO CHINHANH_SANPHAM VALUES (N'CN97887052', N'SP00000001')
COMMIT TRAN


--Case 2
--T1: Doanh nghiệp 'DN71715083' xem số lượng đơn hàng của mình.
--T2: Thêm đơn đặt hàng mới.
--Doanh nghiệp xem số lượng đơn hàng lần 1 là 1
--Doanh nghiệp xem số lượng đơn hàng lần 2 là 2
--Doanh nghiệp 'DN71715083' xem số lượng đơn hàng của mình lần 1
--Doanh nghiệp 'DN71715083' xem số lượng đơn hàng của mình lần 2 và danh sách đơn đặt hàng
--T1
BEGIN TRAN
	SELECT COUNT( DDH.MA_DON)
	FROM DOANH_NGHIEP DN, DON_DAT_HANG DDH
	WHERE DN.MADN = N'DN71715083' AND DDH.MADN = DN.MADN

	WAITFOR DELAY '00:00:10'

	SELECT COUNT( DDH.MA_DON)
	FROM DOANH_NGHIEP DN, DON_DAT_HANG DDH
	WHERE DN.MADN = N'DN71715083' AND DDH.MADN = DN.MADN
	SELECT DISTINCT DDH.MA_DON, DDH.MA_KV, DDH.MA_TX, DDH.MA_KH, DDH.NGAY_LAP, DDH.TINH_TRANG, DDH.TONG_TIEN_, DDH.PHI_SAN_PHAM, DDH.PHI_VAN_CHUYEN, DDH.HINH_THUC_THANH_TOAN
	FROM DOANH_NGHIEP DN, DON_DAT_HANG DDH
	WHERE DN.MADN = N'DN71715083' AND DDH.MADN = DN.MADN
COMMIT TRAN



--T2
BEGIN TRAN
	INSERT INTO DON_DAT_HANG values (N'HD11142021', N'KV69501076', N'DN71715083', N'TX57516577', N'KH30426466', '2021-11-14', N'Chờ lấy hàng', 0, 0, 0, N'Chuyển khoản')
	UPDATE DOANH_NGHIEP SET SL_DON_HANG = SL_DON_HANG + 1 WHERE MADN = N'DN71715083';
COMMIT TRAN


--Case 3
--T1: Khách hàng xem số lượng sản phẩm có giá > 10000 của doanh nghiệp
--T2: Doanh nghiệp cập nhật giá sản phẩm.
--Khách hàng xem số lượng các sản phẩm có giá > 10000 lần 1 là 21.
--Khách hàng xem số lượng các sản phẩm có giá > 10000 lần 2 là 20 và xem danh sách các sản phẩm.

--T1
BEGIN TRAN
	SELECT  COUNT(DISTINCT SP.MA_SP)
	from SAN_PHAM SP, DOANH_NGHIEP DN, CHI_NHANH CN, CHINHANH_SANPHAM CNSP 
	WHERE DN.MADN = N'DN83267769' AND SP.GIA > 10000 AND CN.MADN = DN.MADN AND SP.MA_SP = CNSP.MA_SP

	WAITFOR DELAY '00:00:10'

	SELECT  COUNT(DISTINCT SP.MA_SP)
	from SAN_PHAM SP, DOANH_NGHIEP DN, CHI_NHANH CN, CHINHANH_SANPHAM CNSP 
	WHERE DN.MADN = N'DN83267769' AND SP.GIA > 10000 AND CN.MADN = DN.MADN AND SP.MA_SP = CNSP.MA_SP
	SELECT  DISTINCT SP.MA_SP, SP.TEN_SP, SP.SO_LUONG, SP.GIA
	from SAN_PHAM SP, DOANH_NGHIEP DN, CHI_NHANH CN, CHINHANH_SANPHAM CNSP 
	WHERE DN.MADN = N'DN83267769' AND SP.GIA > 10000 AND CN.MADN = DN.MADN AND SP.MA_SP = CNSP.MA_SP
COMMIT TRAN

--T2
BEGIN TRAN
	UPDATE SAN_PHAM SET GIA = 1000 WHERE MA_SP = N'SP26049509';
COMMIT TRAN

--Circle Deadlock 
--T1: Nhân viên 1 cập nhật thông tin người đại diện trong bảng doanh nghiệp trước 
--rồi cập nhật bảng hợp đồng sau  
--T2: Nhân viên 2 cập nhật thông tin người đại diện trong bảng hợp đồng trước 
--rồi cập nhật bảng doanh nghiệp sau 

-- T1
BEGIN TRAN
	UPDATE dbo.DOANH_NGHIEP 
	SET NGUOI_DAI_DIEN = N'Nguyễn Văn A' 
	WHERE MADN = 'DN61092796 '

	WAITFOR	DELAY '00:00:05'

	UPDATE dbo.HOP_DONG
	SET NGUOI_DAI_DIEN = N'Nguyễn Văn A' 
	WHERE MADN = 'DN61092796 '
COMMIT TRAN

--T2
BEGIN TRAN
	UPDATE dbo.HOP_DONG
	SET NGUOI_DAI_DIEN = N'Nguyễn Văn A' 
	WHERE MADN = 'DN61092796 '
	
	WAITFOR	DELAY '00:00:05'

	UPDATE dbo.DOANH_NGHIEP 
	SET NGUOI_DAI_DIEN = N'Nguyễn Văn A' 
	WHERE MADN = 'DN61092796 '
COMMIT TRAN