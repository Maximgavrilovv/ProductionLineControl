using ProductionLineControl.Services;

namespace ProductionLineControl
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            dgvMotors = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnLoadRecipe = new Button();
            btnSaveRecipe = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvMotors).BeginInit();
            SuspendLayout();
            // 
            // dgvMotors
            // 
            dgvMotors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMotors.Dock = DockStyle.Fill;
            dgvMotors.Location = new Point(0, 0);
            dgvMotors.Name = "dgvMotors";
            dgvMotors.RowHeadersWidth = 51;
            dgvMotors.Size = new Size(800, 450);
            dgvMotors.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(83, 262);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(217, 262);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(352, 262);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoadRecipe
            // 
            btnLoadRecipe.Location = new Point(511, 262);
            btnLoadRecipe.Name = "btnLoadRecipe";
            btnLoadRecipe.Size = new Size(112, 29);
            btnLoadRecipe.TabIndex = 4;
            btnLoadRecipe.Text = "Load Recipe";
            btnLoadRecipe.UseVisualStyleBackColor = true;
            btnLoadRecipe.Click += btnLoadRecipe_Click;
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.Location = new Point(653, 262);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(112, 29);
            btnSaveRecipe.TabIndex = 5;
            btnSaveRecipe.Text = "Save Recipe";
            btnSaveRecipe.UseVisualStyleBackColor = true;
            btnSaveRecipe.Click += btnSaveRecipe_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveRecipe);
            Controls.Add(btnLoadRecipe);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvMotors);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMotors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMotors;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnLoadRecipe;
        private Button btnSaveRecipe;
        private System.Windows.Forms.Timer timer1;
    }
}
