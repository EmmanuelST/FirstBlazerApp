using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstBlazerApp.Entidades
{
    public class Generos
    {
        [Key]
        public int GeneroId { get; set; }
        public string Nombre { get; set; }


    }
}
