UPDATE dbo.DON_DAT_HANG
SET PHI_SAN_PHAM = f.valsum
FROM 
(
  SELECT ct.MA_DON,  SUM(ct.GIA_BAN * CT.SO_LUONG) valsum
  FROM dbo.CT_DON_HANG  ct 
  GROUP BY  ct.MA_DON
) f
WHERE dbo.DON_DAT_HANG.MA_DON= f.MA_DON


UPDATE DON_DAT_HANG 
SET TONG_TIEN_= PHI_SAN_PHAM + PHI_VAN_CHUYEN


UPDATE DOANH_NGHIEP  
SET SO_CHI_NHANH =( 
SELECT COUNT(*) FROM CHI_NHANH  CN 
WHERE DOANH_NGHIEP.MADN =CN.MADN)

UPDATE DOANH_NGHIEP  
SET SL_DON_HANG =( 
SELECT COUNT(*) FROM DON_DAT_HANG  DH 
WHERE DOANH_NGHIEP.MADN =DH.MADN)

GO


--TRIGGER PHI SAN PHAM (DON DAT HANG (DON DAT HANG)  = SUM(TONGTIEN)(DONHANG))
CREATE OR alter trigger trig_PHI_SP on CT_DON_HANG 
for insert, delete, update 
as
BEGIN 
UPDATE dbo.DON_DAT_HANG
SET PHI_SAN_PHAM = f.valsum
FROM 
(
  SELECT ct.MA_DON,  SUM(ct.GIA_BAN * CT.SO_LUONG) valsum
  FROM dbo.CT_DON_HANG  ct 
  WHERE ct.MA_DON IN (SELECT  MA_DON FROM Inserted)
  GROUP BY  ct.MA_DON
) f
WHERE dbo.DON_DAT_HANG.MA_DON= f.MA_DON AND dbo.DON_DAT_HANG.MA_DON IN (SELECT  MA_DON FROM Inserted UNION SELECT MA_DON FROM Deleted)
END 

GO


--TRIGGER 
CREATE OR ALTER TRIGGER TONG_TIEN  ON CT_DON_HANG 
FOR INSERT, DELETE, UPDATE 
AS 
BEGIN 
UPDATE DON_DAT_HANG 
SET TONG_TIEN_= PHI_SAN_PHAM + PHI_VAN_CHUYEN
WHERE MA_DON IN (SELECT MA_DON FROM INSERTED)
END

GO

--SELECT * 
--FROM DON_DAT_HANG
--ORDER BY MA_DON
--SELECT * 
--FROM CT_DON_HANG
--ORDER BY MA_DON



-- TRIGGER SO CHI NHANH  ( DOANH NGHIEP ) =  COUNT(*)(CHI NHANH)

CREATE OR ALTER TRIGGER SO_CHI_NHANH ON CHI_NHANH
FOR INSERT,DELETE ,UPDATE 
AS 
BEGIN
UPDATE DOANH_NGHIEP  
SET SO_CHI_NHANH =( 
SELECT COUNT(*) FROM CHI_NHANH  CN 
WHERE DOANH_NGHIEP.MADN =CN.MADN)
WHERE MADN IN (SELECT MADN FROM INSERTED)
END

--SELECT * FROM DOANH_NGHIEP
--SELECT * FROM CHI_NHANH ORDER BY MADN

GO


--TRIGGER SO DON DAT HANG (DOANH NGHIEP ) = COUNT(*) DON DAT HANG
CREATE OR ALTER TRIGGER SO_DON_DAT_HANG ON DON_DAT_HANG
FOR INSERT,DELETE ,UPDATE 
AS 
BEGIN
UPDATE DOANH_NGHIEP  
SET SL_DON_HANG =( 
SELECT COUNT(*) FROM DON_DAT_HANG  DH 
WHERE DOANH_NGHIEP.MADN =DH.MADN)
END

--SELECT * FROM DOANH_NGHIEP ORDER BY MADN
--SELECT * FROM DON_DAT_HANG ORDER BY MADN