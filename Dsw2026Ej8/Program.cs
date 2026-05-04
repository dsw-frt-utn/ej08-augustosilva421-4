namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Sale(1, 2);
            var b = new WholesaleSale(1, 2);
            var c = new RetailSale(1, 2);
            var helper = new Problema5();
            
            Console.WriteLine(helper.ObtenerImporteFinal(a) == 2);
            Console.WriteLine(helper.ObtenerImporteFinal(b) == 2 * 0.9m);
            Console.WriteLine(helper.ObtenerImporteFinal(c) == 2);
        }
    }
}
