using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulSis
{
    public partial class Form2 : Form
    {
        public Form2(Form1 form1)
        {
            InitializeComponent();
        }
        StudentDAL _studentDal = new StudentDAL();
        private void Form2_Load(object sender, EventArgs e)
        {
            dgw.RowHeadersVisible = false;
            dgw.DataSource = _studentDal.GetAll();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var _studentNumber = stuNumberTb.Text;
            var _studentName = stuNameTb.Text;
            var _studentSurname = stuSurnameTb.Text;
            var _studentClass = stuClassTb.Text;
            Student newStudent = new Student {
                StudentNumber = int.Parse(_studentNumber),
                StudentName = _studentName,
                StudentSurname = _studentSurname,
                StudentClass = _studentClass
            };
            
            _studentDal.Add(newStudent);
            dgw.DataSource = _studentDal.GetAll();
        }
    }
}
