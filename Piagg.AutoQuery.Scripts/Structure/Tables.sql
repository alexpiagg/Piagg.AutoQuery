/*DATABASE*/
CREATE DATABASE /*!32312 IF NOT EXISTS*/`dados` /*!40100 DEFAULT CHARACTER SET utf8 */;

/*TABLES*/

CREATE TABLE IF NOT EXISTS "gastos" (
  "id_gastos" int(11) NOT NULL AUTO_INCREMENT,
  "data" date NOT NULL,
  "local" varchar(100) NOT NULL,
  "valor" decimal(15,4) DEFAULT NULL,
  "id_tipo_gastos" int(11) DEFAULT NULL,
  PRIMARY KEY ("id_gastos"),
  KEY "FK_GASTOS_TIPO_GASTOS" ("id_tipo_gastos"),
  CONSTRAINT "FK_GASTOS_TIPO_GASTOS" FOREIGN KEY ("id_tipo_gastos") REFERENCES "tipo_gastos" ("ID_TIPO_GASTOS")
);

CREATE TABLE IF NOT EXISTS tipo_gastos (
  id_tipo_gastos int(11) NOT NULL AUTO_INCREMENT,
  tipo varchar(20) NOT NULL,
  excluido int(1) DEFAULT NULL,
  PRIMARY KEY (id_tipo_gastos)
);

/*****************************************************************************************************/
/*CONSTRAINTS*/

ALTER TABLE gastos
ADD CONSTRAINT FK_GASTOS_TIPO_GASTOS 
FOREIGN KEY (id_tipo_gastos) 
REFERENCES tipo_gastos (id_tipo_gastos)