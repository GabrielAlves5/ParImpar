
int numero;

        Console.WriteLine("NUMERO PAR OU IMPAR?");
        Console.Write("Digite um numero para saber se é Par ou Impar: ");
       numero = Convert.ToInt32(Console.ReadLine());
        if (numero %2 == 0)
        {
            Console.WriteLine("É par");
        }
        else
            Console.WriteLine("É Impar");

