namespace Use_Databases
{
    partial class Form1
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
            DataGridCarrera = new DataGridView();
            BtnOpenDataCarrera = new Button();
            BtnAddCarrera = new Button();
            DataGrideAlumnos = new DataGridView();
            TxtNombreCarrera = new TextBox();
            TxtAlumnoDate = new TextBox();
            BtnDeleteCarrera = new Button();
            BtnDeleteDataAlumno = new Button();
            BtnClose = new Button();
            BtnAddAlumno = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridCarrera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGrideAlumnos).BeginInit();
            SuspendLayout();
            // 
            // DataGridCarrera
            // 
            DataGridCarrera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridCarrera.Location = new Point(1172, 12);
            DataGridCarrera.Name = "DataGridCarrera";
            DataGridCarrera.Size = new Size(249, 490);
            DataGridCarrera.TabIndex = 1;
            // 
            // BtnOpenDataCarrera
            // 
            BtnOpenDataCarrera.Location = new Point(48, 23);
            BtnOpenDataCarrera.Name = "BtnOpenDataCarrera";
            BtnOpenDataCarrera.Size = new Size(139, 40);
            BtnOpenDataCarrera.TabIndex = 2;
            BtnOpenDataCarrera.Text = "Open";
            BtnOpenDataCarrera.UseVisualStyleBackColor = true;
            BtnOpenDataCarrera.Click += BtnOpenData_Click;
            // 
            // BtnAddCarrera
            // 
            BtnAddCarrera.Location = new Point(910, 163);
            BtnAddCarrera.Name = "BtnAddCarrera";
            BtnAddCarrera.Size = new Size(139, 40);
            BtnAddCarrera.TabIndex = 3;
            BtnAddCarrera.Text = "Add";
            BtnAddCarrera.UseVisualStyleBackColor = true;
            BtnAddCarrera.Click += BtnSendData_Click;
            // 
            // DataGrideAlumnos
            // 
            DataGrideAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrideAlumnos.Location = new Point(270, 12);
            DataGrideAlumnos.Name = "DataGrideAlumnos";
            DataGrideAlumnos.Size = new Size(549, 490);
            DataGrideAlumnos.TabIndex = 5;
            // 
            // TxtNombreCarrera
            // 
            TxtNombreCarrera.Location = new Point(910, 106);
            TxtNombreCarrera.Name = "TxtNombreCarrera";
            TxtNombreCarrera.Size = new Size(226, 23);
            TxtNombreCarrera.TabIndex = 6;
            // 
            // TxtAlumnoDate
            // 
            TxtAlumnoDate.Location = new Point(12, 106);
            TxtAlumnoDate.Name = "TxtAlumnoDate";
            TxtAlumnoDate.Size = new Size(226, 23);
            TxtAlumnoDate.TabIndex = 10;
            // 
            // BtnDeleteCarrera
            // 
            BtnDeleteCarrera.Location = new Point(910, 233);
            BtnDeleteCarrera.Name = "BtnDeleteCarrera";
            BtnDeleteCarrera.Size = new Size(139, 40);
            BtnDeleteCarrera.TabIndex = 11;
            BtnDeleteCarrera.Text = "Delete";
            BtnDeleteCarrera.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteDataAlumno
            // 
            BtnDeleteDataAlumno.Location = new Point(12, 233);
            BtnDeleteDataAlumno.Name = "BtnDeleteDataAlumno";
            BtnDeleteDataAlumno.Size = new Size(139, 40);
            BtnDeleteDataAlumno.TabIndex = 15;
            BtnDeleteDataAlumno.Text = "Delete";
            BtnDeleteDataAlumno.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Location = new Point(12, 529);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(139, 40);
            BtnClose.TabIndex = 14;
            BtnClose.Text = "Close";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click_1;
            // 
            // BtnAddAlumno
            // 
            BtnAddAlumno.Location = new Point(12, 163);
            BtnAddAlumno.Name = "BtnAddAlumno";
            BtnAddAlumno.Size = new Size(139, 40);
            BtnAddAlumno.TabIndex = 13;
            BtnAddAlumno.Text = "Add";
            BtnAddAlumno.UseVisualStyleBackColor = true;
            BtnAddAlumno.Click += BtnAddAlumno_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1505, 581);
            Controls.Add(BtnDeleteDataAlumno);
            Controls.Add(BtnClose);
            Controls.Add(BtnAddAlumno);
            Controls.Add(BtnDeleteCarrera);
            Controls.Add(TxtAlumnoDate);
            Controls.Add(TxtNombreCarrera);
            Controls.Add(DataGrideAlumnos);
            Controls.Add(BtnAddCarrera);
            Controls.Add(BtnOpenDataCarrera);
            Controls.Add(DataGridCarrera);
            Name = "Form1";
            Text = "BtnClose";
            ((System.ComponentModel.ISupportInitialize)DataGridCarrera).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGrideAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridCarrera;
        private Button BtnOpenDataCarrera;
        private Button BtnAddCarrera;
        private DataGridView DataGrideAlumnos;
        private TextBox TxtNombreCarrera;
        private TextBox TxtAlumnoDate;
        private Button BtnDeleteCarrera;
        private Button BtnDeleteDataAlumno;
        private Button BtnClose;
        private Button BtnAddAlumno;
    }
}
