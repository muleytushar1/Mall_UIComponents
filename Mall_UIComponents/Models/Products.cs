namespace Mall_UIComponents.Models
{
    public class Products
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public double ProductPrice { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }

        public string? UpdatedBy { get; set; }
    }
}
