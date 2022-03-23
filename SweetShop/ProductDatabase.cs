using System.Collections.ObjectModel;

namespace SweetShop
{
    class ProductDatabase
    {
        public ProductDatabase()
        {
            ListOfItems = new ObservableCollection<Product>
            {
                new Product("😃", "Happy face", "A beautiful smile to brighten up your day.", 10),
                new Product("😟", "Unhappy face", "A depressing frown that brings you back down to reality.", 10),
                new Product("🐱‍👤", "Ninja cat", "Will fix everything.", 10)
            };
        }
        public ObservableCollection<Product> ListOfItems { get; set; }
    }
}
