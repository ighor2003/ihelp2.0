namespace ihelp
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.btnFechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.listBoxCliente = new System.Windows.Forms.ListBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtSenhaCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtNameCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Black;
            this.btnFechar.Location = new System.Drawing.Point(938, 633);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(116, 30);
            this.btnFechar.TabIndex = 33;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(174, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(292, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 33);
            this.label1.TabIndex = 31;
            this.label1.Text = "Clientes";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(516, 531);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(538, 30);
            this.btnLimpar.TabIndex = 30;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // listBoxCliente
            // 
            this.listBoxCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCliente.FormattingEnabled = true;
            this.listBoxCliente.ItemHeight = 21;
            this.listBoxCliente.Location = new System.Drawing.Point(516, 206);
            this.listBoxCliente.Name = "listBoxCliente";
            this.listBoxCliente.Size = new System.Drawing.Size(538, 319);
            this.listBoxCliente.TabIndex = 29;
            this.listBoxCliente.SelectedIndexChanged += new System.EventHandler(this.listBoxCliente_SelectedIndexChanged_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(88, 466);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(344, 30);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.Location = new System.Drawing.Point(88, 419);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(344, 30);
            this.btnConsultar.TabIndex = 27;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtId.Location = new System.Drawing.Point(393, 286);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(39, 26);
            this.txtId.TabIndex = 26;
            this.txtId.Text = "Id";
            // 
            // txtSenhaCliente
            // 
            this.txtSenhaCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSenhaCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenhaCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCliente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSenhaCliente.Location = new System.Drawing.Point(88, 375);
            this.txtSenhaCliente.Name = "txtSenhaCliente";
            this.txtSenhaCliente.Size = new System.Drawing.Size(344, 26);
            this.txtSenhaCliente.TabIndex = 25;
            this.txtSenhaCliente.Text = "Senha";
            this.txtSenhaCliente.UseSystemPasswordChar = true;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtEmailCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtEmailCliente.Location = new System.Drawing.Point(88, 330);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(344, 26);
            this.txtEmailCliente.TabIndex = 24;
            this.txtEmailCliente.Text = "Email";
            // 
            // txtNameCliente
            // 
            this.txtNameCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtNameCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCliente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNameCliente.Location = new System.Drawing.Point(88, 286);
            this.txtNameCliente.Name = "txtNameCliente";
            this.txtNameCliente.Size = new System.Drawing.Size(289, 26);
            this.txtNameCliente.TabIndex = 23;
            this.txtNameCliente.Text = "Nome";
            this.txtNameCliente.TextChanged += new System.EventHandler(this.txtNameCliente_TextChanged_1);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1090, 699);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.listBoxCliente);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtSenhaCliente);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.txtNameCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListBox listBoxCliente;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSenhaCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.TextBox txtNameCliente;
    }
}