namespace SyringFrontToBack.Models
{
    public class SideBarProductsComponent
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string FilePath { get; set; }
        public string Price { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}
