-- =============================================
-- Author:		KalaiVanan
-- Create date: 06-OCT-2021
-- Description:	To Fetch Doctors Details,Cities DEtails,Hospital Details
-- =============================================
CREATE PROCEDURE HospitalMgmt.SP_FetchSummaryDetails
	@Flag INT
AS
BEGIN
	IF @Flag=0
		BEGIN
			--SELECT * FROM HospitalMgmt.tblCity
			--SELECT * FROM HospitalMgmt.tblDoctor
			--SELECT * FROM HospitalMgmt.tblHospital
			SELECT A.ID AS ID
			,A.DoctorName AS DoctorName
			,B.HospitalName AS HospitalName
			,C.CityName AS CityName FROM 
			HospitalMgmt.tblDoctor AS A
			LEFT JOIN
			HospitalMgmt.tblHospital AS B 
			ON A.HospitalID=B.ID
			LEFT JOIN
			HospitalMgmt.tblCity AS C
			ON A.CityID=C.ID
		END
	ELSE IF @Flag=1
		BEGIN
			SELECT A.ID AS HospitalID
			,A.HospitalName AS HospitalName
			,B.CityName AS CityName FROM
			HospitalMgmt.tblHospital AS A
			LEFT JOIN
			HospitalMgmt.tblCity AS B
			ON A.CityID=B.ID
		END  
	ELSE
		BEGIN
			SELECT * FROM HospitalMgmt.tblCity 
		END
END
GO
