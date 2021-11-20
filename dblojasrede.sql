-- Banco de dados: `dblojasrede`

CREATE DATABASE `dblojasrede`;


CREATE TABLE IF NOT EXISTS `dblojasrede`.`cadastrodeproduto` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nproduto` varchar(45) NOT NULL,
  `quantcomprada` double NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;



INSERT INTO `dblojasrede`.`cadastrodeproduto` (`id`, `nproduto`, `quantcomprada`) VALUES
(1, 'creme', 5);



CREATE TABLE IF NOT EXISTS `dblojasrede`.`login` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `palavrachave` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;



INSERT INTO `dblojasrede`.`login` (`id`, `nome`, `palavrachave`) VALUES
(1, 'lucas', 'key');
