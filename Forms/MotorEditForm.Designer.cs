namespace ProductionLineControl.Forms
{
    partial class MotorEditForm
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
            txtName = new TextBox();
            cbProtocol = new ComboBox();
            cbConnectionType = new ComboBox();
            cbManufacturer = new ComboBox();
            txtIp = new TextBox();
            txtPort = new TextBox();
            txtBaudRate = new TextBox();
            txtComPort = new TextBox();
            btnSave = new Button();
            cbModel = new ComboBox();
            numTargetSpeed = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numTargetSpeed).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(55, 114);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            // 
            // cbProtocol
            // 
            cbProtocol.FormattingEnabled = true;
            cbProtocol.Location = new Point(53, 31);
            cbProtocol.Name = "cbProtocol";
            cbProtocol.Size = new Size(151, 28);
            cbProtocol.TabIndex = 1;
            // 
            // cbConnectionType
            // 
            cbConnectionType.FormattingEnabled = true;
            cbConnectionType.Location = new Point(226, 31);
            cbConnectionType.Name = "cbConnectionType";
            cbConnectionType.Size = new Size(151, 28);
            cbConnectionType.TabIndex = 2;
            cbConnectionType.SelectedIndexChanged += cbConnectionType_SelectedIndexChanged;
            // 
            // cbManufacturer
            // 
            cbManufacturer.FormattingEnabled = true;
            cbManufacturer.Location = new Point(395, 31);
            cbManufacturer.Name = "cbManufacturer";
            cbManufacturer.Size = new Size(151, 28);
            cbManufacturer.TabIndex = 3;
            cbManufacturer.SelectedIndexChanged += cbManufacturer_SelectedIndexChanged;
            // 
            // txtIp
            // 
            txtIp.Location = new Point(55, 240);
            txtIp.Name = "txtIp";
            txtIp.Size = new Size(125, 27);
            txtIp.TabIndex = 4;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(55, 179);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(125, 27);
            txtPort.TabIndex = 5;
            // 
            // txtBaudRate
            // 
            txtBaudRate.Location = new Point(55, 368);
            txtBaudRate.Name = "txtBaudRate";
            txtBaudRate.Size = new Size(125, 27);
            txtBaudRate.TabIndex = 7;
            // 
            // txtComPort
            // 
            txtComPort.Location = new Point(55, 303);
            txtComPort.Name = "txtComPort";
            txtComPort.Size = new Size(125, 27);
            txtComPort.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(659, 368);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbModel
            // 
            cbModel.FormattingEnabled = true;
            cbModel.Location = new Point(574, 31);
            cbModel.Name = "cbModel";
            cbModel.Size = new Size(151, 28);
            cbModel.TabIndex = 9;
            cbModel.SelectedIndexChanged += cbManufacturer_SelectedIndexChanged;
            // 
            // numTargetSpeed
            // 
            numTargetSpeed.Location = new Point(575, 115);
            numTargetSpeed.Name = "numTargetSpeed";
            numTargetSpeed.Size = new Size(150, 27);
            numTargetSpeed.TabIndex = 10;
            // 
            // MotorEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numTargetSpeed);
            Controls.Add(cbModel);
            Controls.Add(btnSave);
            Controls.Add(txtBaudRate);
            Controls.Add(txtComPort);
            Controls.Add(txtPort);
            Controls.Add(txtIp);
            Controls.Add(cbManufacturer);
            Controls.Add(cbConnectionType);
            Controls.Add(cbProtocol);
            Controls.Add(txtName);
            Name = "MotorEditForm";
            Text = "MotorEditForm";
            ((System.ComponentModel.ISupportInitialize)numTargetSpeed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private ComboBox cbProtocol;
        private ComboBox cbConnectionType;
        private ComboBox cbManufacturer;
        private TextBox txtIp;
        private TextBox txtPort;
        private TextBox txtBaudRate;
        private TextBox txtComPort;
        private Button btnSave;
        private ComboBox cbModel;
        private NumericUpDown numTargetSpeed;
    }
}