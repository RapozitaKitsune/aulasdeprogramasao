using UnityEngine;

public class Rev : MonoBehaviour
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
    }

   
}
