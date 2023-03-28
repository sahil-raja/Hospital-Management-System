CREATE DATABASE HOSPITAL

USE HOSPITAL

CREATE TABLE EMPLOYEE(
	Emp_ID NUMERIC PRIMARY KEY,
	First_Name VARCHAR(30),
	Last_Name VARCHAR(30),
	Phone_No VARCHAR(30) CHECK (LEN(Phone_No) = 11),
	Joining_Date DATE,
	Emp_Type VARCHAR(30),
	Salary NUMERIC,
	Dept_ID NUMERIC
);

CREATE TABLE DEPARTMENT(
	ID NUMERIC PRIMARY KEY,
	D_Name VARCHAR(30)
);

ALTER TABLE EMPLOYEE 
ADD FOREIGN KEY (Dept_ID) REFERENCES DEPARTMENT(ID);

CREATE TABLE DEPARTMENT_HEAD(
	Dept_ID NUMERIC REFERENCES DEPARTMENT (ID),
	Head_ID NUMERIC REFERENCES EMPLOYEE (Emp_ID)
);

CREATE TABLE DOCTOR(
	Doctor_ID NUMERIC REFERENCES EMPLOYEE (Emp_ID) UNIQUE,
	Specification VARCHAR(30),
	Charges NUMERIC
);

CREATE TABLE NURSE(
	Nurse_ID NUMERIC REFERENCES EMPLOYEE (Emp_ID) UNIQUE,
	Position VARCHAR(30),
	Experience NUMERIC
);

CREATE TABLE QUALIFICATION(
	Employee_ID NUMERIC REFERENCES EMPLOYEE (Emp_ID),
	Degree VARCHAR(100),
	Institute VARCHAR(100),
	D_Start_Date DATE,
	D_End_Date DATE
);

CREATE TABLE PATIENT(
	Patient_CNIC VARCHAR(30) CHECK (LEN(Patient_CNIC) = 13) PRIMARY KEY,
	Patient_FName VARCHAR(30),
	Patient_LName VARCHAR(30),
	Phone_No VARCHAR(30) CHECK (LEN(Phone_No) = 11),
	Address VARCHAR(100)
);

CREATE TABLE MEDICINE(
	Medicine_ID NUMERIC PRIMARY KEY,
	Med_Name VARCHAR(30),
	Brand VARCHAR(100),
	Description VARCHAR(200),
	Cost NUMERIC
);

CREATE TABLE ROOM(
	Room_ID NUMERIC PRIMARY KEY,
	Room_Type VARCHAR(30),
	Room_Cost NUMERIC
);

CREATE TABLE STAY(
	Stay_ID NUMERIC PRIMARY KEY,
	P_CNIC VARCHAR(30) CHECK (LEN(P_CNIC) = 13) REFERENCES PATIENT (Patient_CNIC),
	Room_ID NUMERIC REFERENCES ROOM (Room_ID),
	Start_Date DATE,
	End_Date DATE, 
	Nurse_ID NUMERIC REFERENCES NURSE (Nurse_ID)
);

CREATE TABLE APPOINTMENT(
	ID NUMERIC PRIMARY KEY,
	Doc_ID NUMERIC REFERENCES DOCTOR (Doctor_ID),
	Start_Time DATETIME2,
	End_Time DATETIME2,
	P_CNIC VARCHAR(30) CHECK (LEN(P_CNIC) = 13) REFERENCES PATIENT (Patient_CNIC)
);


CREATE TABLE PRESCRIPTION(
	Prescription_ID NUMERIC PRIMARY KEY,
	Doc_ID NUMERIC REFERENCES DOCTOR (Doctor_ID),
	P_CNIC VARCHAR(30) CHECK (LEN(P_CNIC) = 13) REFERENCES PATIENT (Patient_CNIC),
	Med_ID NUMERIC REFERENCES MEDICINE (Medicine_ID),
	Appointment NUMERIC REFERENCES APPOINTMENT (ID),
	Pres_DATE DATE
);

CREATE TABLE IN_BILL_INFO(
	In_Bill_ID NUMERIC PRIMARY KEY,
	P_CNIC VARCHAR(30) CHECK (LEN(P_CNIC) = 13) REFERENCES PATIENT (Patient_CNIC),
	Doc_ID NUMERIC REFERENCES DOCTOR (Doctor_ID),
	Room_ID NUMERIC REFERENCES ROOM (Room_ID),
	Medicine_ID NUMERIC REFERENCES MEDICINE (Medicine_ID)
);

CREATE TABLE OUT_BILL_INFO(
	Out_Bill_ID NUMERIC PRIMARY KEY,
	P_CNIC VARCHAR(30) CHECK (LEN(P_CNIC) = 13) REFERENCES PATIENT (Patient_CNIC),
	Doc_ID NUMERIC REFERENCES DOCTOR (Doctor_ID),
	Appointment_ID NUMERIC REFERENCES APPOINTMENT (ID)
);


/*---------INSERTION--------*/
INSERT INTO DEPARTMENT VALUES (1, 'ENT'),
							  (2, 'Dermatology'),
							  (3, 'Nephrology'),
							  (4, 'General Surgery'),
							  (5, 'Cadiology')
		
INSERT INTO EMPLOYEE VALUES (1, 'Sahil', 'Raja', '03331234567', CONVERT(DATE, '01-Jan-2019'), 'Doctor', 100000, 1),
							(2, 'Osaid', 'Ameer', '03331234568', CONVERT(DATE, '01-Feb-2019'), 'Doctor', 100000, 2),
							(3, 'Talha', 'Tanveer', '03331234569', CONVERT(DATE, '01-Mar-2019'), 'Nurse', 50000, 1),
							(4, 'Bahadur', 'Ali', '03331234560', CONVERT(DATE, '01-Apr-2019'), 'Nurse', 50000, 2),
							(5, 'Muhammad', 'Armughan', '03331234561', CONVERT(DATE, '01-Jun-2019'), 'Doctor', 150000, 3),
							(6, 'Zakariya', 'Shahid', '03331234562', CONVERT(DATE, '01-Jul-2019'), 'Doctor', 150000, 4),
							(7, 'Rameez', 'Haider', '03331234563', CONVERT(DATE, '01-Aug-2019'), 'Nurse', 70000, 3),
							(8, 'Haider', 'Zaman', '03331234564', CONVERT(DATE, '01-Sep-2019'), 'Nurse', 70000, 4),
							(9, 'Arham', 'Khan', '03331234565', CONVERT(DATE, '01-Oct-2019'), 'Receptionist', 40000, 1),
							(10, 'Sufyan', 'Majid', '03331234566', CONVERT(DATE, '01-Nov-2019'), 'Receptionist', 40000, 2),
							(11, 'Hassan', 'Abidi', '03331234570', CONVERT(DATE, '01-Dec-2019'), 'Receptionist', 40000, 3),
							(12, 'Ronit', 'Raja', '03331234571', CONVERT(DATE, '01-Jan-2020'), 'Receptionist', 40000, 4),
							(13, 'Hammad', 'Ahmed', '03331234572', CONVERT(DATE, '01-Feb-2020'), 'Doctor', 100000, 5),
							(14, 'Mohsin', 'Pulphuto', '03331234573', CONVERT(DATE, '01-Mar-2020'), 'Nurse', 70000, 5),
							(15, 'Usman', 'Fawad', '03331234574', CONVERT(DATE, '01-Apr-2020'), 'Receptionist', 40000, 5)

INSERT INTO EMPLOYEE VALUES (16, 'Shaheer', 'Farooqui', '03331234575', CONVERT(DATE, '01-May-2020'), 'Doctor', 150000, 1),
							(17, 'Anas', 'Adil', '03331234576', CONVERT(DATE, '01-Jun-2020'), 'Doctor', 100000, 2),
							(18, 'Taha', 'Hussain', '03331234577', CONVERT(DATE, '01-Jul-2020'), 'Doctor', 100000, 3),
							(19, 'Azmat', 'Fareed', '03331234578', CONVERT(DATE, '01-Apr-2021'), 'Doctor', 150000, 4),
							(20, 'Umar', 'Sohail', '03331234579', CONVERT(DATE, '01-Apr-2020'), 'Doctor', 100000, 5),
							(21, 'Maaz', 'Tahir', '03331234580', CONVERT(DATE, '01-May-2020'), 'Nurse', 50000, 1),
							(22, 'Hamza', 'Ahmed', '03331234581', CONVERT(DATE, '01-Jun-2020'), 'Nurse', 50000, 2),
							(23, 'Huzaifa', 'Iftikhar', '03331234582', CONVERT(DATE, '01-Jul-2020'), 'Nurse', 50000, 3),
							(24, 'Aakash', 'Kumar', '03331234583', CONVERT(DATE, '01-Apr-2021'), 'Nurse', 50000, 4),
							(25, 'Naresh', 'Kumar', '03331234584', CONVERT(DATE, '01-Apr-2020'), 'Nurse', 50000, 5)

INSERT INTO DEPARTMENT_HEAD VALUES (1, 1),
								   (2, 2),
								   (3, 5),
								   (4, 6),
								   (5, 14)

INSERT INTO DOCTOR VALUES (1, 'Otolaryngologist', 2000),
						  (16, 'Otolaryngologist', 2500),
						  (2, 'Dermatologist', 1500),
						  (17, 'Dermatologist', 1500),
						  (5, 'Nephrologist', 2000),
						  (18, 'Nephrologist', 2500),
						  (6, 'General Surgeon', 3000),
						  (19, 'General Surgeon', 4000),
						  (13, 'Cardiologist', 5000),
						  (20, 'Cardiologist', 5000)


INSERT INTO NURSE VALUES (3, 'Senior Nurse', 10),
						 (4, 'Senior Nurse', 7),
						 (7, 'Senior Nurse', 3),
						 (8, 'Senior Nurse', 2),
						 (14, 'Senior Nurse', 11),
						 (21, 'Junior Nurse', 10),
						 (22, 'Junior Nurse', 12),
						 (23, 'Junior Nurse', 4),
						 (24, 'Junior Nurse', 10),
						 (25, 'Junior Nurse', 13)


INSERT INTO QUALIFICATION VALUES (1, 'Medical Degree', 'University of Karachi', CONVERT(DATE, '01-Jan-2006'), CONVERT(DATE, '01-Jan-2010')),
								 (1, 'ENT Specialisation', 'University of Lahore', CONVERT(DATE, '01-Feb-2010'), CONVERT(DATE, '01-Feb-2015')),
								 (2, 'Medical Degree', 'University of Punjab', CONVERT(DATE, '01-Jan-2002'), CONVERT(DATE, '01-Jan-2006')),
								 (2, 'Dermatology Specialisation', 'University of Peshawar', CONVERT(DATE, '01-Feb-2006'), CONVERT(DATE, '01-Feb-2011')),
								 (5, 'Medical Degree', 'Aga Khan University', CONVERT(DATE, '01-Jan-2006'), CONVERT(DATE, '01-Jan-2010')),
								 (5, 'Nephrology Specialisation', 'Dow University', CONVERT(DATE, '01-Feb-2010'), CONVERT(DATE, '01-Feb-2015')),
								 (6, 'Medical Degree', 'Liaquat National University', CONVERT(DATE, '01-Jan-2006'), CONVERT(DATE, '01-Jan-2010')),
								 (6, 'Surgery Specialisation', 'Dow University', CONVERT(DATE, '01-Feb-2010'), CONVERT(DATE, '01-Feb-2015')),
								 (13, 'Medical Degree', 'Quaid-e-Azam University', CONVERT(DATE, '01-Jan-2006'), CONVERT(DATE, '01-Jan-2010')),
								 (13, 'Cardiology Specialisation', 'Rawalpindi Medical University', CONVERT(DATE, '01-Feb-2010'), CONVERT(DATE, '01-Feb-2015')),
								 (16, 'Medical Degree', 'Sargodha Medical College', CONVERT(DATE, '01-Jan-2000'), CONVERT(DATE, '01-Jan-2004')),
								 (16, 'ENT Specialisation', 'Army Medical College', CONVERT(DATE, '01-Feb-2004'), CONVERT(DATE, '01-Feb-2009')),
								 (17, 'Medical Degree', 'Isra University/hospital', CONVERT(DATE, '01-Jan-2006'), CONVERT(DATE, '01-Jan-2010')),
								 (17, 'Dermatology Specialisation', 'Hamdard University', CONVERT(DATE, '01-Feb-2010'), CONVERT(DATE, '01-Feb-2015')),
								 (18, 'Medical Degree', 'Zia-ud-din Medical University', CONVERT(DATE, '01-Jan-2003'), CONVERT(DATE, '01-Jan-2007')),
								 (18, 'Nephrology Specialisation', 'Bannu Medical College', CONVERT(DATE, '01-Feb-2007'), CONVERT(DATE, '01-Feb-2012')),
								 (19, 'Medical Degree', 'Gomal Medical College', CONVERT(DATE, '01-Jan-2006'), CONVERT(DATE, '01-Jan-2010')),
								 (19, 'Surgery Specialisation', 'Abwa Medical College', CONVERT(DATE, '01-Feb-2010'), CONVERT(DATE, '01-Feb-2015')),
								 (20, 'Medical Degree', 'Gujranwala Medical College', CONVERT(DATE, '01-Jan-1998'), CONVERT(DATE, '01-Jan-2002')),
								 (20, 'Carediology Specialisation', 'Bilawal Medical College', CONVERT(DATE, '01-Feb-2002'), CONVERT(DATE, '01-Feb-2007')),
								 (3, 'Medical Degree', 'Khairpur Medical College', CONVERT(DATE, '01-Jan-2014'), CONVERT(DATE, '01-Jan-2018')),
								 (4, 'Medical Degree', 'Jhalawan Medical College', CONVERT(DATE, '01-Jan-2014'), CONVERT(DATE, '01-Jan-2018')),
								 (7, 'Medical Degree', 'Chandka Medical College', CONVERT(DATE, '01-Jan-2013'), CONVERT(DATE, '01-Jan-2017')),
								 (8, 'Medical Degree', 'Ameer Ud Din Medical College', CONVERT(DATE, '01-Jan-2014'), CONVERT(DATE, '01-Jan-2018')),
								 (14, 'Medical Degree', 'Cmh Lahore Medical College', CONVERT(DATE, '01-Jan-2014'), CONVERT(DATE, '01-Jan-2018')),
								 (21, 'Medical Degree', 'Avicenna Medical College', CONVERT(DATE, '01-Jan-2014'), CONVERT(DATE, '01-Jan-2018')),
								 (22, 'Medical Degree', 'Muhammad Medical College', CONVERT(DATE, '01-Jan-2014'), CONVERT(DATE, '01-Jan-2018')),
								 (23, 'Medical Degree', 'Sahara Medical College', CONVERT(DATE, '01-Jan-2013'), CONVERT(DATE, '01-Jan-2017')),
								 (24, 'Medical Degree', 'Jinnah Medical College', CONVERT(DATE, '01-Jan-2014'), CONVERT(DATE, '01-Jan-2018')),
								 (25, 'Medical Degree', 'Jinnah Medical College', CONVERT(DATE, '01-Jan-2014'), CONVERT(DATE, '01-Jan-2018'))


INSERT INTO PATIENT VALUES ('1234567890123', 'Hassan', 'Sohail', '03334567890', 'HNo 1, Street 1, DHA, Islamabad'),
						   ('1234567890124', 'Zoha', 'Khattak', '03334567891', 'HNo 1, Street 2, DHA, Islamabad'),
						   ('1234567890125', 'Saud', 'Ul Huda', '03334567892', 'HNo 1, Street 3, Bahria, Islamabad'),
						   ('1234567890126', 'Laiba', 'Nadeem', '03334567893', 'HNo 1, Street 4, DHA, Islamabad'),
						   ('1234567890127', 'Fatima', 'Tahir', '03334567894', 'HNo 1, Street 3, DHA, Islamabad'),
						   ('1234567890128', 'Abiha', 'Farid', '03334567895', 'HNo 1, Street 4, DHA, Islamabad'),
						   ('1234567890129', 'Usama', 'Azam', '03334567896', 'HNo 1, Street 5, Bahria, Islamabad'),
						   ('1234567890120', 'Shah', 'Nehal', '03334567897', 'HNo 1, Street 6, DHA, Islamabad'),
						   ('1234567890121', 'Chaudhary', 'Ammar', '03334567898', 'HNo 1, Street 7, DHA, Islamabad'),
						   ('1234567890122', 'Aizaz', 'Khawar', '03334567899', 'HNo 1, Street 8, DHA, Islamabad')


INSERT INTO MEDICINE VALUES (1, 'Panadol', 'paracetmol', 'Painkiller', 500),
							(2, 'Synthroid', 'levothyroxine', 'Antiallergy', 300),
							(3, 'Crestor', 'rosuvastatin', 'Sedative', 500),
							(4, 'Ventolin', 'albuterol', 'Antibiotic', 700),
							(5, 'Nexium 5', 'esomeprazole', 'Antibiotic', 800),
							(6, 'Advair Diskus', 'fluticasone', 'Painkiller', 500),
							(7, 'Lantus Solostar', 'insulin ', 'Antiallergy', 300),
							(8, 'Vyvanse', 'lisdexamfetamine', 'Multivitamin', 1000),
							(9, 'Lyrica', 'pregabalin', 'Antiallergy', 700),
							(10, 'Spiriva', 'tiotropium', 'Antibiotic', 800)


INSERT INTO ROOM VALUES (1, 'Private Ward', 10000),
						(2, 'Private Ward', 10000),
						(3, 'Executive Room', 20000),
						(4, 'Deluxe Room', 30000),
						(5, 'Private Ward', 10000),
						(6, 'Semi Private', 8000),
						(7, 'Semi Private', 8000)

INSERT INTO STAY VALUES (1, '1234567890123', 1, CONVERT(DATE, '10-May-2022'), CONVERT(DATE, '15-May-2022'), 3),
						(2, '1234567890124', 2, CONVERT(DATE, '08-May-2022'), CONVERT(DATE, '10-May-2022'), 7),
						(3, '1234567890125', 4, CONVERT(DATE, '08-May-2022'), CONVERT(DATE, '10-May-2022'), 21),
						(4, '1234567890126', 6, CONVERT(DATE, '07-May-2022'), CONVERT(DATE, '14-May-2022'), 24)


INSERT INTO APPOINTMENT VALUES (1, 1, CAST('2022-05-06 10:00:00 AM' AS DATETIME2), CAST('2022-05-06 10:30:00 AM' AS DATETIME2), '1234567890127'),
							   (2, 1, CAST('2022-05-06 12:00:00 PM' AS DATETIME2), CAST('2022-05-06 12:30:00 PM' AS DATETIME2), '1234567890128'),
							   (3, 2, CAST('2022-05-06 5:00:00 PM' AS DATETIME2), CAST('2022-05-06 5:30:00PM' AS DATETIME2), '1234567890129'),
							   (4, 2, CAST('2022-05-06 7:00:00 PM' AS DATETIME2), CAST('2022-05-06 7:30:00 PM' AS DATETIME2), '1234567890120' )

INSERT INTO PRESCRIPTION VALUES (1, 1, '1234567890127', 1, 1, CONVERT(DATE, '06-May-22')),
							    (2, 1, '1234567890128', 2, 2, CONVERT(DATE, '06-May-22')),
								(3, 2, '1234567890129', 3, 3, CONVERT(DATE, '06-May-22')),
								(4, 2, '1234567890120', 4, 4, CONVERT(DATE, '06-May-22'))


INSERT INTO IN_BILL_INFO VALUES (1, '1234567890123', 1, 1, 1),
								(2, '1234567890124', 1, 2, 2),
								(3, '1234567890125', 2, 3, 3),
								(4, '1234567890126', 2, 4, 4)


INSERT INTO OUT_BILL_INFO VALUES(1, '1234567890127', 1, 1),
								(2,	'1234567890128', 1, 2),
								(3,	'1234567890129', 2, 3),
								(4, '1234567890120', 2, 4)

/*---------------------------------------------------------*/


/*---------PROCEDURES---------*/
CREATE PROCEDURE ADD_STAY
    @Stay_ID   NUMERIC ,
    @CNIC   VARCHAR(30) ,
    @R_ID     NUMERIC,
	@S_Date DATE,
	@E_Date DATE,
	@D_ID	NUMERIC,
	@M_ID	NUMERIC,
	@Nurse_ID NUMERIC

AS
    IF EXISTS(SELECT 1
                FROM STAY
               WHERE Room_ID = @R_ID
				 AND Start_Date <= @S_Date
                 AND End_Date >= @E_Date)
      BEGIN
        RAISERROR('ERROR! This room has is already booked', 15, 1);
      END
    ELSE
      BEGIN
        INSERT INTO STAY VALUES (@Stay_ID, @CNIC, @R_ID, CONVERT(DATE, @S_Date), CONVERT(DATE, @E_Date), @Nurse_ID)
		INSERT INTO IN_BILL_INFO VALUES(@Stay_ID, @CNIC, @D_ID, @R_ID, @M_ID)
      END
GO

EXEC ADD_STAY @Stay_ID = 6, @CNIC='1234567890128', @R_ID = 4, @S_Date = '24-May-2022', @E_Date = '28-May-2022', @D_ID = 16, @M_ID = 3, @Nurse_ID = 22

SELECT * FROM STAY

CREATE PROCEDURE ADD_APPOINTMENT
    @App_ID   NUMERIC ,
    @Doc_ID   NUMERIC ,
    @Start_Time DATETIME2,
	@End_Time DATETIME2,
	@P_CNIC VARCHAR(30)

AS
    IF EXISTS(SELECT 1
                FROM APPOINTMENT
               WHERE Doc_ID = @Doc_ID
				 AND Start_Time <= @Start_Time
                 AND End_Time >= @End_Time)
      BEGIN
        RAISERROR('ERROR! Doctor has appointment booked at this time already', 16, 1);
      END
    ELSE
      BEGIN
        INSERT INTO APPOINTMENT VALUES (@App_ID, @Doc_ID, CAST(@Start_Time AS DATETIME2), CAST(@End_Time AS DATETIME2) , @P_CNIC)
		INSERT INTO OUT_BILL_INFO VALUES (@App_ID, @P_CNIC, @Doc_ID, @App_ID)
      END
GO

DROP PROCEDURE ADD_APPOINTMENT
/*-----------------------*/

/* USE THIS TO INSERT VALUES INTO STAY  */
EXEC ADD_STAY @Stay_ID = 8, @CNIC = '1234567890125', @R_ID = 3, @S_Date = '25-May-2022', @E_Date = '27-May-2022', @D_ID = 2, @M_ID = 5, @Nurse_ID = 4;
/*------------*/

/* USE THIS TO INSERT VALUES INTO APPOINTMENT RATHER THAN 'INSERT' */
EXEC ADD_APPOINTMENT @App_ID = 6, @Doc_ID = 1, @Start_Time = '2022-05-06 10:00:00 AM', @End_Time = '2022-05-06 10:30:00 AM', @P_CNIC = '1234567890127'
/* -----------*/


/*-----VIEWS-----*/
CREATE VIEW OUT_BILL AS
SELECT OUT_BILL_INFO.Out_Bill_ID, OUT_BILL_INFO.P_CNIC, CONVERT(VARCHAR(10), APPOINTMENT.Start_Time) AS 'Appointment_Date', OUT_BILL_INFO.Doc_ID, DOCTOR.Charges AS 'Doctor Charges'
FROM OUT_BILL_INFO INNER JOIN DOCTOR
ON OUT_BILL_INFO.Doc_ID = DOCTOR.Doctor_ID
INNER JOIN APPOINTMENT
ON OUT_BILL_INFO.Appointment_ID = APPOINTMENT.ID

DROP VIEW OUT_BILL

SELECT * FROM OUT_BILL

CREATE VIEW IN_BILL AS
SELECT IN_BILL_INFO.In_Bill_ID, IN_BILL_INFO.P_CNIC, IN_BILL_INFO.Doc_ID, IN_BILL_INFO.Room_ID, ROOM.Room_Cost,
MEDICINE.Cost AS 'Medicine_Cost',
DOCTOR.Charges AS 'Doctor_Charges',
(DATEDIFF(DAY, STAY.Start_Date, STAY.End_Date)) AS 'Stay_Duration_(Days)',
(DATEDIFF(DAY, STAY.Start_Date, STAY.End_Date)) * DOCTOR.Charges AS 'Total Doctor Charges',
(DATEDIFF(DAY, STAY.Start_Date, STAY.End_Date)) * MEDICINE.Cost AS 'Total Medicine Charges',
(DATEDIFF(DAY, STAY.Start_Date, STAY.End_Date) * ROOM.Room_Cost) + (DATEDIFF(DAY, STAY.Start_Date, STAY.End_Date) * DOCTOR.Charges) + MEDICINE.Cost AS 'Total'
FROM IN_BILL_INFO INNER JOIN DOCTOR ON IN_BILL_INFO.Doc_ID = DOCTOR.Doctor_ID
INNER JOIN ROOM ON IN_BILL_INFO.Room_ID = ROOM.Room_ID
INNER JOIN MEDICINE ON IN_BILL_INFO.Medicine_ID = MEDICINE.Medicine_ID
INNER JOIN STAY ON IN_BILL_INFO.P_CNIC = STAY.P_CNIC
/*------------*/


/* REPORT 1 */
SELECT EMPLOYEE.*, DEPARTMENT.D_Name FROM EMPLOYEE
INNER JOIN DEPARTMENT
ON EMPLOYEE.Dept_ID = DEPARTMENT.ID

/* REPORT 2 */
SELECT EMPLOYEE.First_Name, EMPLOYEE.Last_Name, DEPARTMENT.D_Name, DEPARTMENT_HEAD.* FROM DEPARTMENT_HEAD
INNER JOIN EMPLOYEE
ON EMPLOYEE.Emp_ID = DEPARTMENT_HEAD.Head_ID
INNER JOIN DEPARTMENT
ON DEPARTMENT.ID = DEPARTMENT_HEAD.Dept_ID

/* REPORT 3 */
SELECT * FROM ROOM

/* REPORT 4 */
SELECT QUALIFICATION.Institute, COUNT(*) AS 'No of Degrees from Uni' FROM QUALIFICATION
INNER JOIN EMPLOYEE
ON EMPLOYEE.Emp_ID = QUALIFICATION.Employee_ID
GROUP BY QUALIFICATION.Institute

/* REPORT 5 */
SELECT CONVERT(DATE, QUALIFICATION.D_End_Date) AS 'Graduating Month of Doctors', QUALIFICATION.Degree, COUNT(*) AS 'Num of Doctors' FROM QUALIFICATION  
INNER JOIN DOCTOR
ON QUALIFICATION.Employee_ID = DOCTOR.Doctor_ID
GROUP BY QUALIFICATION.D_End_Date, QUALIFICATION.Degree

/* REPORT 6 */
SELECT EMPLOYEE.First_Name, DOCTOR.Doctor_ID, SUM(OUT_BILL.[Doctor Charges]) AS 'Total_Earnings_From_Doctor_On_Appointments' FROM DOCTOR
INNER JOIN OUT_BILL
ON DOCTOR.Doctor_ID = OUT_BILL.Doc_ID
INNER JOIN EMPLOYEE
ON EMPLOYEE.Emp_ID = DOCTOR.Doctor_ID
GROUP BY DOCTOR.Doctor_ID, EMPLOYEE.First_Name

/* REPORT 7 */
SELECT EMPLOYEE.First_Name, DOCTOR.Doctor_ID, SUM(IN_BILL.[Total Doctor Charges]) AS 'Total_Earnings_From_Doctor_On_Surgeries' FROM DOCTOR
INNER JOIN IN_BILL
ON DOCTOR.Doctor_ID = IN_BILL.Doc_ID
INNER JOIN EMPLOYEE
ON EMPLOYEE.Emp_ID = DOCTOR.Doctor_ID
GROUP BY DOCTOR.Doctor_ID, EMPLOYEE.First_Name

/* REPORT 8 */
CREATE PROCEDURE APPOINTMENTS_FOR_DATE
@Start_Date DATE
AS
BEGIN
SELECT * FROM APPOINTMENT
INNER JOIN DOCTOR
ON DOCTOR.Doctor_ID = APPOINTMENT.Doc_ID
AND CONVERT(DATE, @Start_Date) = CONVERT(DATE, APPOINTMENT.Start_Time)
END

EXEC APPOINTMENTS_FOR_DATE @Start_Date = '2022-5-28'

/* REPORT 9 */
SELECT EMPLOYEE.Dept_ID, DEPARTMENT.D_Name, COUNT(*) AS 'No of Employees' FROM EMPLOYEE
INNER JOIN DEPARTMENT
ON DEPARTMENT.ID = EMPLOYEE.Dept_ID
GROUP BY EMPLOYEE.Dept_ID, DEPARTMENT.D_Name


/* REPORT 10 */
SELECT QUALIFICATION.*, EMPLOYEE.First_Name + ' ' + EMPLOYEE.Last_Name AS 'Full Name' FROM DOCTOR
INNER JOIN QUALIFICATION
ON DOCTOR.Doctor_ID = QUALIFICATION.Employee_ID
INNER JOIN EMPLOYEE
ON DOCTOR.Doctor_ID = EMPLOYEE.Emp_ID



/* REPORT 11 */
SELECT AVG(EMPLOYEE.Salary) AS 'Average_Nurse_Salary' FROM EMPLOYEE
INNER JOIN NURSE
ON EMPLOYEE.Emp_ID = NURSE.Nurse_ID


/* REPORT 12 */
SELECT AVG(EMPLOYEE.Salary) AS 'Average_Doctor_Salary' FROM EMPLOYEE
INNER JOIN DOCTOR
ON EMPLOYEE.Emp_ID = DOCTOR.Doctor_ID


/* REPORT 13 */
SELECT AVG(DOCTOR.Charges) AS 'Average_Doctor_Charges' FROM EMPLOYEE
INNER JOIN DOCTOR
ON EMPLOYEE.Emp_ID = DOCTOR.Doctor_ID

/* REPORT 14 */
EXEC ADD_APPOINTMENT @App_ID = 7, @Doc_ID = 16, @Start_Time = '2022-05-28 10:00:00 AM', @End_Time = '2022-05-28 10:30:00 AM', @P_CNIC = '1234567890120'
EXEC ADD_APPOINTMENT @App_ID = 8, @Doc_ID = 1, @Start_Time = '2022-05-28 11:00:00 AM', @End_Time = '2022-05-28 11:30:00 AM', @P_CNIC = '1234567890121'
EXEC ADD_APPOINTMENT @App_ID = 9, @Doc_ID = 2, @Start_Time = '2022-05-28 12:00:00 PM', @End_Time = '2022-05-28 12:30:00 PM', @P_CNIC = '1234567890123'

SELECT * FROM APPOINTMENT
INNER JOIN DOCTOR
ON DOCTOR.Doctor_ID = APPOINTMENT.Doc_ID
AND CONVERT(DATE, APPOINTMENT.Start_Time) = CONVERT(DATE, GETDATE())
