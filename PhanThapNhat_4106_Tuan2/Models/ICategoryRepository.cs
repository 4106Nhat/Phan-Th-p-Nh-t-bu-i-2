namespace PhanThapNhat_4106_Tuan2.Models
{
    public interface ICategoryRepository
    {

        IEnumerable<Category> AllCategories { get; }
    }
}
