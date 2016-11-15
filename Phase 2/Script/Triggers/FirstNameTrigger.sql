CREATE OR REPLACE TRIGGER userIttNameCheck
BEFORE INSERT OR UPDATE ON IttUser
FOR EACH ROW

	DECLARE 
	 firstName VARCHAR(20);
BEGIN
	firstName := :NEW.firstname;

IF (NOT(regexp_like(firstname, '[a-zA-Z '']+$')))
THEN
	RAISE_APPLICATION_ERROR(-3000,('First name can only contain letters'));
END IF;
END;



