using Escuela;

using (var db = new EscuelaContext())
{
  //borramos de la tabla Alumnos el registro con Id=3
  var alumnoBorrar = db.Alumnos.Where(a => a.Id == 3).SingleOrDefault();
  if (alumnoBorrar != null)
  {
      db.Remove(alumnoBorrar); //se borra realmente con el db.SaveChanges()
  }

  //La nota en Inglés del alumno id=1 es un 5. La cambiamos a 7.5
  var examenModificar = db.Examenes.Where(
                           e => e.AlumnoId == 1 && e.Materia == "Inglés").SingleOrDefault();
  if (examenModificar != null)
  {
      examenModificar.Nota = 7.5; //se modifica el registro en memoria
  }

  db.SaveChanges(); //actualiza la base de datos.

}