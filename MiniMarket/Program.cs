namespace MiniMarket;

partial class Program
{
    const double TASA_ITBIS = 0.18;

    static void Main(string[] args)
    {
        int opcion;

        do
        {
            MostrarMenu();
            opcion = LeerEntero("Elija una opción: ");

            switch (opcion)
            {
                case 1: OpcionTotal(); break;
                case 2: OpcionDescuento(); break;
                case 3: OpcionDevuelta(); break;
                case 4: OpcionTabla(); break;
                case 0: Console.WriteLine("Hasta luego."); break;
                default: Console.WriteLine("Opción inválida."); break;
            }
        } while (opcion != 0);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n===== MINI MARKET =====");
        Console.WriteLine("1. Calcular total de una compra");
        Console.WriteLine("2. Aplicar descuento");
        Console.WriteLine("3. Calcular la devuelta");
        Console.WriteLine("4. Tabla de precios por cantidad");
        Console.WriteLine("0. Salir");
    }

    // pide un entero hasta que el usuario escriba uno válido
    static int LeerEntero(string mensaje)
    {
        int numero;
        do
        {
            Console.WriteLine(mensaje);
        } while (!int.TryParse(Console.ReadLine(), out numero));
        return numero;
    }

    static double CalcularTotal(double precio, int cantidad)
    {
        double subtotal = precio * cantidad;
        return subtotal + subtotal * TASA_ITBIS;
    }

    static void OpcionTotal()
    {
        double precio = LeerDecimal("Precio del producto: ");
        int cantidad = LeerEntero("Cantidad: ");
        double total = CalcularTotal(precio, cantidad);
        Console.WriteLine($"Total con ITBIS: {total:N2}");
    }
}