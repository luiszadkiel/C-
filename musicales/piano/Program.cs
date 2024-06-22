using System;
using System.IO.Compression;
using System.Media;




ConsoleKeyInfo letra ;

do {
Console.Clear();
Console.WriteLine(@"


 Bienvenido usuario [PRESS 'P' para salir]
 _______________________________________
|  | | | |  |  | | | | | |  |  | | | |  |
|  | | | |  |  | | | | | |  |  | | | |  |
|  | | | |  |  | | | | | |  |  | | | |  |
|  |_| |_|  |  |_| |_| |_|  |  |_| |_|  |
|   |   |   |   |   |   |   |   |   |   |
|Do#|Re#|Mi#|Fa#|Sol|La#|Si#|Do#|Re#|Mi#|
|_Z_|_X_|_C_|_V_|_B_|_N_|_M_|_,_|_._|_/_|
");
letra = Console.ReadKey();


  
switch (letra.Key){
       case ConsoleKey.Z:
             if(OperatingSystem.IsWindows()){
             SoundPlayer reproductor = new SoundPlayer(@"C:\Users\User\OneDrive\Escritorio\fundamento de programacion\Do.wav");
             reproductor.Play();
            }
    break;

    case ConsoleKey.X:
             if(OperatingSystem.IsWindows()){
             SoundPlayer reproductor = new SoundPlayer(@"C:\Users\User\OneDrive\Escritorio\fundamento de programacion\Re.wav");
             reproductor.Play();
            }
    break;

    case ConsoleKey.C:
             if(OperatingSystem.IsWindows()){
             SoundPlayer reproductor = new SoundPlayer(@"C:\Users\User\OneDrive\Escritorio\fundamento de programacion\Mi.wav");
             reproductor.Play();
            }
    break;
    case ConsoleKey.V:
             if(OperatingSystem.IsWindows()){
             SoundPlayer reproductor = new SoundPlayer(@"C:\Users\User\OneDrive\Escritorio\fundamento de programacion\Fa.wav");
             reproductor.Play();
            }
    break;
    case ConsoleKey.B:
             if(OperatingSystem.IsWindows()){
             SoundPlayer reproductor = new SoundPlayer(@"C:\Users\User\OneDrive\Escritorio\fundamento de programacion\Sol.wav");
             reproductor.Play();
            }
    break;
    case ConsoleKey.N:
             if(OperatingSystem.IsWindows()){
             SoundPlayer reproductor = new SoundPlayer(@"C:\Users\User\OneDrive\Escritorio\fundamento de programacion\La.wav");
             reproductor.Play();
            }
    break;
    case ConsoleKey.M:
             if(OperatingSystem.IsWindows()){
             SoundPlayer reproductor = new SoundPlayer(@"C:\Users\User\OneDrive\Escritorio\fundamento de programacion\Si.wav");
             reproductor.Play();
            }
    break;
    case ConsoleKey.OemComma:
             if(OperatingSystem.IsWindows()){
             SoundPlayer reproductor = new SoundPlayer(@"C:\Users\User\OneDrive\Escritorio\fundamento de programacion\DoOctavo.wav");
             reproductor.Play();
            }
    break;
    case ConsoleKey.OemPeriod:
             if(OperatingSystem.IsWindows()){
             SoundPlayer reproductor = new SoundPlayer(@"C:\Users\User\OneDrive\Escritorio\fundamento de programacion\Re.wav");
             reproductor.Play();
            }
    break;
    case ConsoleKey.BrowserForward:
             if(OperatingSystem.IsWindows()){
             SoundPlayer reproductor = new SoundPlayer(@"C:\Users\User\OneDrive\Escritorio\fundamento de programacion\Mi.wav");
             reproductor.Play();
            }
    break;
    case ConsoleKey.P: 
     Environment.Exit(0);
    break;
}
}while(letra.Key != ConsoleKey.P);