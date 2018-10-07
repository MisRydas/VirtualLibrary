CREATE TABLE `Users` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserName` varchar(100) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `FirstName` varchar(100) NULL,
  `LastName` varchar(100) NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Users_Name_IDX` (`UserName`)
);