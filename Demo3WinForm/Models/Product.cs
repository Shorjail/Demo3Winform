
namespace Demo3WinForm.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public virtual ProcessRoute Route { get; set; }
    }
}
