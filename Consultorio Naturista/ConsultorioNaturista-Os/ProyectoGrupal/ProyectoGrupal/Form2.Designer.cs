namespace ProyectoGrupal
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbtnn = new System.Windows.Forms.RadioButton();
            this.rbtnFec = new System.Windows.Forms.RadioButton();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.picbus = new System.Windows.Forms.PictureBox();
            this.regresar = new System.Windows.Forms.PictureBox();
            this.datBus = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCos = new System.Windows.Forms.TextBox();
            this.picAgendar = new System.Windows.Forms.PictureBox();
            this.min = new System.Windows.Forms.NumericUpDown();
            this.hour = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAp = new System.Windows.Forms.TextBox();
            this.txtAm = new System.Windows.Forms.TextBox();
            this.txtAnom = new System.Windows.Forms.TextBox();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fac = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picDate = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datBus)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAgendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.fac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 631);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rbtnn
            // 
            this.rbtnn.AutoSize = true;
            this.rbtnn.Font = new System.Drawing.Font("Engravers MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnn.Location = new System.Drawing.Point(24, 29);
            this.rbtnn.Name = "rbtnn";
            this.rbtnn.Size = new System.Drawing.Size(179, 23);
            this.rbtnn.TabIndex = 1;
            this.rbtnn.Text = "Por Nombre";
            this.rbtnn.UseVisualStyleBackColor = true;
            this.rbtnn.CheckedChanged += new System.EventHandler(this.rbtnn_CheckedChanged);
            // 
            // rbtnFec
            // 
            this.rbtnFec.AutoSize = true;
            this.rbtnFec.Font = new System.Drawing.Font("Engravers MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFec.Location = new System.Drawing.Point(351, 38);
            this.rbtnFec.Name = "rbtnFec";
            this.rbtnFec.Size = new System.Drawing.Size(156, 23);
            this.rbtnFec.TabIndex = 2;
            this.rbtnFec.Text = "Por Fecha";
            this.rbtnFec.UseVisualStyleBackColor = true;
            this.rbtnFec.CheckedChanged += new System.EventHandler(this.rbtnFec_CheckedChanged);
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(160, 84);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(213, 24);
            this.txtNom.TabIndex = 3;
            this.txtNom.Visible = false;
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(160, 73);
            this.calendario.MaxSelectionCount = 1;
            this.calendario.MinDate = new System.DateTime(2018, 1, 25, 0, 0, 0, 0);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 4;
            this.calendario.Visible = false;
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateSelected);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.fac);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 663);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.picbus);
            this.tabPage1.Controls.Add(this.regresar);
            this.tabPage1.Controls.Add(this.datBus);
            this.tabPage1.Controls.Add(this.rbtnn);
            this.tabPage1.Controls.Add(this.rbtnFec);
            this.tabPage1.Controls.Add(this.txtNom);
            this.tabPage1.Controls.Add(this.calendario);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 637);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buscar Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // picbus
            // 
            this.picbus.Image = ((System.Drawing.Image)(resources.GetObject("picbus.Image")));
            this.picbus.Location = new System.Drawing.Point(479, 495);
            this.picbus.Name = "picbus";
            this.picbus.Size = new System.Drawing.Size(100, 50);
            this.picbus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbus.TabIndex = 22;
            this.picbus.TabStop = false;
            this.picbus.Click += new System.EventHandler(this.picbus_Click);
            // 
            // regresar
            // 
            this.regresar.Image = ((System.Drawing.Image)(resources.GetObject("regresar.Image")));
            this.regresar.Location = new System.Drawing.Point(103, 495);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(100, 50);
            this.regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.regresar.TabIndex = 21;
            this.regresar.TabStop = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // datBus
            // 
            this.datBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datBus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Fecha,
            this.hora});
            this.datBus.Location = new System.Drawing.Point(6, 247);
            this.datBus.Name = "datBus";
            this.datBus.Size = new System.Drawing.Size(659, 197);
            this.datBus.TabIndex = 19;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha.HeaderText = "fecha";
            this.Fecha.Name = "Fecha";
            // 
            // hora
            // 
            this.hora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtCos);
            this.tabPage2.Controls.Add(this.picAgendar);
            this.tabPage2.Controls.Add(this.min);
            this.tabPage2.Controls.Add(this.hour);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtAp);
            this.tabPage2.Controls.Add(this.txtAm);
            this.tabPage2.Controls.Add(this.txtAnom);
            this.tabPage2.Controls.Add(this.Calendar);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 637);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Añadir Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(249, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "Precio";
            // 
            // txtCos
            // 
            this.txtCos.BackColor = System.Drawing.Color.White;
            this.txtCos.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCos.Location = new System.Drawing.Point(336, 224);
            this.txtCos.Name = "txtCos";
            this.txtCos.Size = new System.Drawing.Size(78, 25);
            this.txtCos.TabIndex = 39;
            // 
            // picAgendar
            // 
            this.picAgendar.BackColor = System.Drawing.Color.Transparent;
            this.picAgendar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAgendar.Image = ((System.Drawing.Image)(resources.GetObject("picAgendar.Image")));
            this.picAgendar.Location = new System.Drawing.Point(278, 496);
            this.picAgendar.Name = "picAgendar";
            this.picAgendar.Size = new System.Drawing.Size(68, 69);
            this.picAgendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAgendar.TabIndex = 38;
            this.picAgendar.TabStop = false;
            this.picAgendar.Click += new System.EventHandler(this.picAgendar_Click);
            // 
            // min
            // 
            this.min.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.Location = new System.Drawing.Point(178, 227);
            this.min.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(48, 25);
            this.min.TabIndex = 37;
            this.min.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // hour
            // 
            this.hour.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour.Location = new System.Drawing.Point(124, 226);
            this.hour.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.hour.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(48, 25);
            this.hour.TabIndex = 36;
            this.hour.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 33);
            this.label4.TabIndex = 34;
            this.label4.Text = "Datos del paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(42, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(441, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "A. Materno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "A. Paterno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nombre";
            // 
            // txtAp
            // 
            this.txtAp.BackColor = System.Drawing.Color.White;
            this.txtAp.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAp.Location = new System.Drawing.Point(211, 156);
            this.txtAp.Name = "txtAp";
            this.txtAp.Size = new System.Drawing.Size(185, 25);
            this.txtAp.TabIndex = 26;
            // 
            // txtAm
            // 
            this.txtAm.BackColor = System.Drawing.Color.White;
            this.txtAm.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAm.Location = new System.Drawing.Point(437, 156);
            this.txtAm.Name = "txtAm";
            this.txtAm.Size = new System.Drawing.Size(161, 25);
            this.txtAm.TabIndex = 27;
            // 
            // txtAnom
            // 
            this.txtAnom.BackColor = System.Drawing.Color.White;
            this.txtAnom.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnom.Location = new System.Drawing.Point(23, 156);
            this.txtAnom.Name = "txtAnom";
            this.txtAnom.Size = new System.Drawing.Size(149, 25);
            this.txtAnom.TabIndex = 25;
            // 
            // Calendar
            // 
            this.Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.Location = new System.Drawing.Point(242, 292);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(670, 631);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // fac
            // 
            this.fac.Controls.Add(this.panel1);
            this.fac.Controls.Add(this.label8);
            this.fac.Controls.Add(this.pictureBox4);
            this.fac.Controls.Add(this.label2);
            this.fac.Controls.Add(this.picDate);
            this.fac.Controls.Add(this.pictureBox3);
            this.fac.Location = new System.Drawing.Point(4, 22);
            this.fac.Name = "fac";
            this.fac.Size = new System.Drawing.Size(676, 637);
            this.fac.TabIndex = 2;
            this.fac.Text = "Facturar";
            this.fac.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(494, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 21);
            this.label8.TabIndex = 33;
            this.label8.Text = "Generar PDF";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(489, 495);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(120, 87);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(256, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Comprobar datos";
            // 
            // picDate
            // 
            this.picDate.Image = ((System.Drawing.Image)(resources.GetObject("picDate.Image")));
            this.picDate.Location = new System.Drawing.Point(251, 123);
            this.picDate.Name = "picDate";
            this.picDate.Size = new System.Drawing.Size(143, 95);
            this.picDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDate.TabIndex = 2;
            this.picDate.TabStop = false;
            this.picDate.Click += new System.EventHandler(this.picDate_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(676, 637);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(222, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 34;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datBus)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAgendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.fac.ResumeLayout(false);
            this.fac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbtnn;
        private System.Windows.Forms.RadioButton rbtnFec;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datBus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAp;
        private System.Windows.Forms.TextBox txtAm;
        private System.Windows.Forms.TextBox txtAnom;
        private System.Windows.Forms.TabPage fac;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picAgendar;
        private System.Windows.Forms.NumericUpDown min;
        private System.Windows.Forms.NumericUpDown hour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox regresar;
        private System.Windows.Forms.PictureBox picbus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
    }
}