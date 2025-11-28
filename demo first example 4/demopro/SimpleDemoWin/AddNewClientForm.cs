using DemoLib;
using DemoLib.Models;
using DemoLib.Models.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDemoWin
{
    public partial class AddNewClientForm: Form
    {
        MySQLClientsModel mySQLClientsModel = new MySQLClientsModel();
        private string imagePath = "";
        public Client addingClient { get; set; }
        public AddNewClientForm(MySQLClientsModel model)
        {
            InitializeComponent();
            mySQLClientsModel = model;
        }
         
        private void Cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddClient_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name_textBox.Text))
            {
                MessageBox.Show("Введите имя клиента", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            addingClient = new Client(mySQLClientsModel.GetClientsCount() + 1)
            {
                Name = Name_textBox.Text,
                Description = Description_textBox.Text,
                Phone = Phone_textBox.Text,
                Mail = Mail_textBox.Text,                
                ImagePath = imagePath
            };
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void chooseAvatar_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName; // Сохраняем выбранный путь 
            }
        }
    }
}
