CREATE OR REPLACE VIEW viewPosts AS
SELECT p.postid, p.parentid, p.postdate, p.posttext, u.firstname, u.surname, t.posttypedesc, c.categoryname, m.url
FROM ITTUSER u, POST p, media m, category c, posttype t
WHERE p.userid = u.userid AND
      m.mediaid = p.postid AND
       p.categoryid = c.Categoryid AND
       p.posttypeid = t.posttypeid
ORDER BY p.postid DESC;

SELECT * FROM viewPosts;