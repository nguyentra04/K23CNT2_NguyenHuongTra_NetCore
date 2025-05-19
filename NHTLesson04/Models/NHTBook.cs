using System.ComponentModel.DataAnnotations;

namespace NHTLesson04.Models
{
    public class NHTBook
    {
        [Required]
        public string NHTId { get; set; }

        [Required]
        public string NHTTitle { get; set; }

        public string NHTDes { get; set; }

        public string NHTImage { get; set; }

        [Range(0, 1000)]//gh//
        public float NHTPrice { get; set; }

        public int NHTPage { get; set; }
    }
}
