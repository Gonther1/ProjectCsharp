using System.Collections;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        // Para recorrer listas
        // int[] numeros= {1,2,3,4,5,6,};
        // int number;
        // number=4;
        // foreach(int i in numeros){
        //     Console.WriteLine($"Tengo {i*number} años");
        // }
        //Exercise Tabla de multiplicar
        // Console.Write("Por favor, ingresa un numero: ");
        // string input = Console.ReadLine();

        // if (int.TryParse(input, out int numero))
        // {
        //     for (int i = 1; i < 11;i++) {
        //         Console.WriteLine($"{numero} x {i} = {numero*i}");
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("No ingresaste un numero valido");
        // }
        // Exercise Tabla #2 multiplicacion
        // int number;
        // Console.Write("Por favor, ingresa un numero: ");
        // string hola = Console.ReadLine();
        // number=Convert.ToInt32(hola);
        // for (int i = 1; i < 11;i++) {
        //     Console.WriteLine($"{number} x {i} = {number*i}");
        // }
        // ArrayList
        // ArrayList myAL = new ArrayList();
        // myAL.Add("The");
        // myAL.Add("quick");
        // myAL.Add("brown");
        // myAL.Add("fox");
        // foreach (Object n in myAL) {
        //     Console.WriteLine(n.ToString());
        // }
        // Method AddRange this method insert the elements in to the array
        // ArrayList Carnivores = new ArrayList();
        // ArrayList Aquatics = new ArrayList();
        // ArrayList Animals = new ArrayList();
        // Carnivores.Add("Tigre");
        // Carnivores.Add("Leon");
        // Carnivores.Add("Pantera");
        // Carnivores.Add("Leopardo");
        // Aquatics.Add("Tiburon");
        // Aquatics.Add("Delfin");
        // Aquatics.Add("Ballena");
        // Aquatics.Add("Pulpo");
        // Animals.AddRange(Carnivores);
        // foreach (Object n in Animals)
        // {
        //     Console.WriteLine(n.ToString());
        // }
        // Console.WriteLine("---------------------------------");
        // Animals.AddRange(Aquatics);
        // foreach (Object n in Animals)
        // {
        //     Console.WriteLine(n.ToString());
        // }
        // Console.WriteLine("Presione enter para continuar");
        // Console.ReadLine();

        // Study subjects

        // string ? word;
        // ArrayList subjects = new ArrayList();
        // subjects.Add("calculo");
        // subjects.Add("español");
        // subjects.Add("sociales");
        // subjects.Add("ingles");
        // Console.WriteLine("Escriba una materia a buscar: ");
        // word=Console.ReadLine().ToLower();
        // Console.WriteLine(subjects.IndexOf(word));
        
        // string ? word;
        // int idx;
        // ArrayList subjects = new ArrayList();
        // subjects.Add("calculo");
        // subjects.Add("español");
        // subjects.Add("sociales");
        // subjects.Add("ingles");
        // do {
        //     Console.WriteLine("Ingrese la posicion donde desea insertar la Asignatura: ");
        //     idx=Convert.ToInt32(Console.ReadLine());
        // } while (idx > subjects.Count);

        // Console.WriteLine("Escriba una materia a insertar: ");
        // word=Console.ReadLine();

        // subjects.Insert(idx,word);

        // foreach (Object materia in subjects)
        // {
        //    Console.WriteLine(materia.ToString()); 
        // }
        // An attempt to insert an array in to ArrayList
        // ArrayList myArrayList = new ArrayList();
        // int[] numbers= {9,5};
        // myArrayList.Add(numbers);
        // myArrayList.Add("Hola");
        // Console.WriteLine(myArrayList[0]);
        // Console.WriteLine(myArrayList[1]);

        // ¿?
        ArrayList subjects=new ArrayList();

        subjects.Add("calculo");
        subjects.Add("español");
        subjects.Add("sociales");
        subjects.Add("ingles");

        String[] myArray = (String[]) subjects.ToArray(typeof(string));

        foreach (String mySubject in myArray)
        {
            Console.WriteLine(mySubject);
        }

        
    }
}