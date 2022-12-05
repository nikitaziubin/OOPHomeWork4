using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        

        public Dormitory dormitory { get; set; } = new Dormitory();
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
            Edit edit = new Edit();
            edit.Show();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form3 form3 = new Form3();
            //DataGridView dgv = (DataGridView)form3.Controls[5];
            const string path = "C:\\Users\\nikit\\source\\repos\\OOPHomeWork4\\LabaOOP4\\WinFormsApp1\\TXT.json";
            string josnFile = File.ReadAllText(path);

            JObject json = JObject.Parse(josnFile);
            var result = json["students"]
            //.Where(s => Convert.ToInt32(s["id"]) == Convert.ToInt32(textBoxID.Text))
            .Where(s => s["faculty"].ToString() == textBox1.Text && s["kafedra"].ToString() == textBox2.Text
            && s["cours"].ToString() == textBox3.Text)
                .Select(s => new Student
                {
                    id = Convert.ToInt32(s["id"]),
                    faculty = s["faculty"].ToString(),
                    kafedra = s["kafedra"].ToString(),
                    cours = s["cours"].ToString(),
                    livePlace = s["livePlace"].ToString()
                }).ToList();
            
            dataGridView3.DataSource = new BindingList<Student>(result);
            //foreach (var item in result)
            //{
            //    //string id = item.id;
            //    dataGridView3.Rows.Add(item);
            //}
            //form3.ShowDialog();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string json = "{\r\n  \"place\": \"PanasaMyrnogo 25\",\r\n  \"students\": [\r\n    {\r\n      \"faculty\": \"we\",\r\n      \"kafedra\": \"we\",\r\n      \"cours\": \"we\",\r\n      \"livePlace\": \"we\",\r\n      \"id\": 1\r\n    },\r\n    {\r\n      \"faculty\": \"we\",\r\n      \"kafedra\": \"we\",\r\n      \"cours\": \"we\",\r\n      \"livePlace\": \"we\",\r\n      \"id\": 2\r\n    },\r\n    {\r\n      \"faculty\": \"we\",\r\n      \"kafedra\": \"we\",\r\n      \"cours\": \"we\",\r\n      \"livePlace\": \"we\",\r\n      \"id\": 3\r\n    }\r\n  ]\r\n}";
                
            var dormitory = JsonSerializer.Deserialize<Dormitory>(json);
            dataGridView1.DataSource = new BindingList<Student>(dormitory.students);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dormitory.students.Remove();
            dormitory.students.RemoveAt(0);
            var json = JsonSerializer.Serialize(dormitory, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(path, json);
            dataGridView1.DataSource = new BindingList<Student>(dormitory.students);
        }
    }
}