DROP DATABASE IF EXISTS `sistemaMercado`;

CREATE DATABASE `sistemaMercado` CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

USE `sistema_mercado`;

CREATE TABLE `usuarios` (
	`id_usuario` INT NOT NULL AUTO_INCREMENT,
	`login_usuario` VARCHAR(100) NOT NULL,
	`senha_usuario` VARCHAR(100) NOT NULL,
	`nome_usuario` VARCHAR(100) NULL,
	PRIMARY KEY (`id_usuario`),
	UNIQUE INDEX `login_usuario` (`login_usuario`)
)
COLLATE='utf8mb4_unicode_ci';

CREATE TABLE tb_produto (
	id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255),
    quantidade INT,
    preco DECIMAL(10,2),
    imagem MEDIUMBLOB
);