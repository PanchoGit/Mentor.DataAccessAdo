CREATE DATABASE IF NOT EXISTS Skate;

USE Skate;

CREATE TABLE IF NOT EXISTS Skaters (
	id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	name varchar(255),
	branch varchar(255)
);
