//////////////////////////////////
//      CLASE 6 - TAREA 2       //
// ALUMNO:  GIACOBINI GASTON    //
// FECHA:   13/05/2022          //
//////////////////////////////////

Console.Title = "PoloTic Cordoba - Tarea 2 - GIACOBINI GASTÓN 2022 - v1.0";

// Arte Ascii para la estetica del programa.
string welcomeLogoAscii =
    @"                                              
            ▐▓█▀▀▀▀▀▀▀▀▀█▓▌░▄▄▄▄▄░            
            ▐▓█░▄▀▀░▄▀▀░█▓▌░█▄▄▄█░            
            ▐▓█░█░░░▀▀▄░█▓▌░█▄▄▄█░            
            ▐▓█░▀▄▄░▄▄▀░█▓▌░█▀███░            
            ▐▓█▄▄▄▄▄▄▄▄▄█▓▌░█▀███░            
            ░░░░▄▄███▄▄░░░░░█████░            
                 Bienvenido a                 
           Adivina el Número en C#!           
                                              
";
string catLogoAscii =
    @"
                ▄▀▄     ▄▀▄
               ▄█░░▀▀▀▀▀░░█▄
           ▄▄  █░░░░░░░░░░░█  ▄▄
          █▄▄█ █░░▀░░┬░░▀░░█ █▄▄█";
string winMessageAscii =
    @"
      ▄▀▀ ▄▀▄ █▄░█ ▄▀▄ ▄▀▀ ▀█▀ █▀▀ █ █
      █░█ █▄█ █▀██ █▄█ ░▀▄ ░█░ █▀▀ ▀ ▀
      ░▀▀ ▀░▀ ▀░░▀ ▀░▀ ▀▀░ ░▀░ ▀▀▀ ▀ ▀
";


int secretNumber = new Random(DateTime.Now.Millisecond).Next(1, 21);

int lapNumber = 1;

do {
    Console.Clear();
    
    
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine(welcomeLogoAscii);
    Console.ResetColor();
    

    Console.Write("Para jugar ingrese un numero entre ");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("1 y 20");
    Console.ResetColor();
    Console.Write(": ");


    Console.ForegroundColor = ConsoleColor.DarkCyan;
    int userNumber = int.Parse(Console.ReadLine());
    
    if (userNumber != secretNumber) {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(
            $"\n\n\t  El numero es muy {(userNumber > secretNumber ? "GRANDE" : "CHICO")}!  \n"
            );
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\nPresione una tecla para volver a intentarlo...");

        Console.ReadKey();
    } else {        
        break;
    }

    lapNumber++;

} while (true);

// FIN DEL PROGRAMA
Console.BackgroundColor = ConsoleColor.Cyan;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("\n\n                Felicitaciones!!              ");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(
    $"\n  Has adivinado el NUMERO SECRETO que era: {secretNumber}\n\tLo has logrado en {lapNumber} intento{(lapNumber == 1 ? "" : "s")}!!"
    );

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(catLogoAscii);
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(winMessageAscii);
Console.ResetColor();

// Musica de victoria.
Console.Beep(659, 125); 
Console.Beep(659, 125); 
Thread.Sleep(125); 
Console.Beep(659, 125); 
Thread.Sleep(167); 
Console.Beep(523, 125); 
Console.Beep(659, 125); 
Thread.Sleep(125); 
Console.Beep(784, 125);
