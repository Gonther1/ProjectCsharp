// See https://aka.ms/new-console-template for more information
// Arreglo - Lista fija
int[] listFixed= { 1, 2, 3, 4};
Console.WriteLine(string.Join(",",listFixed));
// Lista, se le puede cambiar el tamaño
List <string> strings = new List <string> {"1","Hola"};
Console.WriteLine(string.Join(",",strings));
strings.Add("xd"); // Metemos un dato para comprobar que si permita meter mas datos
Console.WriteLine(string.Join(",",strings));
// Array con datos mixtos con dynamic
dynamic[] listDynamic = {1,"Hola",true,1.86};
Console.WriteLine(string.Join(",",listDynamic)); // With this code line we print the array of a way more aestethic for can showing like an another modern languages
// Dictionary
Dictionary <int, string> myDictionary = new Dictionary <int, string>();
myDictionary.Add(17,"Luis Andres Alvarez Silva");
Console.WriteLine(myDictionary[17]);
// Dictionary with key string and value arrayString
Dictionary <string, string[]> valueList = new Dictionary <string, string[]>();
string[] emails = {"luisandresalvarezsilva@gmail.com"};
string[] foodFavorite = {"Pizza","HotDog","Chicken"};
valueList.Add("EmailAndres",emails);
valueList.Add("FoodFavorite",foodFavorite);
Console.WriteLine(valueList["EmailAndres"][0]);
Console.WriteLine(valueList["FoodFavorite"][2]);
