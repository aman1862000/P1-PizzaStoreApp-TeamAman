using PizzaDbData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRepository.Classes
{
   public class UserRepository : Interfaces.IUserRepository
    {
        private PizzaDb db;
        public UserRepository(PizzaDb db)
        {
            this.db = db;
        }
        public void AddNewUser(User objuser)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUser()
        {
            return db.Users.ToList();
        }

        public User GetUserById(int id)
        {
            if (id > 0)
            {
             var data = db.Users.Where(d => d.id == id).FirstOrDefault();
             return data;
            }
            else
            {
                return null;
            }
        }
    }
}
