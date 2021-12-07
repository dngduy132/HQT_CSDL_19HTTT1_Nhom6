-- T1: Doanh nghiệp cập nhật giá sản phẩm có mã là SP26049509
-- T2: Khách hàng xem giá sản phẩm có mã là SP26049509
-- Doanh nghiệp cập nhật giá nhưng không commit => Khách hàng đọc dữ liệu rác

BEGIN TRAN
	SET TRAN ISOLATION LEVEL READ COMMITTED 
	SELECT GIA FROM dbo.SAN_PHAM  WHERE MA_SP = 'SP26049509'
COMMIT TRAN