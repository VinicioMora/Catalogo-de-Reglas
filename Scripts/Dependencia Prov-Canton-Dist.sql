SELECT * FROM proyecto2.distritos
where CodProv=6 and CodCan= 1 and CodDis not Between 1 and 16
or CodProv=6 and CodCan= 2 and CodDis not Between 1 and 5
or CodProv=6 and CodCan= 3 and CodDis not Between 1 and 8;
