CREATE OR REPLACE PROCEDURE createITTUser(firstName IN  VARCHAR2, surname IN VARCHAR2, password IN VARCHAR2,
                                          email IN VARCHAR2)
IS

   score NUMBER(5) := 0;
   


BEGIN
   INSERT INTO IttUser(userId, firstName, surname, password, email, score, profilePic, userTypeId)
  VALUES(IttUser_seq.NEXTVAL,firstName, surname, password, email, score, 'default.jpg', 1);
END;