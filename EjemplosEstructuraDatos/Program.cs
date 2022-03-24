using EjemplosEstructuraDatos;

List<Alumno> lista = new List<Alumno>();

// Alumno 1 //
Alumno a1 = new Alumno();
a1.Nombres = "Roberto";
a1.ApellidoPaterno = "Martinez";
a1.Matricula = "300";
a1.FechaNacimiento = DateTime.Now;
// Alumno 2 //
Alumno a2 = new Alumno();
a2.Nombres = "Pedro";
a2.ApellidoPaterno = "Aguilar";
a2.Matricula = "301";
a2.FechaNacimiento = new DateTime(1980,02,28);
// Alumno 3 //
Alumno a3 = new Alumno();
a3.Nombres = "Sebastian";
a3.ApellidoPaterno = "Tanori";
a3.Matricula = "302";
a3.FechaNacimiento = new DateTime(2003, 09, 01);

lista.Add(a1);
lista.Add(a2);
lista.Add(a3);


foreach (Alumno alumnoEnLista in lista) 
{
    Console.WriteLine(
        " Nombre: "
        + alumnoEnLista.NombreCompleto 
        + " Matricula: " 
        + alumnoEnLista.Matricula 
        + " fecha nacimiento: " 
        + alumnoEnLista.FechaNacimiento.ToString("dd-MM-yyyy"));
}