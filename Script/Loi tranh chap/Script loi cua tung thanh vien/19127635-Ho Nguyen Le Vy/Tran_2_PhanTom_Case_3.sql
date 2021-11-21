--T1: Khách hàng xem số lượng sản phẩm có giá = 10000.
--T2: Doanh nghiệp cập nhật giá sản phẩm.
--Khách hàng xem số lượng sản phẩm có giá = 10000 lần 1 là 0.
--Khách hàng xem số lượng sản phẩm có giá = 10000 lần 2 là 

BEGIN TRAN
	INSERT INTO SAN_PHAM values (N'SP00000002', N'Mì chua ngọt', 10000, 15, N'Vừa chua vừa ngọt')
COMMIT TRAN