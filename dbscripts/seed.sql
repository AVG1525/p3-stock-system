\connect stockSystemDB

CREATE TABLE public.USER (
    ID INT PRIMARY KEY,
    NAME VARCHAR(100) NOT NULL
);

CREATE TABLE ESTABLISHMENT (
    ID INT PRIMARY KEY,
    NAME VARCHAR(100) NOT NULL,
    IDUSER INT NOT NULL
);

CREATE TABLE DESCRIPTIONRAWMATERIAL (
    ID INT PRIMARY KEY,
    DESCRIPTION VARCHAR(30) NOT NULL
);

CREATE TABLE RAWMATERIAL (
    ID INT PRIMARY KEY,
    IDDESCRIPTIONRAWMATERIAL INT NOT NULL,
    IDESTABLISHMENT INT NOT NULL
);

CREATE TABLE HistoryRawMaterial (
    ID INT PRIMARY KEY,
    DATEDAY DATE NOT NULL,
    DATEVALIDITY DATE,
    AMOUNT INT DEFAULT 0,
    UNITPRICE DECIMAL DEFAULT 0,
    IDRAWMATERIAL INT NOT NULL
);

CREATE TABLE SALEDAY (
    ID INT PRIMARY KEY,
    DATEDAY DATE NOT NULL,
    RESULTDAY DECIMAL DEFAULT 0,
    IDESTABLISHMENT INT NOT NULL
);

CREATE TABLE STATISTICSRAWMATERIAL (
    ID INT PRIMARY KEY,
    DATEDAY DATE NOT NULL,
    ESTIMATEDSTOCKDATEEMPTY DATE,
    IDRAWMATERIAL INT NOT NULL
);

CREATE TABLE STATISTICSDAY (
    ID INT PRIMARY KEY,
    DATEDAY DATE NOT NULL,
    RAWMATERIALEXPENDITURE DECIMAL DEFAULT 0,
    GROWTHRATE INT DEFAULT 0,
    IDESTABLISHMENT INT NOT NULL
);

CREATE TABLE ValidationTestDay (
    ID INT PRIMARY KEY,
    DATEDAY DATE NOT NULL,
    ISHOLIDAY BOOLEAN NOT NULL,
    GROWTHRATE INT DEFAULT 0
);

ALTER TABLE RAWMATERIAL
ADD CONSTRAINT FK_IDDESCRIPTIONRAWMATERIAL
FOREIGN KEY (IDDESCRIPTIONRAWMATERIAL) REFERENCES DESCRIPTIONRAWMATERIAL(ID);

ALTER TABLE RAWMATERIAL
ADD CONSTRAINT FK_IDESTABLISHMENT
FOREIGN KEY (IDESTABLISHMENT) REFERENCES ESTABLISHMENT(ID);

ALTER TABLE HistoryRawMaterial
ADD CONSTRAINT FK_IDRAWMATERIAL
FOREIGN KEY (IDRAWMATERIAL) REFERENCES RAWMATERIAL(ID);

ALTER TABLE SALEDAY
ADD CONSTRAINT FK_IDESTABLISHMENT
FOREIGN KEY (IDESTABLISHMENT) REFERENCES ESTABLISHMENT(ID);

ALTER TABLE STATISTICSRAWMATERIAL
ADD CONSTRAINT FK_IDRAWMATERIAL
FOREIGN KEY (IDRAWMATERIAL) REFERENCES RAWMATERIAL(ID);

ALTER TABLE STATISTICSDAY
ADD CONSTRAINT FK_IDESTABLISHMENT
FOREIGN KEY (IDESTABLISHMENT) REFERENCES ESTABLISHMENT(ID);

ALTER TABLE ESTABLISHMENT
ADD CONSTRAINT FK_IDUSER
FOREIGN KEY (IDUSER) REFERENCES public.USER(ID);

ALTER TABLE public.user 
ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY;

ALTER TABLE public.DescriptionRawMaterial 
ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY;

ALTER TABLE public.Establishment 
ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY;

ALTER TABLE public.HistoryRawMaterial 
ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY;

ALTER TABLE public.RawMaterial 
ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY;

ALTER TABLE public.SaleDay 
ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY;

ALTER TABLE public.StatisticsDay 
ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY;

ALTER TABLE public.StatisticsRawMaterial 
ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY;

ALTER TABLE public.ValidationTestDay 
ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY;