using System;
namespace HospiEnCasa.App.Dominio
{
    public class Enfermera
    {
        [Key]
        public int IdEnfermera { get; set; }
        public string TarjetaProfesional { get; set; }
        public int HorasLaboradas { get; set; }
    }
}


