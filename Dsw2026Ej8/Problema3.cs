namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copiedValue = originalValue;

            copiedValue++;

            Product copiedProduct = product;

            copiedProduct.SetDescription("Nueva descripcion");

            return $"{originalValue}-{copiedValue}-{product.GetDescription()}";
        }
    }
}
