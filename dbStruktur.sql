CREATE TABLE studier(
    studieretning VARCHAR(128) PRIMARY KEY,
    grad VARCHAR(45),
    fakultet VARCHAR(45) NOT NULL
);
   
CREATE TABLE foreleser(
    foreleserid INT(4) PRIMARY KEY,
    fornavn VARCHAR(64),
    etternavn VARCHAR(64)
);

CREATE TABLE fag(
    fagkode VARCHAR(8) PRIMARY KEY,
    fagnavn VARCHAR(128) NOT NULL, 
    foreleserid INT(4),
    studieretning VARCHAR (128),
    FOREIGN KEY (foreleserid) REFERENCES foreleser(foreleserid),
    FOREIGN KEY (studieretning) REFERENCES studier(studieretning)
);

CREATE TABLE student(
    studentid INT(10) PRIMARY KEY,
    studieretning VARCHAR(128),
    FOREIGN KEY (studieretning) REFERENCES studier(studieretning)
);

CREATE TABLE vurderingsskjema (
    skjemaid INT(4) PRIMARY KEY,
    beskrivelse VARCHAR(128),
    spm1 VARCHAR(128),
    spm2 VARCHAR(128),
    spm3 VARCHAR(128),
    spm4 VARCHAR(128),
    spm5 VARCHAR(128),
    spm6 VARCHAR(128),
    spm7 VARCHAR(128),
    spm8 VARCHAR(128),
    spm9 VARCHAR(128),
    spm10 VARCHAR(128)
);

CREATE TABLE vurderingshistorikk(
    skjemaid INT(4),
    studentid INT(10),
    fagkode VARCHAR(8),
    spm1 INT(1),
    spm2 INT(1),
    spm3 INT(1),
    spm4 INT(1),
    spm5 INT(1),
    spm6 INT(1),
    spm7 INT(1),
    spm8 INT(1),
    spm9 INT(1),
    spm10 INT(1),
    FOREIGN KEY (skjemaid) REFERENCES vurderingsskjema (skjemaid),
    FOREIGN KEY (studentid) REFERENCES student (studentid),
    FOREIGN KEY (fagkode) REFERENCES fag (fagkode),
    PRIMARY KEY (fagkode, studentid)
);

CREATE TABLE formlogin(
    bruker VARCHAR(64) PRIMARY KEY,
    passord VARCHAR(64),
    brukertype INT(1)
);



---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

 
INSERT INTO studier(studieretning, grad, fakultet) VALUES ('It og Informasjonssystemer', 'Bachelor', 'Handelshøyskolen'), ('Dataingeniør', 'Bachelor','Ingeniørhøyskolen'),
('Regnskapsfører', 'Master', 'Handelshøyskolen');

INSERT INTO foreleser(foreleserid, fornavn, etternavn) VALUES (313, 'Ola', 'Nordmann'), (1337, 'Linus', 'Thorvaldsen'),
(666, 'Steve', 'Jobs'), (111, 'Bill', 'Gates');

INSERT INTO fag(fagkode, fagnavn, foreleserid, studieretning) VALUES ('DAT1000', 'Database', 313, 'It og Informasjonssystemer'), ('OBJ2100', 'Objective C', 666, 'Dataingeniør'), ('MAR1000', 'Markedsføringsledelse', 1337, 'Regnskapsfører'),
('WIN1100', 'Windows bootcamp', 111, 'It og Informasjonssystemer');

INSERT INTO student(studentid, studieretning) VALUES (001, 'It og Informasjonssystemer'), (002, 'It og Informasjonssystemer'), 
(003, 'Regnskapsfører'), (004, 'Regnskapsfører'), (005, 'Dataingeniør'),
(006, 'Dataingeniør');

INSERT INTO vurderingsskjema(skjemaid, beskrivelse, spm1, spm2, spm3, spm4, spm5, spm6, spm7, spm8, spm9, spm10) VALUES (1, 'Spørreskjema for databasefag', 'spm1', 'spm2','spm3','spm4','spm5','spm6','spm7','spm8','spm9','spm10'), (2, 'Spørreskjema for dataingeiør','spm1', 'spm2','spm3','spm4','spm5','spm6','spm7','spm8','spm9','spm10'),
(3, 'Spørreskjema for Markedsføringsledelse','spm1', 'spm2','spm3','spm4','spm5','spm6','spm7','spm8','spm9','spm10');

INSERT INTO vurderingshistorikk (skjemaid, studentid, fagkode, spm1, spm2, spm3, spm4, spm5, spm6, spm7, spm8, spm9, spm10) VALUES (2, 006, 'OBJ2100', 1, 4, 3, 4, 3, 5, 1, 2, 1, 4), (2, 005, 'OBJ2100', 3, 5, 1, 2, 4, 2, 3, 4, 5, 4);

INSERT INTO formlogin(bruker, passord, brukertype) VALUES ('admin', 'admin', 1), ('bruker', 'bruker', 2);


---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

DROP TABLE studier;
DROP TABLE foreleser;
DROP TABLE fag;
DROP TABLE student;
DROP TABLE vurderingsskjema;
DROP TABLE vurderingshistorikk;
DROP TABLE formlogin;