namespace IT_Enterprice_App
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Data_Display = new System.Windows.Forms.DataGridView();
            this.GroupByChekList = new System.Windows.Forms.CheckedListBox();
            this.GroupByButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Display)).BeginInit();
            this.SuspendLayout();
            // 
            // Data_Display
            // 
            this.Data_Display.AllowUserToAddRows = false;
            this.Data_Display.AllowUserToDeleteRows = false;
            this.Data_Display.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data_Display.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Data_Display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Display.Dock = System.Windows.Forms.DockStyle.Left;
            this.Data_Display.Location = new System.Drawing.Point(0, 0);
            this.Data_Display.Name = "Data_Display";
            this.Data_Display.ReadOnly = true;
            this.Data_Display.RowHeadersWidth = 51;
            this.Data_Display.RowTemplate.Height = 24;
            this.Data_Display.ShowEditingIcon = false;
            this.Data_Display.Size = new System.Drawing.Size(884, 630);
            this.Data_Display.TabIndex = 0;
            // 
            // GroupByChekList
            // 
            this.GroupByChekList.FormattingEnabled = true;
            this.GroupByChekList.Items.AddRange(new object[] {
            "Date",
            "Organization",
            "City",
            "Country",
            "Manager"});
            this.GroupByChekList.Location = new System.Drawing.Point(890, 0);
            this.GroupByChekList.Name = "GroupByChekList";
            this.GroupByChekList.Size = new System.Drawing.Size(150, 123);
            this.GroupByChekList.TabIndex = 1;
            // 
            // GroupByButton
            // 
            this.GroupByButton.Location = new System.Drawing.Point(890, 129);
            this.GroupByButton.Name = "GroupByButton";
            this.GroupByButton.Size = new System.Drawing.Size(150, 32);
            this.GroupByButton.TabIndex = 2;
            this.GroupByButton.Text = "Групировать ";
            this.GroupByButton.UseVisualStyleBackColor = true;
            this.GroupByButton.Click += new System.EventHandler(this.GroupByButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 630);
            this.Controls.Add(this.GroupByButton);
            this.Controls.Add(this.GroupByChekList);
            this.Controls.Add(this.Data_Display);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Data_Display;
        private System.Windows.Forms.CheckedListBox GroupByChekList;
        private System.Windows.Forms.Button GroupByButton;
    }
}

