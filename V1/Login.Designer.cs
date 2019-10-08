namespace TELEPRO
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TXT_USER = new System.Windows.Forms.TextBox();
            this.TXT_PASS = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rp1 = new TELEPRO.RP();
            ((System.ComponentModel.ISupportInitialize)(this.rp1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_USER
            // 
            this.TXT_USER.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_USER.ForeColor = System.Drawing.Color.DimGray;
            this.TXT_USER.Location = new System.Drawing.Point(40, 409);
            this.TXT_USER.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_USER.Multiline = true;
            this.TXT_USER.Name = "TXT_USER";
            this.TXT_USER.Size = new System.Drawing.Size(396, 54);
            this.TXT_USER.TabIndex = 0;
            this.TXT_USER.TabStop = false;
            this.TXT_USER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_USER.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TXT_USER_MouseClick);
            this.TXT_USER.TextChanged += new System.EventHandler(this.TXT_USER_TextChanged);
            this.TXT_USER.DragLeave += new System.EventHandler(this.TXT_USER_DragLeave);
            this.TXT_USER.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_USER_KeyPress);
            this.TXT_USER.Leave += new System.EventHandler(this.TXT_USER_Leave);
            this.TXT_USER.MouseLeave += new System.EventHandler(this.TXT_USER_MouseLeave);
            this.TXT_USER.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TXT_USER_MouseMove);
            // 
            // TXT_PASS
            // 
            this.TXT_PASS.ForeColor = System.Drawing.Color.DimGray;
            this.TXT_PASS.Location = new System.Drawing.Point(40, 507);
            this.TXT_PASS.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_PASS.Multiline = true;
            this.TXT_PASS.Name = "TXT_PASS";
            this.TXT_PASS.Size = new System.Drawing.Size(396, 54);
            this.TXT_PASS.TabIndex = 1;
            this.TXT_PASS.TabStop = false;
            this.TXT_PASS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_PASS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TXT_PASS_MouseClick);
            this.TXT_PASS.DragLeave += new System.EventHandler(this.TXT_PASS_DragLeave);
            this.TXT_PASS.Leave += new System.EventHandler(this.TXT_PASS_Leave);
            this.TXT_PASS.MouseLeave += new System.EventHandler(this.TXT_PASS_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(101, 615);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Iniciar Sesion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(147, 577);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "?Necesitas ayuda¿";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(467, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 33);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rp1
            // 
            this.rp1.Image = ((System.Drawing.Image)(resources.GetObject("rp1.Image")));
            this.rp1.Location = new System.Drawing.Point(40, 41);
            this.rp1.Margin = new System.Windows.Forms.Padding(4);
            this.rp1.Name = "rp1";
            this.rp1.Size = new System.Drawing.Size(396, 325);
            this.rp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rp1.TabIndex = 3;
            this.rp1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(502, 679);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rp1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TXT_PASS);
            this.Controls.Add(this.TXT_USER);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rp1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TXT_USER;
        public System.Windows.Forms.TextBox TXT_PASS;
        private System.Windows.Forms.Button button1;
        private RP rp1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

