
using Academy_2024.Data;
using Academy_2024.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Academy_2024.Repositories
{
    public class UserRepository
    {
        // private static List<User> Users = new List<User> { new User { Id = 1, FirstName = "John", LastName = "vsdf" } };
        private readonly ApplicationDbContent _context;

        public UserRepository()
        {
            _context= new ApplicationDbContent();
        }
        public List<User> GetAll() => _context.users.ToList();
        
        public List<User> GetAdults()
        {
            DateOnly eighteenYearsAgo = DateOnly.FromDateTime(DateTime.Now).AddYears(-18);
           return _context.users.Where(user => user.DateOfBirth < eighteenYearsAgo).ToList();
        }

        //LinkQ: memoriaban(list) és adatbázisban(query) is müködik
        public User? GetById(int id) => _context.users.FirstOrDefault(user => user.Id == id);
        
        public void Create(User data)
        {
            _context.users.Add(data);
            _context.SaveChanges();//ha modositunk adatot a db-ben akkor ez tölti fel ténylengesen az adatbáziba
        }

        public User? Update(int id, User data)
        {
            var user=_context.users.FirstOrDefault(user => user.Id == id);
            if (user != null)
            {
                user.FirstName = data.FirstName;
                user.LastName = data.LastName;

                _context.SaveChanges();
                return user;
            }

           
            return null;
        }
        public bool Delete(int id)
        {
            var user = _context.users.FirstOrDefault(user => user.Id == id);
            if (user.Id != null)
                {
                    _context.users.Remove(user);
                    _context.SaveChanges(); 
                    return true;
                }
            return false;
        }
    }
}
