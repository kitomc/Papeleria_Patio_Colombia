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
    public partial class frm_Ordenes : Form
    {
        public frm_Ordenes()
        {
            InitializeComponent();
        }

        private void Frm_Ordenes_Load(object sender, EventArgs e)
        {

            //using (Capa_Datos.Papeleria_Patio_ColombiaEntities2 db = new Capa_Datos.Papeleria_Patio_ColombiaEntities2() ) 
            //{

            //    var lst = db.Servicios;

            //    foreach (var OServicios in lst)
            //    {

            //         cb_Servicios.Items.Add(OServicios.Descripcion);
            //    }

            //}

        }
         //Agregar producto de combo box a list box y luego se limpia el combo box
        private void Btn_AgregarServicio_Click(object sender, EventArgs e)
        {
            //if (cb_Servicios.SelectedIndex != 0)
            //{
            //}
                lb_Servicios.Items.Add(cb_Servicios.SelectedItem);
        }

        private void Btn_RegistrarServicio_Click(object sender, EventArgs e)
        {
            Form frm_Servicios = new frm_Servicios();

            frm_Servicios.ShowDialog();
            
        }
    }
}
