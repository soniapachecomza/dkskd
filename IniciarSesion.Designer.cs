namespace proyecto303
{
    partial class IniciarSesion
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
            this.lblsesion = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblcontrasenia = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcontrasenia = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsesion
            // 
            this.lblsesion.AutoSize = true;
            this.lblsesion.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsesion.Location = new System.Drawing.Point(318, 101);
            this.lblsesion.Name = "lblsesion";
            this.lblsesion.Size = new System.Drawing.Size(175, 31);
            this.lblsesion.TabIndex = 0;
            this.lblsesion.Text = "Iniciar Sesión";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(219, 173);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(48, 19);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "E-mail";
            // 
            // lblcontrasenia
            // 
            this.lblcontrasenia.AutoSize = true;
            this.lblcontrasenia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontrasenia.Location = new System.Drawing.Point(189, 211);
            this.lblcontrasenia.Name = "lblcontrasenia";
            this.lblcontrasenia.Size = new System.Drawing.Size(78, 19);
            this.lblcontrasenia.TabIndex = 2;
            this.lblcontrasenia.Text = "Contraseña";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(298, 174);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(200, 26);
            this.txtemail.TabIndex = 3;
            // 
            // txtcontrasenia
            // 
            this.txtcontrasenia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontrasenia.Location = new System.Drawing.Point(298, 224);
            this.txtcontrasenia.Name = "txtcontrasenia";
            this.txtcontrasenia.Size = new System.Drawing.Size(200, 26);
            this.txtcontrasenia.TabIndex = 4;
            this.txtcontrasenia.TextChanged += new System.EventHandler(this.txtcontrasenia_TextChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(348, 278);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Iniciar ";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pbPassword
            // 
            this.pbPassword.Image = global::proyecto303.Properties.Resources.Eye;
            this.pbPassword.Location = new System.Drawing.Point(514, 224);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(78, 37);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPassword.TabIndex = 6;
            this.pbPassword.TabStop = false;
            this.pbPassword.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtcontrasenia);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblcontrasenia);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblsesion);
            this.Name = "IniciarSesion";
            this.Text = "IniciarSeccion";
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsesion;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblcontrasenia;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcontrasenia;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.PictureBox pbPassword;
    }
}