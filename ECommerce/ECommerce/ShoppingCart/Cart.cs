namespace ShoppingCart;
using System.Collections.Generic;

public class Cart
{
    public List<Item> Items{get; set;}

    public void AddToCart(Item item){
        Items.Add(item);
    }

    public void RemoveFromCart(Item item){
        Items.Remove(item);
    }
}
