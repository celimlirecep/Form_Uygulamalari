USE sHastane
CREATE TABLE tblBolumler
(
ID INT IDENTITY(1,1) NOT NULL,
BolumID VARCHAR(30) UNIQUE NOT NULL,
PRIMARY KEY(ID)
)
GO

INSERT INTO tblBolumler
VALUES
('DAHİLİYE'),('NÖROLOJİ'),('ORTOPEDİ')
GO