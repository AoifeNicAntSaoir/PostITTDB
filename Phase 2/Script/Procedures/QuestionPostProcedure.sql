CREATE OR REPLACE PROCEDURE QuestionPost
IS
pTDesc VARCHAR2(20) := 'Question';

BEGIN
        
        INSERT INTO PostType(postTypeId,postTypeDesc)
        VALUES(PostType_seq.NEXTVAL,pTDesc);
END;