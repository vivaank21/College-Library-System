USE LibraryDB
GO

CREATE TABLE TblCategories
(
    CategoryID INT PRIMARY KEY IDENTITY,

    CategoryName VARCHAR(100) NOT NULL,

    CreatedDate DATETIME DEFAULT GETDATE(),

    IsAct BIT DEFAULT 1
)

GO

CREATE TABLE TblBooks
(
    BookID INT PRIMARY KEY IDENTITY,

    BookName VARCHAR(150) NOT NULL,

    ISBN VARCHAR(50),

    AuthorName VARCHAR(100),

    CategoryID INT,

    Quantity INT DEFAULT 0,

    RackNumber VARCHAR(20),

    BookImage VARCHAR(MAX),

    AvailabilityStatus VARCHAR(20)
        DEFAULT 'Available',

    CreatedDate DATETIME DEFAULT GETDATE(),

    UpdatedDate DATETIME NULL,

    IsAct BIT DEFAULT 1,

    CONSTRAINT FK_Books_Categories
    FOREIGN KEY (CategoryID)
    REFERENCES TblCategories(CategoryID)
)

GO

INSERT INTO TblCategories (CategoryName, IsAct)
VALUES
('All Categories',1),
('Computer Science', 1),
('Fiction', 1),
('Stories', 1),
('Dark Romance', 1),
('psychology', 1),
('Manga', 1),
('Noval', 1),
('Discovery', 1)

GO