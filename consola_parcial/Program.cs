using System;

namespace consola_parcial
{
    class Program
    {
        private static LogicaCambio logica_Cambio;
        public LogicaCambio LogicaCalculadora
        {
            get => default(LogicaCambio);
            set
            {
            }
        }

        static void Main(string[] args)
        {
            Program logica_Cambio = new Program();
            logica_Cambio.ejecutarOperaciones();

        }

        public void ejecutarOperaciones()
        {
            
            LogicaCambio metodos = new LogicaCambio();

            prepararPantalla();
            System.Console.WriteLine("Bienvenido a la aplicacion de conversion \r");
            string numInput1 = "";
            Console.Write("\n Ingrese el valor de la moneda presione enter: ");
            numInput1 = Console.ReadLine();
            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("No es una entrada válida.  Por favor ingrese un valor numérico: ");
                numInput1 = Console.ReadLine();
            }
            // menu
            int Tipomoneda1 = menu();
            int Tipomoneda2 = menu();
            Limpiar();
            bool validacion = ValidarTipoIgual(Tipomoneda1, Tipomoneda2);


            //validar menus
            while (validacion == true)
            {

                Tipomoneda1 = menu();
                Tipomoneda2 = menu();
                validacion = ValidarTipoIgual(Tipomoneda1, Tipomoneda2);
                Limpiar();
                prepararPantalla();
            }

            string numInput2 = "";
            // tasa de cambio
            Console.Write("\n Ingrese el valor de la tasa de cambio y presione enter: ");
            numInput2 = Console.ReadLine();


            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("No es una entrada valida. Por favor ingrese un valor numérico: ");
                numInput2 = Console.ReadLine();
            }
 
            // cardinalidad

            System.Console.Write("Digite el sentido de la conversión Origen-Destino (OD) o Destino-Origen(DO)");
            string card = System.Console.ReadLine();
            int f = cardinalidad(card);
            while (f > 2)
            {
                System.Console.Write("Digite el sentido de la conversión Origen-Destino (OD) o Destino-Origen(DO)");
                string carda = System.Console.ReadLine();
                f = cardinalidad(carda);

            }
            double resultado = 0;
            try
            {
                resultado = metodos.Conversion(cleanNum1, cleanNum2, f);
                string t1 = Monedas(Tipomoneda1);
                string t2 = Monedas(Tipomoneda2);
                string c = cardi(f);
                double tasa = 1.12;
                double tasadolar = 0.00025;
                double resultadobitcoin = metodos.ConversionBit(resultado,tasa,tasadolar);
                System.Console.WriteLine(cleanNum1 + " " + t1 + " son " + resultado + " " + t2 +
                    " Usando una tasa de conversion de: " + cleanNum2 + " con conversion de: " + c );
                System.Console.WriteLine("La tasa del bitcoin es: "+ resultadobitcoin);

            }
            catch (Exception variableError)
            {
                Console.WriteLine("Ha ocurrido una excepción en el procesamiento de la aplicación.\n - Details: " + variableError.Message);
              
            }


        }
    
        public static string cardi(int tipo) {
            string a = "";
            if (tipo == 1)
            {
                a = "OD";

            }
            else {
                a = "DO";
            }
            return a;

        
        }
        public static string Monedas(int tipo) {
            string a = "";
            switch (tipo) {
                case 1:
                    a = "Dolares Americanos";
                    break;
                case 2:
                    a = "Euros";
                    break;
                case 3:
                    a = "Yuanes(Renminbi)";
                    break;
                case 4:
                    a = "Yenes(Japon)";
                    break;
                case 5:
                    a = "Pesos Colombianos";
                    break;
            }
            return a;
        
        
        }
        public static int cardinalidad(string caracter)
        {



            int operacion = 0;



            switch (caracter)
            {
                case "OD":
                case "od":
                    operacion = 1;
                    Console.Clear();
                    break;
                case "DO":
                case "do":
                    operacion = 2;
                    Console.Clear();
                    break;
                default:
                    System.Console.WriteLine("Digite una opcion valida");
                    Limpiar();
                    operacion = 3;
                    break;




            }
            return operacion;
        }
        public static void Limpiar()
        {
            System.Console.WriteLine("Pulse una tecla para continuar");
            System.Console.ReadKey();
            System.Console.Clear();
        }
        public static bool ValidarTipoIgual(int a, int b)
        {
            bool c = false;
            try
            {
                if (a == b)
                {
                    throw new Exception("los tipos de moneda escogidos son iguales");
                }
            }
            catch (Exception mensaje)
            {



                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                System.Console.WriteLine("hubo un error. " + mensaje);
                c = true;



            }
            return c;

        }
        public static void prepararPantalla()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            
        }
        public static int validarmenuprincipal(int entradamenu)
        {
            bool a = false;
            int b = 0;
            try
            {
                if (entradamenu > 5 || entradamenu == 0)
                {
                    throw new Exception("el valor digitado no es una opcion valida");
                }



            }
            catch (Exception menjase)
            {
                System.Console.WriteLine(menjase.Message);
                a = true;



            }
            while (a == true)
            {
                b = menu();
                a = false;
                entradamenu = b;
            }
            return entradamenu;



        }
        public static int menu()
        {
            bool b = false;
            int a = 0;
            int c = 0;
            int d = 0;
            try
            {



                Console.WriteLine("\t1 - Dolares Americanos");
                Console.WriteLine("\t2 - Euros");
                Console.WriteLine("\t3 - Yuanes (Renminbi)");
                Console.WriteLine("\t4 - Yenes (Japon)");
                Console.WriteLine("\t5 - Pesos Colombianos");
                Console.Write("Seleccione el tipo de moneda: ");
                a = Int32.Parse(System.Console.ReadLine());
                d = validarmenuprincipal(a);
            }
            catch (Exception)
            {
                Console.WriteLine("Digite un valor valido, usted digito un valor que no corresponde a un valor numerico");
                b = true;
            }
            if (b == true)
            {
                c = menu();
                b = false;
            }
            a += c;
            if (d > 0 && d <= 5)
            {
                a = d;
            }



            return a;
        }
    }
}

