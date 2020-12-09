using System.ComponentModel.DataAnnotations;

namespace NameThat.Models
{
    public class Result
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Type { get; set; }

        public string Picture { get; set; }

        public int YearOfRelease { get; set; }

    }
}