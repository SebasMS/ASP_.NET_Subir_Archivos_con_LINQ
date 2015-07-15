CREATE DATABASE dbFile

GO
USE dbFile

GO
CREATE TABLE tblFile
(
	id        INT            IDENTITY (1,1),
	name      VARCHAR(MAX)   NOT NULL,
	extension VARCHAR(4)     NOT NULL,
	fileF     VARBINARY(MAX) NOT NULL,
	dateF     DATETIME       NOT NULL
)

ALTER TABLE tblFile ADD CONSTRAINT pk_File PRIMARY KEY (id)