using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class FrnFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            byte[] fileF = null;
            if (fuFile.HasFile) // Validamos si el control FileUpload contiene el archivo
            {
                // Obtenemos el nombre del archivo sin su respectiva extensión
                string name = System.IO.Path.GetFileNameWithoutExtension(fuFile.PostedFile.FileName);
                
                // Hallamos la extesión del archivo y lo concatenamos en una variable
                string extension = System.IO.Path.GetExtension(fuFile.PostedFile.FileName);

                fileF = fuFile.FileBytes; // Agregamos el archivo al array de tipo byte

                // Insertamos el archivo a la base de datos y validamos si fue almacenado correctamente
                if (File.addFile(name, extension, fileF) != null)
                    lblResult.Text = "Archivo ingresado";
                else
                    lblResult.Text = "Error al ingresar el archivo";
            }
        }
    }
}