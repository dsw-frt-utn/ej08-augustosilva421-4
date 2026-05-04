namespace Dsw2026Ej8
{
    internal class Product
    {
        private string _description;

        public Product(string description)
        {
            _description = description;
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string newDescription)
        {
            _description = newDescription;
        }
    }
}
