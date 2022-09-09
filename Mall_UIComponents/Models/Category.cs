namespace Mall_UIComponents.Models
{
    public class Category
    {
        public int _id { get; set; }
        public string CategoryName { get; set; }

        public bool IsActive { get; set; }

        public List<Products> Products { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }

        public string UpdatedBy { get; set; }
    }
}
