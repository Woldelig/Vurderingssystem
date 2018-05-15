-- call hent_spm1_verdier("OBJ2100",@out_value1,@out_value2,@out_value3,@out_value4,@out_value5);
-- SELECT @out_value1,@out_value2,@out_value3,@out_value4,@out_value5;
-- call historikk_prosedyre("tabbelnavnSkalher");
-- Over er eksempler på hvordan man kaller på prosedyrer

DROP PROCEDURE IF EXISTS avslutt_evaluering;
DELIMITER $$
CREATE PROCEDURE avslutt_evaluering()
BEGIN
    INSERT INTO vurderingshistorikk(skjemaid, studentid, fagkode, spm1, spm2, spm3, spm4, spm5, spm6, spm7, spm8, spm9, spm10)
    	SELECT skjemaid, studentid, fagkode, spm1, spm2, spm3, spm4, spm5, spm6, spm7, spm8, spm9, spm10 FROM pågåendevurdering;
    
    DELETE FROM pågåendevurdering;
END$$
DELIMITER ;




DROP PROCEDURE IF EXISTS lagre_pågående_evaluerings_resultater;
DELIMITER $$
CREATE PROCEDURE lagre_pågående_evaluerings_resultater
(
    IN ny_tabell VARCHAR(64)
)
BEGIN
    SET @Sql = CONCAT("CREATE TABLE ",ny_tabell," AS SELECT * FROM pågåendevurdering;");
    PREPARE stmt FROM @Sql;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
END$$
DELIMITER ;






DROP PROCEDURE IF EXISTS telle_svar_skjemaer;
DELIMITER $$
CREATE PROCEDURE telle_svar_skjemaer
(
    IN in_fagkode VARCHAR(10),
    IN in_spmnr VARCHAR (10),
    OUT out_verdi1 INT
)
BEGIN
    SELECT COUNT(in_spmnr) INTO out_verdi1 FROM vurderingshistorikk WHERE fagkode = in_fagkode;
END $$
DELIMITER ;




DROP PROCEDURE IF EXISTS hent_spm1_verdier;
DELIMITER $$
CREATE PROCEDURE hent_spm1_verdier
(
    IN in_fagkode VARCHAR(10),
    OUT out_verdi1 INT,
    OUT out_verdi2 INT,
    OUT out_verdi3 INT,
    OUT out_verdi4 INT,
    OUT out_verdi5 INT
)
BEGIN
    SELECT COUNT(spm1) INTO out_verdi1 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm1 = 1;
    SELECT COUNT(spm1) INTO out_verdi2 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm1 = 2;
    SELECT COUNT(spm1) INTO out_verdi3 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm1 = 3;
    SELECT COUNT(spm1) INTO out_verdi4 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm1 = 4;
    SELECT COUNT(spm1) INTO out_verdi5 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm1 = 5;
END$$
DELIMITER ;



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
    SELECT COUNT(spm2) INTO out_verdi1 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm2 = 1;
    SELECT COUNT(spm2) INTO out_verdi2 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm2 = 2;
    SELECT COUNT(spm2) INTO out_verdi3 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm2 = 3;
    SELECT COUNT(spm2) INTO out_verdi4 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm2 = 4;
    SELECT COUNT(spm2) INTO out_verdi5 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm2 = 5;
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
    SELECT COUNT(spm3) INTO out_verdi1 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm3 = 1;
    SELECT COUNT(spm3) INTO out_verdi2 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm3 = 2;
    SELECT COUNT(spm3) INTO out_verdi3 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm3 = 3;
    SELECT COUNT(spm3) INTO out_verdi4 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm3 = 4;
    SELECT COUNT(spm3) INTO out_verdi5 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm3 = 5;
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
    SELECT COUNT(spm4) INTO out_verdi1 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm4 = 1;
    SELECT COUNT(spm4) INTO out_verdi2 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm4 = 2;
    SELECT COUNT(spm4) INTO out_verdi3 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm4 = 3;
    SELECT COUNT(spm4) INTO out_verdi4 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm4 = 4;
    SELECT COUNT(spm4) INTO out_verdi5 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm4 = 5;
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
    SELECT COUNT(spm5) INTO out_verdi1 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm5 = 1;
    SELECT COUNT(spm5) INTO out_verdi2 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm5 = 2;
    SELECT COUNT(spm5) INTO out_verdi3 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm5 = 3;
    SELECT COUNT(spm5) INTO out_verdi4 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm5 = 4;
    SELECT COUNT(spm5) INTO out_verdi5 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm5 = 5;
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
    SELECT COUNT(spm6) INTO out_verdi1 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm6 = 1;
    SELECT COUNT(spm6) INTO out_verdi2 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm6 = 2;
    SELECT COUNT(spm6) INTO out_verdi3 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm6 = 3;
    SELECT COUNT(spm6) INTO out_verdi4 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm6 = 4;
    SELECT COUNT(spm6) INTO out_verdi5 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm6 = 5;
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
    SELECT COUNT(spm7) INTO out_verdi1 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm7 = 1;
    SELECT COUNT(spm7) INTO out_verdi2 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm7 = 2;
    SELECT COUNT(spm7) INTO out_verdi3 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm7 = 3;
    SELECT COUNT(spm7) INTO out_verdi4 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm7 = 4;
    SELECT COUNT(spm7) INTO out_verdi5 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm7 = 5;
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
    SELECT COUNT(spm8) INTO out_verdi1 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm8 = 1;
    SELECT COUNT(spm8) INTO out_verdi2 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm8 = 2;
    SELECT COUNT(spm8) INTO out_verdi3 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm8 = 3;
    SELECT COUNT(spm8) INTO out_verdi4 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm8 = 4;
    SELECT COUNT(spm8) INTO out_verdi5 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm8 = 5;
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
    SELECT COUNT(spm9) INTO out_verdi1 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm9 = 1;
    SELECT COUNT(spm9) INTO out_verdi2 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm9 = 2;
    SELECT COUNT(spm9) INTO out_verdi3 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm9 = 3;
    SELECT COUNT(spm9) INTO out_verdi4 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm9 = 4;
    SELECT COUNT(spm9) INTO out_verdi5 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm9 = 5;
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
    SELECT COUNT(spm10) INTO out_verdi1 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm10 = 1;
    SELECT COUNT(spm10) INTO out_verdi2 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm10 = 2;
    SELECT COUNT(spm10) INTO out_verdi3 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm10 = 3;
    SELECT COUNT(spm10) INTO out_verdi4 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm10 = 4;
    SELECT COUNT(spm10) INTO out_verdi5 FROM vurderingshistorikk WHERE fagkode = in_fagkode AND spm10 = 5;
END$$
DELIMITER ;