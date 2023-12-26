
using Domain.Models;
namespace Infrastructure.Services;

public class CourseService
{
List<Course> Courses=new List<Course>();

public List<Course> GetCourses(){

   return Courses;

}

public void AddCourse(Course course){

    Courses.Add(course);
}

public void UpdateCourse(Course course){

foreach ( var cou in Courses)
{
    if(course.Id==cou.Id){
       cou.Title=course.Title;
       cou.Description=course.Description;
       cou.Fee=course.Fee;
       cou.HasDiscount=course.HasDiscount;
    }
    
}

}
public void Delete(int id){

 for (int i = 0; i < Courses.Count; i++)
 {
    if(id==Courses[i].Id){
Courses.Remove(Courses[i]);

    }
    
 }

}





}
