--T1: Khách hàng xem số lượng các sản phẩm có số lượng = 10.
--T2: Doanh nghiệp thêm sản phẩm.
--Khách hàng xem số lượng các sản phẩm có số lượng = 10 lần 1 có 3 sản phẩm
--Khách hàng xem số lượng các sản phẩm có số lượng = 10 lần 2 có 4 sản phẩm

BEGIN TRAN
	select count(SO_LUONG) 
	from SAN_PHAM
	WHERE SO_LUONG = 10

	WAITFOR DELAY '00:00:10'

	select count(SO_LUONG) 
	from SAN_PHAM
	WHERE SO_LUONG = 10
COMMIT TRAN