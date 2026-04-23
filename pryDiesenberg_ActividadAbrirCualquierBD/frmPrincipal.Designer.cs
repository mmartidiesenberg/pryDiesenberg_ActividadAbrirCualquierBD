namespace pryDiesenberg_ActividadAbrirCualquierBD
{
    partial class frmPrincipal
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cmbTablas = new System.Windows.Forms.ComboBox();
            this.cmbBD = new System.Windows.Forms.ComboBox();
            this.lblBD = new System.Windows.Forms.Label();
            this.lblTabla = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 215);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(681, 293);
            this.dgvDatos.TabIndex = 1;
            // 
            // cmbTablas
            // 
            this.cmbTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTablas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Location = new System.Drawing.Point(12, 152);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(329, 23);
            this.cmbTablas.TabIndex = 2;
            this.cmbTablas.SelectedIndexChanged += new System.EventHandler(this.cmbTablas_SelectedIndexChanged);
            // 
            // cmbBD
            // 
            this.cmbBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBD.FormattingEnabled = true;
            this.cmbBD.Location = new System.Drawing.Point(12, 53);
            this.cmbBD.Name = "cmbBD";
            this.cmbBD.Size = new System.Drawing.Size(329, 23);
            this.cmbBD.TabIndex = 3;
            this.cmbBD.SelectedIndexChanged += new System.EventHandler(this.cmbBD_SelectedIndexChanged);
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBD.Location = new System.Drawing.Point(12, 37);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(230, 16);
            this.lblBD.TabIndex = 4;
            this.lblBD.Text = "Elija una Base de Datos para Mostrar";
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabla.Location = new System.Drawing.Point(12, 133);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(176, 16);
            this.lblTabla.TabIndex = 5;
            this.lblTabla.Text = "Elija una Tabla para Mostrar";
            // 
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(708, 520);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.lblBD);
            this.Controls.Add(this.cmbBD);
            this.Controls.Add(this.cmbTablas);
            this.Controls.Add(this.dgvDatos);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ComboBox cmbTablas;
        private System.Windows.Forms.ComboBox cmbBD;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.Label lblTabla;
    }
}

