Use wholesale;
create table `Users`
(
`id` int not null auto_increment,
`names` varchar(50) not null,
`number_phone` int not null,
`password` varchar(50) not null,
primary key(`id`)
);
Select * from Users;