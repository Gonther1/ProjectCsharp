internal class Program
{
    private static void Main(string[] args)
    {
        /* 
        List <string> subjects = new List<string>();
        int idx = 0;
        subjects.Add("English");
        subjects.Add("Math");
        subjects.Add("Filosofy");
        subjects.Add("Spanish");
        ContarElementos(subjects);
        Console.WriteLine("Ingrese la posicion: ");
        idx=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("El elemento en la posicion {0} es: {1}",idx,ObtenerElemento(idx,subjects));
        subjects.Add(AddItemData());
        Console.WriteLine(string.Join(",", subjects));
        Console.WriteLine("Ingrese la palabra a buscar: ");
        if (ValidarItem(subjects,Console.ReadLine().ToLower())) {
            Console.WriteLine("Encontrado :D");
        }
        else 
        {
            Console.WriteLine("No encontrado :()");
        } 
        */
        String ? palabra=null;
        List<String>Dinosaurios=new List<string>();
        string[] Dinos = {
            "PrimerDino",
            "SegundoDino",
            "TercerDino"
        };
        Dinosaurios.AddRange(Dinos);
        Console.WriteLine("Ingrese el nombre del dinosaurio a buscar: ");
        palabra=Console.ReadLine();
        string ? nombre = Dinosaurios.Find(n=> n.StartsWith(palabra ?? String.Empty));
        Console.WriteLine(nombre != null ? "Se encotro el dino": "No se encontro el dino");
    }
    public static void ContarElementos(List<string> lista) {
        Console.WriteLine("Todos los elementos de la lista :{0}",lista.Count());
    }
    public static string AddItemData() {
        Console.WriteLine("Ingrese el titulo del elemento: ");
        return Console.ReadLine();
    }    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="idx">Indice de la materia a mostrar</param>
    /// <param name="lista">Lista con las respectivas materias</param>
    /// <returns></returns>
    public static string ObtenerElemento(int idx,List<string> lista) {
        return lista[idx];
    }
    public static bool ValidarItem(List<string> lista,string valor) {
        return lista.Exists(l => l.ToLower().Equals(valor));
    }
}