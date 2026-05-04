namespace Dsw2026Ej8
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            var values = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = quantity <= 0 ? 0 : quantity * unitPrice,
            };

            return $"{values.Code}-{values.Description}-{values.Total}";
        }
    }
}
