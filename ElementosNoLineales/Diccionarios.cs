//ESTRUCTURA NO LINEAL DICCIONARIO
//cada clave es unica y tine un valor asociado
//No mantiene un orden especifico
//No tiene orden de insercion

//Creacion

Dictionary<string, int> edades = new Dictionary<string, int>();

//Agregar elementos 

edades.Add("Ana",25);
edades.Add("Juan", 30);
edades[Maria] = 30;

//Acceso

int edadAna = edades["Ana"];
Console.WriteLine(edadAna);

//Verificar la existencia d clave 

if (edades.ContainsKey("Carlos")) {
    Console.WriteLine("Carlos existe");
}

if (edades.ContainsValue(25)) {
    Console.WriteLine(" Alguien tiene 25 años");
}

//Intentar obtener valor 

if (edades.TryGetValue("Juan", out int edadJuan)) {
    Console.WriteLine($"Edad Juan {edadJuan}");

}


//Recorrer diccionario

foreach (KeyValuePair <string,int> kvp in edades) {
    Cnsole.WriteLine($"{kvp.Key}, {kvp.Value}");
}

foreach (string nombre in edades.Keys) {
    Cnsole.WriteLine(nombre);
}

foreach (int edad in edades.Vlues) {
    Cnsole.WriteLine(edad);
}


//Eliminar 

