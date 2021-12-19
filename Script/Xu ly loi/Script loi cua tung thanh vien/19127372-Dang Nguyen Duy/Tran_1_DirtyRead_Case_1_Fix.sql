-- T1: Doanh nghiệp cập nhật giá sản phẩm có mã là SP26049509
-- T2: Khách hàng xem giá sản phẩm có mã là SP26049509
-- Doanh nghiệp cập nhật giá nhưng không commit => Khách hàng đọc dữ liệu rác

BEGIN TRAN
	UPDATE dbo.SAN_PHAM 
	SET GIA = 500000 
	WHERE MA_SP = 'SP26049509'
	
	WAITFOR DELAY '00:00:05'
	ROLLBACK