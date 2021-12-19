--T1 : Khách hàng tìm xem có tồn tại sản phẩm có mã là SP26049509 và tên là Ly uống nước
--T2 : Doanh nghiệp đổi tên sản phẩm có mã là SP26049509

BEGIN TRANSACTION
	SELECT COUNT(MA_SP) 
	FROM dbo.SAN_PHAM 
	WHERE MA_SP = 'SP26049509' AND TEN_SP = N'Ly uống nước'
	
	WAITFOR DELAY '00:00:05'
	SELECT * 
	FROM SAN_PHAM 
	WHERE MA_SP = 'SP26049509' AND TEN_SP = N'Ly uống nước'
COMMIT TRANSACTION