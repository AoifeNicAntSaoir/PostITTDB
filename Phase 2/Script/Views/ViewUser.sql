--VIEW USERS
CREATE OR REPLACE VIEW ViewUser
AS SELECT userId, firstName, surname, score
FROM IttUser
ORDER BY score DESC;
           
SELECT *
FROM ViewUser;

--VIEW POSTS
CREATE OR REPLACE VIEW ViewPosts
AS SELECT postId, postText, userId
FROM Post;
           
SELECT postId, postText, userId
FROM ViewPosts;

 


