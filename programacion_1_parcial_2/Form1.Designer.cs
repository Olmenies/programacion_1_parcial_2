
namespace programacion_1_parcial_2
{
    partial class Form1
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
            this.groupBoxCheckBox = new System.Windows.Forms.GroupBox();
            this.checkBoxFacturasPares = new System.Windows.Forms.CheckBox();
            this.checkBoxFacturasImpares = new System.Windows.Forms.CheckBox();
            this.checkBoxMayoresIguales10k = new System.Windows.Forms.CheckBox();
            this.checkBoxMenores10k = new System.Windows.Forms.CheckBox();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.listBoxFacturas = new System.Windows.Forms.ListBox();
            this.groupBoxCheckBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCheckBox
            // 
            this.groupBoxCheckBox.Controls.Add(this.checkBoxMenores10k);
            this.groupBoxCheckBox.Controls.Add(this.checkBoxMayoresIguales10k);
            this.groupBoxCheckBox.Controls.Add(this.checkBoxFacturasImpares);
            this.groupBoxCheckBox.Controls.Add(this.checkBoxFacturasPares);
            this.groupBoxCheckBox.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCheckBox.Name = "groupBoxCheckBox";
            this.groupBoxCheckBox.Size = new System.Drawing.Size(602, 66);
            this.groupBoxCheckBox.TabIndex = 0;
            this.groupBoxCheckBox.TabStop = false;
            this.groupBoxCheckBox.Text = "Seleccionar filtro";
            // 
            // checkBoxFacturasPares
            // 
            this.checkBoxFacturasPares.AutoSize = true;
            this.checkBoxFacturasPares.Location = new System.Drawing.Point(6, 16);
            this.checkBoxFacturasPares.Name = "checkBoxFacturasPares";
            this.checkBoxFacturasPares.Size = new System.Drawing.Size(96, 17);
            this.checkBoxFacturasPares.TabIndex = 0;
            this.checkBoxFacturasPares.Text = "Facturas pares";
            this.checkBoxFacturasPares.UseVisualStyleBackColor = true;
            // 
            // checkBoxFacturasImpares
            // 
            this.checkBoxFacturasImpares.AutoSize = true;
            this.checkBoxFacturasImpares.Location = new System.Drawing.Point(6, 39);
            this.checkBoxFacturasImpares.Name = "checkBoxFacturasImpares";
            this.checkBoxFacturasImpares.Size = new System.Drawing.Size(106, 17);
            this.checkBoxFacturasImpares.TabIndex = 1;
            this.checkBoxFacturasImpares.Text = "Facturas impares";
            this.checkBoxFacturasImpares.UseVisualStyleBackColor = true;
            // 
            // checkBoxMayoresIguales10k
            // 
            this.checkBoxMayoresIguales10k.AutoSize = true;
            this.checkBoxMayoresIguales10k.Location = new System.Drawing.Point(297, 39);
            this.checkBoxMayoresIguales10k.Name = "checkBoxMayoresIguales10k";
            this.checkBoxMayoresIguales10k.Size = new System.Drawing.Size(162, 17);
            this.checkBoxMayoresIguales10k.TabIndex = 2;
            this.checkBoxMayoresIguales10k.Text = "Mayores o iguales a $10.000";
            this.checkBoxMayoresIguales10k.UseVisualStyleBackColor = true;
            // 
            // checkBoxMenores10k
            // 
            this.checkBoxMenores10k.AutoSize = true;
            this.checkBoxMenores10k.Location = new System.Drawing.Point(297, 16);
            this.checkBoxMenores10k.Name = "checkBoxMenores10k";
            this.checkBoxMenores10k.Size = new System.Drawing.Size(118, 17);
            this.checkBoxMenores10k.TabIndex = 3;
            this.checkBoxMenores10k.Text = "Menores a $10.000";
            this.checkBoxMenores10k.UseVisualStyleBackColor = true;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(12, 84);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(291, 23);
            this.buttonConsultar.TabIndex = 1;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(309, 84);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(305, 23);
            this.buttonSalir.TabIndex = 2;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // listBoxFacturas
            // 
            this.listBoxFacturas.FormattingEnabled = true;
            this.listBoxFacturas.Location = new System.Drawing.Point(12, 113);
            this.listBoxFacturas.Name = "listBoxFacturas";
            this.listBoxFacturas.Size = new System.Drawing.Size(602, 225);
            this.listBoxFacturas.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 358);
            this.Controls.Add(this.listBoxFacturas);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.groupBoxCheckBox);
            this.Name = "Form1";
            this.Text = "Programacion 1 - Parcial 2";
            this.groupBoxCheckBox.ResumeLayout(false);
            this.groupBoxCheckBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCheckBox;
        private System.Windows.Forms.CheckBox checkBoxMenores10k;
        private System.Windows.Forms.CheckBox checkBoxMayoresIguales10k;
        private System.Windows.Forms.CheckBox checkBoxFacturasImpares;
        private System.Windows.Forms.CheckBox checkBoxFacturasPares;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.ListBox listBoxFacturas;
    }
}

