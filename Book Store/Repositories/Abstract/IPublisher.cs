using Book_Store.Models.Domain;

namespace Book_Store.Repositories.Abstract
{
    public interface IPublisher
    {
        bool Add(Publisher model);
        bool Update(Publisher model);
        bool Delete(int id);
        Publisher FindById(int id);
        IEnumerable<Publisher> GetAll();
    }
}
