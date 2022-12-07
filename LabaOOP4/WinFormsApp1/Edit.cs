//using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Edit : Form
    {
        public Student editStudent { get; set; } = new Student();
        public int rowIndex { get; set; }
        public Dormitory dormitory { get; set; }
        public DataGridView dataGrid { get; set; }

        public Edit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Load(object sender, EventArgs e)
        {
            textBoxFaculty.Text = dormitory.students[rowIndex].faculty;
            textBoxKafedra.Text = dormitory.students[rowIndex].kafedra;
            textBoxCourse.Text = dormitory.students[rowIndex].cours;
            textBoxLivePlace.Text = dormitory.students[rowIndex].livePlace;
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxFaculty_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string path = "C:\\Users\\nikit\\source\\repos\\OOPHomeWork4\\LabaOOP4\\WinFormsApp1\\TXT.json";
            string josnFile = File.ReadAllText(path);
            int rowIndex = dataGrid.CurrentCell.RowIndex;

            dormitory.students[rowIndex].faculty = textBoxFaculty.Text;
            dormitory.students[rowIndex].kafedra = textBoxKafedra.Text;
            dormitory.students[rowIndex].cours = textBoxCourse.Text;
            dormitory.students[rowIndex].livePlace = textBoxLivePlace.Text;

            //dormitory.students.ElementAt(rowIndex);
            
            var json = JsonSerializer.Serialize(dormitory, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(path, json);
            dataGrid.DataSource = new BindingList<Student>(dormitory.students);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
