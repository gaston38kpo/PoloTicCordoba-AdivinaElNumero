//////////////////////////////////
//      CLASE 6 - TAREA 2       //
// ALUMNO:  GIACOBINI GASTON    //
// FECHA:   13/05/2022          //
//////////////////////////////////

Console.Title = "PoloTic Cordoba - Ejercicio 6 - GIACOBINI GASTÓN 2022";

int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);

int lapNumber = 1;

do {
    Console.Clear();
    
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.Black;
    
    Console.WriteLine(@"                                              
            ▐▓█▀▀▀▀▀▀▀▀▀█▓▌░▄▄▄▄▄░            
            ▐▓█░▄▀▀░▄▀▀░█▓▌░█▄▄▄█░            
            ▐▓█░█░░░▀▀▄░█▓▌░█▄▄▄█░            
            ▐▓█░▀▄▄░▄▄▀░█▓▌░█▀███░            
            ▐▓█▄▄▄▄▄▄▄▄▄█▓▌░█▀███░            
            ░░░░▄▄███▄▄░░░░░█████░            
                 Bienvenido a                 
           Adivina el Número en C#!           
                                              
");

    Console.ResetColor();

    Console.Write("Para jugar ingrese un numero entre ");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("1 y 20");
    Console.ResetColor();
    Console.Write(": ");


    Console.ForegroundColor = ConsoleColor.DarkCyan;
    int userNumber = int.Parse(Console.ReadLine());
    
    if (userNumber != numeroSecreto) {
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"\n\n\t  El numero es muy {(userNumber > numeroSecreto ? "GRANDE" : "CHICO")}!  \n");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"\nPresione una tecla para volver a intentarlo...");

        Console.ReadKey();        
    } else {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n\n\t\t Felicitaciones! \n");
        Console.ResetColor();
        
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"\n Has adivinado el NUMERO SECRETO que era: {numeroSecreto}\n\tLo has logrado en {lapNumber} intento{(lapNumber == 1 ? "" : 's')}!!");
        
        Console.ResetColor();
        
        break;
    }

    lapNumber++;

} while (true);

Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125);