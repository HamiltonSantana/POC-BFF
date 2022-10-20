namespace Domain.Entities
{
    public class Movie : BaseEntity
    {
        public string Description { get; set; }
        public int CategorieID { get; set; }
    }
}