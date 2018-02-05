-- 1.0 Henter ut antall svar per spørsmål
DROP PROCEDURE IF EXISTS hentSvarAntall;
DELIMITER $$
CREATE PROCEDURE hentSvarAntall
(
  IN p_spm INT
)

BEGIN
  DECLARE p_svar1 INT;
  DECLARE p_svar2 INT;
  DECLARE p_svar3 INT;
  DECLARE p_svar4 INT;
  DECLARE p_svar5 INT;

  SET p_svar1 = SELECT COUNT(p_spm) FROM vurderingshistorikk WHERE p_spm = 1;
  SET p_svar2 = SELECT COUNT(p_spm) FROM vurderingshistorikk WHERE p_spm = 2;
  SET p_svar3 = SELECT COUNT(p_spm) FROM vurderingshistorikk WHERE p_spm = 3;
  SET p_svar4 = SELECT COUNT(p_spm) FROM vurderingshistorikk WHERE p_spm = 4;
  SET p_svar5 = SELECT COUNT(p_spm) FROM vurderingshistorikk WHERE p_spm = 5;
END$$
DELIMITER ;
-- Slutt 1.0
