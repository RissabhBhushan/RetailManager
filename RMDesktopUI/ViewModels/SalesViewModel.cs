using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMDesktopUI.ViewModels
{
    public class SalesViewModel : Screen
    {
        private BindingList<string> _products { get; set; }
        private BindingList<string> _cart;
        private int _itemQuantity;

        public BindingList<string> Products
        {
            get { return _products; }
            set {
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        public BindingList<string> Cart
        {
            get { return _cart; }
            set {
                _cart = value;
                NotifyOfPropertyChange(() => Cart);
            }
        }
                    
        public int ItemQuantity
        {
            get { return _itemQuantity; }
            set
            {
                _itemQuantity = value;
                NotifyOfPropertyChange(() => ItemQuantity);
            }
        }

        public string SubTotal
        {
            get
            {
                // TODO - Repalce with calculation
                return "Rs 0.00";
            }
        }

        public string Tax
        {
            get
            {
                // TODO - Repalce with calculation
                return "Rs 0.00";
            }
        }

        public string Total
        {
            get
            {
                // TODO - Repalce with calculation
                return "Rs 0.00";
            }
        }

        public bool CanAddToCart
        {
            get
            {
                bool output = false;

                //Make Sure something is selected
                // Make sure there is an item quantity

                return output;
            }
        }

        public void AddToCart()
        {

        }

        public bool CanRemoveFromCart
        {
            get
            {
                bool output = false;

                //Make Sure something is selected                

                return output;
            }
        }

        public void RemoveFromCart()
        {

        }

        public bool CanCheckOut
        {
            get
            {
                bool output = false;

                //Make Sure something is in cart             

                return output;
            }
        }

        public void CheckOut()
        {

        }
    }
}
