﻿-- T1: Khách hàng 1 xác nhận mua sản phẩm có mã SP26049509
-- T2: Khách hàng 2 xác nhận mua sản phẩm có mã SP26049509

BEGIN TRAN
	SET TRAN ISOLATION LEVEL REPEATABLE READ 
	DECLARE @SL INT 
	SET @SL = (SELECT SO_LUONG 
			   FROM dbo.SAN_PHAM 
			   WHERE MA_SP = 'SP26049509')
	IF (@SL > 0)
	BEGIN	
		WAITFOR DELAY '00:00:05'
		UPDATE dbo.SAN_PHAM 
		SET SO_LUONG = @SL - 1 
		WHERE MA_SP = 'SP26049509'
	END 
	ELSE 
	BEGIN 
		RAISERROR(N'Hết hàng',15,1)
		ROLLBACK
	END 
COMMIT TRAN