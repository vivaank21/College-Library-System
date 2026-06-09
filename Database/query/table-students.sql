USE LibraryDB
GO

CREATE TABLE TblDepartments
(
    DepartmentID INT PRIMARY KEY IDENTITY,

    DepartmentName VARCHAR(100),

    CreatedDate DATETIME DEFAULT GETDATE(),

    IsAct BIT DEFAULT 1
)
GO

INSERT INTO TblDepartments
(DepartmentName, IsAct)
VALUES
('Computer Science',1),
('Information Technology',1),
('Mechanical Engineering',1),
('Civil Engineering',1),
('Commerce',1),
('Arts',1)

GO

CREATE TABLE TblStudents
(
    StudentID INT PRIMARY KEY IDENTITY,

    FullName VARCHAR(150) NOT NULL,

    EnrollmentNo VARCHAR(50) UNIQUE,

    Email VARCHAR(100),

    ContactNo VARCHAR(20),

    DepartmentID INT,

    Semester INT,

    StudentImage VARCHAR(MAX),

    StudentStatus VARCHAR(20)
        DEFAULT 'Active',

    CreatedDate DATETIME DEFAULT GETDATE(),

    UpdatedDate DATETIME NULL,

    IsAct BIT DEFAULT 1,

    CONSTRAINT FK_Students_Department
    FOREIGN KEY (DepartmentID)
    REFERENCES TblDepartments(DepartmentID)
)
GO