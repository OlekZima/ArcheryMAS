-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2024-06-16 13:30:51.745

-- tables
-- Table: Archer
CREATE TABLE Archer (
    Person_PESEL text NOT NULL CONSTRAINT Archer_pk PRIMARY KEY,
    Rank text NOT NULL,
    LeaveReason text,
    CONSTRAINT Archer_Person FOREIGN KEY (Person_PESEL)
    REFERENCES Person (PESEL)
);

-- Table: ArcherInCompetition
CREATE TABLE ArcherInCompetition (
    PlaceInCompetition integer NOT NULL,
    Score integer NOT NULL,
    Prize text NOT NULL,
    Archer_Person_PESEL text NOT NULL,
    Competition_Name text NOT NULL,
    CONSTRAINT ArcherInCompetition_pk PRIMARY KEY (Archer_Person_PESEL,Competition_Name),
    CONSTRAINT ArcherInCompetition_Archer FOREIGN KEY (Archer_Person_PESEL)
    REFERENCES Archer (Person_PESEL),
    CONSTRAINT ArcherInCompetition_Competition FOREIGN KEY (Competition_Name)
    REFERENCES Competition (Name)
);

-- Table: ArrowSet
CREATE TABLE ArrowSet (
    ID integer NOT NULL CONSTRAINT ArrowSet_pk PRIMARY KEY,
    MinQuantity integer NOT NULL,
    ArrowQuantity integer NOT NULL,
    State text NOT NULL,
    ArrowLength double NOT NULL
);

-- Table: ArrowSetIndoor
CREATE TABLE ArrowSetIndoor (
    MaxDiameter double NOT NULL,
    Diameter double NOT NULL,
    ArrowSet_ID integer NOT NULL CONSTRAINT ArrowSetIndoor_pk PRIMARY KEY,
    CONSTRAINT ArrowSetIndoor_ArrowSet FOREIGN KEY (ArrowSet_ID)
    REFERENCES ArrowSet (ID)
);

-- Table: ArrowSetOutdoor
CREATE TABLE ArrowSetOutdoor (
    Material text NOT NULL,
    MaxDiameter double NOT NULL,
    Diameter double NOT NULL,
    ArrowSet_ID integer NOT NULL CONSTRAINT ArrowSetOutdoor_pk PRIMARY KEY,
    CONSTRAINT ArrowSetOutdoor_ArrowSet FOREIGN KEY (ArrowSet_ID)
    REFERENCES ArrowSet (ID)
);

-- Table: ArrowSetTraining
CREATE TABLE ArrowSetTraining (
    Material text NOT NULL,
    ArrowSet_ID integer NOT NULL CONSTRAINT ArrowSetTraining_pk PRIMARY KEY,
    CONSTRAINT ArrowSetTraining_ArrowSet FOREIGN KEY (ArrowSet_ID)
    REFERENCES ArrowSet (ID)
);

-- Table: Bow
CREATE TABLE Bow (
    NickName varchar(30) NOT NULL CONSTRAINT Bow_pk PRIMARY KEY,
    Manufacturer text NOT NULL,
    Force double NOT NULL
);

-- Table: Coach
CREATE TABLE Coach (
    Person_PESEL text NOT NULL CONSTRAINT Coach_pk PRIMARY KEY,
    MinSalary integer NOT NULL,
    Bonus integer NOT NULL,
    CONSTRAINT Coach_Person FOREIGN KEY (Person_PESEL)
    REFERENCES Person (PESEL)
);

-- Table: Competition
CREATE TABLE Competition (
    Name varchar(50) NOT NULL CONSTRAINT Competition_pk PRIMARY KEY,
    Description varchar(200),
    Place text NOT NULL,
    DateAndTimeStart datetime NOT NULL,
    DateAndTimeEnd datetime NOT NULL,
    State text NOT NULL,
    CancelingReason text
);

-- Table: CompoundBow
CREATE TABLE CompoundBow (
    Bow_NickName text NOT NULL CONSTRAINT CompoundBow_pk PRIMARY KEY,
    OpticalZoom double NOT NULL,
    CONSTRAINT CompoundBow_Bow FOREIGN KEY (Bow_NickName)
    REFERENCES Bow (NickName)
);

-- Table: OlympicBow
CREATE TABLE OlympicBow (
    Bow_NickName text NOT NULL CONSTRAINT OlympicBow_pk PRIMARY KEY,
    NummberOfStabilizers integer NOT NULL,
    MaxDaysWithoutService integer NOT NULL,
    DaysWithoutService integer NOT NULL,
    CONSTRAINT OlympicBow_Bow FOREIGN KEY (Bow_NickName)
    REFERENCES Bow (NickName)
);

-- Table: Person
CREATE TABLE Person (
    PESEL text NOT NULL CONSTRAINT Person_pk PRIMARY KEY,
    Bow_NickName text NOT NULL,
    ArrowSet_ID integer NOT NULL,
    Surname text NOT NULL,
    DateOfBirth date NOT NULL,
    Names text NOT NULL,
    CONSTRAINT Person_Bow FOREIGN KEY (Bow_NickName)
    REFERENCES Bow (NickName),
    CONSTRAINT Person_ArrowSet FOREIGN KEY (ArrowSet_ID)
    REFERENCES ArrowSet (ID)
);

-- Table: President
CREATE TABLE President (
    Person_PESEL text NOT NULL CONSTRAINT President_pk PRIMARY KEY,
    DegreeOfEducation text NOT NULL,
    CONSTRAINT President_Person FOREIGN KEY (Person_PESEL)
    REFERENCES Person (PESEL)
);

-- Table: Training
CREATE TABLE Training (
    Archer_Person_PESEL text NOT NULL,
    Coach_Person_PESEL text NOT NULL,
    DateAndTimeTrainingStart datetime NOT NULL,
    DateAndTimeTrainingEnd datetime NOT NULL,
    CONSTRAINT Training_pk PRIMARY KEY (Archer_Person_PESEL,Coach_Person_PESEL),
    CONSTRAINT Table_5_Archer FOREIGN KEY (Archer_Person_PESEL)
    REFERENCES Archer (Person_PESEL),
    CONSTRAINT Table_5_Coach FOREIGN KEY (Coach_Person_PESEL)
    REFERENCES Coach (Person_PESEL)
);

-- Table: UniversalSet
CREATE TABLE UniversalSet (
    Price double NOT NULL,
    Age integer NOT NULL,
    ArrowSetIndoor_ArrowSet_ID integer NOT NULL,
    ArrowSetOutdoor_ArrowSet_ID integer NOT NULL,
    ArrowSetTraining_ArrowSet_ID integer NOT NULL,
    CONSTRAINT UniversalSet_pk PRIMARY KEY (ArrowSetIndoor_ArrowSet_ID,ArrowSetOutdoor_ArrowSet_ID,ArrowSetTraining_ArrowSet_ID),
    CONSTRAINT UniversalSet_ArrowSetIndoor FOREIGN KEY (ArrowSetIndoor_ArrowSet_ID)
    REFERENCES ArrowSetIndoor (ArrowSet_ID),
    CONSTRAINT UniversalSet_ArrowSetOutdoor FOREIGN KEY (ArrowSetOutdoor_ArrowSet_ID)
    REFERENCES ArrowSetOutdoor (ArrowSet_ID),
    CONSTRAINT UniversalSet_ArrowSetTraining FOREIGN KEY (ArrowSetTraining_ArrowSet_ID)
    REFERENCES ArrowSetTraining (ArrowSet_ID)
);

-- End of file.

