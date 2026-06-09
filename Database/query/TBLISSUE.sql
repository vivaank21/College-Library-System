USE LibraryDB
GO

CREATE TABLE TblIssueBooks
(
    IssueID INT PRIMARY KEY IDENTITY(1,1),

    StudentID INT NOT NULL,

    BookID INT NOT NULL,

    IssueDate DATE NOT NULL,

    DueDate DATE NOT NULL,

    Status VARCHAR(20) DEFAULT 'Issued',

    IsAct BIT DEFAULT 1,

    CreatedDate DATETIME DEFAULT GETDATE(),

    CONSTRAINT FK_IssueBook_Student
    FOREIGN KEY(StudentID)
    REFERENCES TblStudents(StudentID),

    CONSTRAINT FK_IssueBook_Book
    FOREIGN KEY(BookID)
    REFERENCES TblBooks(BookID)
);