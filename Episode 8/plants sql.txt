use plants;

create table users(
user_id int(11) Primary key,
username varchar(255),
password varchar(255),
name varchar(255),
email varchar(255),
profile_picture varchar(255)
);

create table plants(
plant_id int(11) primary key,
name varchar(255),
type varchar(255),
care_instructions text,
image varchar(255),
purchase_date datetime,
purchase_location varchar(255),
user_id int(11),
foreign key(user_id) references users(user_id)
);

create table categories(
 category_id int(11) primary key,
 name varchar(255)
);

create table fertilizings(
fertilizing_id int(11) primary key,
plant_id int(11),
date datetime,
time timestamp,
foreign key(plant_id) references plants(plant_id)
); 

create table waterings(
watering_id int(11) Primary key,
plant_id int(11),
date datetime,
time timestamp,
foreign key(plant_id) references plants(plant_id)	
);



create table plants_categories(
plant_id int,
category_id int,
Primary key(plant_id,  category_id),
foreign key(plant_id) references plants(plant_id),
foreign key(category_id) references categories(category_id)
);


create table reminders(
reminder_id int(11) primary key,
plant_id int(11),
date datetime,
time timestamp,
foreign key(plant_id) references plants(plant_id)
);

