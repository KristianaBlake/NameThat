using System.ComponentModel.DataAnnotations;

namespace NameThat.Models
{
    public class Result
    {
        public string Type { get; set; }

        public byte[] Picture { get; set; }
        public string Title { get; set; }

        public int YearOfRelease { get; set; }

    }
}