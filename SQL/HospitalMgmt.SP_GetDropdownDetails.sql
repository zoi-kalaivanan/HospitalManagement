-- =============================================
-- Author:		KalaiVanan
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE HospitalMgmt.SP_GetDropdownDetails
@Flag INT
,@CityID INT
,@HospitalID INT

AS
BEGIN
	IF @Flag=1
		BEGIN
			SELECT ID,CityName FROM HospitalMgmt.tblCity
		END
	ELSE IF @Flag=2
		BEGIN
			SELECT ID
			,HospitalName 
			FROM 
			HospitalMgmt.tblHospital 
			WHERE CityID=@CityID
		END
	ELSE IF @Flag=3
		BEGIN
			SELECT ID
			,DoctorName 
			FROM 
			HospitalMgmt.tblDoctor 
			WHERE HospitalID=@HospitalID 
			AND 
			CityID=@CityID
		END
	ELSE
		BEGIN
			SELECT 'Failed' AS Message , 'F' AS Status
		END
END
GO

SELECT * FROM HospitalMgmt.tblCity


SELECT * FROM HospitalMgmt.tblDoctor


SELECT * FROM HospitalMgmt.tblHospital

--UPDATE HospitalMgmt.tblDoctor 
--SET CityID=5
--WHERE HospitalID=1 OR HospitalID=2 OR HospitalID=3

--INSERT INTO HospitalMgmt.tblDoctor
--VALUES
--('Kumaran',4,1),('Murugan',7,2),('Christy',10,3),('John',11,4),('krishna',13,6)