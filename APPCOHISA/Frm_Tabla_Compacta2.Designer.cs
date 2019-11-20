namespace APPCOHISA
{
    partial class Frm_Tabla_Compacta2
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
            this.PanelTab = new System.Windows.Forms.Panel();
            this.tabla2 = new System.Windows.Forms.DataGridView();
            this.tabla1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.PanelTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTab
            // 
            this.PanelTab.Controls.Add(this.BtnCerrar);
            this.PanelTab.Controls.Add(this.tabla2);
            this.PanelTab.Controls.Add(this.tabla1);
            this.PanelTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTab.Location = new System.Drawing.Point(0, 0);
            this.PanelTab.Name = "PanelTab";
            this.PanelTab.Size = new System.Drawing.Size(890, 484);
            this.PanelTab.TabIndex = 1;
            // 
            // tabla2
            // 
            this.tabla2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla2.Location = new System.Drawing.Point(450, 12);
            this.tabla2.Name = "tabla2";
            this.tabla2.Size = new System.Drawing.Size(432, 460);
            this.tabla2.TabIndex = 1;
            // 
            // tabla1
            // 
            this.tabla1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla1.Location = new System.Drawing.Point(9, 12);
            this.tabla1.Name = "tabla1";
            this.tabla1.Size = new System.Drawing.Size(432, 460);
            this.tabla1.TabIndex = 0;
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
            this.BtnCerrar.Location = new System.Drawing.Point(3, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.TabIndex = 18;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // Frm_Tabla_Compacta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(890, 484);
            this.Controls.Add(this.PanelTab);
            this.Name = "Frm_Tabla_Compacta2";
            this.Text = "Compacta2";
            this.Load += new System.EventHandler(this.Frm_Tabla_Compacta2_Load);
            this.PanelTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTab;
        private System.Windows.Forms.DataGridView tabla2;
        private System.Windows.Forms.DataGridView tabla1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnCerrar;
    }
}