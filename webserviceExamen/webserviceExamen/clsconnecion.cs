using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
namespace webservicetrabajo
{
    public class clsconnecion
    {

        String coneccionstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\JAGN\\Documents\\B.mdb";
            OleDbConnection objConeccion;
            OleDbDataAdapter objAdaptador;



        string sintax_sql;
        string str_trabajo;
        int int_idtrabajo;
        string str_usuario;
        string str_tipo;
        int int_idusuario;
        string str_fecha;
        public int idusuario
        {
            get
            {
                return int_idusuario;
            }
            set
            {
                int_idusuario = value;
            }
        }
        public string usuario
        {
            get
            {
                return str_usuario;
            }
            set
            {
                str_usuario = value;
            }
        }
        public int idtrabajo
        {
            get
            {
                return int_idtrabajo;
            }
            set
            {
                int_idtrabajo = value;
            }
        }
        public string trabajo
        {
            get
            {
                return str_trabajo;
            }
            set
            {
                str_trabajo = value;
            }
        }
        public string fecha
        {
            get
            {
                return str_fecha;
            }
            set
            {
                str_fecha = value;
            }
        }



        public string tipo
        {
            get
            {
                return str_tipo;
            }
            set
            {
                str_tipo = value;
            }
        }


    public string fnconsulta(int opcion, string valor)
        {
            string resp = "";
        switch(opcion)
        {
            case 1:
                sintax_sql= "select * from alumno";
                break;
            case 2:
                sintax_sql = "select * from trabajo";
                break;
            case 3:
            case 4:
                break;

        }
        resp = sintax_sql;
        return resp;
        }



        public DataSet fn_Conectarse (int buscar)
    {
        DataSet dt = new DataSet();
        objConeccion = new OleDbConnection(coneccionstring);
        objConeccion.Open();
        fnconsulta(buscar, "");
        objAdaptador = new OleDbDataAdapter(sintax_sql, objConeccion);
        objAdaptador.Fill(dt);
        return dt;


    }


    }
}