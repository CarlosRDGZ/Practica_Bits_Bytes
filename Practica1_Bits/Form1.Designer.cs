namespace Practica1_Bits
{
    partial class Form1
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
            this.BtnProcess = new System.Windows.Forms.Button();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.LblInput = new System.Windows.Forms.Label();
            this.LblSensor1 = new System.Windows.Forms.Label();
            this.LblSensor2 = new System.Windows.Forms.Label();
            this.LblLevel = new System.Windows.Forms.Label();
            this.LblDirection = new System.Windows.Forms.Label();
            this.TxtSensor1 = new System.Windows.Forms.TextBox();
            this.TxtSensor2 = new System.Windows.Forms.TextBox();
            this.TxtLevel = new System.Windows.Forms.TextBox();
            this.TxtDirection = new System.Windows.Forms.TextBox();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.LblDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtDateOutput = new System.Windows.Forms.TextBox();
            this.BtnAdjustDate = new System.Windows.Forms.Button();
            this.LblDateInput = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnProcess
            // 
            this.BtnProcess.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProcess.Location = new System.Drawing.Point(278, 15);
            this.BtnProcess.Name = "BtnProcess";
            this.BtnProcess.Size = new System.Drawing.Size(74, 27);
            this.BtnProcess.TabIndex = 0;
            this.BtnProcess.Text = "Procesar";
            this.BtnProcess.UseVisualStyleBackColor = true;
            this.BtnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // TxtInput
            // 
            this.TxtInput.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInput.Location = new System.Drawing.Point(77, 16);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(181, 25);
            this.TxtInput.TabIndex = 1;
            // 
            // LblInput
            // 
            this.LblInput.AutoSize = true;
            this.LblInput.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInput.Location = new System.Drawing.Point(18, 19);
            this.LblInput.Name = "LblInput";
            this.LblInput.Size = new System.Drawing.Size(53, 18);
            this.LblInput.TabIndex = 2;
            this.LblInput.Text = "Entrada";
            // 
            // LblSensor1
            // 
            this.LblSensor1.AutoSize = true;
            this.LblSensor1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSensor1.Location = new System.Drawing.Point(13, 63);
            this.LblSensor1.Name = "LblSensor1";
            this.LblSensor1.Size = new System.Drawing.Size(58, 18);
            this.LblSensor1.TabIndex = 3;
            this.LblSensor1.Text = "Sensor 1";
            // 
            // LblSensor2
            // 
            this.LblSensor2.AutoSize = true;
            this.LblSensor2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSensor2.Location = new System.Drawing.Point(13, 102);
            this.LblSensor2.Name = "LblSensor2";
            this.LblSensor2.Size = new System.Drawing.Size(58, 18);
            this.LblSensor2.TabIndex = 4;
            this.LblSensor2.Text = "Sensor 2";
            // 
            // LblLevel
            // 
            this.LblLevel.AutoSize = true;
            this.LblLevel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLevel.Location = new System.Drawing.Point(194, 67);
            this.LblLevel.Name = "LblLevel";
            this.LblLevel.Size = new System.Drawing.Size(37, 18);
            this.LblLevel.TabIndex = 5;
            this.LblLevel.Text = "Nivel";
            // 
            // LblDirection
            // 
            this.LblDirection.AutoSize = true;
            this.LblDirection.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDirection.Location = new System.Drawing.Point(169, 106);
            this.LblDirection.Name = "LblDirection";
            this.LblDirection.Size = new System.Drawing.Size(62, 18);
            this.LblDirection.TabIndex = 6;
            this.LblDirection.Text = "Dirección";
            // 
            // TxtSensor1
            // 
            this.TxtSensor1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSensor1.Location = new System.Drawing.Point(77, 60);
            this.TxtSensor1.Name = "TxtSensor1";
            this.TxtSensor1.ReadOnly = true;
            this.TxtSensor1.Size = new System.Drawing.Size(75, 25);
            this.TxtSensor1.TabIndex = 7;
            // 
            // TxtSensor2
            // 
            this.TxtSensor2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSensor2.Location = new System.Drawing.Point(77, 99);
            this.TxtSensor2.Name = "TxtSensor2";
            this.TxtSensor2.ReadOnly = true;
            this.TxtSensor2.Size = new System.Drawing.Size(75, 25);
            this.TxtSensor2.TabIndex = 8;
            // 
            // TxtLevel
            // 
            this.TxtLevel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLevel.Location = new System.Drawing.Point(237, 63);
            this.TxtLevel.Name = "TxtLevel";
            this.TxtLevel.ReadOnly = true;
            this.TxtLevel.Size = new System.Drawing.Size(115, 25);
            this.TxtLevel.TabIndex = 9;
            // 
            // TxtDirection
            // 
            this.TxtDirection.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDirection.Location = new System.Drawing.Point(237, 102);
            this.TxtDirection.Name = "TxtDirection";
            this.TxtDirection.ReadOnly = true;
            this.TxtDirection.Size = new System.Drawing.Size(115, 25);
            this.TxtDirection.TabIndex = 10;
            // 
            // TxtDate
            // 
            this.TxtDate.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDate.Location = new System.Drawing.Point(167, 151);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.ReadOnly = true;
            this.TxtDate.Size = new System.Drawing.Size(100, 25);
            this.TxtDate.TabIndex = 11;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(108, 154);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(44, 18);
            this.LblDate.TabIndex = 12;
            this.LblDate.Text = "Fecha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DatePicker);
            this.groupBox1.Controls.Add(this.TxtDateOutput);
            this.groupBox1.Controls.Add(this.BtnAdjustDate);
            this.groupBox1.Controls.Add(this.LblDateInput);
            this.groupBox1.Location = new System.Drawing.Point(29, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 144);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajustar Fecha";
            // 
            // TxtDateOutput
            // 
            this.TxtDateOutput.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDateOutput.Location = new System.Drawing.Point(106, 96);
            this.TxtDateOutput.Name = "TxtDateOutput";
            this.TxtDateOutput.Size = new System.Drawing.Size(100, 25);
            this.TxtDateOutput.TabIndex = 16;
            // 
            // BtnAdjustDate
            // 
            this.BtnAdjustDate.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdjustDate.Location = new System.Drawing.Point(119, 63);
            this.BtnAdjustDate.Name = "BtnAdjustDate";
            this.BtnAdjustDate.Size = new System.Drawing.Size(74, 27);
            this.BtnAdjustDate.TabIndex = 14;
            this.BtnAdjustDate.Text = "Ajustar";
            this.BtnAdjustDate.UseVisualStyleBackColor = true;
            this.BtnAdjustDate.Click += new System.EventHandler(this.BtnAdjustDate_Click);
            // 
            // LblDateInput
            // 
            this.LblDateInput.AutoSize = true;
            this.LblDateInput.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateInput.Location = new System.Drawing.Point(32, 22);
            this.LblDateInput.Name = "LblDateInput";
            this.LblDateInput.Size = new System.Drawing.Size(44, 18);
            this.LblDateInput.TabIndex = 15;
            this.LblDateInput.Text = "Fecha";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(82, 22);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(182, 20);
            this.DatePicker.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 374);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.TxtDirection);
            this.Controls.Add(this.TxtLevel);
            this.Controls.Add(this.TxtSensor2);
            this.Controls.Add(this.TxtSensor1);
            this.Controls.Add(this.LblDirection);
            this.Controls.Add(this.LblLevel);
            this.Controls.Add(this.LblSensor2);
            this.Controls.Add(this.LblSensor1);
            this.Controls.Add(this.LblInput);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.BtnProcess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnProcess;
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Label LblInput;
        private System.Windows.Forms.Label LblSensor1;
        private System.Windows.Forms.Label LblSensor2;
        private System.Windows.Forms.Label LblLevel;
        private System.Windows.Forms.Label LblDirection;
        private System.Windows.Forms.TextBox TxtSensor1;
        private System.Windows.Forms.TextBox TxtSensor2;
        private System.Windows.Forms.TextBox TxtLevel;
        private System.Windows.Forms.TextBox TxtDirection;
        private System.Windows.Forms.TextBox TxtDate;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtDateOutput;
        private System.Windows.Forms.Button BtnAdjustDate;
        private System.Windows.Forms.Label LblDateInput;
        private System.Windows.Forms.DateTimePicker DatePicker;
    }
}

