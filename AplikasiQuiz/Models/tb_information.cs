using System;
namespace AplikasiQuiz.Models
{
    public class tb_information
    {
        public int Id { get; set; }
        public string nama { get; set; }
        public string type { get; set; }
        public string kategori { get; set; }
        public byte[] gambar { get; set; }
        public string informasi { get; set; }
    }
}

