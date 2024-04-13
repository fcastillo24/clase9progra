

using clase9progra.clasehija;

Nintendo nintendo = new Nintendo();
nintendo.añolanzamiento = 2017;
nintendo.esPortable =   true;
nintendo.Marca = "switch";
Console.WriteLine(nintendo.MostrarDetalleNintendo());

PlayStation ps = new PlayStation();
ps.Marca = "Play Station";
ps.añolanzamiento = 1994;
ps.ModelControlador = " DualSense";
Console.WriteLine($"{ps.MostrarDetallePlay()}");

xbox xb = new xbox();
xb.Marca = "Xbox";
xb.añolanzamiento = 1995;
xb.ColorXbox= " Blanco";
Console.WriteLine($"{xb.MostrarDetalleXbox()}");

segaDreamcast sega = new segaDreamcast();
sega.Marca = "sega";
sega.añolanzamiento = 1990;
sega.juegossega = "Virtual TEnnis";
Console.WriteLine($"{sega.MostrarDetallesega()}");