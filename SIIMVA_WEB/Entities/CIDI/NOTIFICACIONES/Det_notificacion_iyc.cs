using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOTOR_WORKFLOW.Entities;

namespace NotificacionMOTOR_WORKFLOWesGeneralesBack.Entities.NOTIFICACIONES
{
    public class Det_notificacion_iyc : DALBase
    {
        public int Nro_emision { get; set; }
        public int Nro_notificacion { get; set; }
        public int Legajo { get; set; }
        public int Nro_badec { get; set; }
        public string Nombre { get; set; }
        public string Nom_barrio_dom_esp { get; set; }
        public string Nom_calle_dom_esp { get; set; }
        public string Nro_dom_esp { get; set; }
        public string Ciudad_dom_esp { get; set; }
        public string Provincia_dom_esp { get; set; }
        public string Pais_dom_esp { get; set; }
        public string Cod_postal_esp { get; set; }
        public int Nro_proc { get; set; }
        public DateTime Fecha_vencimiento { get; set; }
        public string Periodo { get; set; }
        public decimal Debe { get; set; }
        public int Nro_plan { get; set; }
        public DateTime Vencimiento { get; set; }
        public Int16 Cod_tipo_procuracion { get; set; }
        public bool Bloqueado { get; set; }
        public Int16 Codigo_procurador { get; set; }
        public bool TieneHonorarios { get; set; }
        public Int16 Tipo_descuento { get; set; }
        public Int16 Cod_formulario { get; set; }
        public int Codigo_estado_actual { get; set; }
        public Int16 paraimprimir { get; set; }
        public Int16 CedulonSi { get; set; }
        public int Nro_cedulon { get; set; }
        public string Barcode39 { get; set; }
        public string Barcodeint25 { get; set; }
        public Int16 pagado { get; set; }
        public decimal monto_original { get; set; }
        public decimal interes { get; set; }
        public decimal descuento { get; set; }
        public decimal importe_pagar { get; set; }
        public DateTime fecha_baja_real { get; set; }
        public int nro_secuencia { get; set; }
        public int nro_orden { get; set; }
        public string cuit { get; set; }
        public int notificado_cidi { get; set; }
        public string cuit_valido { get; set; }
        public string estado_actual { get; set; }

        public Det_notificacion_iyc()
        {
            Nro_emision = 0;
            Nro_notificacion = 0;
            Legajo = 0;
            Nro_badec = 0;
            Nombre = string.Empty;
            Nom_barrio_dom_esp = string.Empty;
            Nom_calle_dom_esp = string.Empty;
            Nro_dom_esp = string.Empty;
            Ciudad_dom_esp = string.Empty;
            Provincia_dom_esp = string.Empty;
            Pais_dom_esp = string.Empty;
            Cod_postal_esp = string.Empty;
            Nro_proc = 0;
            Fecha_vencimiento = DateTime.Now;
            Periodo = string.Empty;
            Debe = 0;
            Nro_plan = 0;
            Vencimiento = DateTime.Now;
            Cod_tipo_procuracion = 0;
            Bloqueado = false;
            Codigo_procurador = 0;
            TieneHonorarios = false;
            Tipo_descuento = 0;
            Cod_formulario = 0;
            Codigo_estado_actual = 0;
            paraimprimir = 0;
            CedulonSi = 0;
            Nro_cedulon = 0;
            Barcode39 = string.Empty;
            Barcodeint25 = string.Empty;
            pagado = 0;
            monto_original = 0;
            interes = 0;
            descuento = 0;
            importe_pagar = 0;
            fecha_baja_real = DateTime.Now;
            nro_secuencia = 0;
            nro_orden = 0;            
            notificado_cidi = 0;
            cuit = string.Empty;
            notificado_cidi = 0;
            cuit_valido = string.Empty;
            estado_actual = string.Empty;
        }

        private static List<Det_notificacion_iyc> mapeo(SqlDataReader dr)
        {
            List<Det_notificacion_iyc> lst = new List<Det_notificacion_iyc>();
            Det_notificacion_iyc obj;
            if (dr.HasRows)
            {
                int Nro_emision = dr.GetOrdinal("Nro_emision");
                int Nro_notificacion = dr.GetOrdinal("Nro_notificacion");
                int Legajo = dr.GetOrdinal("Legajo");
                int Nro_badec = dr.GetOrdinal("Nro_badec");
                int Nombre = dr.GetOrdinal("Nombre");               
                //int Nom_barrio_dom_esp = dr.GetOrdinal("Nom_barrio_dom_esp");
                //int Nom_calle_dom_esp = dr.GetOrdinal("Nom_calle_dom_esp");
                //int Nro_dom_esp = dr.GetOrdinal("Nro_dom_esp");
                //int Ciudad_dom_esp = dr.GetOrdinal("Ciudad_dom_esp");
                //int Provincia_dom_esp = dr.GetOrdinal("Provincia_dom_esp");
                //int Pais_dom_esp = dr.GetOrdinal("Pais_dom_esp");
                //int Cod_postal_esp = dr.GetOrdinal("Cod_postal_esp");             
                int Nro_proc = dr.GetOrdinal("Nro_proc");
                //int Fecha_vencimiento = dr.GetOrdinal("Fecha_vencimiento");
                //int Periodo = dr.GetOrdinal("Periodo");
                int Debe = dr.GetOrdinal("Debe");
                //int Nro_plan = dr.GetOrdinal("Nro_plan");
                int Vencimiento = dr.GetOrdinal("Vencimiento");
                //int Cod_tipo_procuracion = dr.GetOrdinal("Cod_tipo_procuracion");
                //int Bloqueado = dr.GetOrdinal("Bloqueado");
                //int Codigo_procurador = dr.GetOrdinal("Codigo_procurador");
                //int TieneHonorarios = dr.GetOrdinal("TieneHonorarios");
                //int Tipo_descuento = dr.GetOrdinal("Tipo_descuento");
                //int Cod_formulario = dr.GetOrdinal("Cod_formulario");
                int Codigo_estado_actual = dr.GetOrdinal("Codigo_estado_actual");
                //int paraimprimir = dr.GetOrdinal("paraimprimir");
                //int CedulonSi = dr.GetOrdinal("CedulonSi");
                int Nro_cedulon = dr.GetOrdinal("Nro_cedulon");
                int Barcode39 = dr.GetOrdinal("Barcode39");
                int Barcodeint25 = dr.GetOrdinal("Barcodeint25");
                //int pagado = dr.GetOrdinal("pagado");
                int monto_original = dr.GetOrdinal("monto_original");
                int interes = dr.GetOrdinal("interes");
                int descuento = dr.GetOrdinal("descuento");
                int importe_pagar = dr.GetOrdinal("importe_pagar");
                //int fecha_baja_real = dr.GetOrdinal("fecha_baja_real");
                //int nro_secuencia = dr.GetOrdinal("nro_secuencia");
                //int nro_orden = dr.GetOrdinal("nro_orden");                
                int notificado_cidi = dr.GetOrdinal("notificado_cidi");
                int cuit = dr.GetOrdinal("cuit");
                int Notificado_cidi = dr.GetOrdinal("Notificado_cidi");
                int estado_actual = dr.GetOrdinal("estado_actual");
                int cuit_valido = dr.GetOrdinal("cuit_valido");

                while (dr.Read())
                {
                    obj = new Det_notificacion_iyc();
                    if (!dr.IsDBNull(Nro_emision)) { obj.Nro_emision = dr.GetInt32(Nro_emision); }
                    if (!dr.IsDBNull(Nro_notificacion)) { obj.Nro_notificacion = dr.GetInt32(Nro_notificacion); }
                    if (!dr.IsDBNull(Legajo)) { obj.Legajo = dr.GetInt32(Legajo); }
                    if (!dr.IsDBNull(Nro_badec)) { obj.Nro_badec = dr.GetInt32(Nro_badec); }
                    if (!dr.IsDBNull(Nombre)) { obj.Nombre = dr.GetString(Nombre); }
                    //if (!dr.IsDBNull(Nom_barrio_dom_esp)) { obj.Nom_barrio_dom_esp = dr.GetString(Nom_barrio_dom_esp); }
                    //if (!dr.IsDBNull(Nom_calle_dom_esp)) { obj.Nom_calle_dom_esp = dr.GetString(Nom_calle_dom_esp); }
                    //if (!dr.IsDBNull(Nro_dom_esp)) { obj.Nro_dom_esp = dr.GetString(Nro_dom_esp); }
                    //if (!dr.IsDBNull(Ciudad_dom_esp)) { obj.Ciudad_dom_esp = dr.GetString(Ciudad_dom_esp); }
                    //if (!dr.IsDBNull(Provincia_dom_esp)) { obj.Provincia_dom_esp = dr.GetString(Provincia_dom_esp); }
                    //if (!dr.IsDBNull(Pais_dom_esp)) { obj.Pais_dom_esp = dr.GetString(Pais_dom_esp); }
                    //if (!dr.IsDBNull(Cod_postal_esp)) { obj.Cod_postal_esp = dr.GetString(Cod_postal_esp); }
                    if (!dr.IsDBNull(Nro_proc)) { obj.Nro_proc = dr.GetInt32(Nro_proc); }
                    //if (!dr.IsDBNull(Fecha_vencimiento)) { obj.Fecha_vencimiento = dr.GetDateTime(Fecha_vencimiento); }
                    //if (!dr.IsDBNull(Periodo)) { obj.Periodo = dr.GetString(Periodo); }
                    if (!dr.IsDBNull(Debe)) { obj.Debe = dr.GetInt32(Debe); }
                    //if (!dr.IsDBNull(Nro_plan)) { obj.Nro_plan = dr.GetInt32(Nro_plan); }
                    if (!dr.IsDBNull(Vencimiento)) { obj.Vencimiento = dr.GetDateTime(Vencimiento); }
                    //if (!dr.IsDBNull(Cod_tipo_procuracion)) { obj.Cod_tipo_procuracion = dr.GetInt16(Cod_tipo_procuracion); }
                    //if (!dr.IsDBNull(Bloqueado)) { obj.Bloqueado = dr.GetBoolean(Bloqueado); }
                    //if (!dr.IsDBNull(Codigo_procurador)) { obj.Codigo_procurador = dr.GetInt16(Codigo_procurador); }
                    //if (!dr.IsDBNull(TieneHonorarios)) { obj.TieneHonorarios = dr.GetBoolean(TieneHonorarios); }
                    //if (!dr.IsDBNull(Tipo_descuento)) { obj.Tipo_descuento = dr.GetInt16(Tipo_descuento); }
                    //if (!dr.IsDBNull(Cod_formulario)) { obj.Cod_formulario = dr.GetInt16(Cod_formulario); }
                    if (!dr.IsDBNull(Codigo_estado_actual)) { obj.Codigo_estado_actual = dr.GetInt32(Codigo_estado_actual); }
                    //if (!dr.IsDBNull(paraimprimir)) { obj.paraimprimir = dr.GetInt16(paraimprimir); }
                    //if (!dr.IsDBNull(CedulonSi)) { obj.CedulonSi = dr.GetInt16(CedulonSi); }
                    if (!dr.IsDBNull(Nro_cedulon)) { obj.Nro_cedulon = dr.GetInt32(Nro_cedulon); }
                    if (!dr.IsDBNull(Barcode39)) { obj.Barcode39 = dr.GetString(Barcode39); }
                    if (!dr.IsDBNull(Barcodeint25)) { obj.Barcodeint25 = dr.GetString(Barcodeint25); }
                    //if (!dr.IsDBNull(pagado)) { obj.pagado = dr.GetInt16(pagado); }
                    if (!dr.IsDBNull(monto_original)) { obj.monto_original = dr.GetInt32(monto_original); }
                    if (!dr.IsDBNull(interes)) { obj.interes = dr.GetInt32(interes); }
                    if (!dr.IsDBNull(descuento)) { obj.descuento = dr.GetInt32(descuento); }
                    if (!dr.IsDBNull(importe_pagar)) { obj.importe_pagar = dr.GetInt32(importe_pagar); }
                    //if (!dr.IsDBNull(fecha_baja_real)) { obj.fecha_baja_real = dr.GetDateTime(fecha_baja_real); }
                    //if (!dr.IsDBNull(nro_secuencia)) { obj.nro_secuencia = dr.GetInt32(nro_secuencia); }
                    //if (!dr.IsDBNull(nro_orden)) { obj.nro_orden = dr.GetInt32(nro_orden); }                    
                    if (!dr.IsDBNull(notificado_cidi)) { obj.notificado_cidi = dr.GetInt16(notificado_cidi); }
                    if (!dr.IsDBNull(cuit)) { obj.cuit = dr.GetString(cuit); }
                    if (!dr.IsDBNull(cuit_valido)) { obj.cuit_valido = dr.GetString(cuit_valido); }
                    if (!dr.IsDBNull(estado_actual)) { obj.estado_actual = dr.GetString(estado_actual); }
                    lst.Add(obj);
                }
            }
            return lst;
        }

        public static List<Det_notificacion_iyc> read(int nro_emision)
        {
            try
            {
                List<Det_notificacion_iyc> lst = new List<Det_notificacion_iyc>();
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT A.*, D.CUIT, C.descripcion_estado AS estado_actual, cuit_valido=''
                                        FROM Det_notificacion_iyc A
                                        INNER JOIN INDYCOM B ON A.legajo = B.legajo
                                        INNER JOIN ESTADOS_PROCURACION C 
                                        ON A.codigo_estado_actual=codigo_estado
                                        INNER JOIN BADEC D ON B.NRO_BAD=D.NRO_BAD
                                        WHERE Nro_emision = @nro_emision";

                    //cmd.CommandText = "SELECT * FROM Det_notificacion_iyc";
                    cmd.Parameters.AddWithValue("@Nro_emision", nro_emision);
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    lst = mapeo(dr);
                    return lst;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Det_notificacion_iyc> listarDetalle(int nro_emision)
        {
            try
            {
                List<Det_notificacion_iyc> lst = new List<Det_notificacion_iyc>();
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"
                        SELECT 
	                        a.Nro_Emision,
	                        a.Nro_Notificacion,
	                        a.Legajo,
	                        a.nro_badec,
	                        a.nombre, 
	                        a.nro_proc,
	                        0 AS debe,
	                        a.Vencimiento,
	                        ep.codigo_estado AS Codigo_estado_actual,
	                        a.Nro_cedulon,
	                        a.Barcode39,
	                        a.Barcodeint25,
	                        0 AS monto_original,
	                        0 AS interes,
                            0 AS descuento,
	                        0 AS importe_pagar,
	                        notificado_cidi=isnull( a.Notificado_cidi,0),
	                        v.nro_cuit,
	                        CASE
		                        WHEN vd.cuit IS NULL THEN 'CUIT_NO_VALIDADO'
		                        ELSE 'CUIT_VALIDADO'
	                        END AS cuit_valido,
	                        ep.descripcion_estado AS estado_actual,
	                        vd.CUIT
                        FROM DET_NOTIFICACION_IYC A (nolock)left join INDYCOM V ON V.legajo=A.Legajo 
	                        INNER JOIN ESTADOS_PROCURACION ep ON ep.codigo_estado=A.codigo_estado_actual
	                        LEFT JOIN VECINO_DIGITAL vd ON vd.CUIT = V.nro_cuit
                        WHERE
	                        nro_emision=@nro_emision";
                    cmd.Parameters.AddWithValue("@nro_emision", nro_emision);
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    lst = mapeo(dr);
                    return lst;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Det_notificacion_iyc> listarDetallexEstado(int nro_emision, int cod_estado)
        {
            try
            {
                List<Det_notificacion_iyc> lst = new List<Det_notificacion_iyc>();
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"
                        SELECT
                      a.Nro_Emision,a.Nro_Notificacion, a.nro_proc, a.legajo, a.nro_badec,
                      a.nombre, a.vencimiento,a.Nro_cedulon,codigo_estado_actual=ISNULL((SELECT ep.codigo_estado
                                        FROM PROCURA_IYC pa
                                        JOIN ESTADOS_PROCURACION ep ON ep.codigo_estado=pa.codigo_estado_actual
                                        AND pa.nro_procuracion=a.Nro_Proc AND a.legajo=pa.legajo),0), 
                                        --v.nro_cuit as cuit
                                       --,notificado_cidi=isnull(a.Notificado_cidi,0),
                      Debe=((SELECT SUM(DEBE)
		   	                    FROM CTASCTES_INDYCOM C
			                    JOIN DEUDAS_PROC_IYC D ON
				                    D.nro_procuracion=a.nro_proc AND
                                    D.nro_transaccion=C.nro_transaccion
                                     )) -
				                       (SELECT SUM(haber)
				                        FROM CTASCTES_INDYCOM C
				                        JOIN DEUDAS_PROC_IYC D ON
						                    D.nro_procuracion=a.nro_proc AND
						                    D.nro_transaccion=C.nro_transaccion) ,
                       a.Barcode39,a.Barcodeint25,a.Monto_original,a.interes, a.Descuento,a.Importe_pagar,
                       estado_actual= (SELECT ep.descripcion_estado
                                        FROM PROCURA_IYC pa
                                         JOIN ESTADOS_PROCURACION ep ON ep.codigo_estado=pa.codigo_estado_actual
                                        AND pa.nro_procuracion=a.nro_proc AND a.legajo=pa.legajo), v.nro_cuit as cuit
                                       ,notificado_cidi=isnull( a.Notificado_cidi,0),
                         CASE
				          WHEN v.nro_cuit ='' then 'CUIT_NO_VALIDADO'
				          WHEN (SELECT count(*) FROM VECINO_DIGITAL vd  WHERE LTRIM(RTRIM(v.nro_cuit))=LTRIM(RTRIM(vd.cuit )))>0 THEN 'CUIT_VALIDADO'
				          WHEN (SELECT count(*) FROM VECINO_DIGITAL vd  WHERE LTRIM(RTRIM(v.nro_cuit))=LTRIM(RTRIM(vd.cuit )))=0 THEN 'CUIT_NO_VALIDADO'
				         END AS cuit_valido
                    FROM DET_NOTIFICACION_IYC A (nolock)left join INDYCOM V ON V.legajo=A.legajo        
                    WHERE
                       nro_emision=@nro_emision AND (SELECT ep.codigo_estado
                                                    FROM PROCURA_IYC pa
                                                    JOIN ESTADOS_PROCURACION ep ON 
                                                      ep.codigo_estado=pa.codigo_estado_actual
                    AND pa.nro_procuracion=a.nro_proc AND a.legajo=pa.legajo)=" + cod_estado.ToString();
                    cmd.Parameters.AddWithValue("@nro_emision", nro_emision);
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    lst = mapeo(dr);
                    return lst;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static Det_notificacion_iyc getByPk(int nro_emision, int nro_notificacion)
        {
            try
            {
                StringBuilder sql = new StringBuilder();                
                sql.AppendLine("SELECT d.*, ");
                sql.AppendLine(" estado_actual= (SELECT ep.descripcion_estado ");
                sql.AppendLine("        FROM Procura_iyc pi  ");
                sql.AppendLine("        JOIN ESTADOS_PROCURACION ep ON ep.codigo_estado=pi.codigo_estado_actual ");
                sql.AppendLine("      AND pi.nro_procuracion=d.nro_proc AND d.legajo=pi.legajo), cuit ='',cuit_valido='' ");
                sql.AppendLine("FROM Det_notificacion_iyc d ");
                sql.AppendLine("WHERE d.Nro_emision = @nro_emision");
                sql.AppendLine("AND d.Nro_notificacion = @nro_notificacion");

                Det_notificacion_iyc obj = null;
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@nro_emision", nro_emision);
                    cmd.Parameters.AddWithValue("@nro_notificacion", nro_notificacion);                    
                    cmd.Connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<Det_notificacion_iyc> lst = mapeo(dr);
                    if (lst.Count != 0)
                        obj = lst[0];
                }
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int insert(Det_notificacion_iyc obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("INSERT INTO Det_notificacion_iyc(");
                sql.AppendLine("Nro_emision");
                sql.AppendLine(", Nro_notificacion");
                sql.AppendLine(", Legajo");
                sql.AppendLine(", Nro_badec");
                sql.AppendLine(", Nombre");
                sql.AppendLine(", Nom_barrio_dom_esp");
                sql.AppendLine(", Nom_calle_dom_esp");
                sql.AppendLine(", Nro_dom_esp");
                sql.AppendLine(", Ciudad_dom_esp");
                sql.AppendLine(", Provincia_dom_esp");
                sql.AppendLine(", Pais_dom_esp");
                sql.AppendLine(", Cod_postal_esp");
                sql.AppendLine(", Nro_proc");
                sql.AppendLine(", Fecha_vencimiento");
                sql.AppendLine(", Periodo");
                sql.AppendLine(", Debe");
                sql.AppendLine(", Nro_plan");
                sql.AppendLine(", Vencimiento");
                sql.AppendLine(", Cod_tipo_procuracion");
                sql.AppendLine(", Bloqueado");
                sql.AppendLine(", Codigo_procurador");
                sql.AppendLine(", TieneHonorarios");
                sql.AppendLine(", Tipo_descuento");
                sql.AppendLine(", Cod_formulario");
                sql.AppendLine(", Codigo_estado_actual");
                sql.AppendLine(", paraimprimir");
                sql.AppendLine(", CedulonSi");
                sql.AppendLine(", Nro_cedulon");
                sql.AppendLine(", Barcode39");
                sql.AppendLine(", Barcodeint25");
                sql.AppendLine(", pagado");
                sql.AppendLine(", monto_original");
                sql.AppendLine(", interes");
                sql.AppendLine(", descuento");
                sql.AppendLine(", importe_pagar");
                sql.AppendLine(", fecha_baja_real");
                sql.AppendLine(", nro_secuencia");
                sql.AppendLine(", nro_orden");
                sql.AppendLine(", notificado_cidi");
                sql.AppendLine(")");
                sql.AppendLine("VALUES");
                sql.AppendLine("(");
                sql.AppendLine("@Nro_emision");
                sql.AppendLine(", @Nro_notificacion");
                sql.AppendLine(", @Legajo");
                sql.AppendLine(", @Nro_badec");
                sql.AppendLine(", @Nombre");
                sql.AppendLine(", @Nom_barrio_dom_esp");
                sql.AppendLine(", @Nom_calle_dom_esp");
                sql.AppendLine(", @Nro_dom_esp");
                sql.AppendLine(", @Ciudad_dom_esp");
                sql.AppendLine(", @Provincia_dom_esp");
                sql.AppendLine(", @Pais_dom_esp");
                sql.AppendLine(", @Cod_postal_esp");
                sql.AppendLine(", @Nro_proc");
                sql.AppendLine(", @Fecha_vencimiento");
                sql.AppendLine(", @Periodo");
                sql.AppendLine(", @Debe");
                sql.AppendLine(", @Nro_plan");
                sql.AppendLine(", @Vencimiento");
                sql.AppendLine(", @Cod_tipo_procuracion");
                sql.AppendLine(", @Bloqueado");
                sql.AppendLine(", @Codigo_procurador");
                sql.AppendLine(", @TieneHonorarios");
                sql.AppendLine(", @Tipo_descuento");
                sql.AppendLine(", @Cod_formulario");
                sql.AppendLine(", @Codigo_estado_actual");
                sql.AppendLine(", @paraimprimir");
                sql.AppendLine(", @CedulonSi");
                sql.AppendLine(", @Nro_cedulon");
                sql.AppendLine(", @Barcode39");
                sql.AppendLine(", @Barcodeint25");
                sql.AppendLine(", @pagado");
                sql.AppendLine(", @monto_original");
                sql.AppendLine(", @interes");
                sql.AppendLine(", @descuento");
                sql.AppendLine(", @importe_pagar");
                sql.AppendLine(", @fecha_baja_real");
                sql.AppendLine(", @nro_secuencia");
                sql.AppendLine(", @nro_orden");
                sql.AppendLine(", @notificado_cidi");
                sql.AppendLine(")");
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@Nro_emision", obj.Nro_emision);
                    cmd.Parameters.AddWithValue("@Nro_notificacion", obj.Nro_notificacion);
                    cmd.Parameters.AddWithValue("@Legajo", obj.Legajo);
                    cmd.Parameters.AddWithValue("@Nro_badec", obj.Nro_badec);
                    cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("@Nom_barrio_dom_esp", obj.Nom_barrio_dom_esp);
                    cmd.Parameters.AddWithValue("@Nom_calle_dom_esp", obj.Nom_calle_dom_esp);
                    cmd.Parameters.AddWithValue("@Nro_dom_esp", obj.Nro_dom_esp);
                    cmd.Parameters.AddWithValue("@Ciudad_dom_esp", obj.Ciudad_dom_esp);
                    cmd.Parameters.AddWithValue("@Provincia_dom_esp", obj.Provincia_dom_esp);
                    cmd.Parameters.AddWithValue("@Pais_dom_esp", obj.Pais_dom_esp);
                    cmd.Parameters.AddWithValue("@Cod_postal_esp", obj.Cod_postal_esp);
                    cmd.Parameters.AddWithValue("@Nro_proc", obj.Nro_proc);
                    cmd.Parameters.AddWithValue("@Fecha_vencimiento", obj.Fecha_vencimiento);
                    cmd.Parameters.AddWithValue("@Periodo", obj.Periodo);
                    cmd.Parameters.AddWithValue("@Debe", obj.Debe);
                    cmd.Parameters.AddWithValue("@Nro_plan", obj.Nro_plan);
                    cmd.Parameters.AddWithValue("@Vencimiento", obj.Vencimiento);
                    cmd.Parameters.AddWithValue("@Cod_tipo_procuracion", obj.Cod_tipo_procuracion);
                    cmd.Parameters.AddWithValue("@Bloqueado", obj.Bloqueado);
                    cmd.Parameters.AddWithValue("@Codigo_procurador", obj.Codigo_procurador);
                    cmd.Parameters.AddWithValue("@TieneHonorarios", obj.TieneHonorarios);
                    cmd.Parameters.AddWithValue("@Tipo_descuento", obj.Tipo_descuento);
                    cmd.Parameters.AddWithValue("@Cod_formulario", obj.Cod_formulario);
                    cmd.Parameters.AddWithValue("@Codigo_estado_actual", obj.Codigo_estado_actual);
                    cmd.Parameters.AddWithValue("@paraimprimir", obj.paraimprimir);
                    cmd.Parameters.AddWithValue("@CedulonSi", obj.CedulonSi);
                    cmd.Parameters.AddWithValue("@Nro_cedulon", obj.Nro_cedulon);
                    cmd.Parameters.AddWithValue("@Barcode39", obj.Barcode39);
                    cmd.Parameters.AddWithValue("@Barcodeint25", obj.Barcodeint25);
                    cmd.Parameters.AddWithValue("@pagado", obj.pagado);
                    cmd.Parameters.AddWithValue("@monto_original", obj.monto_original);
                    cmd.Parameters.AddWithValue("@interes", obj.interes);
                    cmd.Parameters.AddWithValue("@descuento", obj.descuento);
                    cmd.Parameters.AddWithValue("@importe_pagar", obj.importe_pagar);
                    cmd.Parameters.AddWithValue("@fecha_baja_real", obj.fecha_baja_real);
                    cmd.Parameters.AddWithValue("@nro_secuencia", obj.nro_secuencia);
                    cmd.Parameters.AddWithValue("@nro_orden", obj.nro_orden);
                    cmd.Parameters.AddWithValue("@notificado_cidi", obj.notificado_cidi);
                    cmd.Connection.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void update(Det_notificacion_iyc obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("UPDATE  Det_notificacion_iyc SET");
                sql.AppendLine("Nro_badec=@Nro_badec");
                sql.AppendLine(", Nombre=@Nombre");
                sql.AppendLine(", Nom_barrio_dom_esp=@Nom_barrio_dom_esp");
                sql.AppendLine(", Nom_calle_dom_esp=@Nom_calle_dom_esp");
                sql.AppendLine(", Nro_dom_esp=@Nro_dom_esp");
                sql.AppendLine(", Ciudad_dom_esp=@Ciudad_dom_esp");
                sql.AppendLine(", Provincia_dom_esp=@Provincia_dom_esp");
                sql.AppendLine(", Pais_dom_esp=@Pais_dom_esp");
                sql.AppendLine(", Cod_postal_esp=@Cod_postal_esp");
                sql.AppendLine(", Nro_proc=@Nro_proc");
                sql.AppendLine(", Fecha_vencimiento=@Fecha_vencimiento");
                sql.AppendLine(", Periodo=@Periodo");
                sql.AppendLine(", Debe=@Debe");
                sql.AppendLine(", Nro_plan=@Nro_plan");
                sql.AppendLine(", Vencimiento=@Vencimiento");
                sql.AppendLine(", Cod_tipo_procuracion=@Cod_tipo_procuracion");
                sql.AppendLine(", Bloqueado=@Bloqueado");
                sql.AppendLine(", Codigo_procurador=@Codigo_procurador");
                sql.AppendLine(", TieneHonorarios=@TieneHonorarios");
                sql.AppendLine(", Tipo_descuento=@Tipo_descuento");
                sql.AppendLine(", Cod_formulario=@Cod_formulario");
                sql.AppendLine(", Codigo_estado_actual=@Codigo_estado_actual");
                sql.AppendLine(", paraimprimir=@paraimprimir");
                sql.AppendLine(", CedulonSi=@CedulonSi");
                sql.AppendLine(", Nro_cedulon=@Nro_cedulon");
                sql.AppendLine(", Barcode39=@Barcode39");
                sql.AppendLine(", Barcodeint25=@Barcodeint25");
                sql.AppendLine(", pagado=@pagado");
                sql.AppendLine(", monto_original=@monto_original");
                sql.AppendLine(", interes=@interes");
                sql.AppendLine(", descuento=@descuento");
                sql.AppendLine(", importe_pagar=@importe_pagar");
                sql.AppendLine(", fecha_baja_real=@fecha_baja_real");
                sql.AppendLine(", nro_secuencia=@nro_secuencia");
                sql.AppendLine(", nro_orden=@nro_orden");
                sql.AppendLine(", notificado_cidi=@notificado_cidi");
                sql.AppendLine("WHERE");
                sql.AppendLine("Nro_emision=@Nro_emision");
                sql.AppendLine("AND Nro_notificacion=@Nro_notificacion");
                sql.AppendLine("AND Legajo=@Legajo");
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@Nro_emision", obj.Nro_emision);
                    cmd.Parameters.AddWithValue("@Nro_notificacion", obj.Nro_notificacion);
                    cmd.Parameters.AddWithValue("@Legajo", obj.Legajo);
                    cmd.Parameters.AddWithValue("@Nro_badec", obj.Nro_badec);
                    cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("@Nom_barrio_dom_esp", obj.Nom_barrio_dom_esp);
                    cmd.Parameters.AddWithValue("@Nom_calle_dom_esp", obj.Nom_calle_dom_esp);
                    cmd.Parameters.AddWithValue("@Nro_dom_esp", obj.Nro_dom_esp);
                    cmd.Parameters.AddWithValue("@Ciudad_dom_esp", obj.Ciudad_dom_esp);
                    cmd.Parameters.AddWithValue("@Provincia_dom_esp", obj.Provincia_dom_esp);
                    cmd.Parameters.AddWithValue("@Pais_dom_esp", obj.Pais_dom_esp);
                    cmd.Parameters.AddWithValue("@Cod_postal_esp", obj.Cod_postal_esp);
                    cmd.Parameters.AddWithValue("@Nro_proc", obj.Nro_proc);
                    cmd.Parameters.AddWithValue("@Fecha_vencimiento", obj.Fecha_vencimiento);
                    cmd.Parameters.AddWithValue("@Periodo", obj.Periodo);
                    cmd.Parameters.AddWithValue("@Debe", obj.Debe);
                    cmd.Parameters.AddWithValue("@Nro_plan", obj.Nro_plan);
                    cmd.Parameters.AddWithValue("@Vencimiento", obj.Vencimiento);
                    cmd.Parameters.AddWithValue("@Cod_tipo_procuracion", obj.Cod_tipo_procuracion);
                    cmd.Parameters.AddWithValue("@Bloqueado", obj.Bloqueado);
                    cmd.Parameters.AddWithValue("@Codigo_procurador", obj.Codigo_procurador);
                    cmd.Parameters.AddWithValue("@TieneHonorarios", obj.TieneHonorarios);
                    cmd.Parameters.AddWithValue("@Tipo_descuento", obj.Tipo_descuento);
                    cmd.Parameters.AddWithValue("@Cod_formulario", obj.Cod_formulario);
                    cmd.Parameters.AddWithValue("@Codigo_estado_actual", obj.Codigo_estado_actual);
                    cmd.Parameters.AddWithValue("@paraimprimir", obj.paraimprimir);
                    cmd.Parameters.AddWithValue("@CedulonSi", obj.CedulonSi);
                    cmd.Parameters.AddWithValue("@Nro_cedulon", obj.Nro_cedulon);
                    cmd.Parameters.AddWithValue("@Barcode39", obj.Barcode39);
                    cmd.Parameters.AddWithValue("@Barcodeint25", obj.Barcodeint25);
                    cmd.Parameters.AddWithValue("@pagado", obj.pagado);
                    cmd.Parameters.AddWithValue("@monto_original", obj.monto_original);
                    cmd.Parameters.AddWithValue("@interes", obj.interes);
                    cmd.Parameters.AddWithValue("@descuento", obj.descuento);
                    cmd.Parameters.AddWithValue("@importe_pagar", obj.importe_pagar);
                    cmd.Parameters.AddWithValue("@fecha_baja_real", obj.fecha_baja_real);
                    cmd.Parameters.AddWithValue("@nro_secuencia", obj.nro_secuencia);
                    cmd.Parameters.AddWithValue("@nro_orden", obj.nro_orden);
                    cmd.Parameters.AddWithValue("@notificado_cidi", obj.notificado_cidi);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void delete(Det_notificacion_iyc obj)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("DELETE  Det_notificacion_iyc ");
                sql.AppendLine("WHERE");
                sql.AppendLine("Nro_emision=@Nro_emision");
                sql.AppendLine("AND Nro_notificacion=@Nro_notificacion");
                sql.AppendLine("AND Legajo=@Legajo");
                using (SqlConnection con = GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@Nro_emision", obj.Nro_emision);
                    cmd.Parameters.AddWithValue("@Nro_notificacion", obj.Nro_notificacion);
                    cmd.Parameters.AddWithValue("@Legajo", obj.Legajo);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

