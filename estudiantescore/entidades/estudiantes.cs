using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudiantescore.entidades
{
    public class estudiantes
    {
        [Required]
        [Key]
        public string id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Nombre { get; set; }
        [Required]
        public string apellido { get; set; }

        [Required]
        [MaxLength(20)]
        public string Documento { get; set; }
        [Required]
       
        public  DateTime FechaNacimiento{ get; set; }
        [Required]
        [MaxLength(1)]
        public string Sexo { get; set; }
        [Required]
        [MaxLength(500)]
        public string direccion { get; set; }
        [Required]
        [MaxLength(20)]
        public string Telefono { get; set; }
        [MaxLength(50)]
        public string EMAIL { get; set; }
        [Required]
        public string FechaIngreso { get; set; }
        public string FechaEgreso{ get; set; }
        public string FechaRetiro { get; set; }
        [Required]
        public TIPODOCUMENTO TIPODOCUMENTO { get; set; }
        [Required]
        public ESTADOestudiante ESTADO { get; set; }



    }
}
