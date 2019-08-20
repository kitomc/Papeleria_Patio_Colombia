using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Papeleria_Patio_Colombia
{
    public partial class frm_Servicios : Form
    {
        public frm_Servicios()
        {
            InitializeComponent();
        }

        Capa_Datos.Servicios   _Servicios;
        Capa_Datos.Papeleria_Patio_ColombiaEntities2 db = new Capa_Datos.Papeleria_Patio_ColombiaEntities2();


        private void Button1_Click(object sender, EventArgs e)
        {




            _Servicios = new Capa_Datos.Servicios();

            _Servicios.Descripcion = tb_Descripcion.Text.ToString();
            _Servicios.Codigo = int.Parse(tb_CodigoProducto.Text);

            db.Servicios.Add(_Servicios);
            db.SaveChanges();
            
            

          
            

        }

        private void Btn_Atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Servicios_Load(object sender, EventArgs e)
        {
            
        }
    }
}
