/*TABLES*/

CREATE TABLE gastos (
  id_gastos int(11) NOT NULL AUTO_INCREMENT,
  data date NOT NULL,
  local varchar(100) NOT NULL,
  valor decimal(15,4) DEFAULT NULL,
  id_tipo_gastos int(11) DEFAULT NULL,
  PRIMARY KEY (id_gastos),
  KEY FK_GASTOS_TIPO_GASTOS (id_tipo_gastos),  
) ENGINE=InnoDB AUTO_INCREMENT=7531 DEFAULT CHARSET=utf8;

CREATE TABLE tipo_gastos (
  id_tipo_gastos int(11) NOT NULL AUTO_INCREMENT,
  tipo varchar(20) NOT NULL,
  excluido tinyint(1) DEFAULT NULL,
  PRIMARY KEY (id_tipo_gastos)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

/*****************************************************************************************************/
/*CONSTRAINTS*/

ALTER TABLE gastos
ADD CONSTRAINT FK_GASTOS_TIPO_GASTOS 
FOREIGN KEY (id_tipo_gastos) 
REFERENCES tipo_gastos (id_tipo_gastos)