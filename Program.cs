//Un programa que solicite al usuario un valor numerico
//Mostrar en pantalla si positivo o negativo
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Numeros Positivos y Negativos");
        //Varibles
        int num;
        num = Convert.ToInt32(Console.ReadLine());

        if (num >= 0)
            Console.WriteLine("Soy un numero POSITIVO");
        else
            Console.WriteLine("Soy un numero NEGATIVO");

    }
}