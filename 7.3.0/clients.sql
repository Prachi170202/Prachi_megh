CREATE TABLE clients(
id INT NOT NULL PRIMARY KEY IDENTITY,
name VARCHAR (100) NOT NULL,
email VARCHAR (50) NOT NULL UNIQUE,
phone VARCHAR (20) NULL,
address VARCHAR (100) NULL,
created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
);

INSERT INTO clients (name,email,phone,address)
VALUES 
('Bill gates','bilgates12@gmail.com','+1234567899','New york,USA'),
('Elon musk','Elonmusk17@gmail.com','+1234567898','New york,USA'),
('will smith','willsmith11@gmail.com','+1234567897','New york,USA'),
('Bob marley','Bobmarley18@gmail.com','+1234567890','New york,USA');