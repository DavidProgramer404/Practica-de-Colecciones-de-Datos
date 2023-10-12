Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine("TRES MATRICES BASICAS!");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");

Console.WriteLine("*******************************************************************************************************************");
Console.WriteLine("Crea una matriz para contener los valores enteros 0 a 9");
Console.WriteLine("*******************************************************************************************************************");

int[] numeros = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

Console.WriteLine("*******************************************************************************************************************");
Console.WriteLine("Crea una matriz con los nombres Tim, Martin, Nikki y Sara");
Console.WriteLine("*******************************************************************************************************************");

string[] nombres = new string[] { "Tim", "Martin", "Nikki", "Sara" };

foreach (string nombre in nombres)
{
    Console.WriteLine(nombre);
}

Console.WriteLine("*******************************************************************************************************************");
Console.WriteLine("Crea una matriz de longitud 10 que alterne entre valores verdadero y falso, empezando por verdadero");
Console.WriteLine("*******************************************************************************************************************");

bool[] alternar = new bool[10];
for (int i = 0; i < 10; i++)
{
    alternar[i] = i % 2 == 0;
}

foreach (bool valor in alternar)
{
    Console.WriteLine(valor);
}

Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine("LISTAS DE SABORES!");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");

Console.WriteLine("*******************************************************************************************************************");
Console.WriteLine("Crea una lista de sabores de helados que contenga al menos 5 sabores diferentes (¡no dudes en añadir más de 5!).");
Console.WriteLine("*******************************************************************************************************************");

List<string> saboresDeHelado = new List<string>{
"Chocolate","Mango","Durazno","Menta","Pistacho","Manjar","Frutilla","Maracuya","Vainilla","Tres Leches"
};

foreach (string sabor in saboresDeHelado)
{
    Console.WriteLine(sabor);
}

Console.WriteLine("*******************************************************************************************************************");
Console.WriteLine("Imprime la longitud de esta lista después de construirla.");
Console.WriteLine("*******************************************************************************************************************");

List<string> saboresDeHeladoL = new List<string>{
"Chocolate","Mango","Durazno","Menta","Pistacho","Manjar","Frutilla","Maracuya","Vainilla","Tres Leches"
};
Console.WriteLine("La longitud de la lista es: " + saboresDeHeladoL.Count);

Console.WriteLine("*******************************************************************************************************************");
Console.WriteLine("Imprime el tercer sabor de la lista y luego elimina ese valor.");
Console.WriteLine("*******************************************************************************************************************");

List<string> saboresDeHeladoRemove = new List<string>{
"Chocolate(0)","Mango(1)","Durazno(2)","Menta(3)","Pistacho(4)","Manjar(5)","Frutilla(6)","Maracuya(7)","Vainilla(8)","Tres Leches(9)"
};
//Seleccionare el tercer sabor de la lista
Console.WriteLine("El sabor eliminado es:" + saboresDeHeladoRemove[2]);

//Eliminare el sabor de la lisata.
saboresDeHeladoRemove.RemoveAt(2);

//Imprimir al lista actualizada

foreach (string sabor in saboresDeHeladoRemove)
{
    Console.WriteLine(sabor);
}

Console.WriteLine("******************************");
Console.WriteLine("Obtener nueva longitud.");
Console.WriteLine("******************************");

Console.WriteLine("La nueva longitud de la lista es : " + saboresDeHeladoRemove.Count);

Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine("DICCIONARIO DE INFORMACION DEL USUARIO!");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");


Console.WriteLine("**************************************************************************************");
Console.WriteLine("Crea un diccionario que almacene tanto claves de cadena como valores de cadena.");
Console.WriteLine("**************************************************************************************");

Dictionary<string, string> miDiccionario = new Dictionary<string, string>();

//Agregar elementos
miDiccionario.Add("Dave", "Chocolate");
miDiccionario.Add("Alex", "Mango");
miDiccionario.Add("Mark", "Pistacho");
miDiccionario.Add("Erina", "Tres leche");

//acceder a los elementos
string saborKey1 = miDiccionario["Dave"];
string saborKey2 = miDiccionario["Erina"];

//Se imprime valores
Console.WriteLine("Dave selecciono: " + saborKey1);
Console.WriteLine("Erina selecciono: " + saborKey2);


Console.WriteLine("********************************************************************************************************************************************************************************");
Console.WriteLine("Añade pares clave/valor a este diccionario donde​ cada clave sea un nombre de la matriz de nombres cada valor sea un sabor seleccionado al azar de tu lista de sabores");
Console.WriteLine("********************************************************************************************************************************************************************************");

string[] nombresDeMatrices = new string[] { "Dave", "Erina", "Alex" };

Random rand = new Random();
Dictionary<string, string> matrizSabores = new Dictionary<string, string>();

foreach (string nombreMatriz in nombresDeMatrices)
{
    int indiceSabor = rand.Next(saboresDeHelado.Count);
    string saborSeleccionado = saboresDeHelado[indiceSabor];
    matrizSabores[nombreMatriz] = saborSeleccionado;
}

// Imprimir los pares clave/valor
foreach (var par in matrizSabores)
{
    Console.WriteLine($"Nombre de la Matriz: {par.Key}, Sabor: {par.Value}");
}
//impirmir casa usuario y su helado 
foreach (var par in matrizSabores)
{
    Console.WriteLine($"Nombre de Usuario: {par.Key}, Sabor de Helado: {par.Value}");
}
