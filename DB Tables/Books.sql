CREATE TABLE `Books` (
   `Id` int(11) NOT NULL AUTO_INCREMENT,	
   `ISBN13` varchar(100) NOT NULL,
   `ISBN10` varchar(100) NULL,
   `BookName` varchar(100) NOT NULL,
   `Author` varchar(100) NOT NULL, 
   `Publisher` varchar(100) NULL,   
   `Published` int(11) NOT NULL,
   `ListPrice` double NULL,
   `CoverLink` varchar(100) NULL,   
   PRIMARY KEY (`Id`),
   UNIQUE KEY `BOOKS-ISBN` (`ISBN13`)
);