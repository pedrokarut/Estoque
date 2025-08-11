CREATE TABLE IF NOT EXISTS usuarios(id SERIAL PRIMARY KEY, 
name TEXT NOT NULL, 
usr TEXT NOT NULL,
senha TEXT NOT NULL,
tstamp text);

select * from usuarios


CREATE TABLE IF NOT EXISTS produtos(
  id SERIAL PRIMARY KEY, 
  name TEXT NOT NULL, 
  value REAL, 
  litros integer, 
  cod_barras text, 
  custo real, 
  margem real,
  id_fornecedor INT NOT NULL,
  qtd INT NOT NULL);



CREATE TABLE IF NOT EXISTS vendas(id SERIAL PRIMARY KEY, 
id_usuario INT NOT NULL, 
id_cliente INT NOT NULL,
valor_total float NOT NULL,
forma_pagamento TEXT NOT NULL,
tstamp text,
obs text);


CREATE TABLE IF NOT EXISTS itens_vendas(id SERIAL PRIMARY KEY, 
id_venda INT NOT NULL,
id_usuario INT NOT NULL, 
id_cliente INT NOT NULL,
id_produto INT NOT NULL,
valor decimal NOT NULL,
quantidade INT NOT NULL,
tstamp text);


CREATE TABLE IF NOT EXISTS clientes(id SERIAL PRIMARY KEY, 
nome text NOT NULL,
endereco text, 
cnpj text,
incricao_estadual text,
telefone text,
tstamp text); 

CREATE TABLE IF NOT EXISTS fornecedores(id SERIAL PRIMARY KEY, 
nome text NOT NULL,
endereco text, 
cnpj text,
incricao_estadual text,
telefone text,
tstamp text); 


CREATE TABLE IF NOT EXISTS compra(id SERIAL PRIMARY KEY, 
id_prod INT NOT NULL,
if_fornecedor INT NOT NULL, 
qtd INT NOT NULL,
tstamp text); 


