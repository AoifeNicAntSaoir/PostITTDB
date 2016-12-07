View VIEWPOSTS created.


    POSTID   PARENTID POSTDATE  POSTTEXT                                           FIRSTNAME            SURNAME              POSTTYPEDESC         CATEGORYNAME         URL                                    
---------- ---------- --------- -------------------------------------------------- -------------------- -------------------- -------------------- -------------------- ----------------------------------------
         2          1 04-DEC-16 Hi there - reply post here                         Helen                O Brien - Admin      Informative          Business             images\mypic.jpg                        
         2          1 04-DEC-16 Hi there - reply post here                         Katie                Griffiths            Informative          Business             images\mypic.jpg                        
         2          1 04-DEC-16 Hi there - reply post here                         Katie                Griffiths            Informative          Business             images\mypic.jpg                        
         2          1 04-DEC-16 Hi there - reply post here                         Aoife                Sayers - USER        Informative          Business             images\mypic.jpg                        
         1          1 04-DEC-16 Hello World! Informative post here                 Katie                Griffiths            Reply                Computing            \documents\myPhotos\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Katie                Griffiths            Reply                Computing            \documents\myPhotos\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Helen                O Brien - Admin      Reply                Computing            \documents\myPhotos\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Aoife                Sayers - USER        Reply                Computing            \documents\javaBits\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Helen                O Brien - Admin      Reply                Computing            \documents\javaBits\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Aoife                Sayers - USER        Reply                Computing            \documents\myPhotos\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Katie                Griffiths            Reply                Computing            \documents\javaBits\                    

    POSTID   PARENTID POSTDATE  POSTTEXT                                           FIRSTNAME            SURNAME              POSTTYPEDESC         CATEGORYNAME         URL                                    
---------- ---------- --------- -------------------------------------------------- -------------------- -------------------- -------------------- -------------------- ----------------------------------------
         1          1 04-DEC-16 Hello World! Informative post here                 Katie                Griffiths            Reply                Computing            \documents\javaBits\                    

 12 rows selected 

View VIEWPOSTS created.


    POSTID   PARENTID POSTDATE  POSTTEXT                                           FIRSTNAME            SURNAME              POSTTYPEDESC         CATEGORYNAME         URL                                    
---------- ---------- --------- -------------------------------------------------- -------------------- -------------------- -------------------- -------------------- ----------------------------------------
         2          1 04-DEC-16 Hi there - reply post here                         Helen                O Brien - Admin      Informative          Business             images\mypic.jpg                        
         1          1 04-DEC-16 Hello World! Informative post here                 Aoife                Sayers - USER        Reply                Computing            \documents\javaBits\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Aoife                Sayers - USER        Reply                Computing            \documents\myPhotos\                    

Error starting at line : 1 in command -
CREATE OR REPLACE VIEW viewPosts AS
SELECT  p.postid, p.parentid, p.postdate, p.posttext, u.firstname, u.surname, t.posttypedesc,c.categoryname, m.url
FROM ITTUSER u, POST p, media m, category c, posttype t
WHERE
p.categoryid = c.categoryid AND
      p.posttypeid = t.posttypeid AND
      m.postid = p.postid AND
     -- p.userid = u.userid 
ORDER BY p.postid DESC
Error report -
SQL Error: ORA-00936: missing expression
00936. 00000 -  "missing expression"
*Cause:    
*Action:

    POSTID   PARENTID POSTDATE  POSTTEXT                                           FIRSTNAME            SURNAME              POSTTYPEDESC         CATEGORYNAME         URL                                    
---------- ---------- --------- -------------------------------------------------- -------------------- -------------------- -------------------- -------------------- ----------------------------------------
         2          1 04-DEC-16 Hi there - reply post here                         Helen                O Brien - Admin      Informative          Business             images\mypic.jpg                        
         1          1 04-DEC-16 Hello World! Informative post here                 Aoife                Sayers - USER        Reply                Computing            \documents\javaBits\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Aoife                Sayers - USER        Reply                Computing            \documents\myPhotos\                    

View VIEWPOSTS created.

    POSTID   PARENTID POSTDATE  POSTTEXT                                           FIRSTNAME            SURNAME              POSTTYPEDESC         CATEGORYNAME         URL                                    
---------- ---------- --------- -------------------------------------------------- -------------------- -------------------- -------------------- -------------------- ----------------------------------------
         2          1 04-DEC-16 Hi there - reply post here                         Helen                O Brien - Admin      Informative          Business             images\mypic.jpg                        
         2          1 04-DEC-16 Hi there - reply post here                         Katie                Griffiths            Informative          Business             images\mypic.jpg                        
         2          1 04-DEC-16 Hi there - reply post here                         Katie                Griffiths            Informative          Business             images\mypic.jpg                        
         2          1 04-DEC-16 Hi there - reply post here                         Aoife                Sayers - USER        Informative          Business             images\mypic.jpg                        
         1          1 04-DEC-16 Hello World! Informative post here                 Katie                Griffiths            Reply                Computing            \documents\myPhotos\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Katie                Griffiths            Reply                Computing            \documents\myPhotos\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Helen                O Brien - Admin      Reply                Computing            \documents\myPhotos\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Aoife                Sayers - USER        Reply                Computing            \documents\javaBits\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Helen                O Brien - Admin      Reply                Computing            \documents\javaBits\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Aoife                Sayers - USER        Reply                Computing            \documents\myPhotos\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Katie                Griffiths            Reply                Computing            \documents\javaBits\                    

    POSTID   PARENTID POSTDATE  POSTTEXT                                           FIRSTNAME            SURNAME              POSTTYPEDESC         CATEGORYNAME         URL                                    
---------- ---------- --------- -------------------------------------------------- -------------------- -------------------- -------------------- -------------------- ----------------------------------------
         1          1 04-DEC-16 Hello World! Informative post here                 Katie                Griffiths            Reply                Computing            \documents\javaBits\                    

 12 rows selected 

View VIEWPOSTS created.

    POSTID   PARENTID POSTDATE  POSTTEXT                                           FIRSTNAME            SURNAME              POSTTYPEDESC         CATEGORYNAME         URL                                    
---------- ---------- --------- -------------------------------------------------- -------------------- -------------------- -------------------- -------------------- ----------------------------------------
         2          1 04-DEC-16 Hi there - reply post here                         Aoife                Sayers - USER        Informative          Business             images\mypic.jpg                        
         2          1 04-DEC-16 Hi there - reply post here                         Helen                O Brien - Admin      Informative          Business             images\mypic.jpg                        
         2          1 04-DEC-16 Hi there - reply post here                         Katie                Griffiths            Informative          Business             images\mypic.jpg                        
         1          1 04-DEC-16 Hello World! Informative post here                 Aoife                Sayers - USER        Reply                Computing            \documents\javaBits\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Aoife                Sayers - USER        Reply                Computing            \documents\myPhotos\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Helen                O Brien - Admin      Reply                Computing            \documents\javaBits\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Helen                O Brien - Admin      Reply                Computing            \documents\myPhotos\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Katie                Griffiths            Reply                Computing            \documents\javaBits\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Katie                Griffiths            Reply                Computing            \documents\myPhotos\                    

 9 rows selected 

View VIEWPOSTS created.


    POSTID   PARENTID POSTDATE  POSTTEXT                                           FIRSTNAME            SURNAME              POSTTYPEDESC         CATEGORYNAME         URL                                    
---------- ---------- --------- -------------------------------------------------- -------------------- -------------------- -------------------- -------------------- ----------------------------------------
         2          1 04-DEC-16 Hi there - reply post here                         Aoife                Sayers - USER        Informative          Business             images\mypic.jpg                        
         2          1 04-DEC-16 Hi there - reply post here                         Helen                O Brien - Admin      Informative          Business             images\mypic.jpg                        
         2          1 04-DEC-16 Hi there - reply post here                         Katie                Griffiths            Informative          Business             images\mypic.jpg                        
         1          1 04-DEC-16 Hello World! Informative post here                 Aoife                Sayers - USER        Reply                Computing            \documents\javaBits\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Aoife                Sayers - USER        Reply                Computing            \documents\myPhotos\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Helen                O Brien - Admin      Reply                Computing            \documents\javaBits\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Helen                O Brien - Admin      Reply                Computing            \documents\myPhotos\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Katie                Griffiths            Reply                Computing            \documents\javaBits\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Katie                Griffiths            Reply                Computing            \documents\myPhotos\                    

 9 rows selected 

Error starting at line : 1 in command -
CREATE OR REPLACE VIEW viewPosts AS
SELECT unique p.postid, p.parentid, p.postdate, p.posttext, u.firstname, u.surname, t.posttypedesc,c.categoryname, m.url, r.postrank
FROM ITTUSER u, POST p, media m, category c, posttype t, rank r
WHERE
p.postid = r.postid
p.categoryid = c.categoryid AND
      p.posttypeid = t.posttypeid AND
      m.postid = p.postid
ORDER BY p.postid DESC
Error report -
SQL Error: ORA-00933: SQL command not properly ended
00933. 00000 -  "SQL command not properly ended"
*Cause:    
*Action:

    POSTID   PARENTID POSTDATE  POSTTEXT                                           FIRSTNAME            SURNAME              POSTTYPEDESC         CATEGORYNAME         URL                                    
---------- ---------- --------- -------------------------------------------------- -------------------- -------------------- -------------------- -------------------- ----------------------------------------
         2          1 04-DEC-16 Hi there - reply post here                         Aoife                Sayers - USER        Informative          Business             images\mypic.jpg                        
         2          1 04-DEC-16 Hi there - reply post here                         Helen                O Brien - Admin      Informative          Business             images\mypic.jpg                        
         2          1 04-DEC-16 Hi there - reply post here                         Katie                Griffiths            Informative          Business             images\mypic.jpg                        
         1          1 04-DEC-16 Hello World! Informative post here                 Aoife                Sayers - USER        Reply                Computing            \documents\javaBits\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Aoife                Sayers - USER        Reply                Computing            \documents\myPhotos\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Helen                O Brien - Admin      Reply                Computing            \documents\javaBits\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Helen                O Brien - Admin      Reply                Computing            \documents\myPhotos\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Katie                Griffiths            Reply                Computing            \documents\javaBits\                    
         1          1 04-DEC-16 Hello World! Informative post here                 Katie                Griffiths            Reply                Computing            \documents\myPhotos\                    

 9 rows selected 

View VIEWPOSTS created.


    POSTID   PARENTID POSTDATE  POSTTEXT                                           FIRSTNAME            SURNAME              POSTTYPEDESC         CATEGORYNAME         URL                                        POSTRANK
---------- ---------- --------- -------------------------------------------------- -------------------- -------------------- -------------------- -------------------- ---------------------------------------- ----------
         2          1 04-DEC-16 Hi there - reply post here                         Aoife                Sayers - USER        Informative          Business             images\mypic.jpg                                  2
         2          1 04-DEC-16 Hi there - reply post here                         Helen                O Brien - Admin      Informative          Business             images\mypic.jpg                                  2
         2          1 04-DEC-16 Hi there - reply post here                         Katie                Griffiths            Informative          Business             images\mypic.jpg                                  2
         1          1 04-DEC-16 Hello World! Informative post here                 Aoife                Sayers - USER        Reply                Computing            \documents\javaBits\                              1
         1          1 04-DEC-16 Hello World! Informative post here                 Aoife                Sayers - USER        Reply                Computing            \documents\myPhotos\                              1
         1          1 04-DEC-16 Hello World! Informative post here                 Helen                O Brien - Admin      Reply                Computing            \documents\javaBits\                              1
         1          1 04-DEC-16 Hello World! Informative post here                 Helen                O Brien - Admin      Reply                Computing            \documents\myPhotos\                              1
         1          1 04-DEC-16 Hello World! Informative post here                 Katie                Griffiths            Reply                Computing            \documents\javaBits\                              1
         1          1 04-DEC-16 Hello World! Informative post here                 Katie                Griffiths            Reply                Computing            \documents\myPhotos\                              1

 9 rows selected 

