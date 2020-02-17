namespace TheWebApplication.ViewModels
{
    // a helper ViewModel, to aid in assigning an instructor's course information
    public class AssignedCourseData
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public bool Assigned { get; set; }
    }
}