namespace APPCOHISA
{
    partial class Frm_Movimientos
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
            this.PanelMovimientos = new System.Windows.Forms.Panel();
            this.BtnMovimiento = new System.Windows.Forms.Button();
            this.Tablamovimiento = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PanelMovimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tablamovimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMovimientos
            // 
            this.PanelMovimientos.Controls.Add(this.richTextBox1);
            this.PanelMovimientos.Controls.Add(this.button1);
            this.PanelMovimientos.Controls.Add(this.BtnMovimiento);
            this.PanelMovimientos.Controls.Add(this.Tablamovimiento);
            this.PanelMovimientos.Controls.Add(this.BtnCerrar);
            this.PanelMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMovimientos.Location = new System.Drawing.Point(0, 0);
            this.PanelMovimientos.Name = "PanelMovimientos";
            this.PanelMovimientos.Size = new System.Drawing.Size(800, 450);
            this.PanelMovimientos.TabIndex = 0;
            // 
            // BtnMovimiento
            // 
            this.BtnMovimiento.Location = new System.Drawing.Point(357, 40);
            this.BtnMovimiento.Name = "BtnMovimiento";
            this.BtnMovimiento.Size = new System.Drawing.Size(75, 23);
            this.BtnMovimiento.TabIndex = 19;
            this.BtnMovimiento.Text = "Movimiento";
            this.BtnMovimiento.UseVisualStyleBackColor = true;
            this.BtnMovimiento.Click += new System.EventHandler(this.BtnMovimiento_Click);
            // 
            // Tablamovimiento
            // 
            this.Tablamovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tablamovimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.Tablamovimiento.Location = new System.Drawing.Point(12, 40);
            this.Tablamovimiento.Name = "Tablamovimiento";
            this.Tablamovimiento.Size = new System.Drawing.Size(339, 398);
            this.Tablamovimiento.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Estado";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Leyendo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nueva Entrada";
            this.Column3.Name = "Column3";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.DarkRed;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.LightGray;
            this.BtnCerrar.Location = new System.Drawing.Point(0, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.TabIndex = 17;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(390, 146);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // Frm_Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelMovimientos);
            this.Name = "Frm_Movimientos";
            this.Text = "Movimientos";
            this.Load += new System.EventHandler(this.Frm_Movimientos_Load);
            this.PanelMovimientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tablamovimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMovimientos;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridView Tablamovimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button BtnMovimiento;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RichTextBox richTextBox1;
    }
}