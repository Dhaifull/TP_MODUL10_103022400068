namespace TP_MODUL10_103022400068.Models
{
    public class Film
    {
        // Properti data sesuai spesifikasi soal
        public string Judul { get; set; }
        public string Sutradara { get; set; }
        public string Tahun { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }

        // Constructor kosong sesuai dengan notasi +Film() pada diagram (opsional tapi baik untuk ditambahkan)
        public Film()
        {
        }
    }
}