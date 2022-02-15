CREATE DATABASE IF NOT EXISTS Skate;

USE Skate;

CREATE TABLE IF NOT EXISTS Skaters (
	id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	name varchar(255),
	brand varchar(255)
);

INSERT IGNORE INTO Skaters
	(id, name, brand)
VALUES
	(1, "Luan Oliveira", "Flip"),
	(2, "Paul Rodriguez", "Primitive"),
	(3, "Tony Hawk", "Bird");