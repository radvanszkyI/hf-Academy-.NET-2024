using Academy_2024.Models;

namespace Academy_2024.Repositories
{
    public class CourseRepository
    {
        private static List<Course> Courses=new List<Course> { new Course { Id = 1, Name = "Math", Description = "Upper matematic" } };

        public List<Course> GetAll() { return Courses; }

        public Course? GetById(int id)
        {
            foreach (var course in Courses)
            {
                if (course.Id == id) { return course; }
            }
            return null;
        }

        public void Create(Course data)
        {
            Courses.Add(data);
        }

        public Course? Update(int id, Course data) {
            foreach (Course course in Courses)
            {
                if (course.Id == id)
                {
                    course.Name = data.Name;
                    course.Description = data.Description;
                    return course;
                }
            }
            return null;
        }
        public bool Delete(int id)
        {
            foreach (var course in Courses)
            {
                if (course.Id == id)
                {
                    Courses.Remove(course);
                    return true;
                }
            }
            return false;
        }
    }
}
