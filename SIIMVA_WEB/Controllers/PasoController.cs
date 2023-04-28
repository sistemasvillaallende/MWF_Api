using Microsoft.AspNetCore.Mvc;
using Newtonsoft;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using Newtonsoft.Json;
using MOTOR_WORKFLOW.Services;

namespace MOTOR_WORKFLOW.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PasoController : ControllerBase
    {
        private readonly IWebHostEnvironment _HostEnvironment;
        private IPasoService _PasoService;
        public PasoController(IPasoService PasoService, IWebHostEnvironment hostEnvironment)
        {
            _PasoService = PasoService;
            _HostEnvironment = hostEnvironment;
        }
        [HttpGet]
        public IActionResult getByPk(
        int ID)
        {
            var Paso = _PasoService.getByPk(ID);
            if (Paso == null)
            {
                return BadRequest(new { message = "Error al obtener los datos" });
            }
            return Ok(Paso);
        }

        [HttpPost]
        public IActionResult savePaso()
        {
            try
            {
                string json = Request.Form["resultados"];
                int idTramite = int.Parse(Request.Form["idTramite"]);
                int idPaso = int.Parse(Request.Form["idPaso"]);
                string cuit = Request.Form["cuit"];
                string cuitrepresentado = Request.Form["cuitrepresentado"];
                dynamic objeto = JsonConvert.DeserializeObject(json);

                Entities.Tramites objTramites = new Entities.Tramites();
                objTramites.id_tramite = idTramite;
                objTramites.cuit = cuit;
                objTramites.cuit_representado = cuitrepresentado;
                objTramites.fecha = DateTime.Now;
                objTramites.paso_actual = idPaso;

                int idTramites = Entities.Tramites.insert(objTramites);
                int i = 0;
                int id_ingreso_paso = 0;
                string nombre_ingreso_paso = string.Empty;
                foreach (var item in objeto)
                {
                    Entities.Pasos objPasos = new Entities.Pasos();
                    if (id_ingreso_paso != item.id_ingreso_paso.Value)
                    {
                        id_ingreso_paso = Convert.ToInt32(item.id_ingreso_paso.Value);
                        nombre_ingreso_paso = Entities.ingresos_x_paso.getNombreByPk(id_ingreso_paso);
                    }
                    objPasos.id_tramites = idTramites;
                    objPasos.id_paso = idPaso;
                    objPasos.orden_paso = Convert.ToInt32(item.orden.Value);
                    objPasos.id_ingreso_paso = id_ingreso_paso;
                    objPasos.orden_ingreso_paso = Convert.ToInt32(item.orden.Value);
                    objPasos.nombre_ingreso_paso = nombre_ingreso_paso;
                    objPasos.row = Convert.ToInt32(item.row.Value);
                    objPasos.col = Convert.ToInt32(item.col.Value);
                    objPasos.id_formulario = Convert.ToInt32(item.id_formulario.Value);
                    objPasos.id_adjunto = Convert.ToInt32(item.id_adjunto.Value);
                    objPasos.id_ddjj = Convert.ToInt32(item.id_ddjj.Value);
                    int idPasos = Entities.Pasos.insert(objPasos);
                    if (item.id_ddjj != 0)
                    {
                        Entities.Ddjjs objDDJJS = new Entities.Ddjjs();
                        objDDJJS.id = Convert.ToInt32(item.objDDJJ.id.Value);
                        objDDJJS.ddjj = item.objDDJJ.texto.Value;
                        objDDJJS.id_pasos = Convert.ToInt32(idPasos);
                        Entities.Ddjjs.insert(objDDJJS);
                    }
                    if (item.id_formulario != 0)
                    {
                        Entities.Formularios objFormulario = new Entities.Formularios();
                        objFormulario.id_formulario = Convert.ToInt32(item.objFormulario.id.Value);
                        objFormulario.nombre = item.objFormulario.nombre.Value;
                        objFormulario.descripcion = item.objFormulario.descripcion.Value;
                        objFormulario.id_pasos = idPasos;
                        int idForm = Entities.Formularios.insert(objFormulario);
                        foreach (var item2 in item.objFormulario.lstCampos)
                        {
                            Entities.Respuesta_formulario objRespuesta = new Entities.Respuesta_formulario();
                            objRespuesta.id_formularios = idForm;
                            objRespuesta.nombre_campo = item2.nombre.Value;
                            objRespuesta.id_tipo_campo = Convert.ToInt32(item2.id_tipo_campo.Value);
                            objRespuesta.etiqueta_campo = item2.etiqueta.Value;
                            switch (objRespuesta.id_tipo_campo)
                            {
                                case 1:
                                    objRespuesta.respuesta_usuario = item2.ingreso_usuario.Value;
                                    break;
                                case 2:
                                    objRespuesta.respuesta_usuario = item2.ingreso_usuario.Value;
                                    break;
                                case 3:
                                    objRespuesta.respuesta_usuario = Convert.ToString(item2.ingreso_usuario.Value);
                                    break;
                                case 4:
                                    objRespuesta.respuesta_usuario = item2.ingreso_usuario.Value;
                                    break;
                                case 5:
                                    objRespuesta.respuesta_usuario = item2.ingreso_usuario.Value;
                                    break;
                                case 6:
                                    objRespuesta.respuesta_usuario = Convert.ToString(item2.ingreso_usuario.Value);
                                    break;
                                case 7:
                                    objRespuesta.respuesta_usuario = Convert.ToString(item2.ingreso_usuario.Value);
                                    break;
                                case 8:
                                    objRespuesta.respuesta_usuario = Convert.ToString(item2.ingreso_usuario.Value);
                                    break;
                                case 9:
                                    objRespuesta.respuesta_usuario = JsonConvert.SerializeObject(
                                        item2.ingreso_usuario);
                                    break;
                                case 14:
                                    objRespuesta.respuesta_usuario = Convert.ToString(item2.ingreso_usuario.Value);
                                    break;
                                default:
                                    break;
                            }
                            
                            
                            objRespuesta.orden = Convert.ToInt32(item2.orden.Value);
                            Entities.Respuesta_formulario.insert(objRespuesta);
                        }
                    }
                    if (item.id_adjunto != 0)
                    {
                        Entities.Adjuntos objAdjunto = new Entities.Adjuntos();
                        objAdjunto.id = Convert.ToInt32(item.objAdjunto.id.Value);
                        objAdjunto.nombre = item.objAdjunto.nombre.Value;
                        objAdjunto.id_pasos = idPasos;
                        if (item.objAdjunto.multiple.Value)
                        {
                            string jsonString = item.objAdjunto.ingreso_usuario.ToString();
                            objAdjunto.archivo = jsonString;
                        }
                        else
                        {
                            objAdjunto.archivo = item.objAdjunto.ingreso_usuario.Value;
                        }
                        Entities.Adjuntos.insert(objAdjunto);
                    }
                }
                /*byte[] bytes = Convert.FromBase64String(base64BinaryStr);
                */



                /*if (file.Length > 0)
                {
                    ext = Path.GetExtension(file.FileName.Trim('"'));

                    //nombre = string.Format("Carrusel_{0}_Pagina_{1}{2}", id, id_page, ext);
                    //folder = string.Format("Pagina_{0}", id_page);
                    string webRootPath = _HostEnvironment.WebRootPath;
                    string contentRootPath = _HostEnvironment.ContentRootPath;

                    string path = "";
                    path = Path.Combine(contentRootPath, "wwwroot\\Assets\\Archivos_Pagina_Institucional\\");
                    if (!System.IO.Directory.Exists(path + folder))
                    {
                        System.IO.Directory.CreateDirectory(path + folder);
                    }


                    //var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(path + folder, nombre);//pathToSave, fileName);
                    //var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    //Entities.Carrusel.setImgFondo(id, nombre);

                }*/
                //var lst =
                //_carruselService.read(id_page);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }




    }
}

