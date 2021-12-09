﻿-- T1: Tài xế 1 (TX11736641) xác nhận giao hóa đơn có mã hóa đơn  HD56451566
-- T2: Tài xế 2 (TX23114712) đồng thời xác nhận giao hóa đơn có mã hóa đơn  HD56451566
-- Số lượng tài xế tối đa của 1 hóa đơn là 1


BEGIN TRAN
	IF(SELECT MA_TX FROM dbo.DON_DAT_HANG WHERE MA_DON='HD56451566')  IS NULL
	BEGIN	
		WAITFOR DELAY '00:00:05'
		UPDATE dbo.DON_DAT_HANG SET MA_TX = 'TX23114712' WHERE MA_DON = 'HD56451566'
	END 
	ELSE 
	BEGIN 
		RAISERROR(N'ĐƠN HÀNG ĐÃ ĐƯỢC NHẬN',15,1)
		ROLLBACK
	END 
COMMIT TRAN