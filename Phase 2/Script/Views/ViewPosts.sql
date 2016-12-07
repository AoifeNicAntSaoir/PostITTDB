CREATE OR REPLACE VIEW viewPosts AS
SELECT unique p.postid, p.parentid, r.postrank, p.postdate, p.posttext, u.firstname, u.surname, t.posttypedesc,c.categoryname, m.url 
FROM ITTUSER u, POST p, media m, category c, posttype t, rank r
WHERE p.postid = r.postid and
p.categoryid = c.categoryid AND
      p.posttypeid = t.posttypeid AND
      m.postid = p.postid
ORDER BY p.postid DESC;

SELECT * FROM viewPosts;