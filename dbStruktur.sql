DROP TABLE studier;
DROP TABLE foreleser;
DROP TABLE fag;
DROP TABLE student;
DROP TABLE vurderingsskjema;
DROP TABLE vurderingshistorikk;
DROP TABLE formlogin;
DROP TABLE innloggingshistorikk;

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
    FOREIGN KEY (studieretning) REFERENCES studier(studieretning),
    FOREIGN KEY (forkurs) REFERENCES fag(fagkode)
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
    passord VARCHAR(48),
    fornavn VARCHAR(64),
    etternavn VARCHAR(64),
    brukertype INT(1)
);

CREATE TABLE innloggingshistorikk(
  bruker VARCHAR(64) PRIMARY KEY,
  tidsstempel DATETIME,
  FOREIGN KEY (bruker) REFERENCES formlogin (bruker)
);



INSERT INTO studier(studieretning, grad, fakultet) VALUES
('It og Informasjonssystemer', 'Bachelor', 'Handelshøyskolen'),
('Dataingeniør', 'Bachelor','Ingeniørhøyskolen'),
('Regnskapsfører', 'Master', 'Handelshøyskolen');

INSERT INTO foreleser(foreleserid, fornavn, etternavn) VALUES
(313, 'Ola', 'Nordmann'),
(1337, 'Linus', 'Thorvaldsen'),
(666, 'Steve', 'Jobs'),
(111, 'Bill', 'Gates');

INSERT INTO fag(fagkode, fagnavn, foreleserid, studieretning, forkurs) VALUES
('DAT1000', 'Database', 313, 'It og Informasjonssystemer', ''),
('OBJ2000', 'SWIFT', 666, 'Dataingeniør', ''),
('OBJ2100', 'Objective C', 666, 'Dataingeniør', 'OBJ200'),
('MAR1000', 'Markedsføringsledelse', 1337, 'Regnskapsfører', ''),
('WIN1100', 'Windows bootcamp', 111, 'It og Informasjonssystemer','');

INSERT INTO student(studentid, studieretning) VALUES
(1, 'Dataingeniør'), (2, 'Dataingeniør'), (3, 'Dataingeniør'), (4, 'Dataingeniør'),
(5, 'Dataingeniør'), (6, 'Dataingeniør'), (7, 'Dataingeniør'), (8, 'Dataingeniør'),
(9, 'Dataingeniør'), (10, 'Dataingeniør'), (11, 'Dataingeniør'), (12, 'Dataingeniør'),
(13, 'Dataingeniør'), (14, 'Dataingeniør'), (15, 'Dataingeniør'), (16, 'Dataingeniør'),
(17, 'Dataingeniør'), (18, 'Dataingeniør'), (19, 'Dataingeniør'), (20, 'It og Informasjonssystemer'),
(21, 'It og Informasjonssystemer'), (22, 'It og Informasjonssystemer'), (23, 'It og Informasjonssystemer'),
(24, 'It og Informasjonssystemer'), (25, 'It og Informasjonssystemer'), (26, 'It og Informasjonssystemer'),
(27, 'It og Informasjonssystemer'), (28, 'It og Informasjonssystemer'), (29, 'It og Informasjonssystemer'),
(30, 'It og Informasjonssystemer'), (31, 'It og Informasjonssystemer'), (32, 'It og Informasjonssystemer'),
(33, 'It og Informasjonssystemer'), (34, 'It og Informasjonssystemer'), (35, 'It og Informasjonssystemer'),
(36, 'It og Informasjonssystemer'), (37, 'It og Informasjonssystemer'), (38, 'It og Informasjonssystemer'),
(39, 'It og Informasjonssystemer'), (40, 'Regnskapsfører'), (41, 'Regnskapsfører'), (42, 'Regnskapsfører'),
(43, 'Regnskapsfører'), (44, 'Regnskapsfører'), (45, 'Regnskapsfører'), (46, 'Regnskapsfører'),
(47, 'Regnskapsfører'), (48, 'Regnskapsfører'), (49, 'Regnskapsfører'), (50, 'Regnskapsfører'),
(51, 'Regnskapsfører'), (52, 'Regnskapsfører'), (53, 'Regnskapsfører'), (54, 'Regnskapsfører'),
(55, 'Regnskapsfører'), (56, 'Regnskapsfører'), (57, 'Regnskapsfører'),(58, 'Regnskapsfører'),
(59, 'Regnskapsfører'),(60, 'Dataingeniør'), (61, 'Dataingeniør'), (62, 'Dataingeniør'),
(63, 'Dataingeniør'), (64, 'Dataingeniør'), (65, 'Dataingeniør'), (66, 'Dataingeniør'),
(67, 'Dataingeniør'), (68, 'Dataingeniør'), (69, 'Dataingeniør'), (70, 'Dataingeniør'),
(71, 'Dataingeniør'), (72, 'Dataingeniør'), (73, 'Dataingeniør'), (74, 'Dataingeniør'),
(75, 'Dataingeniør'), (76, 'Dataingeniør'), (77, 'Dataingeniør'), (78, 'Dataingeniør'),
(79, 'Dataingeniør'), (80, 'Dataingeniør'), (81, 'Dataingeniør'), (82, 'Dataingeniør'),
(83, 'Dataingeniør'), (84, 'Dataingeniør'), (85, 'Dataingeniør'), (86, 'Dataingeniør'),
(87, 'Dataingeniør'), (88, 'Dataingeniør'), (89, 'Dataingeniør'), (90, 'Dataingeniør'),
(91, 'Dataingeniør'), (92, 'Dataingeniør'), (93, 'Dataingeniør'), (94, 'Dataingeniør'),
(95, 'Dataingeniør'), (96, 'Dataingeniør'), (97, 'Dataingeniør'), (98, 'Dataingeniør'),
(99, 'Dataingeniør');


INSERT INTO vurderingsskjema (skjemaid, fagkode, spm1, spm2, spm3, spm4, spm5, spm6, spm7, spm8, spm9, spm10) VALUES ('0', 'standard', 'Syntes du pensum var for vanskelig?', 'Hvordan var kvaliteten på forelesningen?', 'Var faget vanskelig?', 'Var foreleseren flink til å formidle pensum?', 'Syntes du faget var relevant for din studielinje?', NULL, NULL, NULL, NULL, NULL);
INSERT INTO vurderingsskjema(fagkode, spm1, spm2, spm3, spm4, spm5, spm6, spm7, spm8, spm9, spm10) VALUES
('OBJ2100','Syntes du pensum var for vanskelig?', 'Hvordan var kvaliteten på forelesningen?','Var faget vanskelig?','Var foreleseren flink til å formidle pensum?','Syntes du faget var relevant for din studielinje?','spm6','spm7','spm8','spm9','spm10'),
('DAT1000', 'Syntes du pensum var for vanskelig?', 'Hvordan var kvaliteten på forelesningen?','Var faget vanskelig?','Var foreleseren flink til å formidle pensum?','Syntes du faget var relevant for din studielinje?','spm6','spm7','spm8','spm9','spm10'),
('MAR1000','Syntes du pensum var for vanskelig?', 'Hvordan var kvaliteten på forelesningen?','Var faget vanskelig?','Var foreleseren flink til å formidle pensum?','Syntes du faget var relevant for din studielinje?','spm6','spm7','spm8','spm9','spm10');

INSERT INTO vurderingshistorikk (skjemaid, studentid, fagkode, spm1, spm2, spm3, spm4, spm5, spm6, spm7, spm8, spm9, spm10) VALUES
(2, 1, 'OBJ2100', 3, 3, 2, 3, 3, 1, 1, 2, 4, 5),
(2, 2, 'OBJ2100', 3, 2, 2, 4, 5, 2, 3, 2, 1, 1),
(2, 3, 'OBJ2100', 4, 2, 1, 2, 3, 5, 2, 2, 2, 3),
(2, 4, 'OBJ2100', 1, 4, 2, 2, 1, 3, 3, 4, 2, 2),
(2, 5, 'OBJ2100', 2, 1, 4, 1, 1, 5, 4, 3, 5, 3),
(2, 6, 'OBJ2100', 1, 5, 3, 1, 3, 1, 2, 5, 5, 3),
(2, 7, 'OBJ2100', 4, 5, 1, 1, 5, 4, 5, 5, 4, 3),
(2, 8, 'OBJ2100', 5, 5, 5, 5, 5, 3, 4, 1, 1, 3),
(2, 9, 'OBJ2100', 2, 5, 2, 5, 2, 1, 1, 1, 5, 5),
(2, 10, 'OBJ2100', 2, 3, 4, 4, 3, 2, 1, 4, 2, 2),
(2, 11, 'OBJ2100', 5, 4, 4, 3, 3, 2, 5, 4, 1, 5),
(2, 12, 'OBJ2100', 3, 2, 4, 2, 2, 5, 3, 1, 4, 4),
(2, 13, 'OBJ2100', 4, 5, 1, 4, 2, 2, 1, 2, 3, 3),
(2, 14, 'OBJ2100', 3, 5, 4, 5, 4, 4, 1, 5, 2, 1),
(2, 15, 'OBJ2100', 1, 3, 1, 1, 3, 5, 5, 2, 3, 3),
(2, 16, 'OBJ2100', 5, 5, 5, 3, 4, 1, 4, 1, 2, 1),
(2, 17, 'OBJ2100', 1, 4, 1, 4, 3, 3, 3, 5, 4, 3),
(2, 18, 'OBJ2100', 4, 4, 5, 4, 4, 2, 4, 5, 2, 2),
(2, 19, 'OBJ2100', 3, 5, 4, 5, 4, 4, 1, 2, 1, 3),
(3, 20, 'DAT1000', 5, 1, 3, 1, 5, 2, 2, 3, 4, 5),
(3, 21, 'DAT1000', 3, 5, 3, 5, 5, 2, 5, 1, 5, 3),
(3, 22, 'DAT1000', 2, 4, 5, 1, 4, 2, 5, 2, 5, 4),
(3, 23, 'DAT1000', 3, 2, 5, 2, 4, 4, 1, 5, 5, 2),
(3, 24, 'DAT1000', 1, 2, 2, 2, 5, 4, 2, 5, 1, 3),
(3, 25, 'DAT1000', 4, 5, 2, 4, 1, 2, 1, 3, 3, 3),
(3, 26, 'DAT1000', 2, 1, 3, 5, 3, 1, 1, 1, 2, 1),
(3, 27, 'DAT1000', 1, 1, 2, 4, 3, 1, 2, 3, 1, 5),
(3, 28, 'DAT1000', 1, 1, 1, 3, 1, 3, 5, 1, 2, 2),
(3, 29, 'DAT1000', 3, 4, 2, 3, 5, 1, 5, 3, 5, 4),
(3, 30, 'DAT1000', 4, 1, 3, 1, 3, 4, 4, 4, 2, 1),
(3, 31, 'DAT1000', 5, 4, 2, 3, 2, 2, 5, 5, 5, 1),
(3, 32, 'DAT1000', 1, 5, 5, 5, 3, 2, 4, 4, 5, 3),
(3, 33, 'DAT1000', 1, 5, 4, 3, 2, 1, 3, 1, 1, 3),
(3, 34, 'DAT1000', 4, 2, 5, 2, 3, 5, 3, 5, 1, 4),
(3, 35, 'DAT1000', 1, 1, 4, 5, 3, 4, 2, 4, 3, 1),
(3, 36, 'DAT1000', 5, 5, 5, 5, 5, 1, 1, 5, 1, 2),
(3, 37, 'DAT1000', 4, 4, 4, 3, 2, 5, 1, 3, 3, 4),
(3, 38, 'DAT1000', 4, 5, 4, 1, 2, 1, 2, 5, 5, 4),
(3, 39, 'DAT1000', 5, 5, 4, 5, 3, 4, 2, 5, 2, 2),
(4, 40, 'MAR1000', 5, 4, 4, 4, 5, 3, 2, 1, 3, 4),
(4, 41, 'MAR1000', 3, 4, 2, 5, 2, 5, 2, 4, 4, 5),
(4, 42, 'MAR1000', 5, 2, 5, 3, 3, 4, 1, 4, 5, 3),
(4, 43, 'MAR1000', 3, 2, 2, 1, 5, 1, 1, 5, 2, 4),
(4, 44, 'MAR1000', 4, 1, 2, 2, 1, 1, 4, 4, 4, 3),
(4, 45, 'MAR1000', 3, 4, 2, 3, 3, 3, 4, 1, 2, 1),
(4, 46, 'MAR1000', 2, 3, 2, 1, 1, 2, 2, 1, 1, 2),
(4, 47, 'MAR1000', 5, 2, 3, 5, 1, 4, 5, 4, 3, 2),
(4, 48, 'MAR1000', 1, 2, 1, 2, 5, 5, 5, 4, 3, 2),
(4, 49, 'MAR1000', 3, 1, 4, 1, 3, 2, 4, 1, 1, 4),
(4, 50, 'MAR1000', 4, 3, 4, 3, 4, 1, 2, 3, 3, 5),
(4, 51, 'MAR1000', 3, 5, 4, 5, 1, 1, 2, 1, 1, 1),
(4, 52, 'MAR1000', 3, 4, 4, 4, 4, 4, 4, 2, 3, 4),
(4, 53, 'MAR1000', 1, 5, 4, 5, 3, 3, 3, 4, 3, 5),
(4, 54, 'MAR1000', 4, 3, 2, 4, 4, 3, 3, 4, 5, 2),
(4, 55, 'MAR1000', 5, 4, 1, 1, 2, 1, 5, 1, 4, 1),
(4, 56, 'MAR1000', 2, 5, 5, 4, 5, 4, 2, 4, 2, 4),
(4, 57, 'MAR1000', 3, 4, 3, 1, 3, 5, 2, 5, 1, 2),
(4, 58, 'MAR1000', 2, 5, 3, 1, 4, 2, 4, 3, 4, 3),
(4, 59, 'MAR1000', 3, 3, 1, 3, 3, 5, 3, 4, 5, 5);


INSERT INTO formlogin(bruker, passord, fornavn, etternavn,  brukertype) VALUES ('admin', 'admin', 'Elon', 'Musk', 1), ('bruker', 'bruker', 'Ronald', 'McDonald', 2);

INSERT INTO innloggingshistorikk(bruker, tidsstempel) VALUES
('admin', '2018-02-05 13:45:37');
