internal class Program
{
    private static void Main(string[] args)
    {
        int numA,numB,Max;
        Console.WriteLine("ingresar el primero numero:");
        numA=Convert.ToInt32(System.Console.ReadLine());
        Console.WriteLine("ingresar el segundo numero:");
        numB=Convert.ToInt32(System.Console.ReadLine());
        if(numA > numB) {
            Console.WriteLine("el numero mayro es: "+numA);
        }
        else if (numA < numB){
            Console.WriteLine("el numero mayro es: "+numB);
        }
        else{
            Console.WriteLine("ambos numeros son iguales");
        }
    }
}