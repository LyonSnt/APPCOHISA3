namespace APPCOHISA
{
    partial class Frm_Load_TDS
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
            this.TablaTDS = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.PanelTDS = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TablaTDS)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaTDS
            // 
            this.TablaTDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaTDS.Location = new System.Drawing.Point(12, 103);
            this.TablaTDS.Name = "TablaTDS";
            this.TablaTDS.Size = new System.Drawing.Size(776, 335);
            this.TablaTDS.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.DarkRed;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnCerrar.Location = new System.Drawing.Point(1, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.TabIndex = 17;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // PanelTDS
            // 
            this.PanelTDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTDS.Location = new System.Drawing.Point(0, 0);
            this.PanelTDS.Name = "PanelTDS";
            this.PanelTDS.Size = new System.Drawing.Size(800, 450);
            this.PanelTDS.TabIndex = 18;
            // 
            // Frm_Load_TDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.TablaTDS);
            this.Controls.Add(this.PanelTDS);
            this.Name = "Frm_Load_TDS";
            this.Text = "TDS";
            this.Load += new System.EventHandler(this.Frm_Load_TDS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaTDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaTDS;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel PanelTDS;
    }
}