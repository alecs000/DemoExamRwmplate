namespace MainProject
{
    partial class OrdersForm
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
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.UnsaveButton = new System.Windows.Forms.Button();
            this.CompleteButton = new System.Windows.Forms.Button();
            this.ChangeServices = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Location = new System.Drawing.Point(12, 49);
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.Size = new System.Drawing.Size(776, 261);
            this.OrdersDataGridView.TabIndex = 0;
            this.OrdersDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.OrdersDataGridView_DefaultValuesNeeded);
            this.OrdersDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.OrdersDataGridView_UserDeletingRow);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(561, 12);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(134, 20);
            this.SearchTextBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(713, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 343);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(199, 65);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UnsaveButton
            // 
            this.UnsaveButton.Location = new System.Drawing.Point(217, 343);
            this.UnsaveButton.Name = "UnsaveButton";
            this.UnsaveButton.Size = new System.Drawing.Size(199, 65);
            this.UnsaveButton.TabIndex = 4;
            this.UnsaveButton.Text = "Отменить несохранённые изменения";
            this.UnsaveButton.UseVisualStyleBackColor = true;
            this.UnsaveButton.Click += new System.EventHandler(this.UnsaveButton_Click);
            // 
            // CompleteButton
            // 
            this.CompleteButton.Location = new System.Drawing.Point(422, 343);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(177, 65);
            this.CompleteButton.TabIndex = 5;
            this.CompleteButton.Text = "Завершить заказ";
            this.CompleteButton.UseVisualStyleBackColor = true;
            this.CompleteButton.Click += new System.EventHandler(this.CompleteButton_Click);
            // 
            // ChangeServices
            // 
            this.ChangeServices.Location = new System.Drawing.Point(605, 343);
            this.ChangeServices.Name = "ChangeServices";
            this.ChangeServices.Size = new System.Drawing.Size(177, 65);
            this.ChangeServices.TabIndex = 6;
            this.ChangeServices.Text = "Изменить услуги";
            this.ChangeServices.UseVisualStyleBackColor = true;
            this.ChangeServices.Click += new System.EventHandler(this.ChangeServices_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangeServices);
            this.Controls.Add(this.CompleteButton);
            this.Controls.Add(this.UnsaveButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.OrdersDataGridView);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrdersForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button UnsaveButton;
        private System.Windows.Forms.Button CompleteButton;
        private System.Windows.Forms.Button ChangeServices;
    }
}