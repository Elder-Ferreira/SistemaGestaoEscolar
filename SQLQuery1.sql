CREATE DATABASE escola

USE escola

CREATE TABLE usuario (
	id_usuario VARCHAR(5) not null,
	nome_usuario VARCHAR(20) not null,
	senha VARCHAR(10) not null,
	id_tipo VARCHAR (15) not null,
)

INSERT INTO usuario VALUES ('00001', 'admin', 'admin', 'Administrador')

CREATE TABLE tipo (
	id_tipo VARCHAR(5) not null,
	nome_tipo VARCHAR(20) not null,
)

INSERT INTO tipo VALUES ('T0001','Administrador')

