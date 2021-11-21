-- T1: Doanh nghiệp cập nhật số lượng sản phẩm có mã là SP26049509
-- T2: Khách hàng xem số lượng sản phẩm có mã là SP26049509
-- Doanh nghiệp cập nhật số lượng nhưng không commit => Khách hàng đọc dữ liệu rác

BEGIN TRAN
	UPDATE dbo.SAN_PHAM SET SO_LUONG = 5 WHERE MA_SP = 'SP26049509'
	WAITFOR DELAY '00:00:05'
	ROLLBACK