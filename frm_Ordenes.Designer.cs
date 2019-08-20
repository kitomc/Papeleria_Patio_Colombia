namespace Papeleria_Patio_Colombia
{
    partial class frm_Ordenes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_EnviarOrden = new System.Windows.Forms.Button();
            this.tb_Empleado = new System.Windows.Forms.TextBox();
            this.lb_Servicios = new System.Windows.Forms.ListBox();
            this.cb_Servicios = new System.Windows.Forms.ComboBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btn_AgregarServicio = new System.Windows.Forms.Button();
            this.btn_RegistrarServicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto";
            // 
            // btn_EnviarOrden
            // 
            this.btn_EnviarOrden.Location = new System.Drawing.Point(245, 339);
            this.btn_EnviarOrden.Name = "btn_EnviarOrden";
            this.btn_EnviarOrden.Size = new System.Drawing.Size(158, 86);
            this.btn_EnviarOrden.TabIndex = 2;
            this.btn_EnviarOrden.Text = "Facturar";
            this.btn_EnviarOrden.UseVisualStyleBackColor = true;
            // 
            // tb_Empleado
            // 
            this.tb_Empleado.Location = new System.Drawing.Point(225, 82);
            this.tb_Empleado.Name = "tb_Empleado";
            this.tb_Empleado.Size = new System.Drawing.Size(178, 20);
            this.tb_Empleado.TabIndex = 3;
            // 
            // lb_Servicios
            // 
            this.lb_Servicios.FormattingEnabled = true;
            this.lb_Servicios.Location = new System.Drawing.Point(490, 60);
            this.lb_Servicios.Name = "lb_Servicios";
            this.lb_Servicios.Size = new System.Drawing.Size(370, 329);
            this.lb_Servicios.TabIndex = 4;
            // 
            // cb_Servicios
            // 
            this.cb_Servicios.FormattingEnabled = true;
            this.cb_Servicios.Items.AddRange(new object[] {
            "Yuca",
            "Platano"});
            this.cb_Servicios.Location = new System.Drawing.Point(225, 134);
            this.cb_Servicios.Name = "cb_Servicios";
            this.cb_Servicios.Size = new System.Drawing.Size(178, 21);
            this.cb_Servicios.TabIndex = 5;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(900, 437);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 446;
            this.lineShape1.X2 = 448;
            this.lineShape1.Y1 = 9;
            this.lineShape1.Y2 = 425;
            // 
            // btn_AgregarServicio
            // 
            this.btn_AgregarServicio.Location = new System.Drawing.Point(27, 339);
            this.btn_AgregarServicio.Name = "btn_AgregarServicio";
            this.btn_AgregarServicio.Size = new System.Drawing.Size(159, 41);
            this.btn_AgregarServicio.TabIndex = 7;
            this.btn_AgregarServicio.Text = "Agregar Servicio";
            this.btn_AgregarServicio.UseVisualStyleBackColor = true;
            this.btn_AgregarServicio.Click += new System.EventHandler(this.Btn_AgregarServicio_Click);
            // 
            // btn_RegistrarServicio
            // 
            this.btn_RegistrarServicio.Location = new System.Drawing.Point(27, 386);
            this.btn_RegistrarServicio.Name = "btn_RegistrarServicio";
            this.btn_RegistrarServicio.Size = new System.Drawing.Size(159, 39);
            this.btn_RegistrarServicio.TabIndex = 8;
            this.btn_RegistrarServicio.Text = "Registrar Servicio";
            this.btn_RegistrarServicio.UseVisualStyleBackColor = true;
            this.btn_RegistrarServicio.Click += new System.EventHandler(this.Btn_RegistrarServicio_Click);
            // 
            // frm_Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 437);
            this.Controls.Add(this.btn_RegistrarServicio);
            this.Controls.Add(this.btn_AgregarServicio);
            this.Controls.Add(this.cb_Servicios);
            this.Controls.Add(this.lb_Servicios);
            this.Controls.Add(this.tb_Empleado);
            this.Controls.Add(this.btn_EnviarOrden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "frm_Ordenes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Ordenes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_EnviarOrden;
        private System.Windows.Forms.TextBox tb_Empleado;
        private System.Windows.Forms.ListBox lb_Servicios;
        private System.Windows.Forms.ComboBox cb_Servicios;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btn_AgregarServicio;
        private System.Windows.Forms.Button btn_RegistrarServicio;
    }
}

