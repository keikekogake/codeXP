-- create database ProjetoCidades

use ProjetoCidades

--create table Cidades (
--	id int identity,
--	nome varchar(255) not null,
--	estado char(2) not null,
--	habitantes int not null
--);

insert into Cidades (nome, estado, habitantes)
values  ('S�o Paulo', 'SP', 98734434),
		('Rio de Janeiro', 'RJ', 1273434),
		('Porto Alegre', 'RS', 213241),
		('Campinas', 'SP', 32213),
		('Vit�ria', 'ES', 32213)

select * from Cidades