-- =============================================
-- Author:		Kalaivanan
-- Create date: 08-10-2021
-- Description:	to AddUpdate the Appointment Details
-- =============================================
ALTER PROCEDURE HospitalMgmt.SP_AddUpdateAppointment
@Flag INT
,@ID INT=0
,@Name VARCHAR(150)
,@Phone VARCHAR(13)
,@Email VARCHAR(200)
,@CityID INT
,@HospitalID INT
,@DoctorID INT
,@DateOfAppointment DATETIME
,@HealthQueries VARCHAR(500)

AS
BEGIN
	BEGIN TRY
		IF @Flag=1
			BEGIN
				INSERT INTO HospitalMgmt.tblAppointments
				(PatientName
				,Phone
				,Email
				,CityID
				,HospitalID
				,DoctorID
				,DateOfAppointment
				,HealthQueries)
				VALUES(@Name
				,@Phone
				,@Email
				,@CityID
				,@HospitalID
				,@DoctorID
				,@DateOfAppointment
				,@HealthQueries) 

				SELECT 'S' AS STATUS,'SUCCESS' AS MESSAGE
			END
		ELSE IF @Flag=2
			BEGIN
				UPDATE HospitalMgmt.tblAppointments
				SET PatientName=@Name
				,Phone=@Phone
				,Email=@Email
				,CityID=@CityID
				,HospitalID=@HospitalID
				,DoctorID=@DoctorID
				,DateOfAppointment=@DateOfAppointment
				,HealthQueries=@HealthQueries
				WHERE 
				ID=@ID
				SELECT 'S' AS STATUS,'SUCCESS' AS MESSAGE
			END
		ELSE
			BEGIN
				SELECT 'F' AS STATUS,'FAILED' AS MESSAGE
			END
	END TRY
	BEGIN CATCH
		SELECT 'F' AS STATUS ,ERROR_MESSAGE() AS MESSAGE		
	END CATCH
END
GO
