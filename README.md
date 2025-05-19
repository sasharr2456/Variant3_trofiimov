USE Variant3_Trofimov;

drop table Users
 drop table Requests
 




CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1), 
    Login NVARCHAR(255) NOT NULL, 
    Password NVARCHAR(255) NOT NULL, 
    RegistrationDate DATE NOT NULL, 
    FullName NVARCHAR(255) NOT NULL, 
    PhoneNumber NVARCHAR(50) NULL
);


CREATE TABLE Requests (
    Id INT PRIMARY KEY IDENTITY(1,1), 
    RequestNumber NVARCHAR(50) NOT NULL, 
    Title NVARCHAR(255) NOT NULL, 
    Type NVARCHAR(50) NULL, 
    ProblemDescription NVARCHAR(MAX) NULL, 
    CreatedDate DATE NULL, 
    Status INT NOT NULL, 
    MasterId INT NULL,
    FOREIGN KEY (MasterId) REFERENCES Users(Id)
);

INSERT INTO Users (Login, Password, RegistrationDate, FullName, PhoneNumber) VALUES 
('user1', 'password1', '2023-01-01', 'Иван Иванов', '1234567890'),
('user2', 'password2', '2023-01-02', 'Мария Петрова', '0987654321');



INSERT INTO Requests (RequestNumber, Title, Type, ProblemDescription, CreatedDate, Status, MasterId) VALUES 
('REQ001', 'Проблема с входом', 'Ошибка', 'Пользователь не может войти в систему', '2023-01-10', 1, 1),
('REQ002', 'чиназес)', 'успешно', 'Пользователь вошел в систему', '2022-05-15', 1, 2),
('REQ001', 'Проблема с входом', 'Ошибка', 'Пользователь не может войти в систему', '2023-01-10', 1, 2),
('REQ002', 'чиназес)', 'успешно', 'Пользователь вошел в систему', '2022-05-15', 1, 1),
('REQ001', 'Проблема с входом', 'Ошибка', 'Пользователь не может войти в систему', '2023-01-10', 1, 1),
('REQ002', 'чиназес)', 'успешно', 'Пользователь вошел в систему', '2022-05-15', 1, 2),
('REQ003', 'Запрос на новую функцию', 'Функция', 'Запрос на добавление новой функции', '2023-01-11', 1, 2);


SELECT * FROM Users;
SELECT * FROM Requests;
