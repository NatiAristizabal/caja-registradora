const string nombre_comercio = "=== KIOSCO EL RECREO ===";
Console.WriteLine(nombre_comercio);

Console.Write("Ingrese el nombre del cajero: ");
string nombre_cajero = Console.ReadLine();

Console.WriteLine();
Console.WriteLine(nombre_comercio);
Console.WriteLine($"Nombre del cajero: {nombre_cajero}");
Console.WriteLine($"Bienvenida, {nombre_cajero}. Caja abierta.");

Console.WriteLine();
Console.Write("Ingrese el nombre del producto: ");
string nombre_producto = Console.ReadLine();
Console.Write("Ingrese el precio del producto: ");
decimal precio_producto = decimal.Parse(Console.ReadLine());
Console.WriteLine($"Nombre del producto: {nombre_producto}");
Console.WriteLine($"Precio del producto: {precio_producto:C}");

Console.WriteLine();
int opcion = 0;
int cantidadProductos = 0;
decimal total = 0;
do
{
    Console.WriteLine("¿Qué desea hacer?");
    Console.WriteLine("1 - Cargar un producto");
    Console.WriteLine("2 - Cerrar la ventana");

    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese el nombre del producto: ");
            nombre_producto = Console.ReadLine();
            Console.Write("Ingrese el precio del producto: ");
            precio_producto = decimal.Parse(Console.ReadLine());
            total += precio_producto;
            cantidadProductos++;
            Console.WriteLine($"Producto cargado: {nombre_producto} - Precio: {precio_producto:C}");
            break;
        case 2:
            Console.WriteLine("Cerrando la ventana...");
            break;
        default:
            Console.WriteLine("Opción inválida. Intente nuevamente.");
            break;
    }
} while (opcion != 2);
Console.WriteLine($"Cantidad de productos cargados: {cantidadProductos}");
Console.WriteLine($"Total vendido: {total:C}"); 

Console.ReadLine();


const decimal recargo = 1.15m;
const decimal descuento = 0.10m;
int opcionPago = 0;
string nombreMedioPago = "";
do
{
    Console.WriteLine("Medio de pago");
    Console.WriteLine("1 - Efecetivo");
    Console.WriteLine("2 - Debito");
    Console.WriteLine("3 - Crédito");
    opcionPago = int.Parse(Console.ReadLine());

    if (opcionPago < 1 || opcionPago > 3)
    {
        Console.WriteLine("Opción inválida. Intente nuevamente.");
    }
}
while(opcionPago < 1 || opcionPago > 3);

switch (opcionPago)
{
    case 1:
        nombreMedioPago = "Efectivo";
        decimal totalConDescuento = total - (total * descuento);
        Console.WriteLine($"Total a pagar: {totalConDescuento:C}");
        break;
    case 2:
        nombreMedioPago = "Débito";
        Console.WriteLine($"Total a pagar: {total:C}");
        break;
    case 3:
        nombreMedioPago = "Crédito";
        decimal totalConRecargo = total * recargo;
        Console.WriteLine($"Total a pagar con recargo del 15%: {totalConRecargo:C}");
        break;
    default:
        Console.WriteLine("Opción inválida. Intente nuevamente.");
        break;
}