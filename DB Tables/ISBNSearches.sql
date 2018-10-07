CREATE TABLE `ISBNSearches` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` int(11) NOT NULL,
  `ISBN` varchar(50) NOT NULL,
  `Time` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`),
  KEY `ISBNSearches_Users_FK` (`UserId`),
  CONSTRAINT `ISBNSearches_Users_FK` FOREIGN KEY (`UserId`) REFERENCES `Users` (`Id`)
)