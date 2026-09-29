using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
  enum dificuldade
    {
        facil,
        normal,
        Dificil,
        Insano,

    }
    enum Planetas
    {
        Mercurio = 1,
        Venus = 2,
        Terra = 3,
        Marte = 4,
        Jupiter = 5,
        Saturno = 6,
        Urano = 7,
        Netuno = 8
    }
    void Start()
    {
        // atividade de variáveis 
        string Nome = "Rapozita";
        int idade = 22;
        float altura = 1.62f;
        Debug.Log("olá, meu nome é " + Nome + " eu tenho " + idade + " anos, minha altura é " + altura + "m");
        // atividade de array/for loop
        string[] personagens = {"Mario","Luigi","Peach","Bowser"};

        for(int i=0; i<personagens.Length; i++)
        {
            Debug.Log(personagens[i]);
        }

        // atividade de enum
        dificuldade DificuldadeAtual = dificuldade.normal;

        switch (DificuldadeAtual) 
        {
            case dificuldade.facil:
                Debug.Log("Boa Sorte!");
                break;
            case dificuldade.normal:
                Debug.Log("prepare-se");
                break;
            case dificuldade.Dificil:
                Debug.Log("isso vai doer...");
                break;
            case dificuldade.Insano:
                Debug.Log("DEUS TE ABANDONOU");
                break;
        }
        // atividade enum + for

        for(int i = 1; i <= 8; i++)
        {
            Debug.Log((Planetas)i + " é o planeta número " + (int)(Planetas)i);
        }
    }
}
