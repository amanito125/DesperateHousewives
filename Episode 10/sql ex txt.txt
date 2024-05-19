SELECT user_id, username, balance FROM `users` WHERE city_id = 2 ORDER BY balance desc LIMIT 1;



SELECT COUNT(r.rent_id) AS total_rents, c.name AS name FROM rents AS r
 INNER JOIN users AS u ON u.user_id = r.user_id 
 INNER JOIN cities AS c ON u.city_id=c.city_id 
 GROUP BY c.city_id ORDER BY total_rents desc, r.rent_id desc limit 10;




SELECT COUNT(rent_id) AS total_rents, users.username FROM rents

INNER JOIN users on  rents.user_id = users.user_id

GROUP BY rents.user_id

ORDER BY total_rents desc, username ASC

LIMIT 5;