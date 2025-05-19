 Scaffold-DbContext "Server=1misa;Database=Variant3;Trusted_Connection=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Login NVARCHAR(100) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    RegistrationDate DATE NOT NULL,
    FullName NVARCHAR(200) NOT NULL,
    PhoneNumber NVARCHAR(20)
);

CREATE TABLE Requests (
    Id INT PRIMARY KEY IDENTITY(1,1),
    RequestNumber NVARCHAR(50) NOT NULL UNIQUE,
    Title NVARCHAR(200) NOT NULL,
    Type NVARCHAR(100),
    ProblemDescription NVARCHAR(MAX),
    CreatedDate DATE,
    Status INT NOT NULL, -- 0: Processing, 1: InProgress, 2: Completed
    MasterId INT FOREIGN KEY REFERENCES Users(Id)
);
