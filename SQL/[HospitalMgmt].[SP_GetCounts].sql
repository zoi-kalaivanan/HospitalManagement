USE [Trainee]
GO
/****** Object:  StoredProcedure [HospitalMgmt].[SP_GetCounts]    Script Date: 10/6/2021 12:45:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		KalaiVanan
-- Create date: 04-OCT-2021
-- Description:	For Fetching Counts For User,Hospital,Doctor,City.
-- =============================================
ALTER PROCEDURE [HospitalMgmt].[SP_GetCounts]
	
AS
BEGIN

	SELECT COUNT(*) AS DoctorCount  FROM HospitalMgmt.tblDoctor 
	
	SELECT COUNT(*) AS HospitalCount FROM HospitalMgmt.tblHospital 

	SELECT COUNT(*) AS CityCount FROM HospitalMgmt.tblCity

	SELECT COUNT(*) AS UserCount FROM HospitalMgmt.tblUser

	SELECT TOP 10(DoctorName) AS DoctorsList  FROM HospitalMgmt.tblDoctor 
	
	SELECT TOP 10(HospitalName) AS HospitalsList FROM HospitalMgmt.tblHospital 

	--SELECT TOP 10(CityName) AS CitiesList FROM HospitalMgmt.tblCity

	SELECT TOP 10(Username) AS UsersList FROM HospitalMgmt.tblUser

	

END
