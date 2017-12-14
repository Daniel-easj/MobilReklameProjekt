﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;
using MobilReklameApp.DomainClasses;
using MobilReklameApp.SubClasses;

namespace MobilReklameApp.ViewModels
{
    public class OrderItemViewModel : INotifyPropertyChanged
    {
        private OrderCatalog _orderCatalog = OrderCatalog.SingletonInstance;
        private NoteCatalog _noteCatalog = NoteCatalog.SingletonInstance;

        private ObservableCollection<Order> _orders = new ObservableCollection<Order>();
        private ObservableCollection<Order.OrderStatus> _orderStatuses = new ObservableCollection<Order.OrderStatus>();
        private ObservableCollection<string> _notes = new ObservableCollection<string>();

        private Order _selectedOrder;
        private Order.OrderStatus _selectedStatus;

        public OrderItemViewModel()
        {
            foreach (string note in _noteCatalog.ListAll)
            {
                _notes.Add(note);
            }

            foreach (Order order in _orderCatalog.ListAll)
            {
                _orders.Add(order);   
            }

            _orderStatuses.Add(Order.OrderStatus.Afventer);
            _orderStatuses.Add(Order.OrderStatus.Accepteret);
            _orderStatuses.Add(Order.OrderStatus.Anulleret);
            _orderStatuses.Add(Order.OrderStatus.Færdig);
            _orderStatuses.Add(Order.OrderStatus.Igangværende);
            _orderStatuses.Add(Order.OrderStatus.Leveret);

            _selectedOrder = _orders[0];
        }

        public ObservableCollection<Order> Orders
        {
            get { return _orders; }
        }

        public ObservableCollection<string> Notes
        {
            get { return _notes; }
        }

        public ObservableCollection<Order.OrderStatus> OrderStatuses
        {
            get { return _orderStatuses; }
        }

        public Order.OrderStatus SelectedStatus
        {
            get { return _selectedStatus; }
            set
            {
                _selectedStatus = value;
                _selectedOrder.EnummOrderStatus = value;
                OnPropertyChanged();
            }
        }

        public Order SelectedOrder
        {
            get { return _selectedOrder; }
            set
            {
                _selectedOrder = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}