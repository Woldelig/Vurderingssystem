
DROP PROCEDURE IF EXISTS hent_spm1_verdier;
DELIMITER $$
CREATE PROCEDURE hent_spm1_verdier
(
    IN in_fagkode VARCHAR(10),
    OUT out_verdi1 SMALLINT,
    OUT out_verdi2 SMALLINT,
    OUT out_verdi3 SMALLINT,
    OUT out_verdi4 SMALLINT,
    OUT out_verdi5 SMALLINT
)
BEGIN
    SELECT COUNT(spm1) INTO out_verdi1 FROM vurderingshistorikk WHERE spm1 = 1 AND fagkode = in_fagkode;
    SELECT COUNT(spm1) INTO out_verdi2 FROM vurderingshistorikk WHERE spm1 = 2 AND fagkode = in_fagkode;
    SELECT COUNT(spm1) INTO out_verdi3 FROM vurderingshistorikk WHERE spm1 = 3 AND fagkode = in_fagkode;
    SELECT COUNT(spm1) INTO out_verdi4 FROM vurderingshistorikk WHERE spm1 = 4 AND fagkode = in_fagkode;
    SELECT COUNT(spm1) INTO out_verdi5 FROM vurderingshistorikk WHERE spm1 = 5 AND fagkode = in_fagkode;

END$$
DELIMITER ;


call hent_spm1_verdier("OBJ2100",@out_value1,@out_value2,@out_value3,@out_value4,@out_value5);
SELECT @out_value1,@out_value2,@out_value3,@out_value4,@out_value5



DROP PROCEDURE IF EXISTS hent_spm2_verdier;
DELIMITER $$
CREATE PROCEDURE hent_spm2_verdier
(
    IN in_fagkode VARCHAR(8),
    OUT out_verdi1 INT,
    OUT out_verdi2 INT,
    OUT out_verdi3 INT,
    OUT out_verdi4 INT,
    OUT out_verdi5 INT
)
BEGIN
    SELECT COUNT(spm2) INTO out_verdi1 FROM vurderingshistorikk WHERE spm2 = 1 AND fagkode = in_fagkode;
    SELECT COUNT(spm2) INTO out_verdi2 FROM vurderingshistorikk WHERE spm2 = 2 AND fagkode = in_fagkode;
    SELECT COUNT(spm2) INTO out_verdi3 FROM vurderingshistorikk WHERE spm2 = 3 AND fagkode = in_fagkode;
    SELECT COUNT(spm2) INTO out_verdi4 FROM vurderingshistorikk WHERE spm2 = 4 AND fagkode = in_fagkode;
    SELECT COUNT(spm2) INTO out_verdi5 FROM vurderingshistorikk WHERE spm2 = 5 AND fagkode = in_fagkode;

END$$
DELIMITER ;


DROP PROCEDURE IF EXISTS hent_spm3_verdier;
DELIMITER $$
CREATE PROCEDURE hent_spm3_verdier
(
    IN in_fagkode VARCHAR(8),
    OUT out_verdi1 INT,
    OUT out_verdi2 INT,
    OUT out_verdi3 INT,
    OUT out_verdi4 INT,
    OUT out_verdi5 INT
)
BEGIN
    SELECT COUNT(spm3) INTO out_verdi1 FROM vurderingshistorikk WHERE spm3 = 1 AND fagkode = in_fagkode;
    SELECT COUNT(spm3) INTO out_verdi2 FROM vurderingshistorikk WHERE spm3 = 2 AND fagkode = in_fagkode;
    SELECT COUNT(spm3) INTO out_verdi3 FROM vurderingshistorikk WHERE spm3 = 3 AND fagkode = in_fagkode;
    SELECT COUNT(spm3) INTO out_verdi4 FROM vurderingshistorikk WHERE spm3 = 4 AND fagkode = in_fagkode;
    SELECT COUNT(spm3) INTO out_verdi5 FROM vurderingshistorikk WHERE spm3 = 5 AND fagkode = in_fagkode;

END$$
DELIMITER ;


DROP PROCEDURE IF EXISTS hent_spm4_verdier;
DELIMITER $$
CREATE PROCEDURE hent_spm4_verdier
(
    IN in_fagkode VARCHAR(8),
    OUT out_verdi1 INT,
    OUT out_verdi2 INT,
    OUT out_verdi3 INT,
    OUT out_verdi4 INT,
    OUT out_verdi5 INT
)
BEGIN
    SELECT COUNT(spm4) INTO out_verdi1 FROM vurderingshistorikk WHERE spm4 = 1 AND fagkode = in_fagkode;
    SELECT COUNT(spm4) INTO out_verdi2 FROM vurderingshistorikk WHERE spm4 = 2 AND fagkode = in_fagkode;
    SELECT COUNT(spm4) INTO out_verdi3 FROM vurderingshistorikk WHERE spm4 = 3 AND fagkode = in_fagkode;
    SELECT COUNT(spm4) INTO out_verdi4 FROM vurderingshistorikk WHERE spm4 = 4 AND fagkode = in_fagkode;
    SELECT COUNT(spm4) INTO out_verdi5 FROM vurderingshistorikk WHERE spm4 = 5 AND fagkode = in_fagkode;

END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS hent_spm5_verdier;
DELIMITER $$
CREATE PROCEDURE hent_spm5_verdier
(
    IN in_fagkode VARCHAR(8),
    OUT out_verdi1 INT,
    OUT out_verdi2 INT,
    OUT out_verdi3 INT,
    OUT out_verdi4 INT,
    OUT out_verdi5 INT
)
BEGIN
    SELECT COUNT(spm5) INTO out_verdi1 FROM vurderingshistorikk WHERE spm5 = 1 AND fagkode = in_fagkode;
    SELECT COUNT(spm5) INTO out_verdi2 FROM vurderingshistorikk WHERE spm5 = 2 AND fagkode = in_fagkode;
    SELECT COUNT(spm5) INTO out_verdi3 FROM vurderingshistorikk WHERE spm5 = 3 AND fagkode = in_fagkode;
    SELECT COUNT(spm5) INTO out_verdi4 FROM vurderingshistorikk WHERE spm5 = 4 AND fagkode = in_fagkode;
    SELECT COUNT(spm5) INTO out_verdi5 FROM vurderingshistorikk WHERE spm5 = 5 AND fagkode = in_fagkode;

END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS hent_spm6_verdier;
DELIMITER $$
CREATE PROCEDURE hent_spm6_verdier
(
    IN in_fagkode VARCHAR(8),
    OUT out_verdi1 INT,
    OUT out_verdi2 INT,
    OUT out_verdi3 INT,
    OUT out_verdi4 INT,
    OUT out_verdi5 INT
)
BEGIN
    SELECT COUNT(spm6) INTO out_verdi1 FROM vurderingshistorikk WHERE spm6 = 1 AND fagkode = in_fagkode;
    SELECT COUNT(spm6) INTO out_verdi2 FROM vurderingshistorikk WHERE spm6 = 2 AND fagkode = in_fagkode;
    SELECT COUNT(spm6) INTO out_verdi3 FROM vurderingshistorikk WHERE spm6 = 3 AND fagkode = in_fagkode;
    SELECT COUNT(spm6) INTO out_verdi4 FROM vurderingshistorikk WHERE spm6 = 4 AND fagkode = in_fagkode;
    SELECT COUNT(spm6) INTO out_verdi5 FROM vurderingshistorikk WHERE spm6 = 5 AND fagkode = in_fagkode;

END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS hent_spm7_verdier;
DELIMITER $$
CREATE PROCEDURE hent_spm7_verdier
(
    IN in_fagkode VARCHAR(8),
    OUT out_verdi1 INT,
    OUT out_verdi2 INT,
    OUT out_verdi3 INT,
    OUT out_verdi4 INT,
    OUT out_verdi5 INT
)
BEGIN
    SELECT COUNT(spm7) INTO out_verdi1 FROM vurderingshistorikk WHERE spm7 = 1 AND fagkode = in_fagkode;
    SELECT COUNT(spm7) INTO out_verdi2 FROM vurderingshistorikk WHERE spm7 = 2 AND fagkode = in_fagkode;
    SELECT COUNT(spm7) INTO out_verdi3 FROM vurderingshistorikk WHERE spm7 = 3 AND fagkode = in_fagkode;
    SELECT COUNT(spm7) INTO out_verdi4 FROM vurderingshistorikk WHERE spm7 = 4 AND fagkode = in_fagkode;
    SELECT COUNT(spm7) INTO out_verdi5 FROM vurderingshistorikk WHERE spm7 = 5 AND fagkode = in_fagkode;

END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS hent_spm8_verdier;
DELIMITER $$
CREATE PROCEDURE hent_spm8_verdier
(
    IN in_fagkode VARCHAR(8),
    OUT out_verdi1 INT,
    OUT out_verdi2 INT,
    OUT out_verdi3 INT,
    OUT out_verdi4 INT,
    OUT out_verdi5 INT
)
BEGIN
    SELECT COUNT(spm8) INTO out_verdi1 FROM vurderingshistorikk WHERE spm8 = 1 AND fagkode = in_fagkode;
    SELECT COUNT(spm8) INTO out_verdi2 FROM vurderingshistorikk WHERE spm8 = 2 AND fagkode = in_fagkode;
    SELECT COUNT(spm8) INTO out_verdi3 FROM vurderingshistorikk WHERE spm8 = 3 AND fagkode = in_fagkode;
    SELECT COUNT(spm8) INTO out_verdi4 FROM vurderingshistorikk WHERE spm8 = 4 AND fagkode = in_fagkode;
    SELECT COUNT(spm8) INTO out_verdi5 FROM vurderingshistorikk WHERE spm8 = 5 AND fagkode = in_fagkode;

END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS hent_spm9_verdier;
DELIMITER $$
CREATE PROCEDURE hent_spm9_verdier
(
    IN in_fagkode VARCHAR(8),
    OUT out_verdi1 INT,
    OUT out_verdi2 INT,
    OUT out_verdi3 INT,
    OUT out_verdi4 INT,
    OUT out_verdi5 INT
)
BEGIN
    SELECT COUNT(spm9) INTO out_verdi1 FROM vurderingshistorikk WHERE spm9 = 1 AND fagkode = in_fagkode;
    SELECT COUNT(spm9) INTO out_verdi2 FROM vurderingshistorikk WHERE spm9 = 2 AND fagkode = in_fagkode;
    SELECT COUNT(spm9) INTO out_verdi3 FROM vurderingshistorikk WHERE spm9 = 3 AND fagkode = in_fagkode;
    SELECT COUNT(spm9) INTO out_verdi4 FROM vurderingshistorikk WHERE spm9 = 4 AND fagkode = in_fagkode;
    SELECT COUNT(spm9) INTO out_verdi5 FROM vurderingshistorikk WHERE spm9 = 5 AND fagkode = in_fagkode;

END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS hent_spm10_verdier;
DELIMITER $$
CREATE PROCEDURE hent_spm10_verdier
(
    IN in_fagkode VARCHAR(8),
    OUT out_verdi1 INT,
    OUT out_verdi2 INT,
    OUT out_verdi3 INT,
    OUT out_verdi4 INT,
    OUT out_verdi5 INT
)
BEGIN
    SELECT COUNT(spm10) INTO out_verdi1 FROM vurderingshistorikk WHERE spm10 = 1 AND fagkode = in_fagkode;
    SELECT COUNT(spm10) INTO out_verdi2 FROM vurderingshistorikk WHERE spm10 = 2 AND fagkode = in_fagkode;
    SELECT COUNT(spm10) INTO out_verdi3 FROM vurderingshistorikk WHERE spm10 = 3 AND fagkode = in_fagkode;
    SELECT COUNT(spm10) INTO out_verdi4 FROM vurderingshistorikk WHERE spm10 = 4 AND fagkode = in_fagkode;
    SELECT COUNT(spm10) INTO out_verdi5 FROM vurderingshistorikk WHERE spm10 = 5 AND fagkode = in_fagkode;

END$$
DELIMITER ;