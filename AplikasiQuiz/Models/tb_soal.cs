using System;
namespace AplikasiQuiz.Models
{
    public class tb_soal
    {
        public int Id { get; set; }
        public string type { get; set; }
        public byte[] gambar { get; set; }
        public string soal { get; set; }
        public string pilihanA { get; set; }
        public string pilihanB { get; set; }
        public string pilihanC { get; set; }
        public string pilihanD { get; set; }
        public string jawaban { get; set; }
    }
}

