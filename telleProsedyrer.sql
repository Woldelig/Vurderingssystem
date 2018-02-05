-- spm1

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