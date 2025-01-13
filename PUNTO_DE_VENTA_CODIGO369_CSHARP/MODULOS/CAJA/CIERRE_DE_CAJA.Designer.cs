namespace PUNTO_DE_VENTA_CODIGO369_CSHARP.MODULOS.CAJA
{
    partial class CIERRE_DE_CAJA
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblSerialPc = new System.Windows.Forms.Label();
            this.txtidcaja = new System.Windows.Forms.Label();
            this.datalistado_caja = new System.Windows.Forms.DataGridView();
            this.txtfechacierre = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado_caja)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(957, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "CERRAR TURNO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSerialPc
            // 
            this.lblSerialPc.AutoSize = true;
            this.lblSerialPc.Location = new System.Drawing.Point(392, 240);
            this.lblSerialPc.Name = "lblSerialPc";
            this.lblSerialPc.Size = new System.Drawing.Size(44, 16);
            this.lblSerialPc.TabIndex = 5;
            this.lblSerialPc.Text = "label3";
            // 
            // txtidcaja
            // 
            this.txtidcaja.AutoSize = true;
            this.txtidcaja.Location = new System.Drawing.Point(392, 203);
            this.txtidcaja.Name = "txtidcaja";
            this.txtidcaja.Size = new System.Drawing.Size(44, 16);
            this.txtidcaja.TabIndex = 4;
            this.txtidcaja.Text = "label3";
            // 
            // datalistado_caja
            // 
            this.datalistado_caja.BackgroundColor = System.Drawing.Color.White;
            this.datalistado_caja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado_caja.Location = new System.Drawing.Point(107, 276);
            this.datalistado_caja.Name = "datalistado_caja";
            this.datalistado_caja.RowHeadersWidth = 51;
            this.datalistado_caja.RowTemplate.Height = 24;
            this.datalistado_caja.Size = new System.Drawing.Size(329, 56);
            this.datalistado_caja.TabIndex = 6;
            // 
            // txtfechacierre
            // 
            this.txtfechacierre.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtfechacierre.Location = new System.Drawing.Point(490, 72);
            this.txtfechacierre.Name = "txtfechacierre";
            this.txtfechacierre.Size = new System.Drawing.Size(279, 22);
            this.txtfechacierre.TabIndex = 7;
            // 
            // CIERRE_DE_CAJA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 715);
            this.Controls.Add(this.txtfechacierre);
            this.Controls.Add(this.datalistado_caja);
            this.Controls.Add(this.lblSerialPc);
            this.Controls.Add(this.txtidcaja);
            this.Controls.Add(this.button1);
            this.Name = "CIERRE_DE_CAJA";
            this.Text = "CIERRE_DE_CAJA";
            ((System.ComponentModel.ISupportInitialize)(this.datalistado_caja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSerialPc;
        private System.Windows.Forms.Label txtidcaja;
        private System.Windows.Forms.DataGridView datalistado_caja;
        private System.Windows.Forms.DateTimePicker txtfechacierre;
    }
}