using RegistrationWeb.Logic;
using RegistrationWeb.Logic.RegistrationServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationWeb.Client
{
  public partial class registrar : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      ShowCourses();
      ShowStudents();
    }

    protected void AddStudentButton_Click(Object sender, EventArgs e)
    {
      var data = new DataService();
      StudentDAO student = new StudentDAO();
      student.FirstName = FName_Text.Text;
      student.LastName = LName_Text.Text;
      student.Major = Major_Text.Text;

      data.InsertStudent( new StudentDAO { FirstName = student.FirstName, LastName = student.LastName, Major = student.Major ,Active = true });
      FName_Text.Text = string.Empty;
      LName_Text.Text = string.Empty;
      Major_Text.Text = string.Empty;
    }

    protected void DeleteStudentButton_Click(Object sender, EventArgs e)
    {
      var data = new DataService();
      data.DeleteStudent(int.Parse(userinput_StudentID_Text.Text));
      userinput_StudentID_Text.Text = string.Empty;
    }

    protected void StudentInfo_Button_Click(Object sender, EventArgs e)
    {
      studentcourses.Items.Clear();
      var data = new DataService();
      var courses = data.GetStudentEnrollments(int.Parse(GetStudentinfo_Text.Text));
      foreach (var item in courses)

      {
        studentcourses.Items.Add(new ListItem() { Text = item.Title });
      }
    }

    protected void ShowStudents()
    {
      var data = new DataService();
      var stu = data.GetStudents();
      foreach (var item in stu)
      {
        StudentBox.Items.Add(new ListItem() { Text = item.FirstName + " " + item.LastName });
      }
    }

    protected void ShowCourses()
    {
      var data = new DataService();
        var courses = data.GetCourses();
      foreach (var item in courses)
      {
        courseList.Items.Add(new ListItem() { Text = item.Title + " " + item.Credits + " " + item.Capacity });          
        CList.Items.Add(new ListItem() { Text = item.Title + " " + item.Credits + " " + item.Capacity });
        CoursesList.Items.Add(new ListItem() { Text = item.Title + " " + item.Credits + " " + item.Capacity });
      }
    }
    protected void GetCourseInfo_Button_Click(Object sender, EventArgs e)
    {
      courseList.Items.Clear();
      var data = new DataService();
      var student = data.GetCourseEnrollments(int.Parse(userinput_CourseID_Text.Text));
      foreach(var item in student)
      {
        studentslist.Items.Add(new ListItem() { Text = item.FirstName + " " + item.LastName });
      }   
    }

    protected void AddCourse_Button_Click(Object sender, EventArgs e)
    {
      var data = new DataService();
      CourseDAO course = new CourseDAO();
      course.Title = Title_Text.Text;
      course.CourseNumber = int.Parse(number_text.Text);
      course.StartTime = TimeSpan.Parse(starttime_text.Text);
      course.EndTime = TimeSpan.Parse(endtime_text.Text);
      course.StartDate = DateTime.Parse(startdate_text.Text);
      course.EndDate = DateTime.Parse(enddate_text.Text);
      course.ClassDates = coursedates_text.Text;
      course.Credits = int.Parse(credits_text.Text);
      course.Capacity = int.Parse(capacity_text.Text);
      data.InsertCourse(course);

      Title_Text.Text = string.Empty;
      number_text.Text = string.Empty;
      startdate_text.Text = string.Empty;
      starttime_text.Text = string.Empty;
      enddate_text.Text = string.Empty;
      endtime_text.Text = string.Empty;
      coursedates_text.Text = string.Empty;
      credits_text.Text = string.Empty;
      capacity_text.Text = string.Empty;
    }

    protected void DeleteCourseButton_Click(Object sender, EventArgs e)
    {
      var data = new DataService();
      var courses = data.GetCourses();
      foreach (var item in courses)
      {
        CoursesList.Items.Add(new ListItem() { Text = item.Title + " " + item.Credits + " " + item.Capacity });
      }
      data.DeleteCourse(int.Parse(deletecourse_text.Text));
      deletecourse_text.Text = string.Empty;
    }

    protected void Enroll_Button_Click(Object sender, EventArgs e)
    {
      var data = new DataService();
      var courses = data.GetCourses();
      foreach (var item in courses)
      {
        CList.Items.Add(new ListItem() { Text = item.Title + " " + item.Credits + " " + item.Capacity });
      }
      
      var sid = int.Parse(userinput_StudentID_Text.Text);
      List<CourseDAO> c = data.GetCourses().Where(d => d.Id == int.Parse(CList.SelectedValue)).ToList();
      data.InsertEnrollment(new StudentDAO() { Id = sid }, new CourseDAO() { Id = c[0].Id, Title = c[0].Title, StartTime = c[0].StartTime });
      CList.Items.Clear();
    }

    protected void Unenroll_Button_Click(Object sender, EventArgs e)
    {
      var sid = int.Parse(userinput_StudentID_Text.Text);
      var courseName = StudentsEnrolledList.SelectedItem.ToString();
      var data = new DataService();

      StudentDAO student = new StudentDAO() { Id = sid };
      CourseDAO course = new CourseDAO() { Title = courseName };
      data.DeleteCourseEnrollment(student, course);
      StudentsEnrolledList.Items.Clear();
    }
  }
}