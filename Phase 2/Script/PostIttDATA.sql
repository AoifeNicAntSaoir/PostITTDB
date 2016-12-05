--PostITTDATA
--This Oracle Script populates the database for the PostITT System
--Authors Helen O'Brien, Anthony Bruhl, Aoife Sayers, Katie Griffiths


--UserType
INSERT INTO UserType(userTypeId, typeDescription)
VALUES(UserType_seq.NEXTVAL,'U');

INSERT INTO UserType(userTypeId, typeDescription)
VALUES(UserType_seq.NEXTVAL,'A');

--This shouldn't insert
/*INSERT INTO UserType(userTypeId, typeDescription)
VALUES(UserType_seq.NEXTVAL,'B');
INSERT INTO UserType(userTypeId, typeDescription)
VALUES(2,'A');*/


--Populates IttUser Table 
--need to check password trigger
INSERT INTO IttUser(userId, firstName, surname, password, email, score, profilePic, userTypeId)
VALUES(IttUser_seq.NEXTVAL, 'Aoife','Sayers - USER', 'myPassword123','aoifesayers@gmail.com',34,'mypic.jpg',1);

INSERT INTO IttUser(userId, firstName, surname, password, email, score, profilePic, userTypeId)
VALUES(IttUser_seq.NEXTVAL, 'Helen','O Brien - Admin', 'myPassword123','h3l3n@gmail.com',322,'mypic.png',2);

INSERT INTO ITTUser
(userId, firstName, surname, password, email, score, profilePic, userTypeId)
VALUES(IttUser_seq.NEXTVAL, 'Katie', 'Griffiths', 'myPass!', 'katie@gmail.com', 30, 'mypicKatie.jpg', 1);

--This shouldn't insert on password trigger
    /*  --pass too short
      INSERT INTO IttUser(userId, firstName, surname, password, email, score, profilePic, userTypeId)
      VALUES(IttUser_seq.NEXTVAL, 'Helen','O Brien - Admin', 'pass','h3l3n@gmail.com',322,'mypic.png',2);
      --pass no numbers & not mixed case
      INSERT INTO IttUser(userId, firstName, surname, password, email, score, profilePic, userTypeId)
      VALUES(IttUser_seq.NEXTVAL, 'Helen','O Brien - Admin', 'password','h3l3n@gmail.com',322,'mypic.png',2);
  */

--TEST INCORRECT EMAIL FORMAT
INSERT INTO ITTUser
(userId, firstName, surname, password, email, score, profilePic, userTypeId)
VALUES(ittUser_seq.nextval, 'Katie', 'Griffiths', 'myPass!', 'katie@gmail', 30, 'mypicKatie.jpg', 1);

--PostType
INSERT INTO PostType(postTypeId,postTypeDesc)
VALUES(PostType_seq.NEXTVAL,'Informative');

INSERT INTO PostType(postTypeId,postTypeDesc)
VALUES(PostType_seq.NEXTVAL,'Reply');

INSERT INTO PostType(postTypeId,postTypeDesc)
VALUES(PostType_seq.NEXTVAL,'Question');

INSERT INTO PostType(postTypeId,postTypeDesc)
VALUES(PostType_seq.NEXTVAL,'Answer');
    --shouldnt' insert
   /* INSERT INTO PostType(postTypeId,postType)
  VALUES(PostType_seq.NEXTVAL,'random');*/




--Category
INSERT INTO Category(categoryId,categoryName)
VALUES(Category_seq.NEXTVAL,'Computing');

INSERT INTO Category(categoryId,categoryName)
VALUES(Category_seq.NEXTVAL,'Business');

INSERT INTO Category(categoryId,categoryName)
VALUES(Category_seq.NEXTVAL,'Creative Media');

INSERT INTO Category(categoryId,categoryName)
VALUES(Category_seq.NEXTVAL,'Engineering');

INSERT INTO Category(categoryId,categoryName)
VALUES(Category_seq.NEXTVAL,'Nursing');

INSERT INTO Category(categoryId,categoryName)
VALUES(Category_seq.NEXTVAL,'Social Science');

--shouldn't insert
/*INSERT INTO Category(categoryId,categoryName)
VALUES(Category_seq.NEXTVAL,'RANDOM');*/



--Tag
INSERT INTO Tag(tagId, tagName, categoryId)
VALUES(Tag_seq.NEXTVAL,'HTML',1); --Testing computing category

INSERT INTO Tag(tagId,tagName, categoryId)
VALUES(Tag_seq.NEXTVAL,'Java',1); -- Testing Computing category again

INSERT INTO Tag(tagId,tagName, categoryId)
VALUES(Tag_seq.NEXTVAL,'Accounting',2); -- Testing business category again

INSERT INTO Tag
(tagId, tagName, categoryId)
VALUES(Tag_seq.NEXTVAL, 'Budgeting', 2);

INSERT INTO Tag
(tagId, tagName, categoryId)
VALUES(Tag_seq.NEXTVAL, 'Photoshop', 1);

INSERT INTO Tag
(tagId, tagName, categoryId)
VALUES(Tag_seq.NEXTVAL, 'Nursing Practice', 4);

--shouldn't insert
/*INSERT INTO Tag(tagId,tagName, categoryId)
VALUES(Tag_seq.NEXTVAL,'Java',99); -- Testing Computing category again*/




--Populates Post Table
--postTypeId, categoryId NEEDS FETCHING FROM THEIR TABLES

INSERT INTO Post
(postId, parentId, postDate, postText, userId, postTypeId, categoryId) 
VALUES(Post_seq.NEXTVAL,1,SYSDATE,'Hello World! Informative post here', 1, 2, 1);

INSERT INTO Post
(postId, parentId, postDate, postText, userId, postTypeId, categoryId)
VALUES(Post_seq.NEXTVAL,1,SYSDATE,'Hi there - reply post here', 2, 1, 2);

INSERT INTO Post
(postId, parentId, postDate, postText, userId, postTypeId, categoryId)
VALUES(Post_seq.NEXTVAL,1,SYSDATE,'Who is this? - question post here', 1, 2, 3);

INSERT INTO Post
(postId, parentId, postDate, postText, userId, postTypeId, categoryId)
VALUES(Post_seq.NEXTVAL,1,SYSDATE,'It is me - answer post here', 1, 2,4);

INSERT INTO Post
(postId, parentId, postDate, postText, userId, postTypeId, categoryId)
VALUES(Post_seq.NEXTVAL, 1, SYSDATE, 'This is an informative post about HTML', 1, 1, 1);

INSERT INTO Post
(postId, parentId, postDate, postText, userId, postTypeId, categoryId)
VALUES(Post_seq.NEXTVAL, 2, SYSDATE, 'Question post about HTML again', 1, 2, 1);

INSERT INTO Post
(postId, parentId, postDate, postText, userId, postTypeId, categoryId)
VALUES(Post_seq.NEXTVAL, 2, SYSDATE, 'Reply post about HTML question above', 2, 3, 1);

--shouldn't work
/*INSERT INTO Post(postId, parentId, postdate, postText,postTypeId)
VALUES(Post_seq.NEXTVAL,1,SYSDATE,'I will not work',-99);*/



--Rank
INSERT INTO Rank(rankId, postRank, userId, postId)
VALUES(Rank_seq.NEXTVAL, 1, 1, 1); -- Aoife's Hello World Informative post has rank number 1

INSERT INTO Rank(rankId, postRank, userId, postId)
VALUES(Rank_seq.NEXTVAL, 2, 2, 2);



--Media Type
INSERT INTO MediaType(mediaTypeId,MediaTypeDesc) 
VALUES(MediaType_seq.NEXTVAL,'.jpg');

INSERT INTO MediaType(mediaTypeId,MediaTypeDesc)
VALUES(MediaType_seq.NEXTVAL,'.jpeg');

INSERT INTO MediaType(mediaTypeId,MediaTypeDesc)
VALUES(MediaType_seq.NEXTVAL,'.png');

INSERT INTO MediaType(mediaTypeId,MediaTypeDesc)
VALUES(MediaType_seq.NEXTVAL,'.gif');

INSERT INTO MediaType(mediaTypeId,MediaTypeDesc)
VALUES(MediaType_seq.NEXTVAL,'.docx');

INSERT INTO MediaType(mediaTypeId,MediaTypeDesc)
VALUES(MediaType_seq.NEXTVAL,'.doc');

INSERT INTO MediaType(mediaTypeId,MediaTypeDesc)
VALUES(MediaType_seq.NEXTVAL,'.txt');

INSERT INTO MediaType(mediaTypeId,MediaTypeDesc)
VALUES(MediaType_seq.NEXTVAL,'.pdf');

INSERT INTO MediaType(mediaTypeId,MediaTypeDesc)
VALUES(MediaType_seq.NEXTVAL,'.java');

INSERT INTO MediaType(mediaTypeId,MediaTypeDesc)
VALUES(MediaType_seq.NEXTVAL,'.html');

INSERT INTO MediaType(mediaTypeId,MediaTypeDesc)
VALUES(MediaType_seq.NEXTVAL,'.htm');

--shouldnt' work
/*INSERT INTO MediaType(mediaTypeId,MediaTypeDesc)
VALUES(MediaType_seq.NEXTVAL,'.htm');*/


--Media
INSERT INTO MEDIA(mediaId, mediaTypeId, url, postId)
VALUES(media_seq.NEXTVAL, 1, '\documents\myPhotos\',1); --adding .jpg file to Hello World post - file stored in \documents\myPhotos


INSERT INTO MEDIA(mediaId, mediaTypeId, url, postId)
VALUES(media_seq.NEXTVAL, 8, '\documents\javaBits\',1); -- adding java file to hello World post

INSERT INTO Media
(mediaId, mediaTypeId, url, postId)
VALUES(media_seq.NEXTVAL, 1, 'images\mypic.jpg', 2);

-- won't work
/*INSERT INTO MEDIA(mediaId, mediaTypeId, url, postId)
VALUES(media_seq.NEXTVAL, 90, '\documents\javaBits\',99);*/

COMMIT;

SELECT SUM(postId) AS postTotal
    FROM Post
    GROUP BY userId
    ORDER BY postTotal DESC; 
