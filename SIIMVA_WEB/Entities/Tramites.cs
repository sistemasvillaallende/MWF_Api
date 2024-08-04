// Decompiled with JetBrains decompiler
// Type: MOTOR_WORKFLOW.Entities.Tramites
// Assembly: MOTOR_WORKFLOW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 007B8F5F-49BB-4EE7-8464-22FD2F567A18
// Assembly location: C:\Muni\DEV\WebApiMWF\MOTOR_WORKFLOW.dll

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

#nullable enable
namespace MOTOR_WORKFLOW.Entities
{
    public class Tramites : DALBase
    {
        public int id { get; set; }

        public int id_tramite { get; set; }

        public string cuit { get; set; }

        public string cuit_representado { get; set; }

        public DateTime fecha { get; set; }

        public int paso_anterior { get; set; }

        public int paso_actual { get; set; }

        public List<Pasos> lstPasos { get; set; }

        public int anio { get; set; }

        public int nro_expediente { get; set; }

        public string nombre_oficina { get; set; }

        public string nombre_tramite { get; set; }

        public string logo_oficina { get; set; }

        public Decimal avance { get; set; }

        public string nombre_contribuyente { get; set; }

        public string avatar { get; set; }

        public int id_oficina { get; set; }

        public int estado { get; set; }

        public int en_vecino { get; set; }

        public string _estado { get; set; }

        public Tramites()
        {
            this.id = 0;
            this.id_tramite = 0;
            this.cuit = string.Empty;
            this.cuit_representado = string.Empty;
            this.fecha = DateTime.Now;
            this.paso_anterior = 0;
            this.paso_actual = 0;
            this.anio = 0;
            this.nro_expediente = 0;
            this.logo_oficina = string.Empty;
            this.nombre_oficina = string.Empty;
            this.nombre_tramite = string.Empty;
            this.lstPasos = new List<Pasos>();
            this.avance = 0M;
            this.nombre_contribuyente = string.Empty;
            this.avatar = string.Empty;
            this.id_oficina = 0;
            this.estado = 0;
            this.en_vecino = 0;
            this._estado = string.Empty;
        }

        private static List<Tramites> mapeo(SqlDataReader dr)
        {
            List<Tramites> tramitesList = new List<Tramites>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("id");
                int ordinal2 = dr.GetOrdinal("id_tramite");
                int ordinal3 = dr.GetOrdinal("cuit");
                int ordinal4 = dr.GetOrdinal("cuit_representado");
                int ordinal5 = dr.GetOrdinal("fecha");
                int ordinal6 = dr.GetOrdinal("paso_anterior");
                int ordinal7 = dr.GetOrdinal("paso_actual");
                int ordinal8 = dr.GetOrdinal("nro_expediente");
                int ordinal9 = dr.GetOrdinal("anio");
                int ordinal10 = dr.GetOrdinal("estado");
                int ordinal11 = dr.GetOrdinal("id_oficina");
                int ordinal12 = dr.GetOrdinal("en_vecino");
                int ordinal13 = dr.GetOrdinal("nombre_unidad_organizativa");
                int ordinal14 = dr.GetOrdinal("nombre_tramite");
                int ordinal15 = dr.GetOrdinal("nombre_contribuyente");
                int ordinal16 = dr.GetOrdinal("logo_unidad_administrativa");
                int ordinal17 = dr.GetOrdinal("avatar");
                int ordinal18 = dr.GetOrdinal("_estado");
                while (dr.Read())
                {
                    Tramites tramites = new Tramites();
                    if (!dr.IsDBNull(ordinal1))
                        tramites.id = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        tramites.id_tramite = dr.GetInt32(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                        tramites.cuit = dr.GetString(ordinal3);
                    if (!dr.IsDBNull(ordinal4))
                        tramites.cuit_representado = dr.GetString(ordinal4);
                    if (!dr.IsDBNull(ordinal5))
                        tramites.fecha = dr.GetDateTime(ordinal5);
                    if (!dr.IsDBNull(ordinal6))
                        tramites.paso_anterior = dr.GetInt32(ordinal6);
                    if (!dr.IsDBNull(ordinal7))
                        tramites.paso_actual = dr.GetInt32(ordinal7);
                    if (!dr.IsDBNull(ordinal8))
                        tramites.paso_actual = dr.GetInt32(ordinal8);
                    if (!dr.IsDBNull(ordinal9))
                        tramites.anio = dr.GetInt32(ordinal9);
                    if (!dr.IsDBNull(ordinal10))
                        tramites.estado = dr.GetInt32(ordinal10);
                    if (!dr.IsDBNull(ordinal11))
                        tramites.id_oficina = dr.GetInt32(ordinal11);
                    if (!dr.IsDBNull(ordinal12))
                        tramites.en_vecino = dr.GetInt32(ordinal12);
                    if (!dr.IsDBNull(ordinal13))
                        tramites.nombre_oficina = dr.GetString(ordinal13);
                    if (!dr.IsDBNull(ordinal14))
                        tramites.nombre_tramite = dr.GetString(ordinal14);
                    if (!dr.IsDBNull(ordinal15))
                        tramites.nombre_contribuyente = dr.GetString(ordinal15);
                    if (!dr.IsDBNull(ordinal16))
                        tramites.logo_oficina = dr.GetString(ordinal16);
                    if (!dr.IsDBNull(ordinal17))
                        tramites.avatar = dr.GetString(ordinal17);
                    if (!dr.IsDBNull(ordinal18))
                        tramites._estado = dr.GetString(ordinal18);
                    switch (tramites.estado)
                    {
                        case 1:
                            tramites.avance = 25M;
                            break;
                        case 2:
                            tramites.avance = 50M;
                            break;
                        case 3:
                            tramites.avance = 75M;
                            break;
                        case 4:
                            tramites.avance = 100M;
                            break;
                    }
                    if (tramites.estado == 5)
                        tramites.estado = 1;
                    tramitesList.Add(tramites);
                }
            }
            return tramitesList;
        }

        private static List<Tramites> mapeoCompleto(SqlDataReader dr)
        {
            List<Tramites> tramitesList = new List<Tramites>();
            if (dr.HasRows)
            {
                int ordinal1 = dr.GetOrdinal("id");
                int ordinal2 = dr.GetOrdinal("id_tramite");
                int ordinal3 = dr.GetOrdinal("cuit");
                int ordinal4 = dr.GetOrdinal("cuit_representado");
                int ordinal5 = dr.GetOrdinal("fecha");
                int ordinal6 = dr.GetOrdinal("paso_anterior");
                int ordinal7 = dr.GetOrdinal("paso_actual");
                int ordinal8 = dr.GetOrdinal("nro_expediente");
                int ordinal9 = dr.GetOrdinal("anio");
                int ordinal10 = dr.GetOrdinal("estado");
                int ordinal11 = dr.GetOrdinal("id_oficina");
                int ordinal12 = dr.GetOrdinal("en_vecino");
                int ordinal13 = dr.GetOrdinal("nombre_unidad_organizativa");
                int ordinal14 = dr.GetOrdinal("nombre_tramite");
                int ordinal15 = dr.GetOrdinal("nombre_contribuyente");
                int ordinal16 = dr.GetOrdinal("logo_unidad_administrativa");
                int ordinal17 = dr.GetOrdinal("avatar");
                int ordinal18 = dr.GetOrdinal("_estado");
                while (dr.Read())
                {
                    Tramites tramites = new Tramites();
                    if (!dr.IsDBNull(ordinal1))
                        tramites.id = dr.GetInt32(ordinal1);
                    if (!dr.IsDBNull(ordinal2))
                        tramites.id_tramite = dr.GetInt32(ordinal2);
                    if (!dr.IsDBNull(ordinal3))
                        tramites.cuit = dr.GetString(ordinal3);
                    if (!dr.IsDBNull(ordinal4))
                        tramites.cuit_representado = dr.GetString(ordinal4);
                    if (!dr.IsDBNull(ordinal5))
                        tramites.fecha = dr.GetDateTime(ordinal5);
                    if (!dr.IsDBNull(ordinal6))
                        tramites.paso_anterior = dr.GetInt32(ordinal6);
                    if (!dr.IsDBNull(ordinal7))
                        tramites.paso_actual = dr.GetInt32(ordinal7);
                    if (!dr.IsDBNull(ordinal8))
                        tramites.nro_expediente = dr.GetInt32(ordinal8);
                    if (!dr.IsDBNull(ordinal9))
                        tramites.anio = dr.GetInt32(ordinal9);
                    if (!dr.IsDBNull(ordinal10))
                        tramites.estado = dr.GetInt32(ordinal10);
                    if (!dr.IsDBNull(ordinal11))
                        tramites.id_oficina = dr.GetInt32(ordinal11);
                    if (!dr.IsDBNull(ordinal12))
                        tramites.en_vecino = dr.GetInt32(ordinal12);
                    if (!dr.IsDBNull(ordinal13))
                        tramites.nombre_oficina = dr.GetString(ordinal13);
                    if (!dr.IsDBNull(ordinal14))
                        tramites.nombre_tramite = dr.GetString(ordinal14);
                    if (!dr.IsDBNull(ordinal15))
                        tramites.nombre_contribuyente = dr.GetString(ordinal15);
                    if (!dr.IsDBNull(ordinal16))
                        tramites.logo_oficina = dr.GetString(ordinal16);
                    if (!dr.IsDBNull(ordinal17))
                        tramites.avatar = dr.GetString(ordinal17);
                    if (!dr.IsDBNull(ordinal18))
                        tramites._estado = dr.GetString(ordinal18);
                    tramites.avance = 50M;
                    tramites.lstPasos.AddRange((IEnumerable<Pasos>)Pasos.read(tramites.id));
                    tramitesList.Add(tramites);
                }
            }
            return tramitesList;
        }

        public static List<Tramites> read(string cuit)
        {
            try
            {
                List<Tramites> tramitesList = new List<Tramites>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                            SELECT A.*,
                                B.nombre_unidad_organizativa,
                                B.NOMBRE as nombre_tramite,
                                C.apellido + ', ' + C.NOMBRE as nombre_contribuyente,
                                B.logo_unidad_administrativa, A.avatar,
                                _Estado = CASE estado
                                    WHEN 1 THEN 'INICIADO'
                                    WHEN 2 THEN 'EN PROCESO'
                                    WHEN 3 THEN 'CANCELADO'
                                    WHEN 4 THEN 'FINALIZADO'
                                END
                            FROM TRAMITES A
                                INNER JOIN TRAMITE B ON A.id_tramite=B.ID
                                INNER JOIN SIIMVA.dbo.VECINO_DIGITAL C ON
                                A.cuit COLLATE SQL_Latin1_General_CP1_CI_AS =
                                C.CUIT COLLATE SQL_Latin1_General_CP1_CI_AS
                            WHERE A.cuit = @cuit";
                    command.Parameters.AddWithValue("@cuit", cuit);
                    command.Connection.Open();
                    return Tramites.mapeo(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Tramites> readOficina(int id_oficina)
        {
            try
            {
                List<Tramites> tramitesList = new List<Tramites>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                            SELECT A.*,
                                B.nombre_unidad_organizativa,
                                B.NOMBRE as nombre_tramite,
                                C.apellido + ', ' + C.NOMBRE as nombre_contribuyente,
                                B.logo_unidad_administrativa, A.avatar,
                                _Estado = CASE estado
                                    WHEN 1 THEN 'INICIADO'
                                    WHEN 2 THEN 'EN PROCESO'
                                    WHEN 3 THEN 'CANCELADO'
                                    WHEN 4 THEN 'FINALIZADO'
                                END
                            FROM TRAMITES A
                                INNER JOIN TRAMITE B ON A.id_tramite=B.ID
                                INNER JOIN SIIMVA.dbo.VECINO_DIGITAL C ON
                                A.cuit COLLATE SQL_Latin1_General_CP1_CI_AS =
                                C.CUIT COLLATE SQL_Latin1_General_CP1_CI_AS
                            WHERE A.id_oficina = @id_oficina";
                    command.Parameters.AddWithValue("@id_oficina", id_oficina);
                    command.Connection.Open();
                    return Tramites.mapeo(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Tramites> read()
        {
            try
            {
                List<Tramites> tramitesList = new List<Tramites>();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                            SELECT A.*,
                                D.nombre_oficina AS nombre_unidad_organizativa,
                                B.NOMBRE as nombre_tramite,
                                C.apellido + ', ' + C.NOMBRE as nombre_contribuyente,
                                B.logo_unidad_administrativa, A.avatar,
                                _Estado = CASE estado
                                    WHEN 1 THEN 'INICIADO'
                                    WHEN 2 THEN 'EN PROCESO'
                                    WHEN 3 THEN 'CANCELADO'
                                    WHEN 4 THEN 'FINALIZADO'
                                    WHEN 5 THEN 'CAMBIO OFICINA'
                                END
                            FROM TRAMITES A
                                INNER JOIN TRAMITE B ON A.id_tramite=B.ID
                                INNER JOIN SIIMVA.dbo.VECINO_DIGITAL C ON
                                A.cuit COLLATE SQL_Latin1_General_CP1_CI_AS =
                                C.CUIT COLLATE SQL_Latin1_General_CP1_CI_AS
                                LEFT JOIN SIIMVA.dbo.OFICINAS D ON 
                                A.id_oficina = D.codigo_oficina";
                    command.Connection.Open();
                    return Tramites.mapeo(command.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Tramites getByPk(int id)
        {
            try
            {
                Tramites byPk = (Tramites)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                            SELECT A.*,
                                B.nombre_unidad_organizativa,
                                B.NOMBRE as nombre_tramite,
                                C.apellido + ', ' + C.NOMBRE as nombre_contribuyente,
                                B.logo_unidad_administrativa, A.avatar,
                                _Estado = CASE estado
                                    WHEN 1 THEN 'INICIADO'
                                    WHEN 2 THEN 'EN PROCESO'
                                    WHEN 3 THEN 'CANCELADO'
                                    WHEN 4 THEN 'FINALIZADO'
                                    WHEN 5 THEN 'CAMBIO OFICINA'
                                END
                            FROM TRAMITES A
                                INNER JOIN TRAMITE B ON A.id_tramite=B.ID
                                INNER JOIN SIIMVA.dbo.VECINO_DIGITAL C ON 
                                A.cuit COLLATE SQL_Latin1_General_CP1_CI_AS =
                                C.CUIT COLLATE SQL_Latin1_General_CP1_CI_AS
                                LEFT JOIN SIIMVA.dbo.OFICINAS D ON 
                                A.id_oficina = D.codigo_oficina
                            WHERE A.id=@id";
                    command.Parameters.AddWithValue("@id", id);
                    command.Connection.Open();
                    List<Tramites> tramitesList = Tramites.mapeoCompleto(command.ExecuteReader());
                    if (tramitesList.Count != 0)
                        byPk = tramitesList[0];
                }
                return byPk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Tramites getByPkSimple(int id)
        {
            try
            {
                Tramites byPkSimple = (Tramites)null;
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT A.*,                                 B.nombre_unidad_organizativa,                                B.NOMBRE as nombre_tramite, C.cuit,                                C.apellido + ', ' + C.NOMBRE as nombre_contribuyente,                                 B.logo_unidad_administrativa, A.avatar,                                _Estado = CASE estado                                    WHEN 1 THEN 'INICIADO'                                    WHEN 2 THEN 'EN PROCESO'                                    WHEN 3 THEN 'CANCELADO'                                    WHEN 4 THEN 'FINALIZADO'                                    WHEN 5 THEN 'CAMBIO OFICINA'                                END                                FROM TRAMITES A                                INNER JOIN TRAMITE B ON A.id_tramite=B.ID                                INNER JOIN SIIMVA.dbo.VECINO_DIGITAL C ON                                 A.cuit COLLATE SQL_Latin1_General_CP1_CI_AS =                                C.CUIT COLLATE SQL_Latin1_General_CP1_CI_AS                                LEFT JOIN SIIMVA.dbo.OFICINAS D ON                                 A.id_oficina = D.codigo_oficina                                WHERE A.id=@id";
                    command.Parameters.AddWithValue("@id", id);
                    command.Connection.Open();
                    List<Tramites> tramitesList = Tramites.mapeo(command.ExecuteReader());
                    if (tramitesList.Count != 0)
                        byPkSimple = tramitesList[0];
                }
                return byPkSimple;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<ResultadoTramites> getResultados(int idTramite)
        {
            try
            {
                List<ResultadoTramites> resultados = new List<ResultadoTramites>();
                ResultadoTramites resultadoTramites1 = new ResultadoTramites();
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                    SELECT
                        B.id_paso, 
	                    B.id_ingreso_paso, 
	                    B.orden_ingreso_paso, 
	                    B.row, 
	                    B.col,
                        B.nombre_ingreso_paso AS 'nombre_paso', 
	                    'DDJJ' AS 'nombre_ingreso_paso',
                        C.ddjj AS contenido, 
	                    'DDJJ' AS tipo, 
	                    '' AS extenciones,
                        A.cuit, 
	                    A.cuit_representado, 
	                    V.APELLIDO + ', ' + V.NOMBRE AS nombre_contribuyente,
                        VR.APELLIDO + ', ' + VR.NOMBRE AS nombre_representado,
                        T.NOMBRE AS nombre_tramite, T.nombre_unidad_organizativa,
                        T.ID AS id_tramite, 
	                    A.estado,
                        nombre_estado = CASE estado
                            WHEN 1 THEN 'INICIADO'
                            WHEN 2 THEN 'EN PROCESO'
                            WHEN 3 THEN 'CANCELADO'
                            WHEN 4 THEN 'FINALIZADO'
                            WHEN 5 THEN 'CAMBIO OFICINA'
                        END,
                        A.paso_actual, 
	                    A.paso_anterior, 
	                    A.en_vecino, 
	                    P.es_final,
	                    P.ORDEN
                    FROM TRAMITES A
                        INNER JOIN PASOS B ON A.id=B.id_tramites
                        INNER JOIN DDJJs C ON B.id=C.id_pasos
                        INNER JOIN SIIMVA.dbo.VECINO_DIGITAL V ON A.cuit 
		                    COLLATE SQL_Latin1_General_CP1_CI_AS = V.CUIT COLLATE SQL_Latin1_General_CP1_CI_AS
                        LEFT JOIN SIIMVA.dbo.VECINO_DIGITAL VR ON A.cuit_representado 
		                    COLLATE SQL_Latin1_General_CP1_CI_AS = VR.CUIT COLLATE SQL_Latin1_General_CP1_CI_AS
                        INNER JOIN TRAMITE T ON A.id_tramite=T.ID
                        INNER JOIN PASO P ON A.paso_actual=P.ID
                    WHERE A.id = @idTramite
                    UNION
                    SELECT 
                        B.id_paso,  
	                    B.id_ingreso_paso, 
	                    B.orden_ingreso_paso,
                        B.row,
	                    B.col,
	                    B.nombre_ingreso_paso AS 'nombre_paso', 
                        D.nombre AS 'nombre_ingreso_paso', 
                        CONVERT(VARCHAR(MAX),D.archivo) AS contenido,
                        'ADJUNTO' AS tipo,
                        D.extenciones_aceptadas AS extenciones,
                        A.cuit, 
	                    A.cuit_representado,
                        V.APELLIDO + ', ' + V.NOMBRE AS nombre_contribuyente,
                        VR.APELLIDO + ', ' + VR.NOMBRE AS nombre_representado,
                        T.NOMBRE AS nombre_tramite,  
	                    T.nombre_unidad_organizativa,
                        T.ID AS id_tramite,
                        A.estado, 
	                    nombre_estado = CASE estado
                            WHEN 1 THEN 'INICIADO'
                            WHEN 2 THEN 'EN PROCESO'
                            WHEN 3 THEN 'CANCELADO'
                            WHEN 4 THEN 'FINALIZADO'
                            WHEN 5 THEN 'CAMBIO OFICINA'
                        END,
                        A.paso_actual, 
	                    A.paso_anterior, 
	                    A.en_vecino, 
	                    P.es_final,
	                    P.ORDEN
                    FROM TRAMITES A
                        INNER JOIN PASOS B ON A.id=B.id_tramites
                        INNER JOIN ADJUNTOS D ON B.id=D.id_pasos
                        INNER JOIN SIIMVA.dbo.VECINO_DIGITAL V ON A.cuit 
		                    COLLATE SQL_Latin1_General_CP1_CI_AS = V.CUIT COLLATE SQL_Latin1_General_CP1_CI_AS
                        LEFT JOIN SIIMVA.dbo.VECINO_DIGITAL VR ON A.cuit_representado
		                    COLLATE SQL_Latin1_General_CP1_CI_AS = VR.CUIT COLLATE SQL_Latin1_General_CP1_CI_AS
                        INNER JOIN TRAMITE T ON A.id_tramite=T.ID
                        INNER JOIN PASO P ON A.paso_actual=P.ID
                    WHERE A.id = @idTramite
                    UNION
                    SELECT 
                        B.id_paso, 
	                    B.id_ingreso_paso, 
	                    B.orden_ingreso_paso,   
                        B.row,
	                    B.col, 
	                    B.nombre_ingreso_paso AS 'nombre_paso', 
                        D.nombre AS 'nombre_ingreso_paso', 
	                    (SELECT *FROM RESPUESTA_FORMULARIO               
		                    WHERE id_formularios=D.id                
		                    FOR JSON PATH) AS contenido,                 
                        'FORMULARIO' AS tipo,        
                        '' AS extenciones,
                        A.cuit,
                        A.cuit_representado,
                        V.APELLIDO + ', ' + V.NOMBRE AS nombre_contribuyente,
                        VR.APELLIDO + ', ' + VR.NOMBRE AS nombre_representado,
                        T.NOMBRE AS tnombre_tramite,
                        T.nombre_unidad_organizativa,
                        T.ID AS id_tramite,
                        A.estado,
                        nombre_estado = CASE estado
                            WHEN 1 THEN 'INICIADO'
                            WHEN 2 THEN 'EN PROCESO'
                            WHEN 3 THEN 'CANCELADO'
                            WHEN 4 THEN 'FINALIZADO'
                            WHEN 5 THEN 'CAMBIO OFICINA' 
                            END,
                        A.paso_actual, 
	                    A.paso_anterior,  
	                    A.en_vecino, 
	                    P.es_final,
	                    P.ORDEN
                    FROM TRAMITES A 
	                    INNER JOIN PASOS B ON A.id=B.id_tramites 
                        INNER JOIN FORMULARIOS D ON B.id=D.id_pasos
                        INNER JOIN SIIMVA.dbo.VECINO_DIGITAL V ON A.cuit 
		                    COLLATE SQL_Latin1_General_CP1_CI_AS = V.CUIT 
		                    COLLATE SQL_Latin1_General_CP1_CI_AS
	                    LEFT JOIN SIIMVA.dbo.VECINO_DIGITAL VR ON A.cuit_representado 
		                    COLLATE SQL_Latin1_General_CP1_CI_AS = VR.CUIT 
		                    COLLATE SQL_Latin1_General_CP1_CI_AS
	                    INNER JOIN TRAMITE T ON A.id_tramite=T.ID
	                    INNER JOIN PASO P ON A.paso_actual=P.ID     
                    WHERE A.id = @idTramite            
                    ORDER BY orden_ingreso_paso, row";
                    command.Parameters.AddWithValue("@idTramite", idTramite);
                    command.Connection.Open();
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        int ordinal1 = sqlDataReader.GetOrdinal("id_paso");
                        int ordinal2 = sqlDataReader.GetOrdinal("id_ingreso_paso");
                        int ordinal3 = sqlDataReader.GetOrdinal("orden_ingreso_paso");
                        int ordinal4 = sqlDataReader.GetOrdinal("row");
                        int ordinal5 = sqlDataReader.GetOrdinal("col");
                        int ordinal6 = sqlDataReader.GetOrdinal("nombre_paso");
                        int ordinal7 = sqlDataReader.GetOrdinal("nombre_ingreso_paso");
                        int ordinal8 = sqlDataReader.GetOrdinal("contenido");
                        int ordinal9 = sqlDataReader.GetOrdinal("tipo");
                        int ordinal10 = sqlDataReader.GetOrdinal("extenciones");
                        int ordinal11 = sqlDataReader.GetOrdinal("cuit");
                        int ordinal12 = sqlDataReader.GetOrdinal("cuit_representado");
                        int ordinal13 = sqlDataReader.GetOrdinal("nombre_contribuyente");
                        int ordinal14 = sqlDataReader.GetOrdinal("nombre_representado");
                        int ordinal15 = sqlDataReader.GetOrdinal("nombre_tramite");
                        int ordinal16 = sqlDataReader.GetOrdinal("nombre_unidad_organizativa");
                        int ordinal17 = sqlDataReader.GetOrdinal("id_tramite");
                        int ordinal18 = sqlDataReader.GetOrdinal("estado");
                        int ordinal19 = sqlDataReader.GetOrdinal("nombre_estado");
                        int ordinal20 = sqlDataReader.GetOrdinal("paso_actual");
                        int ordinal21 = sqlDataReader.GetOrdinal("paso_anterior");
                        int ordinal22 = sqlDataReader.GetOrdinal("en_vecino");
                        int ordinal23 = sqlDataReader.GetOrdinal("es_final");
                        while (sqlDataReader.Read())
                        {
                            ResultadoTramites resultadoTramites2 = new ResultadoTramites();
                            if (!sqlDataReader.IsDBNull(ordinal1))
                                resultadoTramites2.id_paso = sqlDataReader.GetInt32(ordinal1);
                            if (!sqlDataReader.IsDBNull(ordinal2))
                                resultadoTramites2.id_ingreso_paso = sqlDataReader.GetInt32(ordinal2);
                            if (!sqlDataReader.IsDBNull(ordinal3))
                                resultadoTramites2.orden_ingreso_paso = sqlDataReader.GetInt32(ordinal3);
                            if (!sqlDataReader.IsDBNull(ordinal4))
                                resultadoTramites2.row = sqlDataReader.GetInt32(ordinal4);
                            if (!sqlDataReader.IsDBNull(ordinal5))
                                resultadoTramites2.col = sqlDataReader.GetInt32(ordinal5);
                            if (!sqlDataReader.IsDBNull(ordinal6))
                                resultadoTramites2.nombre_paso = sqlDataReader.GetString(ordinal6);
                            if (!sqlDataReader.IsDBNull(ordinal7))
                                resultadoTramites2.nombre_ingreso_paso = sqlDataReader.GetString(ordinal7);
                            if (!sqlDataReader.IsDBNull(ordinal8))
                                resultadoTramites2.contenido = sqlDataReader.GetString(ordinal8);
                            if (!sqlDataReader.IsDBNull(ordinal9))
                                resultadoTramites2.tipo = sqlDataReader.GetString(ordinal9);
                            if (!sqlDataReader.IsDBNull(ordinal10))
                                resultadoTramites2.extenciones = sqlDataReader.GetString(ordinal10);
                            if (!sqlDataReader.IsDBNull(ordinal11))
                                resultadoTramites2.cuit = sqlDataReader.GetString(ordinal11);
                            if (!sqlDataReader.IsDBNull(ordinal12))
                                resultadoTramites2.cuit_representado = sqlDataReader.GetString(ordinal12);
                            if (!sqlDataReader.IsDBNull(ordinal13))
                                resultadoTramites2.nombre_contribuyente = sqlDataReader.GetString(ordinal13);
                            if (!sqlDataReader.IsDBNull(ordinal14))
                                resultadoTramites2.nombre_representado = sqlDataReader.GetString(ordinal14);
                            if (!sqlDataReader.IsDBNull(ordinal15))
                                resultadoTramites2.nombre_tramite = sqlDataReader.GetString(ordinal15);
                            if (!sqlDataReader.IsDBNull(ordinal16))
                                resultadoTramites2.nombre_unidad_organizativa = sqlDataReader.GetString(ordinal16);
                            if (!sqlDataReader.IsDBNull(ordinal17))
                                resultadoTramites2.id_tramite = sqlDataReader.GetInt32(ordinal17);
                            if (!sqlDataReader.IsDBNull(ordinal18))
                                resultadoTramites2.estado = sqlDataReader.GetInt32(ordinal18);
                            if (!sqlDataReader.IsDBNull(ordinal19))
                                resultadoTramites2.nombre_estado = sqlDataReader.GetString(ordinal19);
                            if (!sqlDataReader.IsDBNull(ordinal20))
                                resultadoTramites2.paso_actual = sqlDataReader.GetInt32(ordinal20);
                            if (!sqlDataReader.IsDBNull(ordinal21))
                                resultadoTramites2.paso_anterior = sqlDataReader.GetInt32(ordinal21);
                            if (!sqlDataReader.IsDBNull(ordinal22))
                                resultadoTramites2.en_vecino = sqlDataReader.GetBoolean(ordinal22);
                            if (!sqlDataReader.IsDBNull(ordinal23))
                                resultadoTramites2.es_final = sqlDataReader.GetBoolean(ordinal23);
                            resultados.Add(resultadoTramites2);
                        }
                    }
                }
                return resultados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int insert(Tramites obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("INSERT INTO Tramites(");
                stringBuilder.AppendLine("id_tramite");
                stringBuilder.AppendLine(", cuit");
                stringBuilder.AppendLine(", cuit_representado");
                stringBuilder.AppendLine(", fecha");
                stringBuilder.AppendLine(", paso_anterior");
                stringBuilder.AppendLine(", paso_actual");
                stringBuilder.AppendLine(", anio");
                stringBuilder.AppendLine(", nro_expediente");
                stringBuilder.AppendLine(", estado");
                stringBuilder.AppendLine(", id_oficina");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("VALUES");
                stringBuilder.AppendLine("(");
                stringBuilder.AppendLine("@id_tramite");
                stringBuilder.AppendLine(", @cuit");
                stringBuilder.AppendLine(", @cuit_representado");
                stringBuilder.AppendLine(", @fecha");
                stringBuilder.AppendLine(", @paso_anterior");
                stringBuilder.AppendLine(", @paso_actual");
                stringBuilder.AppendLine(", YEAR(GETDATE())");
                stringBuilder.AppendLine(", @nro_expediente");
                stringBuilder.AppendLine(", 1");
                stringBuilder.AppendLine(", @id_oficina");
                stringBuilder.AppendLine(")");
                stringBuilder.AppendLine("SELECT SCOPE_IDENTITY()");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id_tramite", obj.id_tramite);
                    command.Parameters.AddWithValue("@cuit", obj.cuit);
                    command.Parameters.AddWithValue("@cuit_representado", obj.cuit_representado);
                    command.Parameters.AddWithValue("@fecha", obj.fecha);
                    command.Parameters.AddWithValue("@paso_anterior", obj.paso_anterior);
                    command.Parameters.AddWithValue("@paso_actual", obj.paso_actual);
                    command.Parameters.AddWithValue("@nro_expediente", obj.nro_expediente);
                    command.Parameters.AddWithValue("@id_oficina", obj.id_oficina);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void update(Tramites obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Tramites SET");
                stringBuilder.AppendLine("id_tramite=@id_tramite");
                stringBuilder.AppendLine(", cuit=@cuit");
                stringBuilder.AppendLine(", cuit_representado=@cuit_representado");
                stringBuilder.AppendLine(", fecha=@fecha");
                stringBuilder.AppendLine(", paso_anterior=@paso_anterior");
                stringBuilder.AppendLine(", paso_actual=@paso_actual");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id_tramite", obj.id_tramite);
                    command.Parameters.AddWithValue("@cuit", obj.cuit);
                    command.Parameters.AddWithValue("@cuit_representado", obj.cuit_representado);
                    command.Parameters.AddWithValue("@fecha", obj.fecha);
                    command.Parameters.AddWithValue("@paso_anterior", obj.paso_anterior);
                    command.Parameters.AddWithValue("@paso_actual", obj.paso_actual);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int recibir(int id_tramite, int paso_actual, int id_tramites, int cod_usuario)
        {
            try
            {
                Paso proximo = Paso.getProximo(id_tramite, paso_actual);
                int num = 0;
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Tramites SET");
                stringBuilder.AppendLine("paso_anterior=@paso_anterior");
                stringBuilder.AppendLine(", paso_actual=@paso_actual");
                stringBuilder.AppendLine(", estado=2");
                stringBuilder.AppendLine(", id_oficina=@id_oficina");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@paso_anterior", paso_actual);
                    command.Parameters.AddWithValue("@paso_actual", proximo.id);
                    command.Parameters.AddWithValue("@id_oficina", proximo.id_oficina);
                    command.Parameters.AddWithValue("@id", id_tramites);
                    command.Connection.Open();
                    num = Convert.ToInt32(command.ExecuteScalar());
                }
                Paso byPk = Paso.getByPk(paso_actual);
                Movimiento_tramites.insert(new Movimiento_tramites()
                {
                    cod_usuario = cod_usuario,
                    accion = "RECIBE",
                    en_vecino = false,
                    id_tramites = id_tramites,
                    destino_vecino = false,
                    id_oficina = byPk.id_oficina,
                    cod_oficina_destino = byPk.proxima_oficina
                });
                return proximo.id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void mover(int id_tramites, int paso_actual, int paso_anterior, int id_oficina)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Tramites SET");
                stringBuilder.AppendLine("paso_anterior=@paso_anterior");
                stringBuilder.AppendLine(", paso_actual=@paso_actual");
                stringBuilder.AppendLine(", estado=5");
                stringBuilder.AppendLine(", id_oficina=@id_oficina");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@paso_anterior", paso_anterior);
                    command.Parameters.AddWithValue("@paso_actual", paso_actual);
                    command.Parameters.AddWithValue("@id_oficina", id_oficina);
                    command.Parameters.AddWithValue("@id", id_tramites);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void finalizar_rechazar(int id_tramites, int estado)
        {
            try
            {
                int num = 0;
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("UPDATE  Tramites SET");
                stringBuilder.AppendLine("estado=@estado");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@estado", estado);
                    command.Parameters.AddWithValue("@id", id_tramites);
                    command.Connection.Open();
                    num = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(Tramites obj)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("DELETE  Tramites ");
                stringBuilder.AppendLine("WHERE");
                stringBuilder.AppendLine("id=@id");
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = stringBuilder.ToString();
                    command.Parameters.AddWithValue("@id", obj.id);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int valida(int idTramite)
        {
            try
            {
                using (SqlConnection connection = DALBase.GetConnection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT COUNT(*) FROM TRAMITES WHERE ID_TRAMITE = @idTramite";
                    command.Parameters.AddWithValue("@idTramite", idTramite);
                    command.Connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
