namespace APPCOHISA
{
    partial class Frm_Registro
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
            this.btnguardarr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcorreor = new System.Windows.Forms.TextBox();
            this.txtpasswordr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtconfpasswordr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkr = new System.Windows.Forms.LinkLabel();
            this.PanelRegistro = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.PanelRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnguardarr
            // 
            this.btnguardarr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnguardarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarr.Location = new System.Drawing.Point(192, 151);
            this.btnguardarr.Name = "btnguardarr";
            this.btnguardarr.Size = new System.Drawing.Size(225, 31);
            this.btnguardarr.TabIndex = 0;
            this.btnguardarr.Text = "Guardar";
            this.btnguardarr.UseVisualStyleBackColor = true;
            this.btnguardarr.Click += new System.EventHandler(this.btnguardarr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correo:";
            // 
            // txtcorreor
            // 
            this.txtcorreor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreor.Location = new System.Drawing.Point(190, 34);
            this.txtcorreor.Name = "txtcorreor";
            this.txtcorreor.Size = new System.Drawing.Size(227, 26);
            this.txtcorreor.TabIndex = 2;
            // 
            // txtpasswordr
            // 
            this.txtpasswordr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpasswordr.Location = new System.Drawing.Point(190, 69);
            this.txtpasswordr.Name = "txtpasswordr";
            this.txtpasswordr.Size = new System.Drawing.Size(227, 26);
            this.txtpasswordr.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // txtconfpasswordr
            // 
            this.txtconfpasswordr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfpasswordr.Location = new System.Drawing.Point(192, 104);
            this.txtconfpasswordr.Name = "txtconfpasswordr";
            this.txtconfpasswordr.Size = new System.Drawing.Size(225, 26);
            this.txtconfpasswordr.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirmar Contraseña:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtconfpasswordr);
            this.groupBox1.Controls.Add(this.btnguardarr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcorreor);
            this.groupBox1.Controls.Add(this.txtpasswordr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 235);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrarse";
            // 
            // linkr
            // 
            this.linkr.AutoSize = true;
            this.linkr.LinkColor = System.Drawing.Color.Blue;
            this.linkr.Location = new System.Drawing.Point(280, 194);
            this.linkr.Name = "linkr";
            this.linkr.Size = new System.Drawing.Size(137, 24);
            this.linkr.TabIndex = 7;
            this.linkr.TabStop = true;
            this.linkr.Text = "Iniciar Sesión..!";
            this.linkr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkr_LinkClicked);
            // 
            // PanelRegistro
            // 
            this.PanelRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.PanelRegistro.Controls.Add(this.groupBox1);
            this.PanelRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRegistro.Location = new System.Drawing.Point(0, 0);
            this.PanelRegistro.Name = "PanelRegistro";
            this.PanelRegistro.Size = new System.Drawing.Size(449, 259);
            this.PanelRegistro.TabIndex = 8;
            // 
            // Frm_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(449, 259);
            this.Controls.Add(this.PanelRegistro);
            this.Name = "Frm_Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Frm_Registro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelRegistro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnguardarr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcorreor;
        private System.Windows.Forms.TextBox txtpasswordr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtconfpasswordr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkr;
        private System.Windows.Forms.Panel PanelRegistro;
    }
}