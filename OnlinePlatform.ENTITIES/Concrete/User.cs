using OnlinePlatform.ENTITIES.Abstract;

namespace OnlinePlatform.ENTITIES.Concrete
{
    public class User : BaseEntity,IEntity
    {
        public string NickName { get; set; }
        public string UserName { get; set; }
        public string UserSurName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
