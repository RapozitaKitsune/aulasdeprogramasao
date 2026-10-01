
using UnityEngine;

public class Revisão : MonoBehaviour
{
    enum Classes
    {
        Guerreiro = 1,
        Mago,
        Arqueiro,
        Ladino,
        Bardo,
        Bruxo
    }
    void Start()
    {

        int NumeroClasse = UnityEngine.Random.Range(1, 7);
        Classes CurrentClasse = (Classes)NumeroClasse;


        switch (CurrentClasse)
        {
            case Classes.Guerreiro:
                Debug.Log("sua arma é uma espada");
                break;
            case Classes.Mago:
                Debug.Log("Sua arma é um livro de magias");
                break;
            case Classes.Arqueiro:
                Debug.Log("Sua arma é um arco e flecha");
                break;
            case Classes.Bardo:
                Debug.Log("Sua arma é um alaúde");
                break;
            case Classes.Ladino:
                Debug.Log("Sua arma é um par de adagas");
                break;
            case Classes.Bruxo:
                Debug.Log("Sua arma é um pacto com o deus ancestral das profundezas do abismo");
                break;

        }
        // exercicio 1; promoção do dia

        string[] produtos = { "Chocolate", "Biscoito", "Refrigerante", "Café", "Sorvete", "Pizza Congelada", "Salgadinho", "Suco", "Cereal", "Pão de Queijo" };
        int RandomPromo = UnityEngine.Random.Range(0, produtos.Length);

        Debug.Log("A promoção do dia é: " + produtos[RandomPromo]);

        int D20 = UnityEngine.Random.Range(1, 21);
        if (D20 == 1)
        {
            Debug.Log(D20 + " falha critica");
        }
        else if (D20 <= 5)
        {
            Debug.Log(D20 + " Ataque fraco");
        }
        else if (D20 <= 10)
        {
            Debug.Log(D20 + " Ataque normal");
        }
        else if (D20 <= 15)
        {
            Debug.Log(D20 + " Ataque Forte");
        }
        else if (D20 <= 19)
        {
            Debug.Log(D20 + " Ataque critico");
        }
        else
        {
            Debug.Log(D20 + " ATAQUE PERFEITO!");
        } 

      string[] Estoque = { "Maçã", "Banana", "Laranja", "Uva", "Manga" };
      int RandoFruta = UnityEngine.Random.Range(0, Estoque.Length);
      string FrutaAntiga = Estoque[RandoFruta];
      string[] FrutaNova = { "Morango", "Abacaxi" };
      int RandoNova = UnityEngine.Random.Range(0, FrutaNova.Length);
      Estoque[RandoFruta] = FrutaNova[RandoNova];
        
      Debug.Log("A fruta " + FrutaAntiga + " foi substituida por: " + Estoque[RandoFruta]);

        string[] inventario = {"Espada", "Poção", "Arco", "Poção","Escudo", "Poção", "Adaga"};
        int RandomInv = UnityEngine.Random.Range(0, inventario.Length);
        string OGInv = inventario[RandomInv];
        inventario[RandomInv] = "Objeto Amaldiçoado";
        Debug.Log("O item " + OGInv + " na posição " + RandomInv + " foi substituida por " + inventario[RandomInv]);

        bool parouimpar = D20 % 2 == 0;
        if(parouimpar == true)
        {
         Debug.Log(D20 + " o resultado é par");
        }
        else
        {
         Debug.Log(D20 + " o resultado é impar");
        }
    }
}
 
