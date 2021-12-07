-- T1: Khách hàng 1 xác nhận mua sản phẩm có mã SP26049509
-- T2: Khách hàng 2 xác nhận mua sản phẩm có mã SP26049509
-- Số lượng sản phẩm hiện tại là 1
-- Số lượng sản phẩm mong muốn sau khi chạy các giao tác: 0

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
