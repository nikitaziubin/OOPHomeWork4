using Newtonsoft.Json.Linq;

namespace WinFormsApp1
{
    class DormitoryHelper
    {
        public static IList<Student> filter(string path, string faculty, string kafedra, string cours)
        {
            string josnFile = File.ReadAllText(path);

            JObject json = JObject.Parse(josnFile);
            var result = json["students"]
            //.Where(s => Convert.ToInt32(s["id"]) == Convert.ToInt32(textBoxID.Text))
            .Where(s => s["faculty"]?.ToString() == faculty
            && s["kafedra"]?.ToString() == kafedra
            && s["cours"].ToString() == cours)
                .Select(s => new Student
                {
                    id = Convert.ToInt32(s["id"]),
                    faculty = s["faculty"].ToString(),
                    kafedra = s["kafedra"].ToString(),
                    cours = s["cours"].ToString(),
                    livePlace = s["livePlace"].ToString()
                }).ToList();
            return result;
        }
    }
}