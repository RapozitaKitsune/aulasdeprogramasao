using UnityEngine;

public class ForLoopsStudy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
         Loop normal, conta de 1 a 10, a cada repetição soma 2
             for(int i =1; i < 10; i+=2) 
         {
             Debug.Log(i);
         }
            
        Este loop é uma contagem regressiva de 10 a 1, quando termina aparece a mensagem de Feliz ano novo
        for (int i = 10; i > 0; i--) 
        {
            Debug.Log(i);
        }
        Debug.Log("Feliz ano novo!");
        */


        string[] Inventario = { "Espada", "Escudo", "Pocao de Cura", "Mapa do Reino", "Rações de Viagem", "Pergaminho", "Botas", "Maçã Dourada", "Picareta", "Machado", "Corda(10m)", "Olho do Enderman" };
        for (int i = 0; i < Inventario.Length; i++)
        {
            Debug.Log(Inventario);

        }
  
    }


}
