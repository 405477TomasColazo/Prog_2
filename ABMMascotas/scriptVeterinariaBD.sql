select codigo, nombre, nombreEspecie
from Mascotas m join Especies e
on m.especie = e.idEspecie