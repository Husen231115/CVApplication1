using WebApplication9.DataFolder;
using WebApplication9.DB_Model;
using WebApplication9.Model;

namespace WebApplication9.Services
{
    public class CVservice : ICV

    {
        private readonly AppDbContext _dbcontext;
        public CVservice(AppDbContext appDbContext)
        {

            _dbcontext = appDbContext;

        }
        public async Task<int> CreateCv(CV cv)
        {
            CV cv1 = new CV()
            {
                FirstName = cv.FirstName,
                LastName = cv.LastName,
                Skills = string.Join(", ", cv.Skills),
                PhoneNumber=cv.PhoneNumber,
                Nationality=cv.Nationality,
                Birthday=cv.Birthday,
                Password=cv.Password,
                Photo=cv.Photo,
                Email=cv.Email,
                
            };
            _dbcontext.Cv.Add(cv1);
            await _dbcontext.SaveChangesAsync();
            return cv1.Id; 

        }
        public async Task<CV> GetCVbyId(int id)
        {
           return await _dbcontext.Cv.FindAsync(id); 
        }
        

    }
}
