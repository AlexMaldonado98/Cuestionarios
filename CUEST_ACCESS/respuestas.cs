//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CUEST_ACCESS
{
    using System;
    using System.Collections.Generic;
    
    public partial class respuestas
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public int idPregunta { get; set; }
    
        public virtual preguntas preguntas { get; set; }
    }
}
