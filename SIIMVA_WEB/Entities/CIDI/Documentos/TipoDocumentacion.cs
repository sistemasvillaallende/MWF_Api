using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOTOR_WORKFLOW.Entities.CIDI.Documentos
{
    public class TipoDocumentacion
    {
        public int IdTipo { get; set; }

        public String Descripcion { get; set; }

        public String Acumulable { get; set; }
    }
}