using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationWeb.Logic.Fun
{
  class StudentInfo
  {
    private RegistrationServiceClient rsc = new RegistrationServiceClient();

    public List<StudentViewModel> GetAllStudents()
    {
      //return the List<TraineeViewModel> from TraineeDAL
      //Here you will need to use the methods you create in 
      //Dive 1 in order to display the Height and proper cell phone display
      List<StudentViewModel> students = rsc.GetStudents();
      foreach (var item in students)
      {
        //for each item take the Height and CellNbr values,
        //use the HeightDisplay and PhoneDisplay methods
        //and store the returned values from the methods
        //into the HeightDisplay and PhoneDisplay properties of the item.
        //The DisplayHeight is done for you.
        item.DisplayHeight = HeightDisplay(item.Height);
      }
      return students;
    }

    //Returns ViewModel of Trainee by the Id
    public StudentViewModel GetStudentById(int id)
    {
      return rsc.GetStudentById(id);
    }

    //Edits the Trainee accepting a TraineeViewModel
    public int EditStudent(StudentViewModel edit)
    {
      return rsc.EditStudent(edit);
    }

    //Adds a new Trainee
    public int AddStudent(StudentViewModel add)
    {
      return rsc.AddStudent(add);
    }

    //Deletes a trainee by the Id, Delete only needs the id of Trainee
    public int DeleteStudent(int id)
    {
      return rsc.DeleteTrainee(id);
    }
    
  }
}
