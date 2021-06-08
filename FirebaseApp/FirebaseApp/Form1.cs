using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebaseApp.Model;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace FirebaseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private async void Form1_Load(object sender, EventArgs e)
        {
            if(UtilityClass.IsCheckInternet())
            {
                GetAllEmployee();
            }
            else
            {
                MessageBox.Show(@"Please check your internet connection", @"Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
           
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            if(employeeNameTextBox.Text.Trim()==String.Empty)
            {
                MessageBox.Show(@"Please type employee name", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                employeeNameTextBox.Focus();
                return;
            }
            Employee anEmployee=new Employee();
            anEmployee.Id = lblId.Text;
            anEmployee.Name = employeeNameTextBox.Text;
            anEmployee.Address = addressTextBox.Text;
            anEmployee.Email = emailTextBox.Text;
            anEmployee.PhoneNo = phoneNoTextBox.Text;
            anEmployee.FatherName = fatherNameTextBox.Text;

            IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret = "sDG0TdrRppattBwqqZeC6vS4Wa3lrjmba2waveuw",
                BasePath = "https://firstapp-5e5ac.firebaseio.com/"
            };

            IFirebaseClient client=new FirebaseClient(config);
            if (UtilityClass.IsCheckInternet())
            {
                if (saveButton.Text == @"Save")
                {
                    PushResponse message = await client.PushAsync("EmployeeList", anEmployee);
                    if (message.Body != null)
                    {
                        MessageBox.Show("Emplyee information has been saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                        GetAllEmployee();
                    }
                    else
                    {
                        MessageBox.Show("Not saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (saveButton.Text == @"Update")
                {
                    var message = await client.UpdateAsync("EmployeeList/" + anEmployee.Id, anEmployee);
                    if (message.Body != null)
                    {
                        MessageBox.Show("Emplyee information has been updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                        saveButton.Text = "Save";
                        GetAllEmployee();
                    }
                    else
                    {
                        MessageBox.Show("Not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Please check your internet connection", @"Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

           

          
                       

        }

        private void Reset()
        {
            employeeNameTextBox.Clear();
            fatherNameTextBox.Clear();
            emailTextBox.Clear();
            addressTextBox.Clear();
            phoneNoTextBox.Clear();
            employeeDataGridView.Rows.Clear();
            deleteButton.Enabled = false;
        }


        public async void GetAllEmployee()
        {
            IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret = "sDG0TdrRppattBwqqZeC6vS4Wa3lrjmba2waveuw",
                BasePath = "https://firstapp-5e5ac.firebaseio.com/"
            };

            IFirebaseClient client = new FirebaseClient(config);

            var data = await client.GetAsync("EmployeeList");

            if (data.Body != "null")
            {
                Dictionary<string, Employee> employees = data.ResultAs<Dictionary<string, Employee>>();

                foreach (var employee in employees)
                {
                    employeeDataGridView.Rows.Add(employee.Key,employee.Value.Name, employee.Value.PhoneNo, employee.Value.Address,
                        employee.Value.FatherName, employee.Value.Email);
                }
            }
        }

        public async Task<Employee> GetEmployee(string id)
        {
            IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret = "sDG0TdrRppattBwqqZeC6vS4Wa3lrjmba2waveuw",
                BasePath = "https://firstapp-5e5ac.firebaseio.com/"
            };

            IFirebaseClient client = new FirebaseClient(config);

            var data = await client.GetAsync("EmployeeList/"+id);

            Employee anEmployee=new Employee();
            if (data.Body != "null")
            {
                anEmployee = data.ResultAs<Employee>();
                anEmployee.Id = id;

            }

            return anEmployee;
        }

        private async void employeeDataGridView_DoubleClick(object sender, EventArgs e)
        {
            string id= employeeDataGridView.SelectedCells[0].Value.ToString();

            Employee anEmployee =await GetEmployee(id);
            lblId.Text = anEmployee.Id;
            employeeNameTextBox.Text = anEmployee.Name;
            phoneNoTextBox.Text = anEmployee.PhoneNo;
            addressTextBox.Text = anEmployee.Address;
            fatherNameTextBox.Text = anEmployee.FatherName;
            emailTextBox.Text = anEmployee.Email;
            //employeeNameTextBox.Text = employeeDataGridView.SelectedCells[1].Value.ToString();
            //phoneNoTextBox.Text = employeeDataGridView.SelectedCells[2].Value.ToString();
            //addressTextBox.Text = employeeDataGridView.SelectedCells[3].Value.ToString();
            //fatherNameTextBox.Text = employeeDataGridView.SelectedCells[4].Value.ToString();
            //emailTextBox.Text = employeeDataGridView.SelectedCells[5].Value.ToString();
            saveButton.Text = "Update";
            deleteButton.Enabled = true;
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret = "sDG0TdrRppattBwqqZeC6vS4Wa3lrjmba2waveuw",
                BasePath = "https://firstapp-5e5ac.firebaseio.com/"
            };

            string id = lblId.Text;
            IFirebaseClient client = new FirebaseClient(config);

            var data = await client.DeleteAsync("EmployeeList/" + id);
            if (data.StatusCode.ToString()=="OK")
            {
                MessageBox.Show("Emplyee information has been deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                saveButton.Text = "Save";
                GetAllEmployee();

            }
        }

       
        

       
    }
}
