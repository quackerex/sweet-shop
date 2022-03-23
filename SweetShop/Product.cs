namespace SweetShop
{
    class Product
    {
        public Product(string image, string title, string description, decimal cost)
        {
            this.image = image;
            this.Title = title;
            this.Description = description;
            this.Cost = cost;
        }
        public string image { get; private set; }

        // The name of the product
        public string Title { get; private set; }

        // The detailed description of the product.
        public string Description { get; private set; }

        // The amount the product cost.
        // Note: Using the 'decimal' type significantly reduces the likelihood of rouding errors compared to other
        // types such as 'double'.
        public decimal Cost { get; private set; }
    }
}
