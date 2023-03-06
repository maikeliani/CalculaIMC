internal class Program
{
    private static void Main(string[] args)
    {
        double altura, peso, imc;
        char sexo;

        Console.WriteLine(" Informe o peso");
        peso = double.Parse(Console.ReadLine());

        Console.WriteLine(" Informe a altura");
        altura = double.Parse(Console.ReadLine());

        Console.WriteLine(" Informe o sexo: Digite (F) para feminino e (M) para masculino");
        sexo = char.Parse(Console.ReadLine());

        imc = peso / Math.Pow(altura, 2);

        if (sexo == 'M')
        {
            if (imc < 19.1)
            {
                Console.WriteLine(" Abaixo do peso");
            }
            else if (imc >= 19.1 && imc <= 25.8)
            {
                Console.WriteLine(" Peso ideal");
            }
            else if (imc >= 25.9 && imc <= 27.3)
            {
                Console.WriteLine(" Pouco acima do peso");
            }
            else if (imc >= 27.4 && imc <= 32.3)
            {
                Console.WriteLine("Acima do peso");
            }
            else
            {
                Console.WriteLine(" Obesidade");
            }
        }
        else
        {
            if (imc < 20.7)
            {
                Console.WriteLine(" Abaixo do peso");
            }
            else if (imc >= 20.7 && imc <= 26.4)
            {
                Console.WriteLine(" Peso ideal");
            }
            else if (imc >= 26.5 && imc <= 27.8)
            {
                Console.WriteLine(" Pouco acima do peso");
            }
            else if (imc >= 27.9 && imc <= 31.1)
            {
                Console.WriteLine("Acima do peso");
            }
            else
            {
                Console.WriteLine(" Obesidade");
            }
        }
    }
}