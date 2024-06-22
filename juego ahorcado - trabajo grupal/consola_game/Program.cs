// Consola de videogames

// menu


using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

ConsoleKeyInfo press_enter; //  puede almacenar un objeto de tipo ConsoleKeyInfo,
                            // que es lo que devuelve el método Console.ReadKey()

do {
Console.WriteLine("");
Console.ForegroundColor =ConsoleColor.Green;
Console.WriteLine("[BIENVENIDO PLAYER]");
Console.ResetColor();
Console.Write("PRESS ");
Console.ForegroundColor =ConsoleColor.Yellow;
Console.Write("--ENTER-- ");
Console.ResetColor();
Console.WriteLine("PARA COMENZAR");
press_enter = Console.ReadKey(); //Captura la informacion de las tecla ingresada

}while (press_enter.Key != ConsoleKey.Enter);
// si la teclas ingresada es igual a la tecla verificada
int menu ;
do {
 if (press_enter.Key == ConsoleKey.Enter ){
  Console.ForegroundColor = ConsoleColor.Magenta;
  Console.WriteLine("Elige el Juego que Deseas Comenzar");
  Console.WriteLine("[1] AHORCADO");
  Console.WriteLine("[2] Adivina el Numero");
  Console.WriteLine("[3] PIEDRA, PAPEL O TIJERAS");
  Console.WriteLine("[4] Dardo");
  Console.WriteLine("[5] Salir");
  Console.ResetColor();
}
 menu = Convert.ToByte(Console.ReadLine()); //entrada del menu

switch(menu) {
    case 1: {
         int vida = 5;
         Console.Clear();
         Console.ForegroundColor = ConsoleColor.DarkYellow;
         Console.WriteLine("[ -- Ingrese una palabra -- ]");
         Console.ResetColor();
         string palabra = Console.ReadLine()!;
         // obtenemos la longitud
         int longitud = palabra.Length;
         string[] almacen = new string[longitud]; // tamano del array 
         string[] almacen_fallo = new string[5];
         int controlador = 0;
         int indice = 0; // asi podre controlar las posiciones del arrey
         int indice_fallos = 0; //indice de las teclas incorrectas
         Console.Clear();
         
        //repeicion
        do { // este bloque se repetira hasta que vida sea == o 
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Advina una letra de la pablara");
        
        if (controlador <= 0){ // para que [] [] []  solo se muestre una ves
            for (int i = 0; i < longitud; i++) {
            Console.Write("[  ] ");
            }
           Console.ForegroundColor = ConsoleColor.Green; 
           Console.Write($"   Te quedan {vida} Vidas");
           Console.WriteLine("");
           Console.ResetColor();
           if ( controlador > 0){
            Console.Clear();
           }
           controlador ++;
        }
        else {
            foreach (string letras_correctas in almacen) {
                Console.Write($"[ {letras_correctas} ]  "); 
            }
            Console.WriteLine("");

            if (vida == 5 ) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Tienes--> {vida} Vidas");
            }
            else if (vida <= 4 && vida >= 3 ) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Tienes--> {vida} Vidas");
            }
            else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Tienes--> {vida} Vidas");
            }
            Console.ResetColor();
        }

        

        
        indice = 0; // asi podre controlar las posiciones del arrey
        
        Console.ForegroundColor = ConsoleColor.Red;
        foreach (string letras_fallo in almacen_fallo)
        {
         Console.WriteLine($"LETRAS FALLIDAS --> [ {letras_fallo} ]");
        }
        Console.ResetColor();
        
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Ingrese la letra que desea encontrar: ");
        char letra = Console.ReadKey().KeyChar; // Entrada Letra
        Console.Clear();
        Console.ResetColor();
         // si la letra esta contenida en una palabra 
        if (palabra.Contains(letra)) {
           //guardad el arry 
           foreach (char c in palabra) {
              if (c == letra) {
                almacen[indice] = letra.ToString(); // almacena la letra en el array
                }
                indice++; // Incrementamos el índice dentro del bucle foreach
            }
        }

        else {
         vida --; // se resta la vida

         almacen_fallo[indice_fallos] = letra.ToString(); // almacenamos la letra que no haz acertado
         indice_fallos ++;
        }
        
        string letras_alamcen = string.Join("", almacen);// join para juntas las letras individuales
        if (palabra == letras_alamcen) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[VICTORIA, YOU WIN] Las palabra era --> {palabra} ");
            Console.WriteLine(" __     __          __          ___         ");
            Console.WriteLine(" \\ \\   / /          \\ \\        / (_)       ");
            Console.WriteLine("  \\ \\_/ /__  _   _   \\ \\  /\\  / / _ _ __    ");
            Console.WriteLine("   \\   / _ \\| | | |   \\ \\/  \\/ / | | '_ \\   ");
            Console.WriteLine("    | | (_) | |_| |    \\  /\\  /  | | | | ||   ");
            Console.WriteLine("    |_|\\___/ \\__,_|     \\/  \\/   |_|_| |_|  ");
            Console.WriteLine($"[VICTORIA, YOU WIN] Las palabra era --> {palabra} ");
            Console.ResetColor();
            Environment.Exit(0);
        }

       } while(vida > 0); // vida == 0 se termina el juego
         Console.WriteLine("");
         Console.WriteLine("");
         Console.WriteLine("");
         Console.ForegroundColor = ConsoleColor.Yellow;
         Console.WriteLine("[Letras Que Acertaste]");
         Console.ResetColor();
         // Mostrar el contenido del array
        foreach (string letras_correcta in almacen) {
            Console.Write($"[ {letras_correcta} ] "); 
        }
         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine(); // Salto de línea
         Console.WriteLine("  ____ ");
         Console.WriteLine(" |    | ");
         Console.WriteLine(" |    O ");
         Console.WriteLine(" |   /|\\ ");
         Console.WriteLine(" |    | ");
         Console.WriteLine(" |   / \\ ");
         Console.WriteLine("_|_______");
         Console.WriteLine("¡Has sido ahorcado!");
         Console.WriteLine($"La palabra era: {palabra}");
         Console.WriteLine("  _____          __  __ ______    ______      ________ _____  ");
         Console.WriteLine(" / ____|   /\\   |  \\/  |  ____|  / __ \\ \\    / /  ____|  __ \\ ");
         Console.WriteLine("| |  __   /  \\  | \\  / | |__    | |  | \\ \\  / /| |__  | |__) |");
         Console.WriteLine("| | |_ | / /\\ \\ | |\\/| |  __|   | |  | |\\ \\/ / |  __| |  _  / ");
         Console.WriteLine("| |__| |/ ____ \\| |  | | |____  | |__| | \\  /  | |____| | \\ \\ ");
         Console.WriteLine(" \\_____/_/    \\_\\_|  |_|______|  \\____/   \\/   |______|_|  \\_\\");
         Console.ResetColor();

         // continuar a menu o salir
         Console.ForegroundColor = ConsoleColor.Yellow;
         Console.WriteLine("Deseas ver el [menu] o [Salir] del programa?");
         Console.WriteLine("[1] Menu");
         Console.WriteLine("[2] Salir");
         Console.ResetColor();

         byte mostrar = Convert.ToByte(Console.ReadLine());
         if (mostrar == 1) { // El bucle  do while continuera su curso y se volvera a repetir el munu
         Console.ForegroundColor = ConsoleColor.Magenta;
         Console.WriteLine("[MENU]");
         Console.ResetColor();
         Console.Clear();
         }
         else if (mostrar == 2 ){ // se detenra el curso del bucle do while
         Console.Clear();
         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine("----[PROGRAMA CERRADO]----");
         Console.ResetColor();
         Environment.Exit(0); // cierra el codigo
         }

        break;
    }

    case 2: { // ADIVINA EL NUMERO
        Console.WriteLine("     ¡Hola! Bienvenido al juego \"ADIVINA EL NÚMERO\"");
        Console.WriteLine("---------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("                       REGLAS:");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("- El número secreto está entre 1 y 10 por lo que sólo deberás ingresar valores dentro de este rango.");
        Console.WriteLine("- Solo contarás con 5 intentos.");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("                   ¡Mucha suerte!");
        Console.ResetColor();
        Console.WriteLine("---------------------------------------------------------");
        Random numero = new Random();
        int numero_secreto = numero.Next(1,11);
        int intentos = 0;
        Console.WriteLine("Por favor ingrese un número:");
        while (intentos<5)
        {
            int num_ingresado = int.Parse(Console.ReadLine()!);
                if (num_ingresado>=1 && num_ingresado<=10) 
                {
                    if (num_ingresado==numero_secreto)
                {
                    intentos++;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("¡FELICIDADES, HAS ADIVINADO!");
                    Console.ResetColor();
                    break;
                } else 
                {
                    intentos++;
                    if (intentos==5)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("HAS PERDIDO :(");
                        Console.ResetColor();
                        break;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Vuelve a intentar (Te quedan {5-intentos} intentos)");
                    Console.ResetColor();
                }
                } else 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valor inválido, inténtelo de nuevo");
                    Console.ResetColor();
                }
        }
        Console.WriteLine("---------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Número secreto:");
        Console.ResetColor();
        Console.WriteLine(numero_secreto);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Cantidad de intentos realizados:");
        Console.ResetColor();
        Console.WriteLine(intentos);
        
         // continuar a menu o salir
         Console.ForegroundColor = ConsoleColor.Yellow;
         Console.WriteLine("Deseas ver el [menu] o [Salir] del programa?");
         Console.WriteLine("[1] Menu");
         Console.WriteLine("[2] Salir");
         Console.ResetColor();

         byte mostrar = Convert.ToByte(Console.ReadLine());
         if (mostrar == 1) { // El bucle  do while continuera su curso y se volvera a repetir el munu
         Console.ForegroundColor = ConsoleColor.Magenta;
         Console.WriteLine("[MENU]");
         Console.ResetColor();
         Console.Clear();
         }
         else if (mostrar == 2 ){ // se detenra el curso del bucle do while
         Console.Clear();
         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine("----[PROGRAMA CERRADO]----");
         Console.ResetColor();
         Environment.Exit(0); // cierra el codigo
         }

        
        
        break;
    }

    case 3: {

     //Juego de Piedra, Papel o Tijeras.

     Console.WriteLine("Bienvenido/a al juego de Piedra, Papel y Tijeras!");
     bool jugar = true;

     while (jugar)
        {
            string[] opciones = {"piedra", "papel", "tijeras"};
            string jugador = "";
            bool coincide = false;
            do
            {
            Console.WriteLine("Escribe tu eleccion: piedra, papel o tijeras.");
             jugador = Console.ReadLine()!.ToLower();

            for (int i = 0; i < opciones.Length; i++)
                {
                    if (string.Compare(jugador, opciones[i], StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        coincide = true;
                        break;
                    }
                }
                if (!coincide)
                {
                Console.WriteLine("Opcion invalida. Intentalo de nuevo.");
                }
            }
            while (!coincide);


            // Aqui se decide aleatoreamente la eleccion de la pc
            Random random = new Random();
            int numAleatorio = random.Next(1, 4);
            string pc = "";
            if (numAleatorio == 1)
            {
                pc = "piedra";
            }
            else if (numAleatorio == 2)
            {
                pc = "papel";
            }
            else
            {
                pc = "tijeras";
            }

            Console.WriteLine($"El computador eligio: {pc}");

            // Aqui Determinamos el ganador
            if (jugador == pc)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Empate!");
            }
            else if ((jugador == "piedra" && pc == "tijeras") ||
                     (jugador == "papel" && pc == "piedra") ||
                     (jugador == "tijeras" && pc == "papel"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Felicidades, Ganaste!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El PC gana, suerte la proxima!");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Quieres jugar otra vez? Di que si, no pierdes nada! (s/n)");
            string repetirjuego = Console.ReadLine()!.ToLower();
            jugar = (repetirjuego == "s");
        }
        Console.ResetColor();
        Console.WriteLine("Gracias por jugar!");

          // continuar a menu o salir
         Console.ForegroundColor = ConsoleColor.Yellow;
         Console.WriteLine("Deseas ver el [menu] o [Salir] del programa?");
         Console.WriteLine("[1] Menu");
         Console.WriteLine("[2] Salir");
         Console.ResetColor();

         byte mostrar = Convert.ToByte(Console.ReadLine());
         if (mostrar == 1) { // El bucle  do while continuera su curso y se volvera a repetir el munu
         Console.ForegroundColor = ConsoleColor.Magenta;
         Console.WriteLine("[MENU]");
         Console.Clear();
         Console.ResetColor();
         }
         else if (mostrar == 2 ){ // se detenra el curso del bucle do while
         Console.Clear();
         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine("----[PROGRAMA CERRADO]----");
         Console.ResetColor();
         Environment.Exit(0); // cierra el codigo
         }


        break;
     }

    case 4: {
         const int PuntajeInicial = 50;
         int[] puntajes = new int[2] { PuntajeInicial, PuntajeInicial };
         string[] nombresJugadores = new string[2];
         int[][] secciones = {
            new int[] {20, 5, 1},
            new int[] {18, 1, 4},
            new int[] {4, 18, 13},
            new int[] {13, 4, 6},
            new int[] {6, 13, 10},
            new int[] {10, 6, 15},
            new int[] {15, 10, 2},
            new int[] {2, 15, 17},
            new int[] {17, 2, 3},
            new int[] {3, 17, 19},
            new int[] {19, 3, 7},
            new int[] {7, 19, 16},
            new int[] {16, 7, 8},
            new int[] {8, 16, 11},
            new int[] {11, 14, 8},
            new int[] {14, 9, 11},
            new int[] {9, 12, 14},
            new int[] {12, 5, 12},
            new int[] {5, 20, 12}
        };
        Random rnd = new Random();

        // Pedir nombres de los jugadores
        for (int i = 0; i < nombresJugadores.Length; i++)
        {
            Console.Write($"Ingrese el nombre del Jugador {i + 1}: ");
            nombresJugadores[i] = Console.ReadLine()!;
        }
        Console.WriteLine();

        // Juego
        bool juegoTerminado = false;

        while (!juegoTerminado)
        {
            for (int jugador = 0; jugador < nombresJugadores.Length; jugador++)
            {
                if (puntajes[jugador] <= 0)
                {
                    continue;
                }

                Console.WriteLine($"Turno de {nombresJugadores[jugador]}:");

                int puntajeTurno = 0;

                for (int tiro = 0; tiro < 3; tiro++)
                {
                    Console.WriteLine("Secciones disponibles:");
                    for (int i = 0; i < secciones.Length; i++)
                    {
                        Console.Write($"[{i + 1}] ");
                        for (int j = 0; j < secciones[i].Length; j++)
                        {
                            Console.Write($"{secciones[i][j]} ");
                        }
                        Console.WriteLine();
                    }

                    Console.Write("Elige una sección (1-18): ");
                    int seccionElegida = int.Parse(Console.ReadLine()!) - 1;

                    int indiceDardo = rnd.Next(0, 3);
                    int puntajeDardo = secciones[seccionElegida][indiceDardo];

                    if (puntajeTurno + puntajeDardo > puntajes[jugador])
                    {
                        Console.WriteLine("¡No puedes restar más puntos de los que tienes!");
                        continue;
                    }

                    puntajeTurno += puntajeDardo;
                }

                puntajes[jugador] -= puntajeTurno;

                Console.WriteLine($"{nombresJugadores[jugador]} ha obtenido un total de {puntajeTurno} puntos en este turno.");
                Console.WriteLine($"Puntaje restante de {nombresJugadores[jugador]}: {puntajes[jugador]}");
                Console.WriteLine();
            }

            if (puntajes[0] <= 0 && puntajes[1] <= 0)
            {
                Console.WriteLine("¡Es un empate!");
                juegoTerminado = true;
            }
            else if (puntajes[0] <= 0)
            {
                Console.WriteLine($"{nombresJugadores[1]} ha ganado!");
                juegoTerminado = true;
            }
            else if (puntajes[1] <= 0)
            {
                Console.WriteLine($"{nombresJugadores[0]} ha ganado!");
                juegoTerminado = true;
            }
        }

        Console.WriteLine("¡Fin del juego!");
        Console.WriteLine($"Puntaje final de {nombresJugadores[0]}: {puntajes[0]}");
        Console.WriteLine($"Puntaje final de {nombresJugadores[1]}: {puntajes[1]}");

         // continuar a menu o salir
         Console.ForegroundColor = ConsoleColor.Yellow;
         Console.WriteLine("Deseas ver el [menu] o [Salir] del programa?");
         Console.WriteLine("[1] Menu");
         Console.WriteLine("[2] Salir");
         Console.ResetColor();

         byte mostrar = Convert.ToByte(Console.ReadLine());
         if (mostrar == 1) { // El bucle  do while continuera su curso y se volvera a repetir el munu
         Console.ForegroundColor = ConsoleColor.Magenta;
         Console.WriteLine("[MENU]");
         Console.ResetColor();
         Console.ResetColor();
         }
         else if (mostrar == 2 ){ // se detenra el curso del bucle do while
         Console.Clear();
         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine("----[PROGRAMA CERRADO]----");
         Console.ResetColor();
         Environment.Exit(0); // cierra el codigo
         }

        break;
    }
    case 5: {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("<< APAGANADO consola... >>");
        Console.ResetColor();
        Environment.Exit(0);
        break;
    }
    default:
    Console.WriteLine("Respuesta inválida. Por favor, elige una opción válida.");
    break;
} 
} while(true);