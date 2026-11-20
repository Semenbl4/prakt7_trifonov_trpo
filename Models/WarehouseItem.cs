using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace prakt7_trifonov_trpo.Models
{
    public class WarehouseItem : INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name)); 
                }
            }
        }

        private decimal _unitprice;

        public decimal UnitPrice
        {
            get => _unitprice;
            set
            {
                if (_unitprice != value)
                {
                    _unitprice = value;
                    OnPropertyChanged(nameof(UnitPrice));
                    OnPropertyChanged(nameof(TotalValue));
                }
            }
        }

        private int _quantity;

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    OnPropertyChanged(nameof(Quantity));
                    OnPropertyChanged(nameof(TotalValue));
                    OnPropertyChanged(nameof(IsLowStock));
                }
            }
        }

        private int _minstock;

        public int MinimumStock
        {
            get => _minstock;
            set
            {
                if (_minstock != value)
                {
                    _minstock = value;
                    OnPropertyChanged(nameof(MinimumStock));
                    OnPropertyChanged(nameof(IsLowStock));
                }
            }
        }

        public decimal TotalValue => UnitPrice * Quantity;

        public bool IsLowStock => Quantity < MinimumStock;

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}