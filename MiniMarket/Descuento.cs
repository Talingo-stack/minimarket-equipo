namespace MiniMarket;

partial class Program
{
    static void OpcionDescuento()
    {
        double total = LeerDecimal("Total de la compra: ");
        int porcentaje = LeerEntero("Porcentaje de descuento: ");
        double totalFinal = AplicarDescuento(total, porcentaje);
        Console.WriteLine($"Total con descuento: {totalFinal:N2}");
    }


    static double LeerDecimal(string mensaje)
    {
        double numero;
        do
        {
            Console.WriteLine(mensaje);
        } while (!double.TryParse(Console.ReadLine(), out numero));
        return numero;
    }

    static double AplicarDescuento(double total, int porcentaje)
    {
        return total - total * porcentaje / 100;
    }
}