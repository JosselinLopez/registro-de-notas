using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registro_de_notas
{
    class Basedatos1
    {
        readonly String cadena = "Data Source=.DESKTOP-B8OH59T; Initial Catalog=RegistroNotas1201; User ID=sa; Password=jossy96";
        private object sqlDbType;

        public bool validarUsua(string Usuario, string Contraseña)
        {
            bool esusuariovalido = false;

            try
            {

                StringBuilder sql = new StringBuilder();

                sql.Append("SELECT 1 FROM USUARIO WERE USUARIO=@Usuario AND CONTRASEÑA =@Contraseña");
                using (System.Data.SqlClient.SqlConnection _conexion = new System.Data.SqlClient.SqlConnection(cadena))
                {

                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Usuario", SqlDbType.NVarChar, 30).Value = Usuario;
                        comando.Parameters.Add("@Contraseña", SqlDbType.NVarChar, 30).Value = Contraseña;
                        esusuariovalido = Convert.ToBoolean(comando.ExecuteScalar());
                    }
                }

            }


            catch (Exception)
            {


            }

            return esusuariovalido;
        }

        internal void EstudiantesDatos(string text1, string text2, int v1, int v2, decimal v3, decimal v4, decimal v5)
        {
            throw new NotImplementedException();
        }



        public bool EstudiantesDatos(string Nombre, String Apellido, int grado, int seccion, int Nota1, int Nota2, int Nota3, int Nota4, int Notafinal)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO DATOS");
                sql.Append("VALUES (@Nombre,@Apellido,@Grado,@Seccion,@Nota1,@Nota2,@Nota3,@NotaFinal);");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 30).Value = Nombre;
                        comando.Parameters.Add("@Apellido", SqlDbType.NVarChar, 30).Value = Apellido;
                        comando.Parameters.Add("@Grado", SqlDbType.NVarChar, 10).Value = grado;
                        comando.Parameters.Add("@Seccion", SqlDbType.NVarChar, 10).Value = seccion;
                        comando.Parameters.Add("@Nota1", SqlDbType.Decimal).Value = Nota1;
                        comando.Parameters.Add("@Nota2", SqlDbType.Decimal).Value = Nota2;
                        comando.Parameters.Add("@Nota3", SqlDbType.Decimal).Value = Nota3;
                        comando.Parameters.Add("@Nota4", SqlDbType.Decimal).Value = Nota4;
                        comando.Parameters.Add("@Notafinal", SqlDbType.Decimal).Value = Notafinal;
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {

                return false;
            }


        }
    }
}
