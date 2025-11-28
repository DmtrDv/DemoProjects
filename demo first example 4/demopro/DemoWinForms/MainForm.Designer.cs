namespace DemoProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ClientsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddClient_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteClient_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SearchByNameLabel = new System.Windows.Forms.ToolStripLabel();
            this.SearchByClientNameTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientsLayout
            // 
            this.ClientsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientsLayout.Location = new System.Drawing.Point(0, 0);
            this.ClientsLayout.Margin = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.ClientsLayout.Name = "ClientsLayout";
            this.ClientsLayout.Padding = new System.Windows.Forms.Padding(0, 62, 0, 0);
            this.ClientsLayout.Size = new System.Drawing.Size(1067, 554);
            this.ClientsLayout.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddClient_toolStripButton,
            this.DeleteClient_toolStripButton,
            this.SearchByNameLabel,
            this.SearchByClientNameTextBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddClient_toolStripButton
            // 
            this.AddClient_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddClient_toolStripButton.Image = global::DemoProject.Properties.Resources.AddIcon;
            this.AddClient_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddClient_toolStripButton.Name = "AddClient_toolStripButton";
            this.AddClient_toolStripButton.Size = new System.Drawing.Size(29, 28);
            this.AddClient_toolStripButton.Text = "toolStripButton1";
            this.AddClient_toolStripButton.Click += new System.EventHandler(this.AddClient_toolStripButton_Click);
            // 
            // DeleteClient_toolStripButton
            // 
            this.DeleteClient_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteClient_toolStripButton.Image = global::DemoProject.Properties.Resources.RemoveIcon;
            this.DeleteClient_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteClient_toolStripButton.Name = "DeleteClient_toolStripButton";
            this.DeleteClient_toolStripButton.Size = new System.Drawing.Size(29, 28);
            this.DeleteClient_toolStripButton.Text = "toolStripButton2";
            // 
            // SearchByNameLabel
            // 
            this.SearchByNameLabel.Name = "SearchByNameLabel";
            this.SearchByNameLabel.Size = new System.Drawing.Size(186, 28);
            this.SearchByNameLabel.Text = "Поиск по имени клиента:";
            // 
            // SearchByClientNameTextBox
            // 
            this.SearchByClientNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchByClientNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchByClientNameTextBox.Name = "SearchByClientNameTextBox";
            this.SearchByClientNameTextBox.Size = new System.Drawing.Size(133, 31);
            this.SearchByClientNameTextBox.TextChanged += new System.EventHandler(this.SearchByClientNameTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ClientsLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Управление клиентами ОАО \"Цемент-Строй\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel ClientsLayout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel SearchByNameLabel;
        private System.Windows.Forms.ToolStripTextBox SearchByClientNameTextBox;
        private System.Windows.Forms.ToolStripButton AddClient_toolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteClient_toolStripButton;
    }
}

