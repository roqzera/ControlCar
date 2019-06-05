create database controlcar;
use controlcar;

CREATE TABLE `acompanhante` (
  `id_acompanhante` int(11) NOT NULL AUTO_INCREMENT,
  `acompanhante1` varchar(100) DEFAULT NULL,
  `acompanhante2` varchar(100) DEFAULT NULL,
  `acompanhante3` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_acompanhante`)
);

CREATE TABLE `veiculo` (
  `id_veiculo` int(11) NOT NULL AUTO_INCREMENT,
  `placa` varchar(45) NOT NULL,
  `numero_renavam` varchar(45) NOT NULL,
  `marca` varchar(45) NOT NULL,
  `modelo` varchar(45) NOT NULL,
  `motor` varchar(45) NOT NULL,
  `cor` varchar(45) NOT NULL,
  `ano` varchar(45) NOT NULL,
  `quilometragem` decimal(10,2) NOT NULL,
  `tipoveiculo` varchar(45) NOT NULL,
  `status` varchar(45) not null,
  PRIMARY KEY (`id_veiculo`),
  UNIQUE KEY `placa_UNIQUE` (`placa`),
  UNIQUE KEY `numero_renavam_UNIQUE` (`numero_renavam`)
);

CREATE TABLE `funcionario` (
  `id_funcionario` int(11) NOT NULL AUTO_INCREMENT,
  `matricula` varchar(45) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `cpf` varchar(45) NOT NULL,
  `data_nascimento` datetime NOT NULL,
  `telefone` varchar(45) NOT NULL,
  `cargo` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `numero_cnh` varchar(45) DEFAULT NULL,
  `categoria_cnh` varchar(45) DEFAULT NULL,
  `validade_cnh` datetime DEFAULT NULL,
  `motorista` varchar(45) DEFAULT NULL,
  `status` varchar(45) not null,
  PRIMARY KEY (`id_funcionario`),
  UNIQUE KEY `matricula_UNIQUE` (`matricula`),
  UNIQUE KEY `cpf_UNIQUE` (`cpf`)
);

CREATE TABLE `viagem` (
  `id_viagem` int(11) NOT NULL AUTO_INCREMENT,
  `data_saida` datetime NOT NULL,
  `data_retorno` datetime NOT NULL,
  `destino` varchar(100) NOT NULL,
  `valor_adiantamento` decimal(6,2) NOT NULL,
  `km_inicial` decimal(10,2) NOT NULL,
  `km_final` decimal(10,2) NOT NULL,
  `id_veiculo` int(11) NOT NULL,
  `id_funcionario` int(11) NOT NULL,
  `id_acompanhante` int(11) NOT NULL,
  PRIMARY KEY (`id_viagem`),
  KEY `fk_viagemfuncionario` (`id_funcionario`),
  KEY `fk_viagemveiculo` (`id_veiculo`),
  KEY `fk_viagemacompanhante` (`id_acompanhante`),
  CONSTRAINT `fk_viagemacompanhante` FOREIGN KEY (`id_acompanhante`) REFERENCES `acompanhante` (`id_acompanhante`),
  CONSTRAINT `fk_viagemfuncionario` FOREIGN KEY (`id_funcionario`) REFERENCES `funcionario` (`id_funcionario`),
  CONSTRAINT `fk_viagemveiculo` FOREIGN KEY (`id_veiculo`) REFERENCES `veiculo` (`id_veiculo`)
);

CREATE TABLE `multa` (
  `id_multa` int(11) NOT NULL AUTO_INCREMENT,
  `numero_infracao` varchar(45) NOT NULL,
  `valor` decimal(6,2) NOT NULL,
  `data_multa` datetime NOT NULL,
  `id_funcionario` int(11) NOT NULL,
  `id_veiculo` int(11) NOT NULL,
  `controle_multa` int(11) DEFAULT '1',
  PRIMARY KEY (`id_multa`),
  KEY `fk_multafuncionario` (`id_funcionario`),
  KEY `fk_multaveiculo` (`id_veiculo`),
  CONSTRAINT `fk_multafuncionario` FOREIGN KEY (`id_funcionario`) REFERENCES `funcionario` (`id_funcionario`),
  CONSTRAINT `fk_multaveiculo` FOREIGN KEY (`id_veiculo`) REFERENCES `veiculo` (`id_veiculo`)
);

CREATE TABLE `seguros` (
  `id_seguro` int(11) NOT NULL AUTO_INCREMENT,
  `data_inicio` datetime NOT NULL,
  `data_vencimento` datetime NOT NULL,
  `valor` decimal(8,2) NOT NULL,
  `seguradora` varchar(45) NOT NULL,
  `id_veiculo` int(11) NOT NULL,
  PRIMARY KEY (`id_veiculo`),
  KEY (`id_seguro`),
  KEY `fk_seguroveiculo` (`id_veiculo`),
  CONSTRAINT `fk_seguroveiculo` FOREIGN KEY (`id_veiculo`) REFERENCES `veiculo` (`id_veiculo`)
);

CREATE TABLE `custo` (
  `id_custo` int(11) NOT NULL AUTO_INCREMENT,
  `custo_abastecimento` decimal(6,2) DEFAULT NULL,
  `custo_pedagio` decimal(6,2) DEFAULT NULL,
  `custo_estacionamento` decimal(6,2) DEFAULT NULL,
  `custo_veiculo` decimal(6,2) default null,
  `id_viagem` int(11) NOT NULL,
  PRIMARY KEY (`id_custo`),
  UNIQUE KEY `id_viagem_unique` (`id_viagem`),
  KEY `fk_custoviagem` (`id_viagem`),
  CONSTRAINT `fk_custoviagem` FOREIGN KEY (`id_viagem`) REFERENCES `viagem` (`id_viagem`)
);

CREATE TABLE `manutencao` (
  `id_manutencao` int(11) NOT NULL AUTO_INCREMENT,
  `placa` varchar(45) NOT NULL,
  `tipo` varchar(45) NOT NULL,
  `valor` decimal(8,2) NOT NULL,
  `local` varchar(100) NOT NULL, 
  `descricao` mediumtext NOT NULL,
  `data` datetime NOT NULL,
  `quilometragem` decimal(10,2) NOT NULL,
  `id_veiculo` int NOT NULL,
  PRIMARY KEY (`id_manutencao`),
  KEY `fk_manutencaoveiculo` (`id_veiculo`),
  CONSTRAINT `manutencaoveiculo` FOREIGN KEY (`id_veiculo`) REFERENCES `veiculo` (`id_veiculo`)
);
