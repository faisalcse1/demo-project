using DotNet6WithSqliteExample.Manager;
using DotNet6WithSqliteExample.Models;
using DotNet6WithSqliteExample.UI;

namespace DotNet6WithSqliteExample
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        StudentManager _studentManager=new StudentManager();
       
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData()
        {
            StudentManager studentManager = new StudentManager();
            var students = studentManager.GetAll();
            studentDataGridView.Rows.Clear();
            foreach (var student in students)
            {
                studentDataGridView.Rows.Add(student.Id, student.Name, student.FatherName, student.Address);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Please enter name.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
                student.Name =nameTextBox.Text;
                student.FatherName=fatherNameTextBox.Text;
                student.Address = addressTextBox.Text;                
                if (_studentManager.Add(student))
                {
                    MessageBox.Show("Student has been saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Student saved failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Reset()
        {
            nameTextBox.Text = String.Empty;
            fatherNameTextBox.Clear();
            addressTextBox.Clear();
            LoadData();
        }

        private void studentDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = studentDataGridView.SelectedRows[0];
                frmStudentDetail frm=new frmStudentDetail(this);
                //this.Hide();
                //frm.Show();
                frm.idLabel.Text = dr.Cells[0].Value.ToString();
                frm.nameTextBox.Text=dr.Cells[1].Value.ToString();
                frm.fatherNameTextBox.Text=dr.Cells[2].Value.ToString();
                frm.addressTextBox.Text=dr.Cells[3].Value.ToString();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = studentDataGridView.SelectedRows[0];
                if(MessageBox.Show("Do you want to delete?","Qeuestion",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id=(int)dr.Cells[0].Value;
                    bool isDelete = _studentManager.Delete(id);
                    if(isDelete)
                    {
                        MessageBox.Show("Student has been removed.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        //ssLoadData();
                        studentDataGridView.Rows.Remove(dr);
                    }
                    else
                    {
                        MessageBox.Show("Student removed failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}