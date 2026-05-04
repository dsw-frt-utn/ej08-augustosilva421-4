namespace Dsw2026Ej8
{
    internal class Problema6
    {
        public string NormalizarCodigoProducto(string code)
        {
            return code is null ? "SIN-CODIGO" : code.ToProductCode();
        }
    }
}
