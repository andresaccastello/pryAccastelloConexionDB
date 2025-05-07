namespace pryAccastelloConexionDB
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.grbLogin = new System.Windows.Forms.GroupBox();
            this.lblLoginCon = new System.Windows.Forms.Label();
            this.lblLoginNom = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(90, 36);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(90, 64);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnIngresar.Location = new System.Drawing.Point(22, 103);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(201, 36);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // grbLogin
            // 
            this.grbLogin.BackColor = System.Drawing.Color.Khaki;
            this.grbLogin.Controls.Add(this.button1);
            this.grbLogin.Controls.Add(this.lblLoginCon);
            this.grbLogin.Controls.Add(this.lblLoginNom);
            this.grbLogin.Controls.Add(this.txtContraseña);
            this.grbLogin.Controls.Add(this.btnIngresar);
            this.grbLogin.Controls.Add(this.txtUsuario);
            this.grbLogin.Location = new System.Drawing.Point(264, 89);
            this.grbLogin.Name = "grbLogin";
            this.grbLogin.Size = new System.Drawing.Size(250, 156);
            this.grbLogin.TabIndex = 3;
            this.grbLogin.TabStop = false;
            this.grbLogin.Text = "LOGUEARSE";
            // 
            // lblLoginCon
            // 
            this.lblLoginCon.AutoSize = true;
            this.lblLoginCon.Location = new System.Drawing.Point(7, 71);
            this.lblLoginCon.Name = "lblLoginCon";
            this.lblLoginCon.Size = new System.Drawing.Size(61, 13);
            this.lblLoginCon.TabIndex = 4;
            this.lblLoginCon.Text = "Contraseña";
            // 
            // lblLoginNom
            // 
            this.lblLoginNom.AutoSize = true;
            this.lblLoginNom.Location = new System.Drawing.Point(7, 43);
            this.lblLoginNom.Name = "lblLoginNom";
            this.lblLoginNom.Size = new System.Drawing.Size(44, 13);
            this.lblLoginNom.TabIndex = 3;
            this.lblLoginNom.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(210, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 41);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbLogin);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.grbLogin.ResumeLayout(false);
            this.grbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.GroupBox grbLogin;
        private System.Windows.Forms.Label lblLoginCon;
        private System.Windows.Forms.Label lblLoginNom;
        private System.Windows.Forms.Button button1;
    }
}