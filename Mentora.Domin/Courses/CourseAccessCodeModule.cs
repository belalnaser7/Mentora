namespace Mentora.Domain.Courses
{
    public class CourseAccessCodeModule 
    {
        //foregin key
        public int CourseAccessCodeId { get; set; }// primary key  

        public CourseAccessCode CourseAccessCode { get; set; } = default!;
        //foregin key
        public int ModuleId { get; set; }// primary key  

        public Module Module { get; set; } = default!;
    }
}
