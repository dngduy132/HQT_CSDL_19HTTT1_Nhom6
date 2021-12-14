--T1: Khách hàng xem số lượng các sản phẩm có số lượng = 10 của doanh nghiệp có mã 'DN83267769'
--T2: Doanh nghiệp thêm sản phẩm có số lượng = 10
--Khách hàng xem số lượng các sản phẩm có số lượng = 10 của doanh nghiệp có mã 'DN83267769' lần 1 có 3 sản phẩm
--Khách hàng xem số lượng các sản phẩm có số lượng = 10 của doanh nghiệp có mã 'DN83267769' lần 2 có 4 sản phẩm, danh sách của các sản phẩm đó

BEGIN TRAN
	SELECT  COUNT(DISTINCT SP.MA_SP)
	from SAN_PHAM SP, DOANH_NGHIEP DN, CHI_NHANH CN, CHINHANH_SANPHAM CNSP 
	WHERE DN.MADN = N'DN83267769' AND SP.SO_LUONG = 10 AND CN.MADN = DN.MADN AND SP.MA_SP = CNSP.MA_SP

	WAITFOR DELAY '00:00:05'

	SELECT  COUNT(DISTINCT SP.MA_SP)
	from SAN_PHAM SP, DOANH_NGHIEP DN, CHI_NHANH CN, CHINHANH_SANPHAM CNSP 
	WHERE DN.MADN = N'DN83267769' AND SP.SO_LUONG = 10 AND CN.MADN = DN.MADN AND SP.MA_SP = CNSP.MA_SP
	SELECT  DISTINCT SP.MA_SP, SP.TEN_SP, SP.SO_LUONG
	from SAN_PHAM SP, DOANH_NGHIEP DN, CHI_NHANH CN, CHINHANH_SANPHAM CNSP 
	WHERE DN.MADN = N'DN83267769' AND SP.SO_LUONG = 10 AND CN.MADN = DN.MADN AND SP.MA_SP = CNSP.MA_SP
COMMIT TRAN
