using System;
using System.Collections.Generic;
using AplikasiQuiz.Models;

namespace AplikasiQuiz.StaticDetails
{
    public static class StaticSoal
    {
        public static int Id { get; set; }
        public static string jawaban { get; set; }
        public static List<tb_jawab> listJawaban { get; set; } = new List<tb_jawab>();
        public static List<tb_jawab> listJawaban2 { get; set; } = new List<tb_jawab>();
    }
}

