SELECT * FROM proyecto2.cantones
where CodProv=1 and CodCan not Between 1 and 20
or CodProv=2 and CodCan not Between 1 and 15
or CodProv=3 and CodCan not Between 1 and 8
or CodProv=4 and CodCan not Between 1 and 10
or CodProv=5 and CodCan not Between 1 and 11
or CodProv=6 and CodCan not Between 1 and 11
or CodProv=7 and CodCan not Between 1 and 6;