using System.ComponentModel.DataAnnotations;

namespace NewRestApi.Model
{
    public class Students
    {
        public int id { get; set; }
        [StringLength(50)]
        public string name { get; set; }

        public int age { get; set; }

        [StringLength(200)]

        public string email { set; get; }
    }
}
