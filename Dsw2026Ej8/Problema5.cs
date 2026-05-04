namespace Dsw2026Ej8
{
    internal class Sale
    {
        protected int _unitPrice;
        protected int _quantity;

        public Sale(int unitPrice, int quantity)
        {
            _unitPrice = unitPrice;
            _quantity = quantity;    
        }


        public virtual decimal CalculateTotal()
        {
            return _unitPrice * _quantity;
        }
    }

    internal class RetailSale : Sale
    {
        public RetailSale(int unitPrice, int quantity) : base(unitPrice, quantity) {}

        public override decimal CalculateTotal()
        {
            return _unitPrice * _quantity;
        }
    }

    internal class WholesaleSale : Sale
    {
        public WholesaleSale(int unitPrice, int quantity) : base(unitPrice, quantity) {}

        public override decimal CalculateTotal()
        {
           decimal total = _unitPrice * _quantity;
           return total * 0.9m;
        }
    }

    internal class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale)
        {
            return sale.CalculateTotal();
        }
    }
}
