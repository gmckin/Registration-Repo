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
  public partial class student : System.Web.UI.Page
  {
    protected int idx = 0;
    protected DataService data = new DataService();
    protected void Page_Load(object sender, EventArgs e)
    {
      Enrollable();
    }


    protected void CoursesButton_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrWhiteSpace(userinput_StudentID_Text.Text))
      {
        
        var data = new DataService();
        courseList.Items.Clear();
        var courses = data.GetStudentEnrollments(int.Parse(userinput_StudentID_Text.Text));
        foreach (var item in courses)
        {
          courseList.Items.Add(new ListItem() { Text = item.Title });
        }
      }

      else
      {
        courseList.Text = "quit clicking me!";
      }
    }



    //private void opencourses_OnClick(object sender, EventArgs e)
    //{
    //  string cou = opencourses.SelectedItem.ToString();
    //}

    protected void EnrollNowButton_Click(object sender, EventArgs e)
    {
      AddCourse(int.Parse(userinput_StudentID_Text.Text));

    }
    protected void DeleteNowButton_Click(object sender, EventArgs e)
    {
      DeleteCourse(int.Parse(userinput_StudentID_Text.Text));
    }
    protected void GetCoursesByStudentID(int idx)
    {
      var data = new DataService();
      courseList.Items.Clear();
      foreach (var item in data.GetStudentEnrollments(idx))
      {
        courseList.Items.Add(new ListItem() { Text = item.Title, Value = item.CourseID.ToString() });
      }
    }

    protected void courseList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void StudentList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Enrollable()
    {     
      var courses = data.GetCourses().Where(c => c.Active = true);
      foreach (var item in courses)
      {
        opencourses.Items.Add(new ListItem() { Text = item.Title, Value = item.Id.ToString() });
      }      
    }

    protected void AddCourse(int sid)
    {
      var student = new StudentDAO();
      var course = new CourseDAO();
      sid = int.Parse(userinput_StudentID_Text.Text);
      var data = new DataService();
      List<CourseDAO> c = data.GetCourses().Where(x => x.Id == int.Parse(opencourses.SelectedValue)).ToList();

      //sid, c[0].Id, c[0].CourseNumber, c[0].StartTime
      data.InsertEnrollment(new StudentDAO() { Id = sid }, new CourseDAO() { Id = c[0].Id, CourseNumber = c[0].CourseNumber, StartTime = c[0].StartTime });
      GetCoursesByStudentID(sid);
      
    }

    protected void DeleteCourse(int id)
    {
      id = int.Parse(userinput_StudentID_Text.Text);
      var data = new DataService();
      List<CourseDAO> c = data.GetCourses().Where(x => x.Title == courseList.SelectedValue).ToList();
      data.DeleteCourseEnrollment(new StudentDAO() { Id = id }, new CourseDAO() { CourseNumber = c[0].CourseNumber, });

      GetCoursesByStudentID(id);
    }
  }
}