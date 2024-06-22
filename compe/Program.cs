using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {   
        


// crear una instancia de random
Random random = new Random();

// Repetir el carácter "-" 34 veces y almacenarlo en una cadena
string linea = string.Concat(new string('-', 182));
int contadorLineas = 0; // Variable para contar las líneas
int menu = 0;
int indice_agregar = 0;
//[ARRAYS]
string [] elemento_eleminado = new string[2];
int indice_eleminados = 0;
//[LISTAS]
// Declaramos la lista que obtendrá los nombres de los estudiantes
List<string> student_name = new List<string>() {
            "Adrian",
            "Bryant",
            "Derik",
            "Diego",
            "Drianny",
            "Evelyn",
            "Francisco",
            "Gabriel",
            "Isael",
            "Jennifer",
            "Jose",
            "Juan",
            "Kevin",
            "Lenin",
            "Lorenzi",
            "Luis",
            "Maria",
            "Nicolle",
            "Pablo",
            "Ramshley",
            "Tomas",
            "Triana",
            "Victor",
            "Wander",
            "Yeury",
            "Ysauri"
        };
// Declaramos la lista que obtendrá los nombres de los estudiantes que serán desarrolladores en vivo
List<string> student_developer = new List<string>();
// Declaramos la lista que obtendrá los nombres de los estudiantes que serán facilitadores de los ejercicios o mediadores
List<string> student_mediator = new List<string>();

// [ARCHIVOS]
// Crear ruta Archivos 
// primeros verificamos si ya no esta creado 
string rutaArchivo = @"C:\Users\User\OneDrive\Documentos\competancia.txt"; // @ para que no de error "\"
bool existe = File.Exists(rutaArchivo);



if (existe == false) {
    File.Create(rutaArchivo);
    
    //BIENVENIDAD
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow; // Imprime en amarillo
    Console.WriteLine("----[WELCOME USER]----");
    Console.ResetColor(); // Restaura el color original
}
else {
foreach (string leer in File.ReadLines(rutaArchivo))
{
    for (int i = 0; i < student_name.Count; i++)
    {
        // Verificamos si el nombre de estudiante está en la lista
        if (leer == student_name[i])
        {
            // Si está en la lista, lo eliminamos de la lista
            student_name.RemoveAt(i);
            // Decrementamos i para ajustar el índice después de eliminar un elemento
            i--;
        }
    }
}

        //BIENVENIDAD
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow; // Imprime en amarillo
        Console.WriteLine("----[WELCOME USER]----");
        Console.ResetColor(); // Restaura el color original
}

// [Menu entrada]
// tengo que declarar la variable menu fuera del try para que sea asesible al switch
// tengo que declarar las variables fueras de los ciclos si quiero usarlas fueras de ellos luego

// Do while para que se ejecute infinita veces hasta que se cumpla la condicion
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Deseas ver el menu [SI / NO] ");
Console.ResetColor(); // Restaura el color original

string mostrar_menu = Console.ReadLine()!.ToLower(); // Metodo Tolower de la clase string convertir todos los caracteres de una cadena a minúsculas. 

if (mostrar_menu == "si" ) { // si el usuario ingresa si el progama se ejecuta

do {
//[MENU]
// MENU DE CONSOLA
//Console.WriteLine("~~ MENU ~~");
 Console.Clear();
 Console.ForegroundColor = ConsoleColor.Magenta;
 Console.WriteLine(linea);
 Console.ForegroundColor = ConsoleColor.Yellow;
 Console.WriteLine("[OPCIONES]");
 Console.Write("[ 1 ]");
 Console.ForegroundColor = ConsoleColor.Magenta;
 Console.WriteLine(" SELECCIONAR PARTICCIPANTES");
 Console.ForegroundColor = ConsoleColor.Yellow;
 Console.Write("[ 2 ]");
 Console.ForegroundColor = ConsoleColor.Magenta;
 Console.WriteLine(" MOSTRAR PARTICIPANTES ");
 Console.ForegroundColor = ConsoleColor.Yellow;
 Console.Write("[ 3 ]");
 Console.ForegroundColor = ConsoleColor.Magenta;
 Console.WriteLine(" Eliminar");
 Console.ForegroundColor = ConsoleColor.Yellow;
 Console.ForegroundColor = ConsoleColor.Yellow;
 Console.Write("[ 4 ]");
 Console.ForegroundColor = ConsoleColor.Magenta;
 Console.WriteLine(" AGREGAR");
 Console.ForegroundColor = ConsoleColor.Yellow;
 Console.Write("[ 5 ]");
 Console.ForegroundColor = ConsoleColor.Magenta;
 Console.WriteLine(" FINALIZAR PROGRAMA");
 Console.WriteLine(linea);
 Console.ResetColor();

//manejo de error
 try {
  menu = Convert.ToByte(Console.ReadLine()); // controlo todo los errores posible que me puede generar ese codigo
 }
 catch (FormatException) {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("[ADVERTIENCIA]");
    Console.ResetColor();
    Console.WriteLine(linea);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("[Ingrese una opcion valida]");
    Console.ResetColor();
    Console.WriteLine(linea);

 }
// opciones a ejecutar 
 switch (menu)  {
    case 1 :
   
    Console.Clear();
   if(student_name.Count > 1){ // solo se ejecutara si los estudiantes es meyor a 1
    // nota: i siempre tienes que declararle el tipo de dato
    for ( int i = 0; i <= 1; i++) {

         // Generar un índice aleatorio solo si las listas están vacías
        int indice = random.Next(0, student_name.Count);
        // Acceder al elemento aleatorio en la lista usando el índice aleatorio generado
        string elementoAleatorio = student_name[indice];
    
        // como i solo puede obtener dos elemetos 0 y 1
        // eso me permite tener mas control ya que puede asignar que todos los 0  sean desarrollador
        // y todos los 1 o todo lo que sea diferente a 0 sera facilitador y como el for llega a 1 pues todo los 1 seran facilitador
        if ( i == 0 ) {
            student_name.Remove(elementoAleatorio);
            Console.WriteLine(linea);
            Console.WriteLine($" DESARROLLADOR EN VIVO ----> {elementoAleatorio} ");
            Console.WriteLine(linea);
            File.AppendAllLines(rutaArchivo, new List<string> { elementoAleatorio}); // el File.WriteAllLines suscribe en una lia ya existente
           
        }
        else if( i == 1) {
            student_name.Remove(elementoAleatorio);
            Console.WriteLine($" FACILITADOR DEL EJERCICIO ---->  {elementoAleatorio} ");
            Console.WriteLine(linea);
            File.AppendAllLines(rutaArchivo,  new List<string> { elementoAleatorio}); // para que agrege al final utilizamos el AppendAllLines

        }

        // Verificamos si aún quedan estudiantes por asignar
        if (student_name.Count == 0 ){    //SI NO QUEDQN ESTUDIANTES
        Console.WriteLine(linea);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("[EXCELENTE ESTUDIANTES YA HAN PARTICIPARON]");
        Console.ResetColor();
        Console.WriteLine(linea);
        break; // el break aqui impide que se genera una Exception cuando el programa genere un indice que esta fuera del rango
        }


        else if (student_name.Count == 1) {
            Console.WriteLine(linea);    // SI SOLO QUEDA UN ESTUDIANTE
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Falta por Participar: " + student_name[0]); 
            Console.ResetColor();
            Console.WriteLine(linea);
            break; // el break aqui impide que se genera una Exception cuando el programa genere un indice que esta fuera del rango
        }
    }

     // fuera del for por si se ejecuta despues de cerrar el codigo 

    }
    else if (student_name.Count <= 1 ){
            Console.WriteLine(linea);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Falta por Participar: " + student_name[0]); 
            Console.ResetColor();
            Console.WriteLine(linea);
    }
    else if (student_name.Count == 0 ){
        Console.WriteLine(linea);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("[EXCELENTE ESTUDIANTES YA HAN PARTICIPARON]");
        Console.ResetColor();
        Console.WriteLine(linea);
    }
     // continuar a menu o salir
     Console.ForegroundColor = ConsoleColor.Yellow;
     Console.WriteLine("Deseas ver el [menu] o [Salir] del programa?");
     Console.WriteLine("[1] Menu");
     Console.WriteLine("[2] Salir");
     Console.ResetColor();

     byte mostrar = Convert.ToByte(Console.ReadLine());
     if (mostrar == 1) { // El bucle  do while continuera su curso y se volvera a repetir el munu
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("[MENU]");
        Console.ResetColor();
     }
     else if (mostrar == 2 ){ // se detenra el curso del bucle do while
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("----[PROGRAMA CERRADO]----");
        Console.ResetColor();
        Environment.Exit(0); // cierra el codigo
     }


    break;



    case 2 :// Al entrar al (case-2) se lee los datos del archivo y lo guarda en las listas corresponidente
         // leemos el archivos y lo armacenamos en las listas
        foreach (string linea_archivo in File.ReadLines(rutaArchivo))
        {
            contadorLineas++; // Incrementar el contador de líneas
            if (contadorLineas % 2 == 0)
                student_mediator.Add(linea_archivo); // los segunda posicion son los {1} que serian los facilitadores
            else
                student_developer.Add(linea_archivo);
        }
        //opciones de participantes que deseas ver
        
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("~~ MENU ~~");
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;

        Console.WriteLine(linea);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("[OPCIONES]");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("[ 1 ]");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(" Desarrolladores en Vivo");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("[ 2 ]");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(" Facilitadores del ejercicio");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("[ 3 ]");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(" Estudiantes Faltantes");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("[ 4 ]");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(" Todos los que ya participaron");

        Console.WriteLine(linea);
        Console.ResetColor();

        byte ver = Convert.ToByte(Console.ReadLine());
        Console.ResetColor();

        switch (ver) {
        case 1:
                 
                 // solo Desarrolladores

             Console.Clear();
            // solo muestra desarrolladores en vivo
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[ROL --> DESARROLLADOR EN VIVO]");
            Console.ResetColor();
            foreach (string lineaa in student_developer)
            Console.WriteLine(lineaa + "  DESARROLLADOR EN VIVO");
            Console.WriteLine(linea);

            //Limpiamoz para que los datos nose repitan
           student_developer.Clear();
           student_mediator.Clear();

         // reutilizamos continuar a menu o salir
           Console.ForegroundColor = ConsoleColor.Yellow;
           Console.WriteLine("Deseas ver el [menu] o [Salir] del programa?");
           Console.WriteLine("[1] Menu");
           Console.WriteLine("[2] Salir");
           Console.ResetColor();

         // reutilizamos el codigo cerrar
           byte mostrar_1 = Convert.ToByte(Console.ReadLine());
           if (mostrar_1 == 1) { // El bucle  do while continuera su curso y se volvera a repetir el muenu
           Console.Clear();
           Console.ForegroundColor = ConsoleColor.Magenta;
           Console.WriteLine("[MENU]");
           Console.ResetColor();
        } 
           else if (mostrar_1 == 2 ){ // se detenra el curso del bucle do while
           Console.Clear();
           Console.ForegroundColor = ConsoleColor.Red;
           Console.WriteLine("----[PROGRAMA CERRADO]----");
           Console.ResetColor();
           Environment.Exit(0); // cierra el codigo
        }

        break;

        case 2: 


              // solo facilitadores
            
             Console.Clear();
            // muestra solo facilitadores de ejercicio
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[ROL --> FACILITADOR DE EJERCICIO]");
            Console.ResetColor();
            foreach (string line_a in student_mediator)
            Console.WriteLine(line_a + "  FACILITADOR DE EJERCICIO");
            Console.WriteLine(linea);

            //Limpiamoz para que los datos nose repitan
           student_developer.Clear();
           student_mediator.Clear();

         // reutilizamos continuar a menu o salir
           Console.ForegroundColor = ConsoleColor.Yellow;
           Console.WriteLine("Deseas ver el [menu] o [Salir] del programa?");
           Console.WriteLine("[1] Menu");
           Console.WriteLine("[2] Salir");
           Console.ResetColor();

         // reutilizamos el codigo cerrar
           byte mostrar_2 = Convert.ToByte(Console.ReadLine());
           if (mostrar_2 == 1) { // El bucle  do while continuera su curso y se volvera a repetir el munu
           Console.Clear();
           Console.ForegroundColor = ConsoleColor.Magenta;
           Console.WriteLine("[MENU]");
           Console.ResetColor();
        }
        else if (mostrar_2 == 2 ){ // se detenra el curso del bucle do while
           Console.ForegroundColor = ConsoleColor.Red;
           Console.Clear();
           Console.WriteLine("----[PROGRAMA CERRADO]----");
           Console.ResetColor();
           Environment.Exit(0); // cierra el codigo
        }

        break;


        case 3:
         
                
                // solo lo que no han participado

            
              Console.Clear();
              // muestra los estudiantes que faltan por parcicipar
              Console.ForegroundColor = ConsoleColor.Blue;
              Console.WriteLine("[ESTUDIANTES SIN PARTICIPAR]");
              Console.ResetColor();
              foreach (string line_aa in student_name) 
                 if (!student_developer.Contains(line_aa) && !student_mediator.Contains(line_aa)) {
                 // imprime solo las lineas que cumplan esas condicion
                  Console.WriteLine(line_aa + " ----> [SIN PARTICIPAR]");
                  Console.WriteLine(linea);
                 }
             //Limpiamoz para que los datos nose repitan
             student_developer.Clear();
             student_mediator.Clear();

             // reutilizamos continuar a menu o salir
              Console.ForegroundColor = ConsoleColor.Yellow;
              Console.WriteLine("Deseas ver el [menu] o [Salir] del programa?");
              Console.WriteLine("[1] Menu");
              Console.WriteLine("[2] Salir");
              Console.ResetColor();

            // reutilizamos el codigo cerrar
             byte mostrar_3 = Convert.ToByte(Console.ReadLine());
             if (mostrar_3 == 1) { // El bucle  do while continuera su curso y se volvera a repetir el munu
             Console.Clear();
             Console.ForegroundColor = ConsoleColor.Magenta;
             Console.WriteLine("[MENU]");
             Console.ResetColor();
            }
             else if (mostrar_3 == 2 ){ // se detenra el curso del bucle do while
             Console.Clear();
             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("----[PROGRAMA CERRADO]----");
             Console.ResetColor();
             Environment.Exit(0); // cierra el codigo
             }


        break;

        case 4:

               // mostramos todo los estudiantes
            
             Console.Clear();
            // mostramos listas
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[ROL DESARROLLADOR EN VIVO]");
            Console.ResetColor();
            foreach (string lineaa in student_developer)
            Console.WriteLine(lineaa + "  DESARROLLADOR EN VIVO");
            Console.WriteLine(linea);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[ROL FACILITADOR DE EJERCICIO]");
            Console.ResetColor();
            foreach (string line_a in student_mediator)
            Console.WriteLine(line_a + "  FACILITADOR DE EJERCICIO");
            Console.WriteLine(linea);
        
         //Limpiamos para que los datos nose repitan
           student_developer.Clear();
           student_mediator.Clear();

         // reutilizamos continuar a menu o salir
           Console.ForegroundColor = ConsoleColor.Yellow;
           Console.WriteLine("Deseas ver el [menu] o [Salir] del programa?");
           Console.WriteLine("[1] Menu");
           Console.WriteLine("[2] Salir");
           Console.ResetColor();

         // reutilizamos el codigo cerrar
           byte mostrar_4 = Convert.ToByte(Console.ReadLine());
           if (mostrar_4 == 1) { // El bucle  do while continuera su curso y se volvera a repetir el munu 
           Console.Clear();
           Console.ForegroundColor = ConsoleColor.Magenta;
           Console.WriteLine("[MENU]");
           Console.ResetColor();
        }
           else if (mostrar_4 == 2 ){ // se detenra el curso del bucle do while
           Console.Clear();
           Console.ForegroundColor = ConsoleColor.Red;
           Console.WriteLine("----[PROGRAMA CERRADO]----");
           Console.ResetColor();
           Environment.Exit(0); // cierra el codigo
        }
        break;
        }

    break;
    
    case 3 :
           FileInfo fileInfo = new FileInfo(rutaArchivo);
           /* Si existe, creamos un objeto FileInfo para obtener información sobre el archivo,
            y luego verificamos si su longitud es cero (fileInfo.Length == 0). Si es cero, 
            mostramos un mensaje indicando que el archivo está vacío. Si no está vacío, procedemos a leer el archivo como lo haríamos
            normalmente. Si el archivo no existe, mostramos un mensaje indicando eso.*/

                if (fileInfo.Length == 0) {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("---- archivo no contiene informacion ----");

                }else {

          Console.Clear();
          indice_eleminados = 0;
          // Leer todas las líneas del archivo
            string[] lines = File.ReadAllLines(rutaArchivo);
            
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine( "[NOMBRES DISPONIBLES]" );
                Console.ResetColor();
            // Mostrar todas las líneas leídas
            foreach (string line in lines)
            {   
                contadorLineas++; // Incrementar el contador de líneas
              if (contadorLineas % 2 == 0) {
                  Console.WriteLine($"FACILITADOR DE EJERCICIO ---> {line} ");
              }
              else
                Console.WriteLine($"DESARROLLADOR EN VIVO ---> {line} ");
            }
          do {
          
          Console.ForegroundColor = ConsoleColor.DarkYellow;
          Console.WriteLine(linea);
          Console.Write("INGRESE EL -NOMBRE- QUE DESEAS Eliminar o ");
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.WriteLine("[INGRESE DOS ESPACIOS VACIOS PARA BORRAR REGISTRO]:");
          Console.ResetColor();
          string buscar = Console.ReadLine()!;
          elemento_eleminado[indice_eleminados] = buscar;
          string rutaArchivoTemporal = Path.GetTempFileName();
         /*Path: Path es una clase que proporciona métodos estáticos para trabajar con rutas de archivo y directorio en .NET Framework. 
         Está ubicada en el espacio de nombres System.IO.

        GetTempFileName(): GetTempFileName() es un método estático de la clase Path. Cuando se llama a este método, 
        genera un nombre de archivo único en el directorio temporal del sistema y lo devuelve como una cadena. 
        El archivo no se crea realmente en el disco, solo se genera el nombre de archivo único.*/

         // Abre el archivo original para lectura
         using (StreamReader lector = new StreamReader(rutaArchivo)) 
         // using perimite que se puede crear abrir y crear un carchivo sin que exista conflicto
         // creamos una instacia un objecto StreamReader para que lear el archivo en la ruta
         {
            // Creamos un archivo temporal para escritura
            using (StreamWriter escritor = new StreamWriter(rutaArchivoTemporal))
            //StreamWirter escibre en el archo
            // escribe todo lo que este dentro de la llame using
            // exite otra forma sin el using solo que al final de la escritura se necesitara colocar un arvhivo.Close();
            {
                string linea_archivo;
                // Lee línea por línea
                while ((linea_archivo = lector.ReadLine()!) != null)
                {
                    // Si la línea no contiene el elemento a eliminar, escribe la línea en el archivo temporal
                    if (!linea_archivo.Contains(buscar)) // se utiliza NOT - ! para decir cuando no este 
                    // si no existiera el not se ejecutara simpre que este
                    {
                        escritor.WriteLine(linea_archivo);
                     }
                 }
             }
           }

           // Reemplaza el archivo original con el archivo temporal
          File.Delete(rutaArchivo);
          File.Move(rutaArchivoTemporal, rutaArchivo);
          indice_eleminados ++;

        }while(indice_eleminados <= 1);
        Console.Clear();
        for( int i= 0; i < elemento_eleminado.Length; i++ ) {
          Console.WriteLine($"Elemntos eliminados: {elemento_eleminado[i]}");
          Console.WriteLine(linea);
        } 
        
                }

         // reutilizamos continuar a menu o salir
           Console.ForegroundColor = ConsoleColor.Yellow;
           Console.WriteLine("Deseas ver el [menu] o [Salir] del programa?");
           Console.WriteLine("[1] Menu");
           Console.WriteLine("[2] Salir");
           Console.ResetColor();

         // reutilizamos el codigo cerrar
           byte mostrar_5 = Convert.ToByte(Console.ReadLine());
           if (mostrar_5== 1) { // El bucle  do while continuera su curso y se volvera a repetir el munu 
           Console.Clear();
           Console.ForegroundColor = ConsoleColor.Magenta;
           Console.WriteLine("[MENU]");
           Console.ResetColor();
        }
           else if (mostrar_5 == 2 ){ // se detenra el curso del bucle do while
           Console.Clear();
           Console.ForegroundColor = ConsoleColor.Red;
           Console.WriteLine("----[PROGRAMA CERRADO]----");
           Console.ResetColor();
           Environment.Exit(0); // cierra el codigo
        }


    break;


    case 4:
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("[DEBES INGRESAR DOS NOMBRES]");
    do{
    Console.WriteLine("INGRESE EL NOMBRE QUE DECEAS AGREGAR");
    Console.WriteLine(linea);
    if(indice_agregar == 0) {
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("INGRESE DESARROLLADOR EN VIVO: ");
    }
    else { 
         Console.ForegroundColor = ConsoleColor.Blue;
         Console.WriteLine("INGRESE FACILITADOR DEL EJERCICIO: ");
    }
    string agreagr_nombre = Console.ReadLine()!;
    File.AppendAllLines(rutaArchivo, new List<string> {agreagr_nombre});
    indice_agregar++; 
    }while (indice_agregar <=1);

     // reutilizamos continuar a menu o salir
           Console.ForegroundColor = ConsoleColor.Yellow;
           Console.WriteLine("Deseas ver el [menu] o [Salir] del programa?");
           Console.WriteLine("[1] Menu");
           Console.WriteLine("[2] Salir");
           Console.ResetColor();

         // reutilizamos el codigo cerrar
           byte mostrar_6 = Convert.ToByte(Console.ReadLine());
           if (mostrar_6== 1) { // El bucle  do while continuera su curso y se volvera a repetir el munu 
           Console.Clear();
           Console.ForegroundColor = ConsoleColor.Magenta;
           Console.WriteLine("[MENU]");
           Console.ResetColor();
        }
           else if (mostrar_6 == 2 ){ // se detenra el curso del bucle do while
           Console.Clear();
           Console.ForegroundColor = ConsoleColor.Red;
           Console.WriteLine("----[PROGRAMA CERRADO]----");
           Console.ResetColor();
           Environment.Exit(0); // cierra el codigo
        }
    break;

    case 5 :
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("----[PROGRAMA CERRADO]----");
    Console.ResetColor();
    Environment.Exit(0); // cierra el codigo
    break;


    default: 
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("[ADVERTIENCIA]");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Excuseme querido 'user' pero para validar ingrese un valor numerico correspondiente ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("(1-5)");
    Console.ResetColor();
    break;
}
} while (menu != 4);
}
else if (mostrar_menu == "no" ) {
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("----[PROGRAMA CERRADO]----");
    Console.ResetColor();
    Environment.Exit(0); // cierra el codigo
}
}
}


