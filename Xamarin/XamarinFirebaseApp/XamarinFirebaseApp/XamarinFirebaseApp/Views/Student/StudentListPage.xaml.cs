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
    public partial class StudentListPage : ContentPage
    {
        StudentRepository studentRepository = new StudentRepository();
        public StudentListPage()
        {
            InitializeComponent();

            StudentListView.RefreshCommand = new Command(() =>
            {
                OnAppearing();
            });
        }

        protected override async void OnAppearing()
        {
            var students= await studentRepository.GetAll();
            StudentListView.ItemsSource = null;
            StudentListView.ItemsSource = students;
            StudentListView.IsRefreshing = false;

        }

        private void AddToolBarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new StudentEntry());
        }

        private void StudentListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
            {
                return;
            }
            var studnet=e.Item as StudentModel;
            Navigation.PushModalAsync(new StudentDetails(studnet));
            ((ListView)sender).SelectedItem = null;
                
        }

        

        private async void DeleteTapp_Tapped(object sender, EventArgs e)
        {
           
           var response=await DisplayAlert("Delete", "Do you want to delete?","Yes", "No");
            if(response)
            {
                string id = ((TappedEventArgs)e).Parameter.ToString();
               bool isDelete= await studentRepository.Delete(id);
                if(isDelete)
                {
                    await DisplayAlert("Information", "Student has been deleted.", "Ok");
                    OnAppearing();
                }
                else
                {
                    await DisplayAlert("Error", "Student deleted failed.", "Ok");
                }
            }
        }

        private async void EditTap_Tapped(object sender, EventArgs e)
        {
            //DisplayAlert("Edit", "Do you want to Edit?", "Ok");

            string id = ((TappedEventArgs)e).Parameter.ToString();
            var student = await studentRepository.GetById(id);
            if(student==null)
            {
               await DisplayAlert("Warning", "Data not found.", "Ok");
            }
            student.Id = id;
            await Navigation.PushModalAsync(new StudentEdit(student));

        }

        private async void TxtSearch_SearchButtonPressed(object sender, EventArgs e)
        {
            string searchValue = TxtSearch.Text;
            if(!String.IsNullOrEmpty(searchValue))
            {
                var students =await studentRepository.GetAllByName(searchValue);
                StudentListView.ItemsSource = null;
                StudentListView.ItemsSource = students;
            }
            else
            {
                OnAppearing();
            }
        }

        private async void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchValue = TxtSearch.Text;
            if (!String.IsNullOrEmpty(searchValue))
            {
                var students = await studentRepository.GetAllByName(searchValue);
                StudentListView.ItemsSource = null;
                StudentListView.ItemsSource = students;
            }
            else
            {
                OnAppearing();
            }
        }

        private async void EditMenuItem_Clicked(object sender, EventArgs e)
        {
            string id = ((MenuItem)sender).CommandParameter.ToString();
            var student = await studentRepository.GetById(id);
            if (student == null)
            {
                await DisplayAlert("Warning", "Data not found.", "Ok");
            }
            student.Id = id;
            await Navigation.PushModalAsync(new StudentEdit(student));
        }

        private async void DeleteMenuItem_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayAlert("Delete", "Do you want to delete?", "Yes", "No");
            if (response)
            {
                string id = ((MenuItem)sender).CommandParameter.ToString();
                bool isDelete = await studentRepository.Delete(id);
                if (isDelete)
                {
                    await DisplayAlert("Information", "Student has been deleted.", "Ok");
                    OnAppearing();
                }
                else
                {
                    await DisplayAlert("Error", "Student deleted failed.", "Ok");
                }
            }
        }

        private async void EditSwipeItem_Invoked(object sender, EventArgs e)
        {
            string id = ((MenuItem)sender).CommandParameter.ToString();
            var student = await studentRepository.GetById(id);
            if (student == null)
            {
                await DisplayAlert("Warning", "Data not found.", "Ok");
            }
            student.Id = id;
            await Navigation.PushModalAsync(new StudentEdit(student));
        }
    }
}