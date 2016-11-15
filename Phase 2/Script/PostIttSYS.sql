--PostITTSYS
--This Oracle Script builds the database for the PostITT System
--Author Helen O'Brien, Anthony Bruhl, Aoife Sayers, Katie Griffiths

--Anthony What is the advantage of using INTEGER?? If we want it it goes in but with no (number)

--Aoife 
    --Domain Constraints - will also fix the dummy data to match these
    --Sequences instead of auto-increment
DROP TABLE Media;
DROP TABLE MediaType;
DROP TABLE Rank;
DROP TABLE Post;
DROP TABLE Tag;
DROP TABLE Category;
DROP TABLE PostType;
DROP TABLE IttUser;
DROP TABLE UserType;

DROP SEQUENCE Media_seq;
DROP SEQUENCE MediaType_seq;
DROP SEQUENCE Rank_seq;
DROP SEQUENCE Post_seq;
DROP SEQUENCE Tag_seq;
DROP SEQUENCE Category_seq;
DROP SEQUENCE PostType_seq;
DROP SEQUENCE IttUser_seq;
DROP SEQUENCE UserType_seq;

/* *******************************************************************************************************************************************
                                Sequences here - using these instead of auto-increment

INSERT INTO suppliers (supplier_id, supplier_name)
VALUES (supplier_seq.NEXTVAL, 'Kraft Foods');                                
                                */


CREATE SEQUENCE Media_seq
  MINVALUE 1
  MAXVALUE 99999
  START WITH 1
  INCREMENT BY 1
  CACHE 20;

CREATE SEQUENCE UserType_seq
  MINVALUE 1
  MAXVALUE 99999
  START WITH 1
  INCREMENT BY 1
  CACHE 20;

CREATE SEQUENCE IttUser_seq
  MINVALUE 1
  MAXVALUE 99999
  START WITH 1
  INCREMENT BY 1
  CACHE 20;

 CREATE SEQUENCE PostType_seq
  MINVALUE 1
  MAXVALUE 99999
  START WITH 1
  INCREMENT BY 1
  CACHE 20;
  
  CREATE SEQUENCE Category_seq
  MINVALUE 1
  MAXVALUE 99999
  START WITH 1
  INCREMENT BY 1
  CACHE 20;
  
  CREATE SEQUENCE MediaType_seq
  MINVALUE 1
  MAXVALUE 99999
  START WITH 1
  INCREMENT BY 1
  CACHE 20;
  
  
CREATE SEQUENCE Rank_seq
  MINVALUE 1
  MAXVALUE 99999
  START WITH 1
  INCREMENT BY 1
  CACHE 20;
  
  CREATE SEQUENCE Post_seq
  MINVALUE 1
  MAXVALUE 99999
  START WITH 1
  INCREMENT BY 1
  CACHE 20;
  
  
CREATE SEQUENCE Tag_seq
  MINVALUE 1
  MAXVALUE 99999
  START WITH 1
  INCREMENT BY 1
  CACHE 20;
 /*********************************************************************************************************************
                              Tables here*/
  
CREATE TABLE UserType (
    userTypeId      NUMBER(5),
    typeDescription VARCHAR2(1) NOT NULL UNIQUE CONSTRAINT typeDesc_chk CHECK(typeDescription IN('A','U')),
    CONSTRAINT pk_uType_ID PRIMARY KEY (userTypeId)); 
    
CREATE TABLE IttUser (
    userId     NUMBER(5),
    firstName  VARCHAR2(20) NOT NULL CONSTRAINT fname_chk CHECK(LENGTH(firstName)>0 AND LENGTH(firstName)<=20),
    surname    VARCHAR2(20) NOT NULL CONSTRAINT sname_chk CHECK(LENGTH(surname)>0 AND LENGTH(surname)<=20),
    password   VARCHAR2(30) NOT NULL,
    email      VARCHAR2(30) NOT NULL UNIQUE ,
    score      NUMBER(5) CHECK(score>0 AND score<99999),
    profilePic VARCHAR2(50),
    userTypeId   NUMBER(5),
    CONSTRAINT pk_firstName PRIMARY KEY (userId),
    CONSTRAINT fk_userTypeId_UD FOREIGN KEY (userTypeId) REFERENCES UserType(userTypeId));
  
CREATE TABLE PostType (
    postTypeId NUMBER(5) CONSTRAINT postType_chk CHECK(postTypeId >0 AND postTypeId<=99999),
    postType   VARCHAR2(20) NOT NULL CONSTRAINT postTypetbl_chk CHECK(postType IN('Informative','Reply','Question','Answer')),
    CONSTRAINT pk_postTypeId PRIMARY KEY (postTypeId));

CREATE TABLE Category (
    categoryId   NUMBER(5) CONSTRAINT catid_chk CHECK(categoryId >0 AND categoryId<=99999),
    categoryName VARCHAR2(20) NOT NULL UNIQUE CONSTRAINT catName_chk CHECK(categoryName IN('Computing','Business','Creative Media','Engineering','Nursing','Social Science')),
    CONSTRAINT pk_categoryId PRIMARY KEY (categoryId));

CREATE TABLE Tag (
    tagId   NUMBER(5) CONSTRAINT tagid_chk CHECK(tagId >0 AND tagId<=99999),
    tagName VARCHAR2(20) NOT NULL UNIQUE,
    categoryId   NUMBER(5) NOT NULL CONSTRAINT catidtag_chk CHECK(categoryId >0 AND categoryId<=99999),
    CONSTRAINT pk_tagId PRIMARY KEY (tagId),
    CONSTRAINT fk_categoryId_T FOREIGN KEY (categoryId) REFERENCES Category(categoryId));
  
  

--WE NEED TO TEST THE PARENT ID WORKS FOR A ROOT POST AND A CHILD POST 
CREATE TABLE Post (
    postId     NUMBER(5)  CONSTRAINT postid_chk CHECK(postId >0 AND postId<=99999),
    parentId   NUMBER(5) CONSTRAINT parentId_chk CHECK(parentId >0 AND parentId<=99999),
    postdate   DATE DEFAULT SYSDATE, 
    postText   VARCHAR2(50) NOT NULL,
    userId     NUMBER(5),
    postTypeId NUMBER(5) CONSTRAINT postType_chk1 CHECK(postTypeId >0 AND postTypeId<=99999),
    categoryId NUMBER(5) CONSTRAINT cat_chk1 CHECK(categoryId >0 AND categoryId<=99999),
    mediaId    NUMBER(5), 
    CONSTRAINT pk_postId PRIMARY KEY (postId),
    CONSTRAINT fk_parentid_P FOREIGN KEY (parentId) REFERENCES Post(postId),
    CONSTRAINT fk_userId_P FOREIGN KEY (userId) REFERENCES IttUser(userId),
    CONSTRAINT fk_postTypeId_P FOREIGN KEY (postTypeId) REFERENCES PostType(postTypeId),
    CONSTRAINT fk_categoryId_P FOREIGN KEY (categoryId) REFERENCES Category(categoryId));
    
CREATE TABLE Rank (
    rankId   NUMBER(5) CONSTRAINT rankid_chk CHECK(rankId >0 AND rankId<=99999),
    postRank NUMBER(5) NOT NULL  CONSTRAINT postRank_chk_R CHECK(postRank >0 AND postRank<=99999),
    userId   NUMBER(5) NOT NULL  CONSTRAINT userId_chk_R CHECK(userId >0 AND userId<=99999),
    postId   NUMBER(5) CONSTRAINT postId_chk_R CHECK(postId >0 AND postId<=99999),
    CONSTRAINT pk_rankId PRIMARY KEY (rankId),
    CONSTRAINT fk_userId_R FOREIGN KEY (userId) REFERENCES IttUser(userId),
    CONSTRAINT fk_postId_R FOREIGN KEY (postId) REFERENCES Post(postId));
    
CREATE TABLE MediaType (  --Do we need a procedure to check the media type - everything > myPic.jpg >.jpg
    mediaTypeId   NUMBER(5) CONSTRAINT mediaTypeid_chk CHECK(mediaTypeId >0 AND mediaTypeId<=99999),
    MediaTypeDesc VARCHAR2(20) NOT NULL UNIQUE CONSTRAINT mediaTypeDesc_chk CHECK(MediaTypeDesc IN ('.jpg','.jpeg','.png','.gif', '.docx', '.doc', '.pdf', '.java', '.html', '.txt', '.htm')),
    CONSTRAINT pk_mediaTypeId PRIMARY KEY (mediaTypeId));
  
CREATE TABLE Media (
    mediaId        NUMBER(5) CONSTRAINT mediaid_chk CHECK(mediaId >0 AND mediaId<=99999),
    mediaTypeId    NUMBER(5),
    url            VARCHAR2(40) NOT NULL,
    status         VARCHAR2(1) CONSTRAINT status_chk CHECK(status IN ('p','a','f','d')), -- pending, approved, flagged, disabled
    postId         NUMBER(5),
    CONSTRAINT pk_mediaId PRIMARY KEY (mediaId),
    CONSTRAINT fk_mediaTypeId_M FOREIGN KEY (mediaTypeId ) REFERENCES MediaType(mediaTypeId),
    CONSTRAINT fk_postId_M FOREIGN KEY (postId) REFERENCES Post(postId ));

COMMIT;