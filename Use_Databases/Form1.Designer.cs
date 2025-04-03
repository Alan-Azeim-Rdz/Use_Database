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
            BtnOpenData = new Button();
            BtnSendData = new Button();
            BtnClose = new Button();
            DataGrideAlumnos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridCarrera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGrideAlumnos).BeginInit();
            SuspendLayout();
            // 
            // DataGridCarrera
            // 
            DataGridCarrera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridCarrera.Location = new Point(923, 12);
            DataGridCarrera.Name = "DataGridCarrera";
            DataGridCarrera.Size = new Size(549, 490);
            DataGridCarrera.TabIndex = 1;
            // 
            // BtnOpenData
            // 
            BtnOpenData.Location = new Point(113, 113);
            BtnOpenData.Name = "BtnOpenData";
            BtnOpenData.Size = new Size(139, 40);
            BtnOpenData.TabIndex = 2;
            BtnOpenData.Text = "Open";
            BtnOpenData.UseVisualStyleBackColor = true;
            BtnOpenData.Click += BtnOpenData_Click;
            // 
            // BtnSendData
            // 
            BtnSendData.Location = new Point(113, 205);
            BtnSendData.Name = "BtnSendData";
            BtnSendData.Size = new Size(139, 40);
            BtnSendData.TabIndex = 3;
            BtnSendData.Text = "Send";
            BtnSendData.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Location = new Point(113, 289);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(139, 40);
            BtnClose.TabIndex = 4;
            BtnClose.Text = "Close";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // DataGrideAlumnos
            // 
            DataGrideAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrideAlumnos.Location = new Point(340, 12);
            DataGrideAlumnos.Name = "DataGrideAlumnos";
            DataGrideAlumnos.Size = new Size(549, 490);
            DataGrideAlumnos.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1505, 551);
            Controls.Add(DataGrideAlumnos);
            Controls.Add(BtnClose);
            Controls.Add(BtnSendData);
            Controls.Add(BtnOpenData);
            Controls.Add(DataGridCarrera);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DataGridCarrera).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGrideAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridCarrera;
        private Button BtnOpenData;
        private Button BtnSendData;
        private Button BtnClose;
        private DataGridView DataGrideAlumnos;
    }
}
