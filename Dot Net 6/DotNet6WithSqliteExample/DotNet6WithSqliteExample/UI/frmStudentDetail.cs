using DotNet6WithSqliteExample.Manager;
using DotNet6WithSqliteExample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNet6WithSqliteExample.UI
{
    public partial class frmStudentDetail : Form
    {
        
        frmStudent frm;
        public frmStudentDetail(frmStudent frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        StudentManager _studentManager=new StudentManager();

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Please enter name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nameTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(fatherNameTextBox.Text))
                {
                    MessageBox.Show("Please enter father name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fatherNameTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(addressTextBox.Text))
                {
                    MessageBox.Show("Please enter address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    addressTextBox.Focus();
                    return;
                }
                Student student = new Student();
                student.Id =Convert.ToInt32(idLabel.Text);
                student.Name = nameTextBox.Text;
                student.FatherName = fatherNameTextBox.Text;
                student.Address = addressTextBox.Text;
                if (_studentManager.Update(student))
                {
                    MessageBox.Show("Student has been modified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frm.LoadData();
                }
                else
                {
                    MessageBox.Show("Student modified failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
