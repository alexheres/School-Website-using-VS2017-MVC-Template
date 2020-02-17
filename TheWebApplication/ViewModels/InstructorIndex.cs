using System.Collections.Generic;
using TheWebApplication.Models;

namespace TheWebApplication.ViewModels
{
    // a ViewModel, to represent all related information regarding an instructor
    public class InstructorIndexData
    {
        public IEnumerable<Instructor> Instructors { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}