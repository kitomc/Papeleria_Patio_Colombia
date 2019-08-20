namespace Papeleria_Patio_Colombia
{
    partial class frm_Servicios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AgregarProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Descripcion = new System.Windows.Forms.TextBox();
            this.tb_CodigoProducto = new System.Windows.Forms.TextBox();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AgregarProducto
            // 
            this.btn_AgregarProducto.Location = new System.Drawing.Point(274, 272);
            this.btn_AgregarProducto.Name = "btn_AgregarProducto";
            this.btn_AgregarProducto.Size = new System.Drawing.Size(117, 97);
            this.btn_AgregarProducto.TabIndex = 0;
            this.btn_AgregarProducto.Text = "Agregar";
            this.btn_AgregarProducto.UseVisualStyleBackColor = true;
            this.btn_AgregarProducto.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo de Producto";
            // 
            // tb_Descripcion
            // 
            this.tb_Descripcion.Location = new System.Drawing.Point(170, 35);
            this.tb_Descripcion.Multiline = true;
            this.tb_Descripcion.Name = "tb_Descripcion";
            this.tb_Descripcion.Size = new System.Drawing.Size(209, 105);
            this.tb_Descripcion.TabIndex = 3;
            // 
            // tb_CodigoProducto
            // 
            this.tb_CodigoProducto.Location = new System.Drawing.Point(170, 192);
            this.tb_CodigoProducto.Name = "tb_CodigoProducto";
            this.tb_CodigoProducto.Size = new System.Drawing.Size(209, 20);
            this.tb_CodigoProducto.TabIndex = 4;
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(20, 320);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(117, 32);
            this.btn_Atras.TabIndex = 5;
            this.btn_Atras.Text = "Atras";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.Btn_Atras_Click);
            // 
            // frm_Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 381);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.tb_CodigoProducto);
            this.Controls.Add(this.tb_Descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AgregarProducto);
            this.Name = "frm_Servicios";
            this.Text = "frm_Servicios";
            this.Load += new System.EventHandler(this.Frm_Servicios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AgregarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Descripcion;
        private System.Windows.Forms.TextBox tb_CodigoProducto;
        private System.Windows.Forms.Button btn_Atras;
    }
}