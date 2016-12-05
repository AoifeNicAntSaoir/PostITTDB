CREATE OR REPLACE PROCEDURE ReplyPost
IS
pTDesc VARCHAR2(20) := 'Reply';

BEGIN
        INSERT INTO PostType(postTypeId,postTypeDesc)
        VALUES(PostType_seq.NEXTVAL,pTDesc);
END;