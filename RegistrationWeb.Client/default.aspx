<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs"  Inherits="RegistrationWeb.Client._default" MasterPageFile="~/Site.Master" %>



<asp:Content runat="server" contentplaceholderid="body">

   <%--<asp:ListBox runat="server" ID="studentlist" ClientIDMode="Static"></asp:ListBox>--%>
    
    <div runat="server" id="button1" style="columns:auto">    
      <asp:Button runat="server" ID="Registrar"  PostBackUrl="~/registrar.aspx" Text="Registrar Page" />
    </div>
      <div runat="server" id="button2" style="columns:auto">    
      <asp:Button runat="server" ID="Student" PostBackUrl="~/student.aspx" Text="Student Page" />
    </div>
   <div>
     
     </div>

  </asp:Content>