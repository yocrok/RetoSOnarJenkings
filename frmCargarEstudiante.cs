using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace cargadatosuma
{
    public partial class frmCargarEstudiante : Form
    {
        public frmCargarEstudiante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var fileName = @"F:\ESTUDIANTES.xls";
            var connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=\"Excel 12.0;IMEX=1;HDR=NO;TypeGuessRows=0;ImportMixedTypes=Text\""; ;
            using (var conn = new OleDbConnection(connectionString))
            {
                conn.Open();

                var sheets = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM [" + sheets.Rows[0]["Hoja1"].ToString() + "] ";

                    var adapter = new OleDbDataAdapter(cmd);
                    var ds = new DataSet();
                    adapter.Fill(ds);
                }
            }

        }
    }
}
