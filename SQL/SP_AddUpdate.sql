-- =============================================
-- Author:		Kalaivanan
-- Create date: 1-OCT-2021
-- Description:	To Fetch Counts
-- =============================================
ALTER PROCEDURE HospitalMgmt.SP_AddUpdateUser
@Flag BIT=0
,@ID INT=0
,@Username VARCHAR(100)
,@Email VARCHAR(200)
,@Phone VARCHAR(13)
,@Password VARCHAR(15)
,@ConfirmPassword VARCHAR(15)
,@Role BIT=1
,@IsActive BIT=1
,@ModifiedBy VARCHAR(50) ='Admin'
,@DoctorID INT
,@HospitalID INT
,@LocationID INT
AS
BEGIN
	IF @Flag=0
		BEGIN
			INSERT INTO HospitalMgmt.tblUser(Username
			,Email
			,Phone
			,Password
			,ConfirmPassword
			,Role
			,IsActive
			,CreatedOn			
			,DoctorID
			,HospitalID
			,LocationID)VALUES(@Username
			,@Email
			,@Phone
			,@Password
			,@ConfirmPassword
			,@Role
			,@IsActive
			,GETDATE()
			,@DoctorID
			,@HospitalID
			,@LocationID)
		END
	ELSE
		BEGIN
			UPDATE HospitalMgmt.tblUser
			SET  Username=@Username
			,Email=@Email
			,Phone=@Phone
			,Password=@Password
			,ConfirmPassword=@ConfirmPassword
			,Role=@Role
			,IsActive=@IsActive
			,ModifiedOn=GETDATE()
			,ModifiedBy=@ModifiedBy
			,DoctorID=@DoctorID
			,HospitalID=@HospitalID
			,LocationID=@LocationID
			WHERE ID=@ID
		END
END
GO

SELECT * FROM HospitalMgmt.tblDoctor

SELECT * FROM HospitalMgmt.tblCity

SELECT * FROM HospitalMgmt.tblUser