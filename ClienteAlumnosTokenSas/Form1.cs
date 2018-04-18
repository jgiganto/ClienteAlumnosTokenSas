using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAzure.Storage.Table;
using System.Net;
using System.Xml.Linq;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage;

namespace ClienteAlumnosTokenSas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public String GetToken(String curso)
        {
            String urlapi =
                "http://apitablaalumnosjgd.azurewebsites.net/api/RecuperarToken/"+curso;
            WebClient cliente = new WebClient();
            cliente.Headers["content-type"] = "application/xml";
            String datosxml = cliente.DownloadString(urlapi);
            XDocument doc = XDocument.Parse(datosxml);
            XElement elem = (XElement)doc.FirstNode;
            String token = elem.Value;
            return token;

        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            String urltable = "https://storagetajamarjgd.table.core.windows.net/";//Punto de conexión de servicio Tabla principal en azure table
            String curso = this.txtcurso.Text;
            String token = this.GetToken(curso);
            StorageCredentials credenciales =
                new StorageCredentials(token);
            CloudTableClient cliente =
                new CloudTableClient(
                    new StorageUri(new Uri(urltable)), credenciales);
            CloudTable tabla = cliente.GetTableReference("alumnos");
            TableQuery<Alumno> consulta =
                new TableQuery<Alumno>();
           var datos = tabla.ExecuteQuery(consulta);
            if (datos.Count() == 0)
            {
                MessageBox.Show("Nohay registros");
            }
            else
            {
                gridalumnos.DataSource = datos.ToList();
            }
        }
    }
}
