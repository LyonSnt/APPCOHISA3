namespace APPCOHISA
{
    partial class Frm_Verificacion
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
            this.panellogin = new System.Windows.Forms.GroupBox();
            this.btnverificar = new System.Windows.Forms.Button();
            this.txtverificar = new System.Windows.Forms.TextBox();
            this.PanelVerificacion = new System.Windows.Forms.Panel();
            this.panellogin.SuspendLayout();
            this.PanelVerificacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panellogin
            // 
            this.panellogin.Controls.Add(this.btnverificar);
            this.panellogin.Controls.Add(this.txtverificar);
            this.panellogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panellogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.panellogin.Location = new System.Drawing.Point(12, 12);
            this.panellogin.Name = "panellogin";
            this.panellogin.Size = new System.Drawing.Size(310, 165);
            this.panellogin.TabIndex = 1;
            this.panellogin.TabStop = false;
            this.panellogin.Text = "Ingrese Código";
            // 
            // btnverificar
            // 
            this.btnverificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnverificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverificar.Location = new System.Drawing.Point(47, 96);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(213, 34);
            this.btnverificar.TabIndex = 4;
            this.btnverificar.Text = "Verificar";
            this.btnverificar.UseVisualStyleBackColor = true;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // txtverificar
            // 
            this.txtverificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtverificar.Location = new System.Drawing.Point(47, 53);
            this.txtverificar.Name = "txtverificar";
            this.txtverificar.Size = new System.Drawing.Size(213, 26);
            this.txtverificar.TabIndex = 1;
            // 
            // PanelVerificacion
            // 
            this.PanelVerificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.PanelVerificacion.Controls.Add(this.panellogin);
            this.PanelVerificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelVerificacion.Location = new System.Drawing.Point(0, 0);
            this.PanelVerificacion.Name = "PanelVerificacion";
            this.PanelVerificacion.Size = new System.Drawing.Size(334, 189);
            this.PanelVerificacion.TabIndex = 2;
            // 
            // Frm_Verificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(334, 189);
            this.Controls.Add(this.PanelVerificacion);
            this.Name = "Frm_Verificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificacion";
            this.Load += new System.EventHandler(this.Verificacion_Load);
            this.panellogin.ResumeLayout(false);
            this.panellogin.PerformLayout();
            this.PanelVerificacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox panellogin;
        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.TextBox txtverificar;
        private System.Windows.Forms.Panel PanelVerificacion;
    }
}