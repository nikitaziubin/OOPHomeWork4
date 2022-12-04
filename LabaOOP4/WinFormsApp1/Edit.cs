using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

namespace WinFormsApp1
{
    public partial class Edit : Form
    {
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

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            const string path = "C:\\Users\\nikit\\source\\repos\\OOPHomeWork4\\LabaOOP4\\WinFormsApp1\\TXT.json";
            string josnFile = File.ReadAllText(path);

            JObject json = JObject.Parse(josnFile);

            var result = json["students"]
                .Where(s => Convert.ToInt32(s["id"]) == Convert.ToInt32(textBoxID.Text))
                .Select(s => new
                {
                    id = s["id"].ToString(),
                    faculty = s["faculty"].ToString()
                }).ToList();
            foreach(var item in result)
            {
                string id = item.id;
            }
        }

        private void textBoxFaculty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
