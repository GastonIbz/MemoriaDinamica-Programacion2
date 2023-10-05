using System.Collections;
#region Contacto, colas #073

// Declaración de una cola para almacenar las cadenas de texto ingresadas por el usuario.
Queue<string> cadenaQ = new Queue<string>();


Console.WriteLine("A continuación, ingrese cadenas de texto que desea guardar y luego presione Enter después de cada una:");
while (true)
{
    // Solicitud al usuario.
    Console.Write("Ingresar Cadena: ");
    string cadena = Console.ReadLine();

    // ISNOTNULLOREMPTY: Valida y comprueba si el usuario ingresó una cadena vacía o nula.
    if (string.IsNullOrEmpty(cadena))
    {
        break; // El break aparece cuando el usuario ingresa una cadena vacía o nula, haciendo que se salga del bucle y se muestren las cadenas guardadas hasta el momento.
    }

    // Guarda la cadena ingresada en la cola.
    cadenaQ.Enqueue(cadena);
}

// Muestra las cadenas almacenas e ingresadas.
Console.WriteLine("Cadenas Ingresadas: ");
while (cadenaQ.Count > 0)
{
    string cadena = cadenaQ.Dequeue();
    Console.WriteLine(cadena);

}
Console.WriteLine("El programa ha llegado a su fin.");
#endregion