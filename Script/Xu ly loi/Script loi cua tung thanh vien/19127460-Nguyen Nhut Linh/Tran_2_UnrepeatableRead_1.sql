--T1 : Khách hàng tìm xem có tồn tại sản phẩm có mã là SP26049509 và tên là Ly uống nước
--T2 : Doanh nghiệp đổi tên sản phẩm có mã là SP26049509

BEGIN TRANSACTION
	SET TRAN ISOLATION LEVEL REPEATABLE READ
	UPDATE dbo.SAN_PHAM
	SET TEN_SP = N'Ly uống trà'
	WHERE MA_SP = 'SP26049509'
COMMIT TRANSACTION