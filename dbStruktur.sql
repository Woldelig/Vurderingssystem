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
    forkurs VARCHAR (128),
    FOREIGN KEY (foreleserid) REFERENCES foreleser(foreleserid),
    FOREIGN KEY (studieretning) REFERENCES studier(studieretning)
);

CREATE TABLE student(
    studentid INT(10) PRIMARY KEY AUTO_INCREMENT,
    studieretning VARCHAR(128),
    FOREIGN KEY (studieretning) REFERENCES studier(studieretning)
);

CREATE TABLE vurderingsskjema (
    skjemaid INT(4) PRIMARY KEY AUTO_INCREMENT,
    fagkode VARCHAR(8),
    spm1 VARCHAR(128),
    spm2 VARCHAR(128),
    spm3 VARCHAR(128),
    spm4 VARCHAR(128),
    spm5 VARCHAR(128),
    spm6 VARCHAR(128),
    spm7 VARCHAR(128),
    spm8 VARCHAR(128),
    spm9 VARCHAR(128),
    spm10 VARCHAR(128),
    FOREIGN KEY (fagkode) REFERENCES fag(fagkode)
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
    fornavn VARCHAR(64),
    etternavn VARCHAR(64),
    brukertype INT(1)
);

CREATE TABLE innloggingshistorikk(
  bruker VARCHAR(64) PRIMARY KEY,
  tidsstempel DATETIME,
  FOREIGN KEY (bruker) REFERENCES formlogin (bruker)
);



INSERT INTO studier(studieretning, grad, fakultet) VALUES ('It og Informasjonssystemer', 'Bachelor', 'Handelshøyskolen'), ('Dataingeniør', 'Bachelor','Ingeniørhøyskolen'),
('Regnskapsfører', 'Master', 'Handelshøyskolen');

INSERT INTO foreleser(foreleserid, fornavn, etternavn) VALUES (313, 'Ola', 'Nordmann'), (1337, 'Linus', 'Thorvaldsen'),
(666, 'Steve', 'Jobs'), (111, 'Bill', 'Gates');

INSERT INTO fag(fagkode, fagnavn, foreleserid, studieretning) VALUES ('DAT1000', 'Database', 313, 'It og Informasjonssystemer'), ('OBJ2100', 'Objective C', 666, 'Dataingeniør'), ('MAR1000', 'Markedsføringsledelse', 1337, 'Regnskapsfører'),
('WIN1100', 'Windows bootcamp', 111, 'It og Informasjonssystemer');

INSERT INTO student(studentid, studieretning) VALUES 
(0, 'Dataingeniør'), (1, 'Dataingeniør'), (2, 'Dataingeniør'), (3, 'Dataingeniør'), (4, 'Dataingeniør'), (5, 'Dataingeniør'), (6, 'Dataingeniør'), (7, 'Dataingeniør'), 
(8, 'Dataingeniør'), (9, 'Dataingeniør'), (10, 'Dataingeniør'), (11, 'Dataingeniør'), (12, 'Dataingeniør'), (13, 'Dataingeniør'), (14, 'Dataingeniør'), (15, 'Dataingeniør'), 
(16, 'Dataingeniør'), (17, 'Dataingeniør'), (18, 'Dataingeniør'), (19, 'Dataingeniør'), (20, 'It og Informasjonssystemer'), (21, 'It og Informasjonssystemer'), (22, 'It og Informasjonssystemer'), 
(23, 'It og Informasjonssystemer'), (24, 'It og Informasjonssystemer'), (25, 'It og Informasjonssystemer'), (26, 'It og Informasjonssystemer'), (27, 'It og Informasjonssystemer'), 
(28, 'It og Informasjonssystemer'), (29, 'It og Informasjonssystemer'), (30, 'It og Informasjonssystemer'), (31, 'It og Informasjonssystemer'), (32, 'It og Informasjonssystemer'), 
(33, 'It og Informasjonssystemer'), (34, 'It og Informasjonssystemer'), (35, 'It og Informasjonssystemer'), (36, 'It og Informasjonssystemer'), (37, 'It og Informasjonssystemer'), 
(38, 'It og Informasjonssystemer'), (39, 'It og Informasjonssystemer'), (40, 'Regnskapsfører'), (41, 'Regnskapsfører'), (42, 'Regnskapsfører'), (43, 'Regnskapsfører'), (44, 'Regnskapsfører'), 
(45, 'Regnskapsfører'), (46, 'Regnskapsfører'), (47, 'Regnskapsfører'), (48, 'Regnskapsfører'), (49, 'Regnskapsfører'), (50, 'Regnskapsfører'), (51, 'Regnskapsfører'), (52, 'Regnskapsfører'), 
(53, 'Regnskapsfører'), (54, 'Regnskapsfører'), (55, 'Regnskapsfører'), (56, 'Regnskapsfører'), (57, 'Regnskapsfører'), (58, 'Regnskapsfører'), (59, 'Regnskapsfører');

INSERT INTO vurderingsskjema(fagkode, spm1, spm2, spm3, spm4, spm5, spm6, spm7, spm8, spm9, spm10) VALUES 
('DAT1000', 'Syntes du pensum var for vanskelig?', 'Stemte pensum overens med emneplanen?','Stemte oppgavene overens med hva du har lært?','Var faget vanskelig?','spm5','spm6','spm7','spm8','spm9','spm10'), 
('OBJ2100','spm1', 'spm2','spm3','spm4','spm5','spm6','spm7','spm8','spm9','spm10'),
('MAR1000','spm1', 'spm2','spm3','spm4','spm5','spm6','spm7','spm8','spm9','spm10');

INSERT INTO vurderingshistorikk (skjemaid, studentid, fagkode, spm1, spm2, spm3, spm4, spm5, spm6, spm7, spm8, spm9, spm10) VALUES (2, 006, 'OBJ2100', 1, 4, 3, 4, 3, 5, 1, 2, 1, 4), (2, 005, 'OBJ2100', 3, 5, 1, 2, 4, 2, 3, 4, 5, 4);

INSERT INTO formlogin(bruker, passord, fornavn, etternavn,  brukertype) VALUES ('admin', 'admin', 'Elon', 'Musk', 1), ('bruker', 'bruker', 'Ronald', 'McDonald', 2);

INSERT INTO innloggingshistorikk(bruker, tidsstempel) VALUES
('admin', '2018-02-05 13:45:37');


DROP TABLE studier;
DROP TABLE foreleser;
DROP TABLE fag;
DROP TABLE student;
DROP TABLE vurderingsskjema;
DROP TABLE vurderingshistorikk;
DROP TABLE formlogin;
DROP TABLE innloggingshistorikk;
