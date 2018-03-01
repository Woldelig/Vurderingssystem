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
(1, 'Dataingeniør'), (2, 'Dataingeniør'), (3, 'Dataingeniør'), (4, 'Dataingeniør'), (5, 'Dataingeniør'), (6, 'Dataingeniør'), (7, 'Dataingeniør'), 
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

INSERT INTO vurderingshistorikk (skjemaid, studentid, fagkode, spm1, spm2, spm3, spm4, spm5, spm6, spm7, spm8, spm9, spm10) VALUES 
(2, 1, 'OBJ2100', 4, 2, 1, 2, 4, 5, 5, 0, 1, 3),
(2, 2, 'OBJ2100', 5, 0, 3, 2, 2, 2, 0, 2, 2, 5),
(2, 3, 'OBJ2100', 2, 1, 2, 4, 4, 5, 0, 0, 3, 3),
(2, 4, 'OBJ2100', 5, 5, 5, 3, 1, 5, 1, 5, 4, 3),
(2, 5, 'OBJ2100', 4, 2, 3, 1, 4, 1, 5, 3, 0, 4),
(2, 6, 'OBJ2100', 3, 5, 4, 1, 5, 2, 0, 2, 4, 4),
(2, 7, 'OBJ2100', 4, 5, 2, 4, 3, 5, 0, 5, 1, 2),
(2, 8, 'OBJ2100', 1, 0, 4, 4, 0, 5, 4, 0, 0, 3),
(2, 9, 'OBJ2100', 5, 2, 0, 5, 0, 5, 1, 4, 4, 4),
(2, 10, 'OBJ2100', 5, 5, 1, 5, 4, 4, 5, 4, 4, 5),
(2, 11, 'OBJ2100', 0, 5, 2, 3, 3, 2, 1, 0, 0, 5),
(2, 12, 'OBJ2100', 3, 5, 1, 0, 5, 2, 5, 3, 4, 4),
(2, 13, 'OBJ2100', 4, 1, 1, 2, 3, 2, 5, 4, 5, 2),
(2, 14, 'OBJ2100', 0, 0, 2, 1, 2, 0, 0, 2, 1, 3),
(2, 15, 'OBJ2100', 3, 0, 3, 4, 1, 0, 3, 0, 0, 2),
(2, 16, 'OBJ2100', 4, 1, 5, 0, 0, 5, 3, 5, 0, 1),
(2, 17, 'OBJ2100', 3, 3, 1, 4, 5, 3, 2, 0, 4, 5),
(2, 18, 'OBJ2100', 1, 3, 2, 0, 0, 3, 3, 3, 1, 2),
(2, 19, 'OBJ2100', 4, 4, 4, 2, 3, 4, 0, 2, 0, 3),
(1, 20, 'DAT1000', 1, 3, 4, 4, 0, 0, 2, 0, 1, 3), 
(1, 21, 'DAT1000', 3, 3, 2, 0, 2, 1, 5, 3, 2, 2), 
(1, 22, 'DAT1000', 5, 0, 2, 4, 2, 5, 3, 1, 2, 0), 
(1, 23, 'DAT1000', 1, 2, 2, 3, 1, 2, 1, 4, 5, 1), 
(1, 24, 'DAT1000', 3, 3, 2, 3, 4, 5, 5, 4, 0, 0), 
(1, 25, 'DAT1000', 0, 5, 1, 3, 0, 1, 1, 0, 1, 0), 
(1, 26, 'DAT1000', 2, 1, 4, 1, 1, 0, 1, 5, 4, 5), 
(1, 27, 'DAT1000', 0, 1, 4, 1, 5, 1, 3, 4, 5, 3), 
(1, 28, 'DAT1000', 0, 4, 0, 2, 5, 2, 0, 4, 3, 0), 
(1, 29, 'DAT1000', 1, 1, 2, 4, 4, 2, 5, 1, 1, 4), 
(1, 30, 'DAT1000', 4, 0, 0, 1, 0, 4, 0, 0, 4, 4), 
(1, 31, 'DAT1000', 3, 2, 0, 4, 0, 4, 0, 2, 1, 5), 
(1, 32, 'DAT1000', 5, 2, 1, 4, 4, 4, 5, 5, 2, 2), 
(1, 33, 'DAT1000', 1, 2, 3, 1, 5, 5, 4, 5, 1, 0), 
(1, 34, 'DAT1000', 1, 0, 0, 4, 2, 4, 1, 3, 4, 0), 
(1, 35, 'DAT1000', 2, 3, 5, 1, 4, 1, 5, 1, 2, 1), 
(1, 36, 'DAT1000', 5, 0, 3, 1, 3, 1, 5, 4, 5, 0), 
(1, 37, 'DAT1000', 5, 0, 0, 0, 4, 5, 2, 2, 2, 5), 
(1, 38, 'DAT1000', 2, 1, 1, 2, 0, 4, 2, 1, 3, 3), 
(1, 39, 'DAT1000', 0, 3, 2, 5, 1, 0, 2, 4, 1, 0), 
(3, 40, 'MAR1000', 4, 1, 2, 2, 3, 5, 0, 3, 3, 5), 
(3, 41, 'MAR1000', 0, 2, 5, 5, 1, 4, 2, 4, 3, 3), 
(3, 42, 'MAR1000', 4, 5, 1, 2, 1, 3, 5, 5, 5, 4), 
(3, 43, 'MAR1000', 3, 5, 2, 1, 0, 3, 4, 3, 2, 5), 
(3, 44, 'MAR1000', 3, 1, 4, 0, 1, 5, 5, 2, 4, 1), 
(3, 45, 'MAR1000', 2, 0, 4, 0, 1, 5, 0, 5, 0, 5), 
(3, 46, 'MAR1000', 0, 0, 4, 5, 2, 0, 5, 4, 5, 3), 
(3, 47, 'MAR1000', 5, 4, 2, 3, 0, 3, 0, 0, 0, 2), 
(3, 48, 'MAR1000', 4, 2, 1, 3, 1, 2, 0, 2, 0, 0), 
(3, 49, 'MAR1000', 2, 4, 2, 2, 5, 2, 3, 5, 3, 0), 
(3, 50, 'MAR1000', 5, 1, 3, 0, 1, 3, 3, 0, 0, 4), 
(3, 51, 'MAR1000', 4, 5, 5, 4, 1, 3, 5, 0, 3, 0), 
(3, 52, 'MAR1000', 5, 3, 3, 4, 0, 0, 2, 5, 4, 3), 
(3, 53, 'MAR1000', 5, 1, 3, 5, 2, 2, 4, 1, 2, 4), 
(3, 54, 'MAR1000', 5, 0, 1, 1, 2, 3, 5, 4, 1, 1), 
(3, 55, 'MAR1000', 2, 2, 2, 3, 0, 1, 3, 5, 5, 1), 
(3, 56, 'MAR1000', 1, 3, 2, 2, 4, 3, 2, 5, 2, 4), 
(3, 57, 'MAR1000', 5, 4, 4, 4, 0, 5, 1, 2, 2, 3), 
(3, 58, 'MAR1000', 1, 3, 4, 2, 0, 3, 5, 0, 4, 0), 
(3, 59, 'MAR1000', 5, 5, 1, 0, 3, 1, 4, 5, 3, 5);


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
