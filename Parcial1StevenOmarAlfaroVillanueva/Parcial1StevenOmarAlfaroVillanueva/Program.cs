using Parcial1StevenOmarAlfaroVillanueva.Entidades;
using Parcial1StevenOmarAlfaroVillanueva.Negocio;

Usuario usuario = new Usuario();
ClsUsuario clsUsuario = new ClsUsuario();   
Venta venta = new Venta();
ClsVenta clsVenta = new ClsVenta();



Console.WriteLine("Ingresa tu nomnbre de usuario:  ");
usuario.Nombre = Console.ReadLine();


Console.WriteLine("ingresa tu contraseña: ");
usuario.Contraseña = Convert.ToInt32(Console.ReadLine());


if (clsUsuario.Acceso(usuario) == true)
{
    Console.WriteLine("Usuario y Contraseña correctos puedes realizar tu proceso de compra");
    Console.WriteLine("*******************************************************************");

    Console.WriteLine("Idproducto: ");
    venta.IdentificadorDelProducto = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Nombre del Producto: ");
    venta.Nombreodeproducto = Console.ReadLine();

    Console.WriteLine("Descripcion del producto: ");
    venta.DescripcioDeProducto = Console.ReadLine();

    Console.WriteLine("Precio  del Producto: ");
    venta.PrecioDelProducto = float.Parse(Console.ReadLine());

    Console.WriteLine("Cantidad de producto: ");
    venta.CantidadDelProducto = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(clsVenta.Cobro(venta));
    Console.WriteLine($"codigo de producto: {venta.IdentificadorDelProducto}\nNombre del producto: {venta.Nombreodeproducto}\nDescripcion del producto: {venta.DescripcioDeProducto}\nprecio del producto:{venta.PrecioDelProducto}\nCantidad de producto: {venta.CantidadDelProducto}");
}
else 
{
    Console.WriteLine("Error credenciales incorrectas");
}
