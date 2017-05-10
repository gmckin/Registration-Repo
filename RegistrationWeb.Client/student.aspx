<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="RegistrationWeb.Client.student" MasterPageFile="~/Site.Master" %>

<asp:Content ContentPlaceHolderID="body" runat="server">

     <div>    
      <asp:Button ID="BackHome" runat="server" PostBackUrl="~/default.aspx" Text="Home Page" />
    </div>
 
  <asp:Label runat="server" ID="userinputstudentid">Student ID</asp:Label>
  <asp:TextBox runat="server" ID="userinput_StudentID_Text" Wrap="False"></asp:TextBox>

 <%-- <asp:Label runat="server" ID="userinputcourseid">Course IDc</asp:Label>
  <asp:TextBox runat="server" ID="userinput_CourseID_Text"></asp:TextBox>--%>

  <div runat="server" id="coursessection" style="columns:auto">
    <asp:ListBox runat="server" ID="courseList" Width="281px" AutoPostBack="True"></asp:ListBox>

  <asp:Button runat="server" ID="CoursesButton" OnClick="CoursesButton_Click" Text="Get Enrolled Courses" />
  
    
  
  </div>

  <div runat="server" id="clist">

   <asp:ListBox runat="server" ID="opencourses" AutoPostBack="True" Width="278px" ></asp:ListBox>
    <asp:Button runat="server" ID="EnrollNow" OnClick="EnrollNowButton_Click" Text="Enroll into Courses" />
    <asp:Button runat="server" ID="DeleteNow" OnClick="DeleteNowButton_Click" Text="Unenroll from Course" />
  </div>
</asp:Content>
