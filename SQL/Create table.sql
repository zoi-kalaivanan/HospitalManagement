USE TRAINEE

/*HospitalMgmt SCHEMA CREATION */

CREATE SCHEMA HospitalMgmt

/*Hospital table Creation */

CREATE TABLE HospitalMgmt.tblHospital
(ID INT IDENTITY(1,1) PRIMARY KEY
,HospitalName VARCHAR(100)NOT NULL
,CityID INT NOT NULL);

/* Doctor Table Creation */

CREATE TABLE HospitalMgmt.tblDoctor
(ID INT IDENTITY(1,1) PRIMARY KEY
,DoctorName VARCHAR(100)NOT NULL
,HospitalID INT NOT NULL
,CityID INT NOT NULL);


/* City Table Creation */

CREATE TABLE HospitalMgmt.tblCity
(ID INT IDENTITY(1,1) PRIMARY KEY
,CityName VARCHAR(50)UNIQUE NOT NULL);


/* User (patient) Table Creation */

CREATE TABLE HospitalMgmt.tblUser
(ID INT IDENTITY(1,1) PRIMARY KEY
,Username VARCHAR(100)NOT NULL
,Email VARCHAR(200) UNIQUE NOT NULL
,Phone VARCHAR(12) UNIQUE NOT NULL
,Password VARCHAR(50) NOT NULL
,ConfirmPassword VARCHAR(50) NOT NULL
,Role INT DEFAULT 1 NOT NULL
,IsActive BIT DEFAULT 1
,CreatedOn DATETIME DEFAULT GETDATE()
,CreatedBy VARCHAR(50)
,ModifiedOn DATETIME
,ModifiedBy VARCHAR(50)
,DoctorID INT
,HospitalID INT
,LocationID INT);


/*Admin Insert Process */
	INSERT INTO HospitalMgmt.tblUser(Username
			,Email
			,Phone
			,Password
			,ConfirmPassword
			,Role
			,IsActive
			,CreatedOn
			,CreatedBy			
			,ModifiedBy
			,DoctorID
			,HospitalID
			,LocationID)VALUES('Kalaivanan'
			,'m.maddykapil@gmail.com'
			,'8825976158'
			,'Kalai007'
			,'Kalai007'
			,0
			,1
			,@CreatedOn
			,@DoctorID
			,@HospitalID
			,@LocationID)

SELECT * FROM HospitalMgmt.tblUser