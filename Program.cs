// Piedra_papel_o_tijera
Console.WriteLine("Hello, World!");
int seleccionRobot = 0;
Random aleatorio = new Random ();
seleccionRobot = aleatorio.Next(1, 4); // para generar un numero del 1 al 3
Console.WriteLine("El numero aleatorio es:"+seleccionRobot);
Console.WriteLine("Elige 1 para piedra, 2 para papel o 3 para tijera");

string texto = Console.ReadLine();
int seleccionHumano;

if (int.TryParse(texto, out seleccionHumano))
{
    Console.WriteLine("Número válido: " + seleccionHumano);
}
Console.WriteLine("El numero que escoge el humano es:"+seleccionHumano);

if (seleccionHumano == seleccionRobot)
Console.WriteLine("Empate");
if ((seleccionHumano == 1 && seleccionRobot == 3) || (seleccionHumano == 2 && seleccionRobot == 1) || (seleccionHumano == 3 && seleccionRobot ==1 ))
Console.WriteLine ("Gana Humano");
else 
Console.WriteLine ("Gana Robot");
