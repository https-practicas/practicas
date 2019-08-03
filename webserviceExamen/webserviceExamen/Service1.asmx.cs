using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace webservicetrabajo
{
    /// <summary>
    /// Descripción breve de Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        clsconnecion clsOBJETOCONEXION = new clsconnecion();


        [WebMethod]
        
             public int fn_SUMA (int a, int b)
        
        {
            int c;
            c = a + b;
            return c;
        }

       [WebMethod]
        public DataSet fn_Conectarse(int buscar)
        {
           DataSet dt = new DataSet();
           dt = clsOBJETOCONEXION.fn_Conectarse(buscar);

           return dt;
 
        }

    [WebMethod]
        public void CARGAR_VALORES (int idusuario, int idtrabajo, string usuario, string Trabajo, string tipo)
       {
           clsOBJETOCONEXION.idtrabajo = idtrabajo;
           clsOBJETOCONEXION.idusuario = idusuario;
           clsOBJETOCONEXION.usuario = usuario;
           clsOBJETOCONEXION.trabajo = Trabajo;
           clsOBJETOCONEXION.tipo = tipo;

           fn_Conectarse(4);

       }


    }
}