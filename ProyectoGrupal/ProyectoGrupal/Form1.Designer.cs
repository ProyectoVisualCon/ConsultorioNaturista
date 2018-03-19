namespace ProyectoGrupal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnc = new System.Windows.Forms.Button();
            this.btnp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 661);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnc
            // 
            this.btnc.Font = new System.Drawing.Font("Engravers MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnc.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnc.Image = ((System.Drawing.Image)(resources.GetObject("btnc.Image")));
            this.btnc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnc.Location = new System.Drawing.Point(159, 229);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(120, 80);
            this.btnc.TabIndex = 1;
            this.btnc.Text = "Consulta";
            this.btnc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnp
            // 
            this.btnp.Font = new System.Drawing.Font("Engravers MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnp.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnp.Image = ((System.Drawing.Image)(resources.GetObject("btnp.Image")));
            this.btnp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnp.Location = new System.Drawing.Point(386, 229);
            this.btnp.Name = "btnp";
            this.btnp.Size = new System.Drawing.Size(120, 80);
            this.btnp.TabIndex = 2;
            this.btnp.Text = "Pacientes";
            this.btnp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnp.UseVisualStyleBackColor = true;
            this.btnp.Click += new System.EventHandler(this.btnp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(107, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consultorio Naturista!";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnp);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultorio Naturista";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnp;
        private System.Windows.Forms.Label label1;
    }
}

