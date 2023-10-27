using System.ComponentModel.DataAnnotations;

namespace exam.Models
{
    public class Musica
    {
        [Key]
        public int idMusica { 
            get; set;
        }
        public string Titulo { 
            get; set; 
        }
        public string Genero { 
            get; set; 
        }
        public int NumeroReproducciones { 
            get; set; 
        }
    }
}
