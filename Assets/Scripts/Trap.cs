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

        string[] Trap = { "Espada Quebrada", "Escudo Quebrado" };

        inventory[RandomSlot] =Trap[UnityEngine.Random.Range(0, Trap.Length)];

        for (int i = 0; i < inventory.Length; i++)
        {
            for(int t = 0; t < Trap.Length; t++)
            {
                if (inventory[i] == Trap[t])
                {
                    Debug.Log("O item " + inventory[i] + " foi substituido por " + Trap[t]);
                }
            }
        }
    }
}
