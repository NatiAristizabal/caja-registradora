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


