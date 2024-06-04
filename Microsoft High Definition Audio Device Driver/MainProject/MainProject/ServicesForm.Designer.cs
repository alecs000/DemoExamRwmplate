namespace MainProject
{
    partial class ServicesForm
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
            this.ServicesDataGridView = new System.Windows.Forms.DataGridView();
            this.ServicesComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ServicesDataGridView
            // 
            this.ServicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServicesDataGridView.Location = new System.Drawing.Point(40, 92);
            this.ServicesDataGridView.Name = "ServicesDataGridView";
            this.ServicesDataGridView.Size = new System.Drawing.Size(479, 175);
            this.ServicesDataGridView.TabIndex = 0;
            // 
            // ServicesComboBox
            // 
            this.ServicesComboBox.FormattingEnabled = true;
            this.ServicesComboBox.Location = new System.Drawing.Point(40, 35);
            this.ServicesComboBox.Name = "ServicesComboBox";
            this.ServicesComboBox.Size = new System.Drawing.Size(385, 21);
            this.ServicesComboBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(444, 35);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(232, 299);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 349);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ServicesComboBox);
            this.Controls.Add(this.ServicesDataGridView);
            this.MaximumSize = new System.Drawing.Size(584, 388);
            this.MinimumSize = new System.Drawing.Size(584, 388);
            this.Name = "ServicesForm";
            this.Text = "ServicesForm";
            ((System.ComponentModel.ISupportInitialize)(this.ServicesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ServicesDataGridView;
        private System.Windows.Forms.ComboBox ServicesComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SaveButton;
    }
}