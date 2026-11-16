namespace MiniMarket;

partial class Program
{
    static void OpcionTabla()
    {
        // pido el precio del producto con el método de B
        double precio = LeerDecimal("Precio del producto: ");

        // llamo al método que dibuja la tabla, pasándole el precio
        MostrarTablaPrecios(precio);
    }

    static void MostrarTablaPrecios(double precio)
    {
        // encabezado de la tabla, se muestra una sola vez antes del ciclo
        Console.WriteLine($"{"Cantidad",8}{"Precio",12}{"Subtotal",12}");

        // la cantidad va de 1 a 10
        for (int cantidad = 1; cantidad <= 10; cantidad++)
        {
            // el subtotal de cada fila es la cantidad por el precio
            double subtotal = cantidad * precio;

            // una fila: cantidad, precio y subtotal con los mismos anchos del encabezado
            Console.WriteLine($"{cantidad,8}{precio,12:N2}{subtotal,12:N2}");
        }
    }
}