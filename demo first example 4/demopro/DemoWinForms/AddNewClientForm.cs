using DemoLib;
using DemoLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class AddNewClientForm: Form
    {
        public event Action<Client> ClientAdded;
        private string imagePath = "";
        public IClientsModel ClientsModel { get; set; }
        public AddNewClientForm()
        {
            InitializeComponent();
        }
         
        private void Cancel_button_Click(object sender, EventArgs e)
        {
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
            Client newClient = new Client(ClientsModel.GetClientsCount() + 1)
            {
                Name = Name_textBox.Text,
                Description = Description_textBox.Text,
                Phone = Phone_textBox.Text,
                Mail = Mail_textBox.Text,                
                ImagePath = imagePath
            };

            ClientAdded?.Invoke(newClient);
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
