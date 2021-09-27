use RunwayHairSalon
GO


IF OBJECT_ID ('Appointment') IS NOT NULL
	DROP table Appointment
GO

IF OBJECT_ID ('Staff') IS NOT NULL
	DROP table Staff
GO
IF OBJECT_ID ('Customer') IS NOT NULL
	DROP table Customer
GO

IF OBJECT_ID ('Payment') IS NOT NULL
	DROP table Payment
GO

IF OBJECT_ID ('Treatment') IS NOT NULL
	DROP table Treatment
GO

IF OBJECT_ID ('Room') IS NOT NULL
	DROP table Room
GO



CREATE TABLE Staff
(
	StaffNo				int				NOT NULL,	--Primary Key
	Forename			varchar			NOT NULL,
	Surname				varchar			NOT NULL,
	TelNo				int				NOT NULL,
	Email				varchar			NOT NULL,
	EmergancyContact	int				NOT	NULL,
	Speciality			varchar			NOT NULL,
	PPS					varchar			NOT NULL,
	AccountNumber		int				NOT NULL,
	BranchNumber		int				NOT NULL,
	StaffDOB			datetime		NOT NULL,

	CONSTRAINT pkStaffNo PRIMARY KEY (StaffNo)
)

CREATE TABLE Customer
(
	CustomerNo			int				NOT NULL,	--Primary Key
	CustForename		varchar			NOT NULL,
	CustTitle			varchar			NOT NULL,
	CustSurname			varchar			NOT NULL,
	CustDOB				datetime		NOT NULL,
	CustTel				int				NOT NULL,
	CustAddress			varchar			NOT NULL,

	CONSTRAINT pkCustomerNumber PRIMARY KEY (CustomerNo)
)

CREATE TABLE Appointment
(
	AppointmentNo		int				NOT NULL,	--Primary Key
	StaffNo				int				NOT NULL,	--Foreign Key
	CustomerNo			int				NOT NULL,	--Foreign Key
	AppointmentTime		datetime		NOT NULL,
	AppointmentDate		datetime		NOT NULL,
	RoomNumber			int				NOT NULL,
	AppointmentType		int				NOT NULL,
	AppointmentDesc		varchar			NOT NULL,

	CONSTRAINT pkAppointmentNo PRIMARY KEY (AppointmentNo),
	CONSTRAINT fkStaffNo	FOREIGN KEY (StaffNo) REFERENCES Staff (StaffNo),
	CONSTRAINT fkCustomerNo	FOREIGN KEY (CustomerNo) REFERENCES Customer (CustomerNo)
)

CREATE TABLE Payment
(
	PaymentNo			int				NOT NULL,	--Primary Key
	PaymentType			varchar			NOT NULL,
	AppointmentNo		int				NOT NULL,	--Foreign Key
	Amount				int				NOT NULL,
	DatePaid			datetime		NOT NULL,

	CONSTRAINT pkPaymentNo PRIMARY KEY (PaymentNo),
	CONSTRAINT fkAppointmentNo	FOREIGN KEY (AppointmentNo) REFERENCES Appointment (AppointmentNo)
)

CREATE TABLE Treatment
(
	TreatmentNo			int				NOT NULL,	--Primary Key
	TreatmentCode		varchar			NOT NULL,
	TreatmentDesc		varchar			NOT NULL,
	TreatmentPrice		int				NOT NULL,

	CONSTRAINT pkTreatmentNo PRIMARY KEY (TreatmentNo)
)

CREATE TABLE Room
(
	RoomNo				int				NOT NULL, --Primary Key
	RoomFunction		varchar			NOT NULL,
	TreatmentNo			int				NOT NULL, --Foreign Key

	CONSTRAINT pkRoomNo PRIMARY KEY (RoomNo)
)

--Populating Tables


 --populating customer table
--INSERT INTO Customer() 
--VALUES 
--(10000), 

--SELECT * FROM customer
