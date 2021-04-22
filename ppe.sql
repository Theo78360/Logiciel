Drop database if exists ppe;
Create database ppe;
Use ppe;

Create table user (
    idu int(11) not null auto_increment,
    login varchar(10),
    mdp varchar(255),
    primary key (idu)
) ;


