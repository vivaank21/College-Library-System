USE LibraryDB
GO

CREATE TABLE TblSemester
(
    SemesterID INT PRIMARY KEY IDENTITY,

    SemesterName VARCHAR(50),

    CreatedDate DATETIME DEFAULT GETDATE(),

    IsAct BIT DEFAULT 1
)
GO 

INSERT INTO TblSemester
(SemesterName, IsAct)
VALUES
('Semester 1',1),
('Semester 2',1),
('Semester 3',1),
('Semester 4',1),
('Semester 5',1),
('Semester 6',1),
('Semester 7',1),
('Semester 8',1)

GO