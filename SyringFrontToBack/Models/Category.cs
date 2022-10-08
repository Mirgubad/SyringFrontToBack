namespace SyringFrontToBack.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<SideBarProductsComponent>sideBarProductsCategories { get; set; }
    }
}
