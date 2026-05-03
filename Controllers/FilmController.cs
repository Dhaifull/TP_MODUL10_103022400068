using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TP_MODUL10_103022400068.Models;

namespace TP_MODUL10_103022400068.Controllers
{
    // Menandai kelas ini sebagai controller API dengan route dasar "api/Film"
    [Route("api/Film")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        // Disimpan sebagai variabel 'static' list/array yang berisi 3 data default
        private static List<Film> _films = new List<Film>
        {
            new Film { Judul = "Inception", Sutradara = "Christopher Nolan", Tahun = "2010", Genre = "Sci-Fi", Rating = "9.0" },
            new Film { Judul = "Interstellar", Sutradara = "Christopher Nolan", Tahun = "2014", Genre = "Sci-Fi", Rating = "8.7" },
            new Film { Judul = "Parasite", Sutradara = "Bong Joon-ho", Tahun = "2019", Genre = "Thriller", Rating = "8.6" }
        };

        // Memenuhi instruksi C.4.a: GET /api/Film (mengeluarkan semua objek)
        [HttpGet]
        public IEnumerable<Film> Get()
        {
            return _films;
        }

        // Memenuhi instruksi C.4.b: GET /api/Film/{index} (mengeluarkan objek berdasarkan index)
        [HttpGet("{id}")]
        public ActionResult<Film> Get(int id)
        {
            // Asumsi input user selalu benar (C.6), tapi kita beri validasi dasar agar program tidak error/crash
            if (id < 0 || id >= _films.Count)
            {
                return NotFound("Index film tidak ditemukan.");
            }
            return _films[id];
        }

        // Memenuhi instruksi C.4.c: POST /api/Film (menambahkan objek film baru)
        [HttpPost]
        public IActionResult Post([FromBody] Film film)
        {
            _films.Add(film);
            return Ok("Film berhasil ditambahkan.");
        }

        // Memenuhi instruksi C.4.d: DELETE /api/Film/{index} (menghapus objek film)
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= _films.Count)
            {
                return NotFound("Index film tidak ditemukan.");
            }
            _films.RemoveAt(id);
            return Ok("Film berhasil dihapus.");
        }
    }
}