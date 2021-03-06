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
    
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            this.ClassRooms = new HashSet<ClassRoom>();
            this.CourseProfessors = new HashSet<CourseProfessor>();
            this.Enrollments = new HashSet<Enrollment>();
        }
    
        public int CourseID { get; set; }
        public int CourseNumber { get; set; }
        public string Title { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.TimeSpan EndTime { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string ClassDates { get; set; }
        public int Credits { get; set; }
        public int Capacity { get; set; }
        public bool Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassRoom> ClassRooms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseProfessor> CourseProfessors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
