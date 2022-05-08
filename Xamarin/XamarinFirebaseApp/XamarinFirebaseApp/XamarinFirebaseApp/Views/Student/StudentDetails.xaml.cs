using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFirebaseApp.Views.Student
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentDetails : ContentPage
    {
        public StudentDetails(StudentModel student)
        {
            InitializeComponent();
            LabelName.Text = student.Name;
            LabelEmail.Text = student.Email;
        }
    }
}