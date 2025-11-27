using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VT_I_Final_MuhammetEminBalcioglu_MertGul
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=(local);Initial Catalog=veritabani_proje;Integrated Security=SSPI");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
