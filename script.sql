create database if not exists dbCriarConta;

use dbCriarConta;

create table if not exists tbUsuario(
Id int primary key auto_increment,
Nome varchar(50) not null,
Email varchar(50) not null,
Senha varchar(250) not null
);

select * from tbUsuario;