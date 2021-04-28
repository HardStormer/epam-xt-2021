namespace CatalogFiles
{
	partial class Form1
	{
		/// <summary>
		/// Требуется переменная конструктора.
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

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.RevisionHistory = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearRevisionHistoryButton = new System.Windows.Forms.Button();
            this.SelectCatalogButton = new System.Windows.Forms.Button();
            this.MonitoringModButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RevisionHistory
            // 
            this.RevisionHistory.Location = new System.Drawing.Point(9, 134);
            this.RevisionHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RevisionHistory.Name = "RevisionHistory";
            this.RevisionHistory.ReadOnly = true;
            this.RevisionHistory.Size = new System.Drawing.Size(312, 311);
            this.RevisionHistory.TabIndex = 0;
            this.RevisionHistory.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "История изменений:";
            // 
            // ClearRevisionHistoryButton
            // 
            this.ClearRevisionHistoryButton.Location = new System.Drawing.Point(222, 109);
            this.ClearRevisionHistoryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearRevisionHistoryButton.Name = "ClearRevisionHistoryButton";
            this.ClearRevisionHistoryButton.Size = new System.Drawing.Size(98, 20);
            this.ClearRevisionHistoryButton.TabIndex = 6;
            this.ClearRevisionHistoryButton.Text = "Очистить";
            this.ClearRevisionHistoryButton.UseVisualStyleBackColor = true;
            this.ClearRevisionHistoryButton.Click += new System.EventHandler(this.ClearRevisionHistoryButton_Click);
            // 
            // SelectCatalogButton
            // 
            this.SelectCatalogButton.Location = new System.Drawing.Point(9, 10);
            this.SelectCatalogButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectCatalogButton.Name = "SelectCatalogButton";
            this.SelectCatalogButton.Size = new System.Drawing.Size(136, 37);
            this.SelectCatalogButton.TabIndex = 7;
            this.SelectCatalogButton.Text = "Выбрать папку";
            this.SelectCatalogButton.UseVisualStyleBackColor = true;
            this.SelectCatalogButton.Click += new System.EventHandler(this.SelectCatalogButton_Click);
            // 
            // MonitoringModButton
            // 
            this.MonitoringModButton.Location = new System.Drawing.Point(182, 10);
            this.MonitoringModButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MonitoringModButton.Name = "MonitoringModButton";
            this.MonitoringModButton.Size = new System.Drawing.Size(138, 37);
            this.MonitoringModButton.TabIndex = 8;
            this.MonitoringModButton.Text = "Режим наблюдения";
            this.MonitoringModButton.UseVisualStyleBackColor = true;
            this.MonitoringModButton.Click += new System.EventHandler(this.MonitoringModButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Расположение:";
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(110, 65);
            this.Location.Multiline = true;
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(211, 20);
            this.Location.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 454);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MonitoringModButton);
            this.Controls.Add(this.SelectCatalogButton);
            this.Controls.Add(this.ClearRevisionHistoryButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RevisionHistory);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button ClearRevisionHistoryButton;
		private System.Windows.Forms.Button SelectCatalogButton;
		private System.Windows.Forms.Button MonitoringModButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Location;
		public System.Windows.Forms.RichTextBox RevisionHistory;
	}
}

