USE sHastane

CREATE TABLE tblDoktorlar(

ID INT IDENTITY(1,1) NOT NULL,
SicilNo CHAR(5) NOT NULL,
AdSoyad CHAR(11) NULL,
Tel CHAR(11) NULL,
Mail VARCHAR(30),
BolumID INT NOT NULL,
PRIMARY KEY(ID),
FOREIGN KEY(BolumID) REFERENCES tblBolumler(ID)
)

GO
INSERT INTO tblDoktorlar VALUES

('12343','RECEP','15415','recepmail','1'),
('42331','ALÝ','5614561','alimail','1'),
('21432','VELÝ','5156','velimail','3'),
('23114','SEYMA','545616','seymamail','2'),
('23174','Selen','5456184','selenmail','2')