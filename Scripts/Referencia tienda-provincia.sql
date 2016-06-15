SELECT * from proyecto2.tiendas where not exists (
SELECT CodProv from proyecto2.provincias)