using UnityEngine;

public class Trap : MonoBehaviour
{
    void Start()
    {
        string[] inventory = { "Espada Longa de Aço", "Escudo de Carvalho", "Poção de Cura Maior",
                                "Elixir de Mana", "Pergaminho de Bola de Fogo", "Rações de Viagem",
            "Tocha", "Corda de Cânhamo (10m)", "Gazuas de Ladrão", "Anel de Prata Antigo", "Mapa do Reino",
            "Saco de Moedas de Ouro", "Adaga Envenenada", "Amuleto de Proteção", "Pena de Fênix",
                                                                                "Cajado de Fogo" };
        int RandomSlot = UnityEngine.Random.Range(0, inventory.Length);

        string SlotAntigo = inventory[RandomSlot];

        string[] Trap = { "Espada Quebrada", "Escudo Quebrado" };

        int RandomTrap = UnityEngine.Random.Range(0, Trap.Length);

  
       inventory[RandomSlot] = Trap[RandomTrap];
       Debug.Log("O item " + SlotAntigo + " foi substituido por " + inventory[RandomSlot]);

    }
}
