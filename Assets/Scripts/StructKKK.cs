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

        //Tocha
        InventoryItem Torch = new InventoryItem();
        Torch.name = "Tocha";
        Torch.price = 9f;
        Torch.amount = 5;
        Debug.Log("Item: " + Torch.name + " preço: " + Torch.price + " Quantidade no inventário: " + Torch.amount);

        //Corda de Cânhamo (10m)
        InventoryItem Rope = new InventoryItem();
        Rope.name = "Corda de Cânhamo (10m)";
        Rope.price = 8f;
        Rope.amount = 2;
        Debug.Log("Item: " + Rope.name + " preço: " + Rope.price + " Quantidade no inventário: " + Rope.amount);

        //Gazuas de Ladrão
        InventoryItem Lockpick = new InventoryItem();
        Lockpick.name = "Gazuas de Ladrão";
        Lockpick.price = 130f;
        Lockpick.amount = 8;
        Debug.Log("Item: " + Lockpick.name + " preço: " + Lockpick.price + " Quantidade no inventário: " + Lockpick.amount);

        //Anel de Prata Antigo
        InventoryItem Ring = new InventoryItem();
        Ring.name = "Anel de Prata Antigo";
        Ring.price = 20f;
        Ring.amount = 1;
        Debug.Log("Item: " + Ring.name + " preço: " + Ring.price + " Quantidade no inventário: " + Ring.amount);

        // Mapa do Reino
        InventoryItem Map = new InventoryItem();
        Map.name = "Mapa do Reino";
        Map.price = 8f;
        Map.amount = 1;
        Debug.Log("Item: " + Map.name + " preço: " + Map.price + " Quantidade no inventário: " + Map.amount);

        // Saco de Moedas de Ouro
        InventoryItem Gold = new InventoryItem();
        Gold.name = "Saco de Moedas de Ouro";
        Gold.price = 500f;
        Gold.amount = 1;
        Debug.Log("Item: " + Gold.name + " preço: " + Gold.price + " Quantidade no inventário: " + Gold.amount);

        // Adaga Envenenada
        InventoryItem Dagger = new InventoryItem();
        Dagger.name = "Adaga Envenenada";
        Dagger.price = 85f;
        Dagger.amount = 1;
        Debug.Log("Item: " + Dagger.name + " preço: " + Dagger.price + " Quantidade no inventário: " + Dagger.amount);

        // Amuleto de Proteção
        InventoryItem Amulet = new InventoryItem();
        Amulet.name = "Amuleto de Proteção";
        Amulet.price = 200f;
        Amulet.amount = 1;
        Debug.Log("Item: " + Amulet.name + " preço: " + Amulet.price + " Quantidade no inventário: " + Amulet.amount);

        // Pena de Fênix
        InventoryItem Phoenix = new InventoryItem();
        Phoenix.name = "Pena de Fênix";
        Phoenix.price = 750f;
        Phoenix.amount = 2;
        Debug.Log("Item: " + Phoenix.name + " preço: " + Phoenix.price + " Quantidade no inventário: " + Phoenix.amount);

        // Cajado de Fogo
        InventoryItem Staff = new InventoryItem();
        Staff.name = "Cajado de Fogo";
        Staff.price = 320f;
        Staff.amount = 1;
        Debug.Log("Item: " + Staff.name + " preço: " + Staff.price + " Quantidade no inventário: " + Staff.amount);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
