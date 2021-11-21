--T1: Doanh nghiệp xem số lượng đơn hàng.
--T2: Thêm đơn đặt hàng mới.
--Doanh nghiệp xem số lượng đơn hàng lần 1 là 40
--Doanh nghiệp xem số lượng đơn hàng lần 2 là 41

BEGIN TRAN
	SELECT SL_DON_HANG
	FROM DOANH_NGHIEP
	WHERE MADN = N'DN61092796'

	WAITFOR DELAY '00:00:10'

	SELECT SL_DON_HANG
	FROM DOANH_NGHIEP
	WHERE MADN = N'DN61092796'
COMMIT TRAN