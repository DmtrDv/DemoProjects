namespace DemoProject
{
    partial class AddNewClientForm
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
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Description_textBox = new System.Windows.Forms.TextBox();
            this.Phone_textBox = new System.Windows.Forms.TextBox();
            this.Mail_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddClient_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chooseAvatar_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(101, 17);
            this.Name_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(132, 22);
            this.Name_textBox.TabIndex = 0;
            // 
            // Description_textBox
            // 
            this.Description_textBox.Location = new System.Drawing.Point(101, 50);
            this.Description_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Description_textBox.Name = "Description_textBox";
            this.Description_textBox.Size = new System.Drawing.Size(132, 22);
            this.Description_textBox.TabIndex = 1;
            // 
            // Phone_textBox
            // 
            this.Phone_textBox.Location = new System.Drawing.Point(100, 82);
            this.Phone_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Phone_textBox.Name = "Phone_textBox";
            this.Phone_textBox.Size = new System.Drawing.Size(132, 22);
            this.Phone_textBox.TabIndex = 2;
            // 
            // Mail_textBox
            // 
            this.Mail_textBox.Location = new System.Drawing.Point(100, 114);
            this.Mail_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Mail_textBox.Name = "Mail_textBox";
            this.Mail_textBox.Size = new System.Drawing.Size(132, 22);
            this.Mail_textBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Аватар";
            // 
            // AddClient_button
            // 
            this.AddClient_button.Location = new System.Drawing.Point(24, 180);
            this.AddClient_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddClient_button.Name = "AddClient_button";
            this.AddClient_button.Size = new System.Drawing.Size(100, 28);
            this.AddClient_button.TabIndex = 10;
            this.AddClient_button.Text = "ОК";
            this.AddClient_button.UseVisualStyleBackColor = true;
            this.AddClient_button.Click += new System.EventHandler(this.AddClient_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(133, 178);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(100, 28);
            this.Cancel_button.TabIndex = 11;
            this.Cancel_button.Text = "Отмена";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chooseAvatar_button
            // 
            this.chooseAvatar_button.Location = new System.Drawing.Point(100, 146);
            this.chooseAvatar_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chooseAvatar_button.Name = "chooseAvatar_button";
            this.chooseAvatar_button.Size = new System.Drawing.Size(132, 28);
            this.chooseAvatar_button.TabIndex = 12;
            this.chooseAvatar_button.Text = "Выбрать аватар";
            this.chooseAvatar_button.UseVisualStyleBackColor = true;
            this.chooseAvatar_button.Click += new System.EventHandler(this.chooseAvatar_button_Click);
            // 
            // AddNewClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 223);
            this.Controls.Add(this.chooseAvatar_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.AddClient_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mail_textBox);
            this.Controls.Add(this.Phone_textBox);
            this.Controls.Add(this.Description_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewClientForm";
            this.Text = "AddNewClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox Description_textBox;
        private System.Windows.Forms.TextBox Phone_textBox;
        private System.Windows.Forms.TextBox Mail_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddClient_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button chooseAvatar_button;
    }
}