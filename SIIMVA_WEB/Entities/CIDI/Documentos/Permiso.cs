using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOTOR_WORKFLOW.Entities.CIDI.Documentos
{
    public class Permiso
    {
        public int IdTipoDocumentacion { get; set; }
        public string NombreTipoDocumentacion { get; set; }
        public string Upload { get; set; }
        public string Discard { get; set; }
    }
}