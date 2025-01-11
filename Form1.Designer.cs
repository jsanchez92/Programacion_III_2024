namespace IntroClase_POO
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            DtTeachers = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            DtStudents = new DataGridView();
            BtnAddRow = new Button();
            BtnDeleteRow = new Button();
            button1 = new Button();
            button2 = new Button();
            TxtId = new TextBox();
            label3 = new Label();
            label4 = new Label();
            TxtNombres = new TextBox();
            label5 = new Label();
            TxtApellidos = new TextBox();
            label6 = new Label();
            TxtSexo = new TextBox();
            label7 = new Label();
            TxtDni = new TextBox();
            label8 = new Label();
            TxtCarnet = new TextBox();
            label9 = new Label();
            TxtNacimiento = new DateTimePicker();
            TNacimiento = new DateTimePicker();
            label10 = new Label();
            TDni = new TextBox();
            label11 = new Label();
            TProfesion = new TextBox();
            label12 = new Label();
            label13 = new Label();
            TSexo = new TextBox();
            label14 = new Label();
            TApellido = new TextBox();
            label15 = new Label();
            TNombre = new TextBox();
            label16 = new Label();
            textBox6 = new TextBox();
            BtnDelMaestro = new Button();
            BtnAddMaestro = new Button();
            label17 = new Label();
            TSalario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DtTeachers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtStudents).BeginInit();
            SuspendLayout();
            // 
            // DtTeachers
            // 
            DtTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtTeachers.Location = new Point(130, 371);
            DtTeachers.Name = "DtTeachers";
            DtTeachers.RowHeadersWidth = 102;
            DtTeachers.Size = new Size(2246, 227);
            DtTeachers.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(117, 92);
            label1.Name = "label1";
            label1.Size = new Size(185, 54);
            label1.TabIndex = 1;
            label1.Text = "Teachers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(130, 647);
            label2.Name = "label2";
            label2.Size = new Size(189, 54);
            label2.TabIndex = 3;
            label2.Text = "Students";
            // 
            // DtStudents
            // 
            DtStudents.AllowUserToAddRows = false;
            DtStudents.AllowUserToDeleteRows = false;
            DtStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtStudents.Location = new Point(130, 951);
            DtStudents.Name = "DtStudents";
            DtStudents.ReadOnly = true;
            DtStudents.RowHeadersWidth = 102;
            DtStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtStudents.Size = new Size(2246, 303);
            DtStudents.TabIndex = 2;
            DtStudents.CellValueChanged += DtStudents_CellValueChanged;
            DtStudents.DoubleClick += DtStudents_DoubleClick;
            // 
            // BtnAddRow
            // 
            BtnAddRow.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnAddRow.Location = new Point(2234, 615);
            BtnAddRow.Name = "BtnAddRow";
            BtnAddRow.Size = new Size(68, 58);
            BtnAddRow.TabIndex = 4;
            BtnAddRow.Text = "+";
            BtnAddRow.UseVisualStyleBackColor = true;
            BtnAddRow.Click += BtnAddRow_Click;
            // 
            // BtnDeleteRow
            // 
            BtnDeleteRow.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnDeleteRow.Location = new Point(2308, 615);
            BtnDeleteRow.Name = "BtnDeleteRow";
            BtnDeleteRow.Size = new Size(68, 58);
            BtnDeleteRow.TabIndex = 5;
            BtnDeleteRow.Text = "-";
            BtnDeleteRow.UseVisualStyleBackColor = true;
            BtnDeleteRow.Click += BtnDeleteRow_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1994, 869);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 6;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(2188, 869);
            button2.Name = "button2";
            button2.Size = new Size(188, 58);
            button2.TabIndex = 7;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TxtId
            // 
            TxtId.Font = new Font("Segoe UI", 12F);
            TxtId.Location = new Point(235, 770);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(120, 61);
            TxtId.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(153, 770);
            label3.Name = "label3";
            label3.Size = new Size(67, 54);
            label3.TabIndex = 9;
            label3.Text = "Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(393, 777);
            label4.Name = "label4";
            label4.Size = new Size(178, 54);
            label4.TabIndex = 11;
            label4.Text = "Nombre:";
            // 
            // TxtNombres
            // 
            TxtNombres.Font = new Font("Segoe UI", 12F);
            TxtNombres.Location = new Point(604, 777);
            TxtNombres.Name = "TxtNombres";
            TxtNombres.Size = new Size(282, 61);
            TxtNombres.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(977, 780);
            label5.Name = "label5";
            label5.Size = new Size(197, 54);
            label5.TabIndex = 13;
            label5.Text = "Apellidos:";
            // 
            // TxtApellidos
            // 
            TxtApellidos.Font = new Font("Segoe UI", 12F);
            TxtApellidos.Location = new Point(1188, 780);
            TxtApellidos.Name = "TxtApellidos";
            TxtApellidos.Size = new Size(282, 61);
            TxtApellidos.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(1503, 780);
            label6.Name = "label6";
            label6.Size = new Size(115, 54);
            label6.TabIndex = 15;
            label6.Text = "Sexo:";
            // 
            // TxtSexo
            // 
            TxtSexo.Font = new Font("Segoe UI", 12F);
            TxtSexo.Location = new Point(1624, 777);
            TxtSexo.Name = "TxtSexo";
            TxtSexo.Size = new Size(110, 61);
            TxtSexo.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(1270, 876);
            label7.Name = "label7";
            label7.Size = new Size(101, 54);
            label7.TabIndex = 21;
            label7.Text = "DNI:";
            // 
            // TxtDni
            // 
            TxtDni.Font = new Font("Segoe UI", 12F);
            TxtDni.Location = new Point(1391, 873);
            TxtDni.Name = "TxtDni";
            TxtDni.Size = new Size(110, 61);
            TxtDni.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(744, 876);
            label8.Name = "label8";
            label8.Size = new Size(149, 54);
            label8.TabIndex = 19;
            label8.Text = "Carnet:";
            // 
            // TxtCarnet
            // 
            TxtCarnet.Font = new Font("Segoe UI", 12F);
            TxtCarnet.Location = new Point(955, 876);
            TxtCarnet.Name = "TxtCarnet";
            TxtCarnet.Size = new Size(282, 61);
            TxtCarnet.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(160, 873);
            label9.Name = "label9";
            label9.Size = new Size(235, 54);
            label9.TabIndex = 17;
            label9.Text = "Nacimiento:";
            // 
            // TxtNacimiento
            // 
            TxtNacimiento.Font = new Font("Segoe UI", 12F);
            TxtNacimiento.Format = DateTimePickerFormat.Short;
            TxtNacimiento.Location = new Point(386, 883);
            TxtNacimiento.Name = "TxtNacimiento";
            TxtNacimiento.Size = new Size(352, 61);
            TxtNacimiento.TabIndex = 22;
            // 
            // TNacimiento
            // 
            TNacimiento.Font = new Font("Segoe UI", 12F);
            TNacimiento.Format = DateTimePickerFormat.Short;
            TNacimiento.Location = new Point(401, 283);
            TNacimiento.Name = "TNacimiento";
            TNacimiento.Size = new Size(352, 61);
            TNacimiento.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(1270, 283);
            label10.Name = "label10";
            label10.Size = new Size(101, 54);
            label10.TabIndex = 37;
            label10.Text = "DNI:";
            // 
            // TDni
            // 
            TDni.Font = new Font("Segoe UI", 12F);
            TDni.Location = new Point(1391, 280);
            TDni.Name = "TDni";
            TDni.Size = new Size(110, 61);
            TDni.TabIndex = 36;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(744, 283);
            label11.Name = "label11";
            label11.Size = new Size(198, 54);
            label11.TabIndex = 35;
            label11.Text = "Profesion:";
            // 
            // TProfesion
            // 
            TProfesion.Font = new Font("Segoe UI", 12F);
            TProfesion.Location = new Point(955, 283);
            TProfesion.Name = "TProfesion";
            TProfesion.Size = new Size(282, 61);
            TProfesion.TabIndex = 34;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(160, 280);
            label12.Name = "label12";
            label12.Size = new Size(235, 54);
            label12.TabIndex = 33;
            label12.Text = "Nacimiento:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(1503, 187);
            label13.Name = "label13";
            label13.Size = new Size(115, 54);
            label13.TabIndex = 32;
            label13.Text = "Sexo:";
            // 
            // TSexo
            // 
            TSexo.Font = new Font("Segoe UI", 12F);
            TSexo.Location = new Point(1624, 184);
            TSexo.Name = "TSexo";
            TSexo.Size = new Size(110, 61);
            TSexo.TabIndex = 31;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(977, 187);
            label14.Name = "label14";
            label14.Size = new Size(197, 54);
            label14.TabIndex = 30;
            label14.Text = "Apellidos:";
            // 
            // TApellido
            // 
            TApellido.Font = new Font("Segoe UI", 12F);
            TApellido.Location = new Point(1188, 187);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(282, 61);
            TApellido.TabIndex = 29;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F);
            label15.Location = new Point(393, 184);
            label15.Name = "label15";
            label15.Size = new Size(178, 54);
            label15.TabIndex = 28;
            label15.Text = "Nombre:";
            // 
            // TNombre
            // 
            TNombre.Font = new Font("Segoe UI", 12F);
            TNombre.Location = new Point(604, 184);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(282, 61);
            TNombre.TabIndex = 27;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F);
            label16.Location = new Point(153, 177);
            label16.Name = "label16";
            label16.Size = new Size(67, 54);
            label16.TabIndex = 26;
            label16.Text = "Id:";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 12F);
            textBox6.Location = new Point(235, 177);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(120, 61);
            textBox6.TabIndex = 25;
            // 
            // BtnDelMaestro
            // 
            BtnDelMaestro.Location = new Point(2188, 276);
            BtnDelMaestro.Name = "BtnDelMaestro";
            BtnDelMaestro.Size = new Size(188, 58);
            BtnDelMaestro.TabIndex = 24;
            BtnDelMaestro.Text = "Eliminar";
            BtnDelMaestro.UseVisualStyleBackColor = true;
            // 
            // BtnAddMaestro
            // 
            BtnAddMaestro.Location = new Point(1982, 276);
            BtnAddMaestro.Name = "BtnAddMaestro";
            BtnAddMaestro.Size = new Size(188, 58);
            BtnAddMaestro.TabIndex = 23;
            BtnAddMaestro.Text = "Agregar";
            BtnAddMaestro.UseVisualStyleBackColor = true;
            BtnAddMaestro.Click += BtnAddMaestro_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F);
            label17.Location = new Point(1551, 276);
            label17.Name = "label17";
            label17.Size = new Size(150, 54);
            label17.TabIndex = 40;
            label17.Text = "Salario:";
            // 
            // TSalario
            // 
            TSalario.Font = new Font("Segoe UI", 12F);
            TSalario.Location = new Point(1707, 277);
            TSalario.Name = "TSalario";
            TSalario.Size = new Size(110, 61);
            TSalario.TabIndex = 39;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2477, 1318);
            Controls.Add(label17);
            Controls.Add(TSalario);
            Controls.Add(TNacimiento);
            Controls.Add(label10);
            Controls.Add(TDni);
            Controls.Add(label11);
            Controls.Add(TProfesion);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(TSexo);
            Controls.Add(label14);
            Controls.Add(TApellido);
            Controls.Add(label15);
            Controls.Add(TNombre);
            Controls.Add(label16);
            Controls.Add(textBox6);
            Controls.Add(BtnDelMaestro);
            Controls.Add(BtnAddMaestro);
            Controls.Add(TxtNacimiento);
            Controls.Add(label7);
            Controls.Add(TxtDni);
            Controls.Add(label8);
            Controls.Add(TxtCarnet);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(TxtSexo);
            Controls.Add(label5);
            Controls.Add(TxtApellidos);
            Controls.Add(label4);
            Controls.Add(TxtNombres);
            Controls.Add(label3);
            Controls.Add(TxtId);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BtnDeleteRow);
            Controls.Add(BtnAddRow);
            Controls.Add(label2);
            Controls.Add(DtStudents);
            Controls.Add(label1);
            Controls.Add(DtTeachers);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "Formulario Princpal.";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)DtTeachers).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DtTeachers;
        private Label label1;
        private Label label2;
        private DataGridView DtStudents;
        private Button BtnAddRow;
        private Button BtnDeleteRow;
        private Button button1;
        private Button button2;
        private TextBox TxtId;
        private Label label3;
        private Label label4;
        private TextBox TxtNombres;
        private Label label5;
        private TextBox TxtApellidos;
        private Label label6;
        private TextBox TxtSexo;
        private Label label7;
        private TextBox TxtDni;
        private Label label8;
        private TextBox TxtCarnet;
        private Label label9;
        private DateTimePicker TxtNacimiento;
        private DateTimePicker TNacimiento;
        private Label label10;
        private TextBox TDni;
        private Label label11;
        private TextBox TProfesion;
        private Label label12;
        private Label label13;
        private TextBox TSexo;
        private Label label14;
        private TextBox TApellido;
        private Label label15;
        private TextBox TNombre;
        private Label label16;
        private TextBox textBox6;
        private Button BtnDelMaestro;
        private Button BtnAddMaestro;
        private Label label17;
        private TextBox TSalario;
    }
}
