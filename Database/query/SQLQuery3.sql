CREATE TABLE TblStudents
(
    StudentID INT PRIMARY KEY IDENTITY,

    FullName VARCHAR(150) NOT NULL,

    EnrollmentNo VARCHAR(50) UNIQUE,

    Email VARCHAR(100),

    ContactNo VARCHAR(20),

    DepartmentID INT,

    SemesterID INT,

    StudentImage VARCHAR(MAX),

    StudentStatus VARCHAR(20) DEFAULT 'Active',

    CreatedDate DATETIME DEFAULT GETDATE(),

    UpdatedDate DATETIME NULL,

    IsAct BIT DEFAULT 1,

    CONSTRAINT FK_Students_Department
    FOREIGN KEY (DepartmentID)
    REFERENCES TblDepartments(DepartmentID),

    CONSTRAINT FK_Students_Semester
    FOREIGN KEY (SemesterID)
    REFERENCES TblSemester(SemesterID)
)
GO