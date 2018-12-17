CREATE TABLE `Administator` (
  `UserID` int(11) NOT NULL,
  `AddNewAdministator` bit(1) NOT NULL,
  `AddNewBook` bit(1) NOT NULL,
  `CheckMissingBooks` bit(1) NULL,
  PRIMARY KEY (`UserID`),
  CONSTRAINT `Administator_Users_FK` FOREIGN KEY (`UserId`) REFERENCES `Users` (`Id`)
);