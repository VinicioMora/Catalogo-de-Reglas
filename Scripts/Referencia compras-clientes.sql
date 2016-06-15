SELECT * from proyecto2.compras where not exists (
SELECT IDCLIENTE from proyecto2.clientes)