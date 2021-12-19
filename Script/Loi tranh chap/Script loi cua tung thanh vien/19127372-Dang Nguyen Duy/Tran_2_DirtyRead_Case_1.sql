-- T1: Doanh nghiệp cập nhật giá sản phẩm có mã là SP26049509
-- T2: Khách hàng xem giá sản phẩm có mã là SP26049509

BEGIN TRAN
	SELECT GIA 
	FROM dbo.SAN_PHAM WITH(NOLOCK) 
	WHERE MA_SP = 'SP26049509'
COMMIT TRAN