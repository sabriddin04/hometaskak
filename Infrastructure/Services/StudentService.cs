using System.Data.Common;
using Domain.Models;

namespace Infrastructure.Services;

public class StudentService
{

List<Student> students=new List<Student>();

public List<Student> GetStudents(){

   return students;

}

public void AddStudent(Student student){

    students.Add(student);
}

public void UpdateStudent(Student student){

foreach ( var stud  in students)
{
    if(student.Id==stud.Id){
       stud.FirstName=student.FirstName;
       stud.LastName=student.LastName;
       stud.Addres=student.Addres;
       stud.BirthDate=student.BirthDate;
    }
    
}

}
public void Delete(int id){

 for (int i = 0; i < students.Count; i++)
 {
    if(id==students[i].Id){
students.Remove(students[i]);

    }
    
 }

}






}
