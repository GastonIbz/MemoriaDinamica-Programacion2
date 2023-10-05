using System.Collections;
#region Contacto, colas #073

//// Declaración de una cola para almacenar las cadenas de texto ingresadas por el usuario.
//Queue<string> cadenaQ = new Queue<string>();


//Console.WriteLine("A continuación, ingrese cadenas de texto que desea guardar y luego presione Enter después de cada una:");
//while (true)
//{
//    // Solicitud al usuario.
//    Console.Write("Ingresar Cadena: ");
//    string cadena = Console.ReadLine();

//    // ISNOTNULLOREMPTY: Valida y comprueba si el usuario ingresó una cadena vacía o nula.
//    if (string.IsNullOrEmpty(cadena))
//    {
//        break; // El break aparece cuando el usuario ingresa una cadena vacía o nula, haciendo que se salga del bucle y se muestren las cadenas guardadas hasta el momento.
//    }

//    // Guarda la cadena ingresada en la cola.
//    cadenaQ.Enqueue(cadena);
//}

//// Muestra las cadenas almacenas e ingresadas.
//Console.WriteLine("Cadenas Ingresadas: ");
//while (cadenaQ.Count > 0)
//{
//    string cadena = cadenaQ.Dequeue();
//    Console.WriteLine(cadena);

//}
//Console.WriteLine("El programa ha llegado a su fin.");
#endregion

#region Pilas #074


//// Declaración de una pila para almacenar las cadenas de texto.
//Stack<string> pila = new Stack<string>();

//// Mensajes iniciales para el usuario.
//Console.WriteLine("A continuación, ingrese cadenas de texto que desea guardar.");
//Console.WriteLine("Luego presione Enter después de cada una.");
//Console.WriteLine("Para mostrar las cadenas en orden inverso, introduzca una cadena vacía.");
//Console.WriteLine("");

//while (true)
//{
//    Console.Write("Ingresar Cadena: ");
//    string datoPila = Console.ReadLine();

//    // ISNOTNULLOREMPTY: Valida y comprueba si el usuario ingresó una cadena vacía o nula.
//    if (string.IsNullOrEmpty(datoPila))
//    {
//        // Si se ingresa una cadena vacía o nula, llama a la función para mostrar las cadenas en orden inverso.
//        MostrarCadenasEnOrdenInverso(pila);
//        Console.WriteLine("El programa ha llegado a su fin.");
//        break;
//    }
//    else
//    {
//        // Almacena la cadena ingresada en la pila.
//        pila.Push(datoPila);
//    }
//}


//// Función para mostrar las cadenas en orden inverso.
//static void MostrarCadenasEnOrdenInverso(Stack<string> pila)
//{

//    Console.WriteLine("Cadenas ingresadas en orden inverso: ");

//    foreach (var dato in pila)
//    {
//        // Muestra las cadenas en orden inverso.
//        Console.WriteLine(dato);
//    }
//}


#endregion

#region ArrayList #075

//// Creamos un ArrayList para almacenar las cadenas de texto.
//ArrayList listArray = new ArrayList();


//while (true)
//{
//    Console.WriteLine("Introduzca una cadena de texto para guardar en la lista Array");
//    Console.WriteLine("o introduzca un texto vacio para ver lo que ha sido guardado.");
//    Console.WriteLine("");

//    string DatoArray = Console.ReadLine(); // Lee la entrada del usuario.
//    Console.WriteLine("");



//    if (string.IsNullOrEmpty(DatoArray))  // Verificar si la entrada del usuario (datoArray) está vacía o nula.
//    {
//        ConsultaArray(listArray); // Entra en el modo de consulta si el usuario ingresó una cadena vacía.
//    }
//    else
//    {
//        listArray.Add(DatoArray); // Agrega la cadena ingresada a la lista.
//    }
//}


//static void ConsultaArray(ArrayList listArray)
//{
//    while (true)
//    {
//        Console.WriteLine("¿Qué posición de la lista Array desea consultar? / Para salir del programa ingrese el número 0 : ");
//        Console.WriteLine("");

//        if (int.TryParse(Console.ReadLine(), out int pos))
//        {
//            if (pos == 0)
//            {
//                Environment.Exit(0);  // Al ingresar 0 se sale del programa en ejecución.
//            }
//            else if (pos >= 1 && pos <= listArray.Count) // Verifica si la posición ingresada por el usuario  está dentro del rango válido.
//            {
//                Console.WriteLine($"En posición {pos} se encuentra: {listArray[pos - 1]}");  // Muestra la cadena en la posición especifica.

//            }
//            else
//            {
//                Console.WriteLine("La posición se encuentra fuera de rango. A continuación, intente nuevamente: ");
//            }
//        }
//        else
//        {
//            Console.WriteLine("La entrada no es válida. A continuación, ingrese un número válido o ingrese 0 para salir.");
//        }
//    }
//}
#endregion