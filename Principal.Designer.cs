namespace Encrypt
{
    partial class Principal
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
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtContenido = new System.Windows.Forms.RichTextBox();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.btnLimpiarContenido = new System.Windows.Forms.Button();
            this.lblIV = new System.Windows.Forms.Label();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.RichTextBox();
            this.txtCadenaEncriptada = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTarjetaDesencriptada = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(100)))), ((int)(((byte)(175)))));
            this.pnlBarraTitulo.Controls.Add(this.button1);
            this.pnlBarraTitulo.Controls.Add(this.button2);
            this.pnlBarraTitulo.Controls.Add(this.lblTitulo);
            this.pnlBarraTitulo.Controls.Add(this.btnMinimizar);
            this.pnlBarraTitulo.Controls.Add(this.btnCerrar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(782, 52);
            this.pnlBarraTitulo.TabIndex = 1;
            this.pnlBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseMove);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(683, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "_";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(730, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(331, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(122, 25);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Entregable 2";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimizar.Location = new System.Drawing.Point(941, 6);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(43, 38);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.Text = "_";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(988, 6);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(43, 38);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(73, 110);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(95, 16);
            this.lblKey.TabIndex = 4;
            this.lblKey.Text = "Encryption key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tarjeta de Crédito";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(76, 143);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(650, 22);
            this.txtKey.TabIndex = 8;
            this.txtKey.Text = "Tis0wosTbuEUQldRGhJJbQ1mmdqauOHLrMR0j/ZarwM=";
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(76, 283);
            this.txtContenido.MaxLength = 16;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(278, 34);
            this.txtContenido.TabIndex = 9;
            this.txtContenido.Text = "";
            this.txtContenido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContenido_KeyPress);
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEncriptar.FlatAppearance.BorderSize = 2;
            this.btnEncriptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEncriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncriptar.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncriptar.ForeColor = System.Drawing.Color.DimGray;
            this.btnEncriptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncriptar.Location = new System.Drawing.Point(141, 520);
            this.btnEncriptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(136, 48);
            this.btnEncriptar.TabIndex = 10;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDesencriptar.FlatAppearance.BorderSize = 2;
            this.btnDesencriptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDesencriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesencriptar.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesencriptar.ForeColor = System.Drawing.Color.DimGray;
            this.btnDesencriptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesencriptar.Location = new System.Drawing.Point(522, 520);
            this.btnDesencriptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(136, 48);
            this.btnDesencriptar.TabIndex = 11;
            this.btnDesencriptar.Text = "Desencriptar";
            this.btnDesencriptar.UseVisualStyleBackColor = true;
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // btnLimpiarContenido
            // 
            this.btnLimpiarContenido.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLimpiarContenido.FlatAppearance.BorderSize = 2;
            this.btnLimpiarContenido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpiarContenido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarContenido.Font = new System.Drawing.Font("Maiandra GD", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarContenido.ForeColor = System.Drawing.Color.DimGray;
            this.btnLimpiarContenido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarContenido.Location = new System.Drawing.Point(303, 607);
            this.btnLimpiarContenido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiarContenido.Name = "btnLimpiarContenido";
            this.btnLimpiarContenido.Size = new System.Drawing.Size(194, 48);
            this.btnLimpiarContenido.TabIndex = 12;
            this.btnLimpiarContenido.Text = "Limpiar Contenido";
            this.btnLimpiarContenido.UseVisualStyleBackColor = true;
            this.btnLimpiarContenido.Click += new System.EventHandler(this.btnLimpiarContenido_Click);
            // 
            // lblIV
            // 
            this.lblIV.AutoSize = true;
            this.lblIV.Location = new System.Drawing.Point(73, 184);
            this.lblIV.Name = "lblIV";
            this.lblIV.Size = new System.Drawing.Size(81, 16);
            this.lblIV.TabIndex = 13;
            this.lblIV.Text = "Encription IV";
            // 
            // txtIV
            // 
            this.txtIV.Location = new System.Drawing.Point(76, 212);
            this.txtIV.Name = "txtIV";
            this.txtIV.Size = new System.Drawing.Size(650, 22);
            this.txtIV.TabIndex = 14;
            this.txtIV.Text = "jI42F/YEvzL7WqSQyATlmw==";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cadena Encriptada";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(76, 374);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(278, 131);
            this.txtResultado.TabIndex = 17;
            this.txtResultado.Text = "";
            // 
            // txtCadenaEncriptada
            // 
            this.txtCadenaEncriptada.Location = new System.Drawing.Point(448, 283);
            this.txtCadenaEncriptada.Name = "txtCadenaEncriptada";
            this.txtCadenaEncriptada.Size = new System.Drawing.Size(278, 131);
            this.txtCadenaEncriptada.TabIndex = 21;
            this.txtCadenaEncriptada.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tarjeta de Crédito";
            // 
            // txtTarjetaDesencriptada
            // 
            this.txtTarjetaDesencriptada.Location = new System.Drawing.Point(448, 471);
            this.txtTarjetaDesencriptada.MaxLength = 16;
            this.txtTarjetaDesencriptada.Name = "txtTarjetaDesencriptada";
            this.txtTarjetaDesencriptada.Size = new System.Drawing.Size(278, 34);
            this.txtTarjetaDesencriptada.TabIndex = 19;
            this.txtTarjetaDesencriptada.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cadena Encriptada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 664);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Marcos Isai Reyes de la Cruz";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 689);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCadenaEncriptada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTarjetaDesencriptada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIV);
            this.Controls.Add(this.lblIV);
            this.Controls.Add(this.btnLimpiarContenido);
            this.Controls.Add(this.btnDesencriptar);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.pnlBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "frmPrincipal";
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.RichTextBox txtContenido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Button btnDesencriptar;
        private System.Windows.Forms.Button btnLimpiarContenido;
        private System.Windows.Forms.Label lblIV;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtResultado;
        private System.Windows.Forms.RichTextBox txtCadenaEncriptada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtTarjetaDesencriptada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

