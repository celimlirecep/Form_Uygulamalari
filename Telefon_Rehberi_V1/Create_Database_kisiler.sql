--CREATE DATABASE Srehber
USE Srehber
CREATE TABLE tblKisiler 
(
ID INT IDENTITY(1,1),
AD VARCHAR(20) NOT NULL,
Soyad VARCHAR(20) NOT NULL,
Cinsiyet CHAR NOT NULL,
telefon NCHAR(11) NOT NULL,
PRIMARY KEY(ID)
)

INSERT INTO tblKisiler
VALUES
		('Haluk','levent','E','05554325566'),
		('Seren','Günaçtı','K','0555332566'),
		('Kemal','Kalbur','E','0555432999'),
		('Saide','Kül','K','05554325888'),
		('Mahir','Çakmak','E','05554777566'),
		('Canan','Solak','K','05556665566')