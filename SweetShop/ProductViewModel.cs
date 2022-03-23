namespace SweetShop
{
    class ProductViewModel
    {
        public ProductViewModel(Product product)
        {

            this.Product = product;
            this.PriceString = string.Format("{0:C}", this.Product.Cost);
        }
        public Product Product
        {
            private set;
            get;
        }
        public string PriceString
        {
            private set;
            get;
        }
    }
}
