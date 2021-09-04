using SEDC.CSharpAdv.VideoRentalData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.CSharpAdv.VideoRentalData.Database
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository()
        {
            Seed();
        }

        private void Seed()
        {
            if (!_db.Read().Any())
            {
                _db.Seed(new List<User>
                {
                    new User() { Id = 1, CardNumber = 123, FullName = "Simona Milanova" }
                });
            }
            
        }
        public User GetUserByIdCard(int idCard) 
        {
            return _db.Read().FirstOrDefault(x => x.CardNumber == idCard); 
        }

        public List<int> GetAllCardNumbers()
        {
            return _db.Read().Select(x => x.CardNumber).ToList();
        }

    }
}
