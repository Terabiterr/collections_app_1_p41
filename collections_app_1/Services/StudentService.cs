using collections_app_1.DbContext;
using collections_app_1.Models;

namespace collections_app_1.Services
{
    public interface IStudentService
    {
        public void CreateStudent(Student student);
        public IEnumerable<Student> GetAll();
        public void UpdateStudent(int id, Student student);
        public void DeleteStudent(int id);
    }
    public class StudentService : IStudentService
    {
        private List<Student> Students = AcademyContext.GetStudents() as List<Student>;
        public void CreateStudent(Student student)
        {
            
        }

        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(int id, Student student)
        {
            throw new NotImplementedException();
        }
    }
}
