namespace MiniMarket;

partial class Program
{
    static double CalcularDevuelta(double total, double pago)
    {
        return pago - total;
    }

    static void OpcionDevuelta()
    {
        double total = LeerDecimal("Total a pagar: ");
        double pago = LeerDecimal("Pago del cliente: ");

        if (pago < total)
        {
            Console.WriteLine("Pago insuficiente");
        }
        else
        {
            double devuelta = CalcularDevuelta(total, pago);
            Console.WriteLine($"Devuelta: {devuelta:N2}");
        }
    }
}