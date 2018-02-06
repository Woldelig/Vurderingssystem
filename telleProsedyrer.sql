
DROP PROCEDURE IF EXISTS hent_spm1_verdier;
DELIMITER $$
CREATE PROCEDURE hent_spm1_verdier
(
    OUT out_verdi1 INT,
    OUT out_verdi2 INT,
    OUT out_verdi3 INT,
    OUT out_verdi4 INT,
    OUT out_verdi5 INT
)
BEGIN
    SELECT COUNT(spm1) INTO out_verdi1 FROM vurderingshistorikk WHERE spm1 = 1;
    SELECT COUNT(spm1) INTO out_verdi2 FROM vurderingshistorikk WHERE spm1 = 2;
    SELECT COUNT(spm1) INTO out_verdi3 FROM vurderingshistorikk WHERE spm1 = 3;
    SELECT COUNT(spm1) INTO out_verdi4 FROM vurderingshistorikk WHERE spm1 = 4;
    SELECT COUNT(spm1) INTO out_verdi5 FROM vurderingshistorikk WHERE spm1 = 5;

END$$
DELIMITER ;


call hent_spm1_verdier(@out_value1,@out_value2,@out_value3,@out_value4,@out_value5);
SELECT @out_value1,@out_value2,@out_value3,@out_value4,@out_value5



DROP PROCEDURE IF EXISTS hent_spm2_verdier;
DELIMITER $$
CREATE PROCEDURE hent_spm2_verdier
(
    OUT out_verdi1 INT,
    OUT out_verdi2 INT,
    OUT out_verdi3 INT,
    OUT out_verdi4 INT,
    OUT out_verdi5 INT
)
BEGIN
    SELECT COUNT(spm2) INTO out_verdi1 FROM vurderingshistorikk WHERE spm2 = 1;
    SELECT COUNT(spm2) INTO out_verdi2 FROM vurderingshistorikk WHERE spm2 = 2;
    SELECT COUNT(spm2) INTO out_verdi3 FROM vurderingshistorikk WHERE spm2 = 3;
    SELECT COUNT(spm2) INTO out_verdi4 FROM vurderingshistorikk WHERE spm2 = 4;
    SELECT COUNT(spm2) INTO out_verdi5 FROM vurderingshistorikk WHERE spm2 = 5;

END$$
DELIMITER ;


DROP PROCEDURE IF EXISTS hent_spm3_verdier;
DELIMITER $$
CREATE PROCEDURE hent_spm3_verdier
(
    OUT out_verdi1 INT,
    OUT out_verdi2 INT,
    OUT out_verdi3 INT,
    OUT out_verdi4 INT,
    OUT out_verdi5 INT
)
BEGIN
    SELECT COUNT(spm3) INTO out_verdi1 FROM vurderingshistorikk WHERE spm3 = 1;
    SELECT COUNT(spm3) INTO out_verdi2 FROM vurderingshistorikk WHERE spm3 = 2;
    SELECT COUNT(spm3) INTO out_verdi3 FROM vurderingshistorikk WHERE spm3 = 3;
    SELECT COUNT(spm3) INTO out_verdi4 FROM vurderingshistorikk WHERE spm3 = 4;
    SELECT COUNT(spm3) INTO out_verdi5 FROM vurderingshistorikk WHERE spm3 = 5;

END$$
DELIMITER ;


DROP PROCEDURE IF EXISTS hent_spm4_verdier;
DELIMITER $$
CREATE PROCEDURE hent_spm4_verdier
(
    OUT out_verdi1 INT,
    OUT out_verdi2 INT,
    OUT out_verdi3 INT,
    OUT out_verdi4 INT,
    OUT out_verdi5 INT
)
BEGIN
    SELECT COUNT(spm4) INTO out_verdi1 FROM vurderingshistorikk WHERE spm4 = 1;
    SELECT COUNT(spm4) INTO out_verdi2 FROM vurderingshistorikk WHERE spm4 = 2;
    SELECT COUNT(spm4) INTO out_verdi3 FROM vurderingshistorikk WHERE spm4 = 3;
    SELECT COUNT(spm4) INTO out_verdi4 FROM vurderingshistorikk WHERE spm4 = 4;
    SELECT COUNT(spm4) INTO out_verdi5 FROM vurderingshistorikk WHERE spm4 = 5;

END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS hent_spm5_verdier;
DELIMITER $$
CREATE PROCEDURE hent_spm5_verdier
(
    OUT out_verdi1 INT,
    OUT out_verdi2 INT,
    OUT out_verdi3 INT,
    OUT out_verdi4 INT,
    OUT out_verdi5 INT
)
BEGIN
    SELECT COUNT(spm5) INTO out_verdi1 FROM vurderingshistorikk WHERE spm5 = 1;
    SELECT COUNT(spm5) INTO out_verdi2 FROM vurderingshistorikk WHERE spm5 = 2;
    SELECT COUNT(spm5) INTO out_verdi3 FROM vurderingshistorikk WHERE spm5 = 3;
    SELECT COUNT(spm5) INTO out_verdi4 FROM vurderingshistorikk WHERE spm5 = 4;
    SELECT COUNT(spm5) INTO out_verdi5 FROM vurderingshistorikk WHERE spm5 = 5;

END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS hent_spm6_verdier;
DELIMITER $$
CREATE PROCEDURE hent_spm6_verdier
(
    OUT out_verdi1 INT,
    OUT out_verdi2 INT,
    OUT out_verdi3 INT,
    OUT out_verdi4 INT,
    OUT out_verdi5 INT
)
BEGIN
    SELECT COUNT(spm6) INTO out_verdi1 FROM vurderingshistorikk WHERE spm6 = 1;
    SELECT COUNT(spm6) INTO out_verdi2 FROM vurderingshistorikk WHERE spm6 = 2;
    SELECT COUNT(spm6) INTO out_verdi3 FROM vurderingshistorikk WHERE spm6 = 3;
    SELECT COUNT(spm6) INTO out_verdi4 FROM vurderingshistorikk WHERE spm6 = 4;
    SELECT COUNT(spm6) INTO out_verdi5 FROM vurderingshistorikk WHERE spm6 = 5;

END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS hent_spm7_verdier;
DELIMITER $$
CREATE PROCEDURE hent_spm7_verdier
(
    OUT out_verdi1 INT,
    OUT out_verdi2 INT,
    OUT out_verdi3 INT,
    OUT out_verdi4 INT,
    OUT out_verdi5 INT
)
BEGIN
    SELECT COUNT(spm7) INTO out_verdi1 FROM vurderingshistorikk WHERE spm7 = 1;
    SELECT COUNT(spm7) INTO out_verdi2 FROM vurderingshistorikk WHERE spm7 = 2;
    SELECT COUNT(spm7) INTO out_verdi3 FROM vurderingshistorikk WHERE spm7 = 3;
    SELECT COUNT(spm7) INTO out_verdi4 FROM vurderingshistorikk WHERE spm7 = 4;
    SELECT COUNT(spm7) INTO out_verdi5 FROM vurderingshistorikk WHERE spm7 = 5;

END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS hent_spm8_verdier;
DELIMITER $$
CREATE PROCEDURE hent_spm8_verdier
(
    OUT out_verdi1 INT,
    OUT out_verdi2 INT,
    OUT out_verdi3 INT,
    OUT out_verdi4 INT,
    OUT out_verdi5 INT
)
BEGIN
    SELECT COUNT(spm8) INTO out_verdi1 FROM vurderingshistorikk WHERE spm8 = 1;
    SELECT COUNT(spm8) INTO out_verdi2 FROM vurderingshistorikk WHERE spm8 = 2;
    SELECT COUNT(spm8) INTO out_verdi3 FROM vurderingshistorikk WHERE spm8 = 3;
    SELECT COUNT(spm8) INTO out_verdi4 FROM vurderingshistorikk WHERE spm8 = 4;
    SELECT COUNT(spm8) INTO out_verdi5 FROM vurderingshistorikk WHERE spm8 = 5;

END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS hent_spm9_verdier;
DELIMITER $$
CREATE PROCEDURE hent_spm9_verdier
(
    OUT out_verdi1 INT,
    OUT out_verdi2 INT,
    OUT out_verdi3 INT,
    OUT out_verdi4 INT,
    OUT out_verdi5 INT
)
BEGIN
    SELECT COUNT(spm9) INTO out_verdi1 FROM vurderingshistorikk WHERE spm9 = 1;
    SELECT COUNT(spm9) INTO out_verdi2 FROM vurderingshistorikk WHERE spm9 = 2;
    SELECT COUNT(spm9) INTO out_verdi3 FROM vurderingshistorikk WHERE spm9 = 3;
    SELECT COUNT(spm9) INTO out_verdi4 FROM vurderingshistorikk WHERE spm9 = 4;
    SELECT COUNT(spm9) INTO out_verdi5 FROM vurderingshistorikk WHERE spm9 = 5;

END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS hent_spm10_verdier;
DELIMITER $$
CREATE PROCEDURE hent_spm10_verdier
(
    OUT out_verdi1 INT,
    OUT out_verdi2 INT,
    OUT out_verdi3 INT,
    OUT out_verdi4 INT,
    OUT out_verdi5 INT
)
BEGIN
    SELECT COUNT(spm10) INTO out_verdi1 FROM vurderingshistorikk WHERE spm10 = 1;
    SELECT COUNT(spm10) INTO out_verdi2 FROM vurderingshistorikk WHERE spm10 = 2;
    SELECT COUNT(spm10) INTO out_verdi3 FROM vurderingshistorikk WHERE spm10 = 3;
    SELECT COUNT(spm10) INTO out_verdi4 FROM vurderingshistorikk WHERE spm10 = 4;
    SELECT COUNT(spm10) INTO out_verdi5 FROM vurderingshistorikk WHERE spm10 = 5;

END$$
DELIMITER ;