using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{

    public partial class Form2 : Form
    {
        const string path = "C:\\Users\\nikit\\source\\repos\\OOPHomeWork4\\LabaOOP4\\WinFormsApp1\\TXT.json";
        public Student student { get; set; } = new Student();
        Form1 form1 = new Form1();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {            
            student.faculty = textBox1.Text;
            student.kafedra = textBox2.Text;
            student.cours = textBox3.Text;
            student.livePlace = textBox4.Text;
            student.id = IdGenerator.getCurrentId();

            form1.dormitory.students.Add(student);

            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
