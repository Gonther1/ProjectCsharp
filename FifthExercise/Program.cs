 using FifthExercise.Entities;

 internal class Program
 {
     private static void Main(string[] args)
     {
         Dictionary<int, List<string>> myDict = new Dictionary<int, List<string>>();
         List<string> myList = new List<string>();
         int AddEstudiante = 0;
         int Flag=0;
         do {
             Estudiante estudiante= new Estudiante();
             estudiante.Id=Guid.NewGuid().ToString();
             Console.WriteLine("Ingrese su nombre: ");
             estudiante.Nombre=Console.ReadLine();
             myList.Add(estudiante.Id);
             myList.Add(estudiante.Nombre);
             myDict.Add(Flag,)
              Console.WriteLine("Ingrese su email: ");
              estudiante.Email=Console.ReadLine();
              Console.WriteLine("Ingrese su edad: ");
              estudiante.Edad=int.Parse(Console.ReadLine());
             Console.Clear();
             Console.WriteLine("Desea agregar otro estudiante?: ");
             AddEstudiante=int.Parse(Console.ReadLine());
              Console.WriteLine(Guid.NewGuid().ToString());
              Console.WriteLine("{0,10} {1,40}","Cod. Estudiante","Nombre Estudiante");
              Console.WriteLine("{0,-20} {1,13}",list[First+=2],list[Second+=2]);
         } while (AddEstudiante==0);
     }
 }