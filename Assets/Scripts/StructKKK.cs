using UnityEngine;
public enum ItemType { Weapon, Armor, Consumable};
public struct InventoryItem
{
    public string name;
    public float price;
    public int amount;
    public ItemType Itemtype;
}
public class StructKKK : MonoBehaviour
   
{
    void Start()
    {
        //espada

        InventoryItem Sword = new InventoryItem();
        Sword.name = "Espada Longa de Aço";
        Sword.price = 75f;
        Sword.amount = 1;
        Debug.Log("Item: " + Sword.name + " preço: " + Sword.price + " Quantidade no inventário: " + Sword.amount);

        //poção 
        InventoryItem Potion = new InventoryItem();
        Potion.name = "Poção de Cura";
        Potion.price = 160f;
        Potion.amount = 12;
        Debug.Log("Item: " + Potion.name + " preço: " + Potion.price + " Quantidade no inventário: " + Potion.amount);

        //escudo

        InventoryItem Shield = new InventoryItem();
        Shield.name = "Escudo de Carvalho";
        Shield.price = 90f;
        Shield.amount = 1;
        Debug.Log("Item: " + Shield.name + " preço: " + Shield.price + " Quantidade no inventário: " + Shield.amount);

        //elixir de Mana
        InventoryItem Mana = new InventoryItem();
        Mana.name = "Elixir de Mana";
        Mana.price = 350f;
        Mana.amount = 18;
        Debug.Log("Item: " + Mana.name + " preço: " + Mana.price + " Quantidade no inventário: " + Mana.amount);

        //pergaminjo bola de fogo
        InventoryItem Fireball = new InventoryItem();
        Fireball.name = "Pergaminho de Bola de Fogo";
        Fireball.price = 120f;
        Fireball.amount = 4;
        Debug.Log("Item: " + Fireball.name + " preço: " + Fireball.price + " Quantidade no inventário: " + Fireball.amount);

        //rações de viagem
        InventoryItem Food = new InventoryItem();
        Food.name = "Rações de Viagem";
        Food.price = 540f;
        Food.amount = 40;
        Debug.Log("Item: " + Food.name + " preço: " + Food.price + " Quantidade no inventário: " + Food.amount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
