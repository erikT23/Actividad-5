class MainClass
{


    static void Main(string[] args)
    {
        double hawaiana = 150;
        double pepperoni = 155;
        double quesos = 145;
        double margarita = 168;
        double salami = 159;
        double envio = 45;
        double pagoFinal;

        Console.WriteLine("Seleccione la pizza que desea comprar:");
        Console.WriteLine("1. Hawaiana - $150");
        Console.WriteLine("2. Pepperoni - $155");
        Console.WriteLine("3. Quesos - $145");
        Console.WriteLine("4. Margarita - $168");
        Console.WriteLine("5. Salami - $159");

        int opcion = int.Parse(Console.ReadLine());

        double precio = 0;

        switch (opcion)
        {
            case 1:
                precio = hawaiana;
                break;
            case 2:
                precio = pepperoni;
                break;
            case 3:
                precio = quesos;
                break;
            case 4:
                precio = margarita;
                break;
            case 5:
                precio = salami;
                break;
            default:
                break;
        }

        Console.WriteLine("Necesita Servicio a domicilio? S/N");
        string aDomicilio = Console.ReadLine().ToUpper();

        bool domicilio = false;
        while (aDomicilio != "S" && aDomicilio != "N")
        {
            Console.WriteLine("Ingreso una opción no válida para el servicio a domicilio. Por favor, ingrese S o N.");
            aDomicilio = Console.ReadLine().ToUpper();

        }

        if (aDomicilio == "S")
        {
            domicilio = true;
        }

        Console.WriteLine("El pago es con tarjeta? S/N");
        string tarjeta = Console.ReadLine().ToUpper();

        bool cTarjeta = false;
        while (tarjeta != "S" && tarjeta != "N")
        {
            Console.WriteLine("Ingreso una opción no válida para el pago con tarjeta. Por favor, ingrese S o N.");
            tarjeta = Console.ReadLine().ToUpper();
        }

        if (tarjeta == "S")
        {
            cTarjeta = true;
        }

        pagoFinal = precio;

        if (domicilio)
        {
            pagoFinal += envio;
        }
        if (cTarjeta)
        {
            pagoFinal *= 1.03;
        }


        Console.WriteLine("Monto a pagar: $" + pagoFinal.ToString("0.00"));


    }

































    /*    public static void Main(string[] args)

        {
            ClasificarEmpleado(5500);

        }

        public static bool VerificarEdad(int edad)
        {

            return (edad >= 18) ? true : false;

        }

        public static string ClasificarEmpleado(decimal salario)
        {
            string tipoEmpleado;
            switch (salario)
            {
                case < 5000:
                    tipoEmpleado = "Asociado A";
                    break;

                case >= 5000 and <= 10000:
                    tipoEmpleado = "Asociado B";

                    break;
                default:
                    tipoEmpleado = "Asociado C";
                    break;
            }
            Console.WriteLine($"el tipo de empleado es {tipoEmpleado}");
            return tipoEmpleado;
        }

        public static void ValidadMedidas(int a, int b)
        {
            switch ((a, b))
            {
                case ( > 0, > 0) when a == b:
                    Console.WriteLine($"Ambas medidas son validas e iguales a {a}");
                    break;
                case ( > 0, > 0):
                    Console.WriteLine($"La primera medida es {a} la segunda es {b}");
                    break;
                default:
                    Console.WriteLine("Una de las dos medidas es invalida");
                    break;
            }
        }*/
}

