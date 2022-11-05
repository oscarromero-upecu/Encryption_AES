namespace Encryption_AES
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.encriptartxt = new System.Windows.Forms.TextBox();
            this.desencriptartxt = new System.Windows.Forms.TextBox();
            this.encriptar = new System.Windows.Forms.Button();
            this.desencriptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.salida = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.keysize = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un texto :";
            // 
            // encriptartxt
            // 
            this.encriptartxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encriptartxt.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encriptartxt.Location = new System.Drawing.Point(214, 54);
            this.encriptartxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.encriptartxt.Multiline = true;
            this.encriptartxt.Name = "encriptartxt";
            this.encriptartxt.Size = new System.Drawing.Size(274, 32);
            this.encriptartxt.TabIndex = 1;
            this.encriptartxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // desencriptartxt
            // 
            this.desencriptartxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.desencriptartxt.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desencriptartxt.ForeColor = System.Drawing.Color.Green;
            this.desencriptartxt.Location = new System.Drawing.Point(214, 172);
            this.desencriptartxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.desencriptartxt.Multiline = true;
            this.desencriptartxt.Name = "desencriptartxt";
            this.desencriptartxt.Size = new System.Drawing.Size(274, 34);
            this.desencriptartxt.TabIndex = 2;
            this.desencriptartxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // encriptar
            // 
            this.encriptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.encriptar.Location = new System.Drawing.Point(496, 54);
            this.encriptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.encriptar.Name = "encriptar";
            this.encriptar.Size = new System.Drawing.Size(105, 32);
            this.encriptar.TabIndex = 3;
            this.encriptar.Text = "ENCRIPTAR";
            this.encriptar.UseVisualStyleBackColor = true;
            this.encriptar.Click += new System.EventHandler(this.encriptar_Click);
            // 
            // desencriptar
            // 
            this.desencriptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.desencriptar.Location = new System.Drawing.Point(496, 172);
            this.desencriptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.desencriptar.Name = "desencriptar";
            this.desencriptar.Size = new System.Drawing.Size(127, 34);
            this.desencriptar.TabIndex = 4;
            this.desencriptar.Text = "DESENCRIPTAR";
            this.desencriptar.UseVisualStyleBackColor = true;
            this.desencriptar.Click += new System.EventHandler(this.desencriptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salida cifrada AES";
            // 
            // salida
            // 
            this.salida.ForeColor = System.Drawing.Color.Red;
            this.salida.Location = new System.Drawing.Point(643, 228);
            this.salida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(88, 37);
            this.salida.TabIndex = 6;
            this.salida.Text = "EXIT";
            this.salida.UseVisualStyleBackColor = true;
            this.salida.Click += new System.EventHandler(this.salida_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Key Size in Bits";
            // 
            // keysize
            // 
            this.keysize.AccessibleDescription = "Seleccione los bits";
            this.keysize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keysize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keysize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.keysize.FormattingEnabled = true;
            this.keysize.Items.AddRange(new object[] {
            "128",
            "256"});
            this.keysize.Location = new System.Drawing.Point(312, 115);
            this.keysize.MaxDropDownItems = 2;
            this.keysize.MaxLength = 2;
            this.keysize.Name = "keysize";
            this.keysize.Size = new System.Drawing.Size(80, 29);
            this.keysize.TabIndex = 9;
            this.keysize.SelectedIndexChanged += new System.EventHandler(this.keysize_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(731, 264);
            this.Controls.Add(this.keysize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.desencriptar);
            this.Controls.Add(this.encriptar);
            this.Controls.Add(this.desencriptartxt);
            this.Controls.Add(this.encriptartxt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "AES Crypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox encriptartxt;
        private System.Windows.Forms.TextBox desencriptartxt;
        private System.Windows.Forms.Button encriptar;
        private System.Windows.Forms.Button desencriptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button salida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox keysize;
    }
}

