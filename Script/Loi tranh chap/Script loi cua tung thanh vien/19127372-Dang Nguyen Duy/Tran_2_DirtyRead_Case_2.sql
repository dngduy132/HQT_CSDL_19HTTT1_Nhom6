-- T1: Doanh nghiệp cập nhật số lượng sản phẩm có mã là SP26049509
-- T2: Khách hàng xem số lượng sản phẩm có mã là SP26049509

BEGIN TRAN
	SELECT SO_LUONG 
	FROM dbo.SAN_PHAM WITH(NOLOCK) 
	WHERE MA_SP = 'SP26049509'
	WAITFOR DELAY '00:00:05'
COMMIT TRAN