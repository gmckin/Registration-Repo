<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrar.aspx.cs" Inherits="RegistrationWeb.Client.registrar" MasterPageFile="~/Site.Master" %>

<asp:Content ContentPlaceHolderID="body" runat="server">

    <div>    
      <asp:Button ID="BackHome" runat="server" PostBackUrl="~/default.aspx" Text="Home Page" />
    </div>
 
  <div>
     <h3>Create a new Student</h3>
    <asp:Label runat="server" ID="FName">First Name</asp:Label>
    <asp:TextBox runat="server" ID="FName_Text"></asp:TextBox>
    <asp:Label runat="server" ID="LName">Last Name</asp:Label>
    <asp:TextBox runat="server" ID="LName_Text"></asp:TextBox>
    <asp:Label runat="server" ID="Major">Major</asp:Label>
    <asp:TextBox runat="server" ID="Major_Text"></asp:TextBox>
    <asp:Button runat="server" ID="AddStudent_Button" OnClick="AddStudentButton_Click" Text="Submit" />

  </div>
  <div>
    <h2>Delete a Student</h2>
    <asp:Label runat="server" ID="userinputstudentid">Student ID</asp:Label>
  <asp:TextBox runat="server" ID="userinput_StudentID_Text"></asp:TextBox>
    <asp:Button runat="server" ID="DeleteStudent_Button" OnClick="DeleteStudentButton_Click" Text="Submit" />
  </div>
  <div>
   <h2>View Student Info</h2>
    <asp:Label runat="server" ID="GetStudentinfo">Student ID</asp:Label>
  <asp:TextBox runat="server" ID="GetStudentinfo_Text"></asp:TextBox>    
  <asp:ListBox runat="server" ID="studentcourses" Width="281px" AutoPostBack="True"></asp:ListBox>
    <asp:Button runat="server" ID="StudentInfo_Button" OnClick="StudentInfo_Button_Click" Text="Submit" />
  </div>
  
  <div>
    <h1>View Course Info</h1>
    <asp:Label runat="server" ID="userinputcourseid">Course ID</asp:Label>
  <asp:TextBox runat="server" ID="userinput_CourseID_Text"></asp:TextBox>
    <asp:ListBox runat="server" ID="studentslist" Width="281px" AutoPostBack="True"></asp:ListBox>
    <asp:Button runat="server" ID="GetCourseInfo_Button" OnClick="GetCourseInfo_Button_Click" Text="Submit" />
  </div>

  <div>
    <h1>Students</h1>
    <asp:ListBox runat="server" ID="StudentBox" AutoPostBack="true"></asp:ListBox>

  </div>

  <div>
    <h1>Courses</h1>
    <asp:ListBox runat="server" ID="courseList" Width="281px" AutoPostBack="True"></asp:ListBox>
  </div>
  
  <div>
    <h1>Add Course</h1>
    <asp:Label runat="server" ID="courseTitlelabel">Title</asp:Label>
    <asp:TextBox runat="server" ID="Title_Text"></asp:TextBox>
    <asp:Label runat="server" ID="numberlabel">CRN</asp:Label>
    <asp:TextBox runat="server" ID="number_text"></asp:TextBox>
    <asp:Label runat="server" ID="starttimelabel">Start Time</asp:Label>
    <asp:TextBox runat="server" ID="starttime_text"></asp:TextBox>
    <asp:Label runat="server" ID="endtimelabel">End Time</asp:Label>
    <asp:TextBox runat="server" ID="endtime_text"></asp:TextBox>
    <asp:Label runat="server" ID="startdatelabel">Start Date</asp:Label>
    <asp:TextBox runat="server" ID="startdate_text"></asp:TextBox>
    <asp:Label runat="server" ID="enddatelabel">End Date</asp:Label>
    <asp:TextBox runat="server" ID="enddate_text"></asp:TextBox>
    <asp:Label runat="server" ID="coursedateslabel">Course Dates</asp:Label>
    <asp:TextBox runat="server" ID="coursedates_text"></asp:TextBox>
    <asp:Label runat="server" ID="creditslabel">Credits</asp:Label>
    <asp:TextBox runat="server" ID="credits_text"></asp:TextBox>
    <asp:Label runat="server" ID="capacitylabel">Capacity</asp:Label>
    <asp:TextBox runat="server" ID="capacity_text"></asp:TextBox>
    <asp:Button runat="server" ID="AddCourse_Button" OnClick="AddCourse_Button_Click" Text="Submit" />
  </div>
    <asp:ListBox runat="server" ID="CoursesList" Width="281px" AutoPostBack="True"></asp:ListBox>

  <div>
    <h1>Delete Course</h1>
    <asp:Label runat="server" ID="deletecourselabel">Course ID</asp:Label>
    <asp:TextBox runat="server" ID="deletecourse_text"></asp:TextBox>
    <asp:Button runat="server" ID="DeleteCourse_Button" OnClick="DeleteCourseButton_Click" Text="Submit" />
  </div>

  <div>
    <h2>Enroll a Student</h2>
  <asp:Label runat="server" ID="enrollLabel">Student ID</asp:Label>
  <asp:TextBox runat="server" ID="enrollText"></asp:TextBox>
    <asp:Button runat="server" ID="Enroll_Button" OnClick="Enroll_Button_Click" Text="Submit"/>
     <asp:ListBox runat="server" ID="CList" Width="281px" AutoPostBack="True"></asp:ListBox>
  </div>
   
  <div>
    <h2>Unenroll a Student</h2>
     <asp:ListBox runat="server" ID="StudentsEnrolledList" Width="281px" AutoPostBack="True"></asp:ListBox>
    <asp:Label runat="server" ID="unenrollLabel">Student ID"</asp:Label>
    <asp:TextBox runat="server" ID="unenroll_Text"></asp:TextBox>
    <asp:Button runat="server" ID="unenrollButton" OnClick="Unenroll_Button_Click" Text="Submit" />
  </div>
 
</asp:Content>