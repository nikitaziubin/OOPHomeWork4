using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Dormitory
    {
        public string place { get; } = "PanasaMyrnogo 25";
        public  List<Student> students { get; set;  } = new List<Student>();
    }
}
