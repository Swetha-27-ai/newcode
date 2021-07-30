using OnlinePlatform.DAL.Abstract;
using OnlinePlatform.ENTITIES.Concrete;

namespace OnlinePlatform.DAL.Concrete
{
    public class UserRepository : Repository<User, DatabaseContext>, IUserRepository
    {
        
    }
}
