-- =============================================
-- Author:		Kalaivanan
-- Create date: 13-OCT-2021
-- Description: For	LoginFunctionalities
-- =============================================
ALTER PROCEDURE HospitalMgmt.SP_UserLogin 
@Username VARCHAR(200)
,@Password VARCHAR(15)
AS
BEGIN
	BEGIN TRY
		/*Checking Credentials */
		IF(EXISTS(SELECT * FROM HospitalMgmt.tblUser 
		WHERE Username=@Username AND Password=@Password))
			BEGIN
				
				/* Return Status */
				SELECT 'S' AS STATUS,'SUCCESS' AS MESSAGE

				SELECT ID AS UserID,Username AS UserName FROM HospitalMgmt.tblUser 
				WHERE Username=@Username AND Password=@Password
			END
		ELSE
			BEGIN
				SELECT 'F' AS STATUS,'Failure' AS MESSAGE
			END

		

	END TRY

	BEGIN CATCH
		SELECT 'F' AS STATUS,ERROR_MESSAGE() AS MESSAGE
	END CATCH

END
GO
--USE Trainee
--SELECT * FROM HospitalMgmt.tblUser

