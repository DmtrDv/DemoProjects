using DemoLib.Models;
using DemoLib.Views;
using System.Collections.Generic;

namespace DemoLib.Presenters
{
    public class ClientPresenter
    {
        private readonly IClientsModel model_;
        private readonly List<IClientView> views_ = new List<IClientView>();
        public ClientPresenter(IClientsModel model, List<IClientView> views)
        {
            model_ = model;
            views_ = views;

            List<Client> allClients = model_.ReadAllClients();

            if (views_.Count > 0)
            {
                for (int i = 0; i < allClients.Count; ++i)
                {
                    Client client = allClients[i];
                    views[i].ShowClientInfo(client);
                }
            }
        }

        public void SearchClientsByPartialName(string searchText)
        {
            foreach (IClientView view in views_)
            {
                Client client = view.GetClientInfo();

                string clientNameToLower = client.Name.ToLower();
                string text = searchText.ToLower();

                if(clientNameToLower.Contains(text))
                {
                    view.ShowView();
                }
                else
                {
                    view.HideView();
                }
            }
        }
      /*  public void AddClient(Client client)
        {
            model_.AddClient(client); // Добавляем клиента в модель

            if (views_.Count > 0 && views_[0] is Control control)
            {
                // Находим родительский контейнер
                var parent = control.Parent;
                if (parent is FlowLayoutPanel flowLayout)
                {
                    ClientView newCard = new ClientView();
                    newCard.ShowClientInfo(client); // Заполняем карточку данными
                    newCard.SelectedClient += (clientObj) =>
                    {
                        // Здесь можно вызвать обработчик выбора клиента
                        // Пока оставляем пустым
                    };

                    flowLayout.Controls.Add(newCard); // Добавляем в layout
                    views_.Add(newCard); // Добавляем в список представлений
                }
            }
        }*/

        /// Д.З. Реализация фильтрации по какому-либо полю клиента
        /// Задание на 5+++++++. Сортировка  по числу заказов!!!
    }
}
