using Domain.Models;
namespace Infrastructure.Services;

public class TeacherService
{


List<Teacher> Teachers=new List<Teacher>();

public List<Teacher> GetTeachers(){

   return Teachers;

}

public void AddTeacher(Teacher teacher){

    Teachers.Add(teacher);
}

public void UpdateTeacher(Teacher teacher){

foreach ( var teach  in Teachers)
{
    if(teacher.Id==teach.Id){
       teach.FirstName=teacher.FirstName;
       teach.LastName=teacher.LastName;
       teach.Position=teacher.Position;
       teach.ExperienceAmount=teacher.ExperienceAmount;
    }
    
}

}
public void Delete(int id){

 for (int i = 0; i < Teachers.Count; i++)
 {
    if(id==Teachers[i].Id){
Teachers.Remove(Teachers[i]);

    }
    
 }

}
























}
