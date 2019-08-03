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



            String coneccionstring = " Provider=SQLNCLI11;Data Source=DESKTOP-N54DNTA;Integrated Security=SSPI;Initial Catalog=ExamenFinal";
            OleDbConnection objConeccion;
            OleDbDataAdapter objAdaptador;



       //AQUI COLOCAMOS TODOS LOS CAMPOS DE NUESTRA TABLA USUARIOS 
        int IDUSUARIO ;
        string CEDULA;
        string NOMBRE;
        string APELLIDO;
        string DIRECCION;
  
        //AQUI HACEMOS UNA VARIABLE QUE ES LA QUE SE ENCARGARA DE HACER LAS CONEXIONES A LA BD
        string sintax_sql_buscar;

        //AQUI CREAMOS LAS VARIABLES DE NUESTRA TABLA MATERIAS
        int IDMATERIAS ;
        string MATERIA;
      
        //AQUI LAS VARIABLES DE NUESTRA TABLA NOTAS
        int IDNOTAS;
        float NOTA;


        public int idusuario
        {
            get
            {
                return IDUSUARIO;
            }
            set
            {
                IDUSUARIO = value;
            }
        }
        public string Cedula
        {
            get
            {
                return CEDULA;
            }
            set
            {
                CEDULA = value;
            }
        }
        public string Nombre
        {
            get
            {
                return NOMBRE;
            }
            set
            {
                NOMBRE = value;
            }
        }
        public string Apellido
        {
            get
            {
                return APELLIDO;
            }
            set
            {
                APELLIDO = value;
            }
        }
        public string Direccion
        {
            get
            {
                return DIRECCION;
            }
            set
            {
                DIRECCION = value;
            }
        }



        public int IdMaterias
        {
            get
            {
                return IDMATERIAS;
            }
            set
            {
                IDMATERIAS = value;
            }
        }
        public int IdMaterias
        {
            get
            {
                return IDMATERIAS;
            }
            set
            {
                IDMATERIAS = value;
            }
        }

        public string Materias
        {
            get
            {
                return MATERIA;
            }
            set
            {
                MATERIA = value;
            }
        }


        public int IdNotas
        {
            get
            {
                return IDNOTAS;
            }
            set
            {
                IDNOTAS = value;
            }
        }

        public float Notas
        {
            get
            {
                return NOTA;
            }
            set
            {
                NOTA = value;
            }
        }



    public string fnconsulta(int opcion, string valor)
        {
        string resp = "";
        switch(opcion)
        {
            case 1:
                sintax_sql_buscar = "select CEDULA, NOMBRE, APELLIDO, DIRECCION from Usuario";
                break;
            case 2:
                sintax_sql_buscar = "select MATERIA  from Materias ";
                break;
            case 3:
                sintax_sql_buscar = "select NOTA from NOTAS  ";
                break;
            case 4:
                break;

        }
        resp = sintax_sql_buscar;
        return resp;
        }



        public DataSet fn_Conectarse (int buscar)
    {
        DataSet dt = new DataSet();
        objConeccion = new OleDbConnection(coneccionstring);
        objConeccion.Open();
        fnconsulta(buscar, "");
        objAdaptador = new OleDbDataAdapter(sintax_sql_buscar, objConeccion);
        objAdaptador.Fill(dt);
        return dt;


    }


    }
}