using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_QLNT.Models
{
    public class GioHang
    {
        public List<CartItem> items = new List<CartItem>();

        public List<CartItem> Items
        {
            get { return items; }
        }

        public void AddToCart(SanPham product, int quantity)
        {
            CartItem existingItem = items.Find(item => item.SanPham.MaSP == product.MaSP);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                items.Add(new CartItem { SanPham = product, Quantity = quantity });
            }
        }

        public int GetTotalQuantity()
        {
            return items.Sum(item => item.Quantity);
        }

        public decimal GetTotalPrice()
        {
            return items.Sum(item => item.SanPham.DonGia * item.Quantity);
        }

        public void RemoveFromCart(string productId)
        {
            CartItem cartItem = Items.FirstOrDefault(item => item.SanPham.MaSP == productId);

            if (cartItem != null)
            {
                Items.Remove(cartItem);
            }
        }

        public void ClearCart()
        {
            Items.Clear();
        }

    }

    public class CartItem
    {
        public SanPham SanPham { get; set; }
        public int Quantity { get; set; }
    }
}