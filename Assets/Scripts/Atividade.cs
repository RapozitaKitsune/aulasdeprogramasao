using UnityEngine;

public class Atividade : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] inventory = { "Espada Longa de Aço", "Escudo de Carvalho", "Poção de Cura Maior", 
                                "Elixir de Mana", "Pergaminho de Bola de Fogo", "Rações de Viagem", 
            "Tocha", "Corda de Cânhamo (10m)", "Gazuas de Ladrão", "Anel de Prata Antigo", "Mapa do Reino", 
            "Saco de Moedas de Ouro", "Adaga Envenenada", "Amuleto de Proteção", "Pena de Fênix", 
                                                                                "Cajado de Fogo" };

        int randomIndex = Random.Range(0, inventory.Length);
        inventory[randomIndex] = (Random.Range(0,2) % 2) == 0 ? "Espada Quebrada" : "Escudo Quebrado";

        string oldName;

        int percent = Random.Range(0, 100);
        if(percent < 50)
        {
            oldName = inventory[randomIndex];
            inventory[randomIndex] = "Espada Quebrada";
        }
        else
        {
            inventory[randomIndex] = "Escudo Quebrado";
        }


        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == "Espada Quebrada")
            {
                Debug.Log("O index: " + i+1 + "Foi substituido por Espada Quebrada");
                break;
            }
            else if(inventory[i] == "Escudo Quebrado")
            {
                Debug.Log("O index: " + i +1+ "Foi substituido por Escudo Quebrado");
                break;
            }
        }

        string[] trapArray = { "Espada Quebrada", "Escudo Quebrado" };

        for (int i = 0; i < inventory.Length; i++)
        {
            for (int j = 0; j < trapArray.Length; j++)
            {
                if(inventory[i] == trapArray[j])
                {
                    Debug.Log("O index: " + i + "Foi substituido por " + trapArray[j]);
                }
            }
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
