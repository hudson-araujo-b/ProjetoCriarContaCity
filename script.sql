create database if not exists dbCriarConta;

use dbCriarConta;

create table if not exists tbUsuario(
Id int primary key auto_increment,
Email varchar(50) not null,
Senha varchar(250) not null,
Nome varchar(50) not null
);

select * from tbUsuario;