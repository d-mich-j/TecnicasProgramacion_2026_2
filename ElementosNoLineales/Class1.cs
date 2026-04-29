//ARBOL

//N NODOS
//N-1 ARISTAS 
//lONGITUD - Ruta de la cantidad de aristas que contiene

//Arbol binario (2 nodos como maximo de hijos)

//-Datos Nombre de persona
//-Hijos izquierdos : primer hijo
//Hijo derecho: segundo hijo

//Recorrer arbol 
//pREORDEN (pADRE --> HIJO IZQUIERDO --> HIJO DERECHO)
//INORDEN (hIJO IZQUIERDO --> PADRE -->HIJO DERECHO)
//POSTORDEN (HIJO IZQUIERDO --< hIJO DERECHO --> PADRE)

//CLASE PARA CREAR NODO EN EL ARBOL

public class NodoArbol 
 {
    public string Nombre { get; set; }
    public NodoArbol HijoIzquierdo { get; set; }
    public NodoArbol HijoDerecho { get; set; }



}


