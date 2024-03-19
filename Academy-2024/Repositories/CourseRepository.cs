using Academy_2024.Data;
using Academy_2024.Models;

namespace Academy_2024.Repositories
{
    public class CourseRepository
    {
        //private static List<Course> Courses=new List<Course> { new Course { Id = 1, Name = "Math", Description = "Upper matematic" } };
        private readonly ApplicationDbContext _context;

        
        public CourseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Course> GetAll() => _context.Courses.ToList();

                                      //visszaadjuk az első olyan kurzust       amelyikre EZ TRUE-t ad vissza
        public Course? GetById(int id) => _context.Courses.FirstOrDefault(course => course.Id == id);

        public void Create(Course data)
        {
            _context.Courses.Add(data);
            _context.SaveChanges();//ha modositunk adatot a db-ben akkor ez tölti fel ténylengesen az adatbáziba
        }

        public Course? Update(int id, Course data) {
            var course = _context.Courses.FirstOrDefault(user => user.Id == id);
           
            /*if (course != null)
            {
                course.Name = data.Name;
                course.Description = data.Description;
            */
                _context.SaveChanges();
            /*    return course;
            }*/

            return null;
        }
        public bool Delete(int id)
        {
            var course = _context.Courses.FirstOrDefault(user => user.Id == id);
            if (course != null){
                    _context.Courses.Remove(course);
                    return true;
            }
            return false;
        }
    }
}
