﻿--T1: Doanh nghiệp 'DN71715083' xem số lượng đơn hàng của mình.
--T2: Thêm đơn đặt hàng mới.
--Doanh nghiệp xem số lượng đơn hàng lần 1 là 1
--Doanh nghiệp xem số lượng đơn hàng lần 2 là 2
--Doanh nghiệp 'DN71715083' xem số lượng đơn hàng của mình lần 1
--Doanh nghiệp 'DN71715083' xem số lượng đơn hàng của mình lần 2 và danh sách đơn đặt hàng

BEGIN TRAN
	SELECT COUNT( DDH.MA_DON)
	FROM DOANH_NGHIEP DN, DON_DAT_HANG DDH
	WHERE DN.MADN = N'DN71715083' AND DDH.MADN = DN.MADN

	WAITFOR DELAY '00:00:10'

	SELECT COUNT( DDH.MA_DON)
	FROM DOANH_NGHIEP DN, DON_DAT_HANG DDH
	WHERE DN.MADN = N'DN71715083' AND DDH.MADN = DN.MADN
	SELECT DISTINCT DDH.MA_DON, DDH.MA_KV, DDH.MA_TX, DDH.MA_KH, DDH.NGAY_LAP, DDH.TINH_TRANG, DDH.TONG_TIEN_, DDH.PHI_SAN_PHAM, DDH.PHI_VAN_CHUYEN, DDH.HINH_THUC_THANH_TOAN
	FROM DOANH_NGHIEP DN, DON_DAT_HANG DDH
	WHERE DN.MADN = N'DN71715083' AND DDH.MADN = DN.MADN
COMMIT TRAN