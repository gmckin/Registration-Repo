//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationApp.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class CourseProfessor
    {
        public int CourseProfessorID { get; set; }
        public int CourseID { get; set; }
        public int ProfessorID { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Professor Professor { get; set; }
    }
}