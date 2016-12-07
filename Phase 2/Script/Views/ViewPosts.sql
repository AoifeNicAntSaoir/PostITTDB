CREATE OR REPLACE VIEW viewPosts
AS SELECT p.postid, p.parentid, p.postdate, p.posttext, u.firstname, u.surname, t.posttypedesc, c.categoryname, m.url, r.postrank
FROM post p, ittuser u, posttype t, category c, media m, rank r
where p.postid = r.postid and
      p.postid = m.mediaid and
      c.categoryid = p.categoryid and
      c.categoryname = (select categoryname from category where categoryid = c.categoryid) and
      t.posttypeid = p.posttypeid and
      u.userid = p.userid and 
      u.userid = r.userid;

SELECT * FROM viewPosts;