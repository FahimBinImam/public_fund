CREATE DATABASE FUBLIC_FUND_CHARITY

CREATE TABLE VOLUNTEER
(
	vID INT IDENTITY(1001,1) PRIMARY KEY,
	Name VARCHAR(256) NOT NULL,
	Email VARCHAR(256) UNIQUE,
	Username VARCHAR(256) UNIQUE,
	Password NVARCHAR(24) NOT NULL,
	Security VARCHAR(512) NOT NULL,
	Answer VARCHAR(128) NOT NULL,
	Gender VARCHAR(32) NOT NULL,
	NID VARCHAR(17) UNIQUE,
	DOB VARCHAR(128) NOT NULL,
	Phone1 NVARCHAR(24) NOT NULL,
	Phone2 NVARCHAR(24),
	BloodGroup VARCHAR(5) NOT NULL,
	Occupation VARCHAR(128) NOT NULL,
	Area VARCHAR(256) NOT NULL,
	City VARCHAR(128) NOT NULL,
	Country VARCHAR(128) NOT NULL,
	Picture Image 
);

/*Insert into VOLUNTEER Values ('Habibur Rahman Masum','hrmasum67@gmail.com','hrm67','1234','Birth Place ?','Kishoreganj','Male','3309587867','28-OCT-1999','01794669675',null, 'B+','Student','Vatara','Dhaka','Bangladesh');*/

select * from VOLUNTEER

CREATE TABLE SPONSOR
(
	sID INT IDENTITY(100001,1) PRIMARY KEY,
	Name VARCHAR(256) NOT NULL,
	Email VARCHAR(256) UNIQUE,
	Username VARCHAR(256) UNIQUE,
	Password NVARCHAR(24) NOT NULL,
	Security VARCHAR(512) NOT NULL,
	Answer VARCHAR(128) NOT NULL,
	Gender VARCHAR(32) NOT NULL,
	NID VARCHAR(17) UNIQUE,
	DOB VARCHAR(128) NOT NULL,
	Phone1 NVARCHAR(24) NOT NULL,
	Phone2 NVARCHAR(24),
	BloodGroup VARCHAR(5) NOT NULL,
	Occupation VARCHAR(128) NOT NULL,
	Area VARCHAR(256) NOT NULL,
	City VARCHAR(128) NOT NULL,
	Country VARCHAR(128) NOT NULL,
	Picture Image
);

/*Insert into SPONSOR(NAME,Email,Username,Password,Security,Answer,GENDER,NID,DOB,Phone1,Phone2,BLOODGROUP,Occupation,Area,CITY,country) Values ('H.R. Masum','hrmasum85@gmail.com','hrm85','1234','Birth Year ?','1999','Male','3309587867','28-OCT-1999','01794669675','01567965315', 'B+','Student','Vatara','Dhaka','Bangladesh');*/

select * from SPONSOR

CREATE TABLE EVENT
(
	eID INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(1024) NOT NULL,
	DATE VARCHAR(128) NOT NULL,
	Area VARCHAR(256) NOT NULL,
	City VARCHAR(128) NOT NULL
);

/*Insert into EVENT Values ('Tader Eid','04/20/2023','Vatara','Dhaka');
Insert into EVENT Values ('Tader Khusi','05/17/2023','Uttara','Dhaka');*/

select * from EVENT

CREATE TABLE DONATION
(
	dID INT IDENTITY(10001,1) PRIMARY KEY,
	Acc_No varchar(32) not null,
	Acc_H_Name varchar(64) not null,
	Amount INT NOT NULL,
	Transaction_Date datetime,
	eID INT NOT NULL,
	sID INT FOREIGN KEY REFERENCES SPONSOR(sID) 
);

ALTER TABLE DONATION ADD FOREIGN KEY(eID) REFERENCES EVENT(eID); 
/* NOTE:- [To get auto date & time]
  1. Right click on the table and select "Design"
  2. Select existing "datetime" field or create new one
  3. In the "Colunm Properties" below, under "Default Value or Binding" enter getdate()
  4. Save the change to the table*/

/*Insert into DONATION (Acc_No,Acc_H_Name,Amount,eID,sID) Values ('23011564218','H.R. Masum',10000,1,100001);
Insert into DONATION (Acc_No,Acc_H_Name,Amount,eID,sID) Values ('23011578901','Mr Masum',1000,1,null);*/

select * from DONATION

CREATE TABLE EVENT_MANAGEMENT
(
	eID INT NOT NULL,
	vID INT NOT NULL,
	STATUS  VARCHAR(16) 
);
ALTER TABLE EVENT_MANAGEMENT ADD CONSTRAINT PK_EM PRIMARY KEY (eID,vID);

/*Insert into EVENT_MANAGEMENT(eID,vID) Values (1,1001);*/

select * from EVENT_MANAGEMENT

/*EXEC sp_help 'DONATION';

DROP TABLE VOLUNTEER

DROP DATABASE FUBLIC_FUND_CHARITY;

select name from sys.tables*/