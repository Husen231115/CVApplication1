using WebApplication9.DB_Model;

namespace WebApplication9.Services
{
    public interface ICV
    {
        Task<int> CreateCv(CV cv);
        Task<CV> GetCVbyId(int id ); 
    }
}
