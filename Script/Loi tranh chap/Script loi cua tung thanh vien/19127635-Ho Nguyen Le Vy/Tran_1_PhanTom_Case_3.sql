--T1: Khách hàng xem số lượng sản phẩm có giá = 10000.
--T2: Doanh nghiệp cập nhật giá sản phẩm.
--Khách hàng xem số lượng sản phẩm có giá = 10000 lần 1 là 0.
--Khách hàng xem số lượng sản phẩm có giá = 10000 lần 2 là 1.

BEGIN TRAN
	SELECT count(GIA)
	FROM SAN_PHAM
	WHERE GIA = 10000

	WAITFOR DELAY '00:00:10'

	SELECT count(GIA)
	FROM SAN_PHAM
	WHERE GIA = 10000
COMMIT TRAN