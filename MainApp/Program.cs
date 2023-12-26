using Domain.Models;
using Infrastructure.Services;

var Stud1=new Student();
System.Console.WriteLine("ДАННЫЕ ПЕРВОГО СТУДЕНТА: ");
System.Console.WriteLine("ВВЕДИТЕ ID СТУДЕНТА: ");
Stud1.Id=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ ИМЯ ПЕРВОГО СТУДЕНТА: ");
Stud1.FirstName=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ ФАМИЛИЮ ПЕРВОГО СТУДЕНТА: ");
Stud1.LastName=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ ДЕНЬ РОЖДЕНИЕ ПЕРВОГО СТУДЕНТА: ");
int day1=Convert.ToInt32(Console.ReadLine());
int month1=Convert.ToInt32(Console.ReadLine());
int year1=Convert.ToInt32(Console.ReadLine());
Stud1.BirthDate=new DateTime(day1,month1,year1);
System.Console.WriteLine("ВВЕДИТЕ АДДРЕС ПЕРВОГО СТУДЕНТА: ");
Stud1.Addres=Console.ReadLine();
System.Console.WriteLine("-------------------------------------------------------------------------------------");
//----------------------------------------------------------------------------------------------
var Stud2=new Student();
System.Console.WriteLine("ДАННЫЕ ВТОРОГО СТУДЕНТА: ");
System.Console.WriteLine("ВВЕДИТЕ ID СТУДЕНТА: ");
Stud2.Id=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ ИМЯ ВТОРОГО СТУДЕНТА: ");
Stud2.FirstName=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ ФАМИЛИЮ ВТОРОГО СТУДЕНТА: ");
Stud2.LastName=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ ДЕНЬ РОЖДЕНИЕ ВТОРОГО СТУДЕНТА: ");
int day2=Convert.ToInt32(Console.ReadLine());
int month2=Convert.ToInt32(Console.ReadLine());
int year2=Convert.ToInt32(Console.ReadLine());
Stud2.BirthDate=new DateTime(day2,month2,year2);
System.Console.WriteLine("ВВЕДИТЕ АДДРЕС ВТОРОГО СТУДЕНТА: ");
Stud2.Addres=Console.ReadLine();
System.Console.WriteLine("-------------------------------------------------------------------------------------");
//----------------------------------------------------------------------------------------------
var Stud3=new Student();
System.Console.WriteLine("ДАННЫЕ ТРЕТЬЕГО СТУДЕНТА: ");
System.Console.WriteLine("ВВЕДИТЕ ID СТУДЕНТА: ");
Stud3.Id=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ ИМЯ ТРЕТЬЕГО СТУДЕНТА: ");
Stud3.FirstName=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ ФАМИЛИЮ ТРЕТЬЕГО СТУДЕНТА: ");
Stud3.LastName=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ ДЕНЬ РОЖДЕНИЕ ТРЕТЬЕГО СТУДЕНТА: ");
int day3=Convert.ToInt32(Console.ReadLine());
int month3=Convert.ToInt32(Console.ReadLine());
int year3=Convert.ToInt32(Console.ReadLine());
Stud3.BirthDate=new DateTime(day3,month3,year3);
System.Console.WriteLine("ВВЕДИТЕ АДДРЕС ТРЕТЬЕГО СТУДЕНТА: ");
Stud3.Addres=Console.ReadLine();
System.Console.WriteLine("-------------------------------------------------------------------------------------");

var StudentService=new StudentService();
StudentService.AddStudent(Stud1);
StudentService.AddStudent(Stud2);
StudentService.AddStudent(Stud3);
foreach (var stud in StudentService.GetStudents())
{  System.Console.WriteLine("ID: "+stud.Id);
    System.Console.WriteLine("FirstName: "+stud.FirstName);
    System.Console.WriteLine("LastName: "+stud.LastName);
    System.Console.WriteLine("BirthDate: "+stud.BirthDate);
    System.Console.WriteLine("Addres: "+stud.Addres);
    System.Console.WriteLine("-------------------------------------------------------------------------------------");
    
}
System.Console.WriteLine("----------------------------------------------------------------------------------------------");

//----------------------------------------------------------------------------------------------

var stud11=new Student();
System.Console.WriteLine("ДАННЫЕ СТУДЕНТА КОТОРОГО ХОТИТЕ ИЗМЕНИТЬ!!!!");
System.Console.WriteLine("ВВЕДИТЕ ID СТУДЕНТА КОТОРОГО ХОТИТЕ ИЗМЕНИТЬ:");
Stud1.Id=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ ИМЯ СТУДЕНТА КОТОРОГО ХОТИТЕ ИЗМЕНИТЬ:");
Stud1.FirstName=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ ФАМИЛИЮ СТУДЕНТА КОТОРОГО ХОТИТЕ ИЗМЕНИТЬ: ");
Stud1.LastName=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ ДЕНЬ РОЖДЕНИЕ СТУДЕНТА КОТОРОГО ХОТИТЕ ИЗМЕНИТЬ: ");
int day4=Convert.ToInt32(Console.ReadLine());
int month4=Convert.ToInt32(Console.ReadLine());
int year4=Convert.ToInt32(Console.ReadLine());
Stud1.BirthDate=new DateTime(day4,month4,year4);
System.Console.WriteLine("ВВЕДИТЕ АДДРЕС СТУДЕНТА КОТОРОГО ХОТИТЕ ИЗМЕНИТЬ: ");
Stud1.Addres=Console.ReadLine();

StudentService.UpdateStudent(stud11);

System.Console.WriteLine("ИЗМЕННЫЙ СПИСОК СТУДЕНТОВ!!!!!!!!");
foreach (var stud in StudentService.GetStudents())
{  System.Console.WriteLine("ID: "+stud.Id);
    System.Console.WriteLine("FirstName: "+stud.FirstName);
    System.Console.WriteLine("LastName: "+stud.LastName);
    System.Console.WriteLine("BirthDate: "+stud.BirthDate);
    System.Console.WriteLine("Addres: "+stud.Addres);
    System.Console.WriteLine("-------------------------------------------------------------------------------------");
    
}
System.Console.WriteLine("-------------------------------------------------------------------------------------");

System.Console.WriteLine("ВВЕДИТЕ ID СТУДЕНТА КОТОРОГО ХОТИТЕ УДАЛИТЬ: ");
StudentService.Delete(Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine("ИЗМЕННЫЙ СПИСОК ПОСЛЕ УДАЛЕНИЯ СТУДЕНТA!!!!!!");
foreach (var stud in StudentService.GetStudents())
{  System.Console.WriteLine("ID: "+stud.Id);
    System.Console.WriteLine("FirstName: "+stud.FirstName);
    System.Console.WriteLine("LastName: "+stud.LastName);
    System.Console.WriteLine("BirthDate: "+stud.BirthDate);
    System.Console.WriteLine("Addres: "+stud.Addres);
    System.Console.WriteLine("-------------------------------------------------------------------------------------");
    
}
System.Console.WriteLine("-------------------------------------------------------------------------------------");
System.Console.WriteLine("-------------------------------------------------------------------------------------");
System.Console.WriteLine("-------------------------------------------------------------------------------------");
System.Console.WriteLine("-------------------------------------------------------------------------------------");
System.Console.WriteLine("-------------------------------------------------------------------------------------");





var Teach1=new Teacher();
System.Console.WriteLine("ДАННЫЕ ПЕРВОГО УЧИТЕЛЯ!!!");
System.Console.WriteLine("ВВЕДИТЕ ID УЧИТЕЛЯ: ");
Teach1.Id=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ ИМЯ ПЕРВОГО УЧИТЕЛЯ: ");
Teach1.FirstName=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ ФАМИЛИЮ ПЕРВОГО УЧИТЕЛЯ: ");
Teach1.LastName=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ УРОВЕНЬ ПЕРВОГО УЧИТЕЛЯ: ");
Teach1.Position=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ ЧИСЛО ЛЕТ СТАЖА ПЕРВОГО УЧИТЕЛЯ: ");
Teach1.ExperienceAmount=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("-------------------------------------------------------------------------------------");
//----------------------------------------------------------------------------------------------
var Teach2=new Teacher();
System.Console.WriteLine("ДАННЫЕ ВТОРОГО УЧИТЕЛЯ!!!");
System.Console.WriteLine("ВВЕДИТЕ ID УЧИТЕЛЯ: ");
Teach2.Id=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ ИМЯ ВТОРОГО УЧИТЕЛЯ: ");
Teach2.FirstName=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ ФАМИЛИЮ ВТОРОГО УЧИТЕЛЯ: ");
Teach2.LastName=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ УРОВЕНЬ ВТОРОГО УЧИТЕЛЯ: ");
Teach2.Position=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ ЧИСЛО ЛЕТ СТАЖА  ВТОРОГО УЧИТЕЛЯ: ");
Teach2.ExperienceAmount=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("-------------------------------------------------------------------------------------");
var Teach3=new Teacher();
System.Console.WriteLine("ДАННЫЕ ТРЕТЬЕГО УЧИТЕЛЯ!!!");
System.Console.WriteLine("ВВЕДИТЕ ID УЧИТЕЛЯ: ");
Teach3.Id=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ ИМЯ ТРЕТЬЕГО УЧИТЕЛЯ: ");
Teach3.FirstName=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ ФАМИЛИЮ ТРЕТЬЕГО УЧИТЕЛЯ: ");
Teach3.LastName=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ УРОВЕНЬ ТРЕТЬЕГО УЧИТЕЛЯ: ");
Teach3.Position=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ ЧИСЛО ЛЕТ СТАЖА  ТРЕТЬЕГО УЧИТЕЛЯ: ");
Teach3.ExperienceAmount=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("-------------------------------------------------------------------------------------");

var TeacherService=new TeacherService();
TeacherService.AddTeacher(Teach1);
TeacherService.AddTeacher(Teach2);
TeacherService.AddTeacher(Teach3);
foreach (var teach in TeacherService.GetTeachers())
{  System.Console.WriteLine("ID: "+teach.Id);
    System.Console.WriteLine("FirstName: "+teach.FirstName);
    System.Console.WriteLine("LastName: "+teach.LastName);
    System.Console.WriteLine("Position: "+teach.Position);
    System.Console.WriteLine("ExperienceAmount: "+teach.ExperienceAmount);
    System.Console.WriteLine("-------------------------------------------------------------------------------------");
    
}
System.Console.WriteLine("----------------------------------------------------------------------------------------------");

//----------------------------------------------------------------------------------------------

var Teach11=new Teacher();
System.Console.WriteLine("ДАННЫЕ  УЧИТЕЛЯ  КОТОРОГО ХОТИТЕ ИЗМЕНИТЬ !!!");
System.Console.WriteLine("ВВЕДИТЕ ID УЧИТЕЛЯ: ");
Teach11.Id=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ ИМЯ ТРЕТЬЕГО УЧИТЕЛЯ: ");
Teach11.FirstName=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ ФАМИЛИЮ ТРЕТЬЕГО УЧИТЕЛЯ: ");
Teach11.LastName=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ УРОВЕНЬ ТРЕТЬЕГО УЧИТЕЛЯ: ");
Teach11.Position=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ ЧИСЛО ЛЕТ СТАЖА  ТРЕТЬЕГО УЧИТЕЛЯ: ");
Teach11.ExperienceAmount=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("-------------------------------------------------------------------------------------");




TeacherService.UpdateTeacher(Teach11);

System.Console.WriteLine("ИЗМЕНЕНЫЙ СПИСОК УЧИТЕЛЕЙ!!!!!!!!");
foreach (var teach in TeacherService.GetTeachers())
{  System.Console.WriteLine("ID: "+teach.Id);
    System.Console.WriteLine("FirstName: "+teach.FirstName);
    System.Console.WriteLine("LastName: "+teach.LastName);
    System.Console.WriteLine("Position: "+teach.Position);
    System.Console.WriteLine("ExperienceAmount: "+teach.ExperienceAmount);
    System.Console.WriteLine("-------------------------------------------------------------------------------------");
    
}
System.Console.WriteLine("----------------------------------------------------------------------------------------------");


System.Console.WriteLine("ВВЕДИТЕ ID УЧИТЕЛЯ КОТОРОГО ХОТИТЕ УДАЛИТЬ: ");
TeacherService.Delete(Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine("ИЗМЕНЕНЫЙ СПИСОК ПОСЛЕ УДАЛЕНИЯ УЧИТЕЛЯ!!!!!!");
foreach (var teach in TeacherService.GetTeachers())
{  System.Console.WriteLine("ID: "+teach.Id);
    System.Console.WriteLine("FirstName: "+teach.FirstName);
    System.Console.WriteLine("LastName: "+teach.LastName);
    System.Console.WriteLine("Position: "+teach.Position);
    System.Console.WriteLine("ExperienceAmount: "+teach.ExperienceAmount);
    System.Console.WriteLine("-------------------------------------------------------------------------------------");
    
}

System.Console.WriteLine("-------------------------------------------------------------------------------------");
System.Console.WriteLine("-------------------------------------------------------------------------------------");
System.Console.WriteLine("-------------------------------------------------------------------------------------");
System.Console.WriteLine("-------------------------------------------------------------------------------------");
System.Console.WriteLine("-------------------------------------------------------------------------------------");









var Course1=new Course();
System.Console.WriteLine("ДАННЫЕ ПЕРВОГО КУРСА!!!");
System.Console.WriteLine("ВВЕДИТЕ ID КУРСА: ");
Course1.Id=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ TITLE ПЕРВОГО КУРСА: ");
Course1.Title=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ Description ПЕРВОГО КУРСА: ");
Course1.Description=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ FEE ПЕРВОГО КУРСА: ");
Course1.Fee=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ HasDiscount ПЕРВОГО КУРСА: ");
Course1.HasDiscount=Convert.ToBoolean(Console.ReadLine());
System.Console.WriteLine("-------------------------------------------------------------------------------------");
//----------------------------------------------------------------------------------------------
var Course2=new Course();
System.Console.WriteLine("ДАННЫЕ ВТОРОГО КУРСА!!!");
System.Console.WriteLine("ВВЕДИТЕ ID КУРСА: ");
Course2.Id=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ TITLE ВТОРОГО КУРСА: ");
Course2.Title=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ Description ВТОРОГО КУРСА: ");
Course2.Description=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ FEE ВТОРОГО КУРСА: ");
Course2.Fee=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ HasDiscount ВТОРОГО КУРСА: ");
Course2.HasDiscount=Convert.ToBoolean(Console.ReadLine());
System.Console.WriteLine("-------------------------------------------------------------------------------------");
System.Console.WriteLine("-------------------------------------------------------------------------------------");
var Course3=new Course();
System.Console.WriteLine("ДАННЫЕ ТРЕТЬЕГО КУРСА!!!");
System.Console.WriteLine("ВВЕДИТЕ ID КУРСА: ");
Course3.Id=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ TITLE ТРЕТЬЕГО КУРСА: ");
Course3.Title=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ Description ТРЕТЬЕГО КУРСА: ");
Course3.Description=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ FEE ТРЕТЬЕГО КУРСА: ");
Course3.Fee=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ HasDiscount ТРЕТЬЕГО КУРСА: ");
Course3.HasDiscount=Convert.ToBoolean(Console.ReadLine());
System.Console.WriteLine("-------------------------------------------------------------------------------------");
System.Console.WriteLine("-------------------------------------------------------------------------------------");

var CourseService=new CourseService();
CourseService.AddCourse(Course1);
CourseService.AddCourse(Course2);
CourseService.AddCourse(Course3);
foreach (var cour in CourseService.GetCourses())
{  System.Console.WriteLine("ID: "+cour.Id);
    System.Console.WriteLine("Title: "+cour.Title);
    System.Console.WriteLine("Description: "+cour.Description);
    System.Console.WriteLine("Fee: "+cour.Fee);
    System.Console.WriteLine("HasDiscount: "+cour.HasDiscount);
    System.Console.WriteLine("-------------------------------------------------------------------------------------");
    
}
System.Console.WriteLine("----------------------------------------------------------------------------------------------");

//----------------------------------------------------------------------------------------------

var Course11=new Course();
System.Console.WriteLine("ДАННЫЕ КУРСА КОТОРОГО ХОТИТЕ ИЗМЕНИТЬ !!!!!!");
System.Console.WriteLine("ВВЕДИТЕ ID КУРСА: ");
Course11.Id=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ TITLE  КУРСА: ");
Course11.Title=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ Description  КУРСА: ");
Course11.Description=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ FEE  КУРСА: ");
Course11.Fee=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ HasDiscount КУРСА: ");
Course11.HasDiscount=Convert.ToBoolean(Console.ReadLine());

System.Console.WriteLine("-------------------------------------------------------------------------------------");




CourseService.UpdateCourse(Course11);

System.Console.WriteLine("ИЗМЕНЕНЫЙ СПИСОК КУРСОВ!!!!!!!!");
foreach (var cour in CourseService.GetCourses())
{  System.Console.WriteLine("ID: "+cour.Id);
    System.Console.WriteLine("Title: "+cour.Title);
    System.Console.WriteLine("Description: "+cour.Description);
    System.Console.WriteLine("Fee: "+cour.Fee);
    System.Console.WriteLine("HasDiscount: "+cour.HasDiscount);
    System.Console.WriteLine("-------------------------------------------------------------------------------------");
    
}
System.Console.WriteLine("----------------------------------------------------------------------------------------------");


System.Console.WriteLine("ВВЕДИТЕ ID КУРСА КОТОРОГО ХОТИТЕ УДАЛИТЬ: ");
CourseService.Delete(Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine("ИЗМЕНЕНЫЙ СПИСОК ПОСЛЕ УДАЛЕНИЯ КУРСА!!!!!!");
foreach (var cour in CourseService.GetCourses())
{  System.Console.WriteLine("ID: "+cour.Id);
    System.Console.WriteLine("Title: "+cour.Title);
    System.Console.WriteLine("Description: "+cour.Description);
    System.Console.WriteLine("Fee: "+cour.Fee);
    System.Console.WriteLine("HasDiscount: "+cour.HasDiscount);
    System.Console.WriteLine("-------------------------------------------------------------------------------------");
    
}

System.Console.WriteLine("-------------------------------------------------------------------------------------");
System.Console.WriteLine("-------------------------------------------------------------------------------------");
System.Console.WriteLine("-------------------------------------------------------------------------------------");
System.Console.WriteLine("-------------------------------------------------------------------------------------");
System.Console.WriteLine("-------------------------------------------------------------------------------------");




var Post1=new Post();

System.Console.WriteLine("ДАННЫЕ ПЕРВОГО ПОСТА!!!");
System.Console.WriteLine("ВВЕДИТЕ ID ПОСТА: ");
Post1.Id=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ TITLE ПЕРВОГО ПОСТА: ");
Post1.Title=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ Description ПЕРВОГО ПОСТА: ");
Post1.Description=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ VoteAmount ПЕРВОГО ПОСТА: ");
Post1.VoteAmount=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ CreateAt ПЕРВОГО ПОСТА: ");
int day10=Convert.ToInt32(Console.ReadLine());
int month10=Convert.ToInt32(Console.ReadLine());
int year10=Convert.ToInt32(Console.ReadLine());
Post1.CreateAt=new DateTime(day10,month10,year10);
System.Console.WriteLine("-------------------------------------------------------------------------------------");



var Post2=new Post();

System.Console.WriteLine("ДАННЫЕ ВТОРОГО ПОСТА!!!");
System.Console.WriteLine("ВВЕДИТЕ ID ПОСТА: ");
Post2.Id=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ TITLE ВТОРОГО ПОСТА: ");
Post2.Title=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ Description ВТОРОГО ПОСТА: ");
Post2.Description=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ VoteAmount ВТОРОГО ПОСТА: ");
Post2.VoteAmount=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ CreateAt ВТОРОГО ПОСТА: ");
int day20=Convert.ToInt32(Console.ReadLine());
int month20=Convert.ToInt32(Console.ReadLine());
int year20=Convert.ToInt32(Console.ReadLine());
Post2.CreateAt=new DateTime(day20,month20,year20);
System.Console.WriteLine("-------------------------------------------------------------------------------------");

var Post3=new Post();

System.Console.WriteLine("ДАННЫЕ ТРЕТЬЕГО ПОСТА!!!");
System.Console.WriteLine("ВВЕДИТЕ ID ПОСТА: ");
Post3.Id=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ TITLE ТРЕТЬЕГО ПОСТА: ");
Post3.Title=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ Description ТРЕТЬЕГО ПОСТА: ");
Post3.Description=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ VoteAmount ТРЕТЬЕГО ПОСТА: ");
Post3.VoteAmount=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ CreateAt ТРЕТЬЕГО ПОСТА: ");
int daн30=Convert.ToInt32(Console.ReadLine());
int month30=Convert.ToInt32(Console.ReadLine());
int year30=Convert.ToInt32(Console.ReadLine());
Post3.CreateAt=new DateTime(daн30,month30,year30);
System.Console.WriteLine("-------------------------------------------------------------------------------------");


var PostService=new PostService();
PostService.AddPost(Post1);
PostService.AddPost(Post2);
PostService.AddPost(Post3);
foreach (var post in PostService.GetPosts())
{  System.Console.WriteLine("ID: "+post.Id);
    System.Console.WriteLine("Title: "+post.Title);
    System.Console.WriteLine("Description: "+post.Description);
    System.Console.WriteLine("VoteAmount: "+post.VoteAmount);
    System.Console.WriteLine("CreateAt: "+post.CreateAt);
    System.Console.WriteLine("-------------------------------------------------------------------------------------");
    
}
System.Console.WriteLine("----------------------------------------------------------------------------------------------");


var Post11=new Post();


System.Console.WriteLine("-------------------------------------------------------------------------------------");





PostService.UpdatePost(Post11);
System.Console.WriteLine("ДАННЫЕ  ПОСТА КОТОРОГО ХОТИТЕ ИЗМЕНИТЬ!!!");
System.Console.WriteLine("ВВЕДИТЕ ID ПОСТА: ");
Post1.Id=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ TITLE ПОСТА: ");
Post1.Title=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ Description ПОСТА: ");
Post1.Description=Console.ReadLine();
System.Console.WriteLine("ВВЕДИТЕ VoteAmount ПОСТА: ");
Post1.VoteAmount=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВЕДИТЕ CreateAt ПОСТА: ");
int day0=Convert.ToInt32(Console.ReadLine());
int month0=Convert.ToInt32(Console.ReadLine());
int year0=Convert.ToInt32(Console.ReadLine());
Post1.CreateAt=new DateTime(day0,month0,year0);
System.Console.WriteLine("-------------------------------------------------------------------------------------");

System.Console.WriteLine("ИЗМЕНЕНЫЙ СПИСОК ПОСТОВ!!!!!!!!");
foreach (var post in PostService.GetPosts())
{  System.Console.WriteLine("ID: "+post.Id);
    System.Console.WriteLine("Title: "+post.Title);
    System.Console.WriteLine("Description: "+post.Description);
    System.Console.WriteLine("VoteAmount: "+post.VoteAmount);
    System.Console.WriteLine("CreateAt: "+post.CreateAt);
    System.Console.WriteLine("-------------------------------------------------------------------------------------");
    
}
System.Console.WriteLine("----------------------------------------------------------------------------------------------");


System.Console.WriteLine("ВВЕДИТЕ ID ПОСТА КОТОРОГО ХОТИТЕ УДАЛИТЬ: ");
PostService.Delete(Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine("ИЗМЕНЕНЫЙ СПИСОК ПОСЛЕ УДАЛЕНИЯ ПОСТА!!!!!!");
foreach (var post in PostService.GetPosts())
{  System.Console.WriteLine("ID: "+post.Id);
    System.Console.WriteLine("Title: "+post.Title);
    System.Console.WriteLine("Description: "+post.Description);
    System.Console.WriteLine("VoteAmount: "+post.VoteAmount);
    System.Console.WriteLine("CreateAt: "+post.CreateAt);
    System.Console.WriteLine("-------------------------------------------------------------------------------------");
    
}