using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Para trabajar con Linq, agregamos los siguientes namespace
using System.Data.Linq.Mapping;
using System.Data.Linq.SqlClient;

namespace DataAccess
{
    [Table(Name = "tblFile")] //Tabla a la que se referencia la clase
    public class File
    {
        #region Properties
        //La columna o propiedad es auto generadora (IsDbGenerated) y además clave primaria (IsPrimaryKey)
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int id { get; set; }

        [Column]
        public string name { get; set; }

        [Column]
        public string extension { get; set; }

        [Column]
        public byte[] fileF { get; set; }

        [Column]
        public DateTime dateF { get; set; }
        #endregion

        #region Methods
        public static File addFile(string pName, string pExtension, byte[] pFile)
        {
            // Se utiliza using para que automáticamente limpie los recursos utilizados
            using (Connection db = new Connection())
            {
                // Creamos el objeto de la clase File y pasamos los datos a sus propiedades
                File file = new File() 
                { 
                    name = pName,
                    extension = pExtension,
                    fileF = pFile,
                    dateF = DateTime.Now
                };
                /* Añadimos los datos el objeto File a una lista en espera, 
                 * para insertar en la tabla*/
                db.tblFile.InsertOnSubmit(file);

                db.SubmitChanges(); // Enviamos el cambio a la base de datos
                return file;
            }
        }
        #endregion
    }
}
