namespace Mynda.Shared.DTOs;

public class SchoolDTO
{
    public string? Name { get; set; }
    
    public string? Email { get; set; }
    
    public string? PhoneNumber { get; set; }
    
    public string? TrainingSchoolLicense { get; set; }
    
    public string? Description { get; set; }
    
    public string? CourseName { get; set; }
    
    public enum CourseLocation { Remote , Onsite }
    
    public string? CourseDetails { get; set; }
    
    public string? CoursePrice { get; set; }
    
    public string? Question { get; set; }
    
    public string? Answer { get; set; }
    
    public string? VideoUrl { get; set; }
}