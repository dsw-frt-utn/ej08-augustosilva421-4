namespace Dsw2026Ej8
{
    internal static class Extensions
    {
        extension(string str)
        {
            public string ToProductCode()
            {
                return str.Trim().ToUpper().Replace(' ', '-');
            }
        }
    }
}
