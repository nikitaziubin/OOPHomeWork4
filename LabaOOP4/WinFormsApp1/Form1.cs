using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Dormitory dormitory { get; set; } = new Dormitory();
        public DataGridView Grid3 { get; set; }

        const string path = "C:\\Users\\nikit\\source\\repos\\OOPHomeWork4\\LabaOOP4\\WinFormsApp1\\TXT.json";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            dormitory.students.Add(form2.student);
            var json = JsonSerializer.Serialize(dormitory, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(path, json);
            dataGridView1.DataSource = new BindingList<Student>(dormitory.students);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            Edit edit = new Edit();
            edit.rowIndex = dataGridView1.CurrentCell.RowIndex;
            edit.dormitory = dormitory;
            edit.dataGrid = dataGridView1;
            edit.Show();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            IList<Student> result = DormitoryHelper.filter(path, textBox1.Text, textBox2.Text, textBox3.Text);
            form3.getGrid().DataSource = new BindingList<Student>(result);           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string json = "{\r\n  \"place\": \"PanasaMyrnogo 25\",\r\n  \"students\": [\r\n    {\r\n      \"faculty\": \"we\",\r\n      \"kafedra\": \"we\",\r\n      \"cours\": \"we\",\r\n      \"livePlace\": \"we\",\r\n      \"id\": 1\r\n    },\r\n    {\r\n      \"faculty\": \"we\",\r\n      \"kafedra\": \"we\",\r\n      \"cours\": \"we\",\r\n      \"livePlace\": \"we\",\r\n      \"id\": 2\r\n    },\r\n    {\r\n      \"faculty\": \"we\",\r\n      \"kafedra\": \"we\",\r\n      \"cours\": \"we\",\r\n      \"livePlace\": \"we\",\r\n      \"id\": 3\r\n    }\r\n  ]\r\n}";
            var dormitor = JsonSerializer.Deserialize<Dormitory>(json);
            dataGridView1.DataSource = new BindingList<Student>(dormitor.students);


        }

        private void button4_Click(object sender, EventArgs e)
        {           
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dormitory.students.RemoveAt(row.Index);
            }

            var json = JsonSerializer.Serialize(dormitory, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(path, json);
            dataGridView1.DataSource = new BindingList<Student>(dormitory.students);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nikita ZIubin K-27");
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}