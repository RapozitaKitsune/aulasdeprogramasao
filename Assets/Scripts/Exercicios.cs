
using UnityEditor.Experimental.GraphView;
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
        dificuldade DificuldadeAtual = dificuldade.Insano;

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

        // atividade de if/else
        
        int[] numeros = { 10, 25, 30, 47, 50, 63 };
        
        for (int i = 0; i < numeros.Length; i++)
        {
          bool parouimpar = numeros[i] % 2 == 0;
           if (parouimpar == true)
            {
                Debug.Log(numeros[i] + " é um numero par");
            }
           if (parouimpar == false)
            {
                Debug.Log(numeros[i] + " é um numero impar");
            }
        }

        int[] DoisNumeros = { 17, 8 };
        if (DoisNumeros[0] > DoisNumeros[1])
        {
            Debug.Log(DoisNumeros[0] + " é o número maior");
            Debug.Log(DoisNumeros[1] + " é o número menor");
        }
        else
        {
            Debug.Log(DoisNumeros[1] + " é o número maior");
            Debug.Log(DoisNumeros[0] + " é o número menor");
        }
     
        // atividade random range

        int RandNum1 = UnityEngine.Random.Range(1, 21);
        int RandNum2 = UnityEngine.Random.Range(1, 21);
        int RandNum3 = UnityEngine.Random.Range(1, 21);

        int SomaNum = RandNum1 + RandNum2 + RandNum3;

        float MediaNum = (RandNum1 + RandNum2 + RandNum3) / 3f;

        Debug.Log("Você rolou:" + RandNum1 + ", " + RandNum2 + " e " + RandNum3);
        Debug.Log(" a soma das três rolagens é:" + SomaNum);
        Debug.Log("A média das três rolagens é: " + MediaNum.ToString("F2"));

        // exercicios random + if

        int CaraCoroa = UnityEngine.Random.Range(1, 3);
        if (CaraCoroa == 1)
        {
            Debug.Log("Cara");
        }
        else
        {
            Debug.Log("Coroa");
        }
        int RandomNum = UnityEngine.Random.Range(1, 11);
        int SecretNum = 7;
        
        if (RandomNum == SecretNum)
        {
          Debug.Log("Você acertou");
        }
        else
        {
            Debug.Log("Você errou");
        }

        int D20 = UnityEngine.Random.Range(1, 21);
        int CritSuccess = 20;
        int CritFail = 1;

        if(D20 == CritSuccess)
        {
            Debug.Log(CritSuccess + ", SUCESSO CRITICO!");
        }
        else if( D20 == CritFail)
        {
            Debug.Log(CritFail + ", FALHA CRITICA!");
        }
        else
        {
            Debug.Log(D20 + " resultado normal");
        }

       if(D20 <= 5)
       {
            Debug.Log(D20 + "ruim");
       }
       else if(D20 >= 6 && D20 <= 10)
       {
            Debug.Log(D20 + "mediano");
       }
       else if(D20 >= 11 && D20 <= 15)
        {
            Debug.Log(D20 + "bom");
        }
       else if(D20 >= 16 && D20 <= 19)
        {
            Debug.Log(D20 + "excelente");
        }
       else
        {
            Debug.Log(D20 + "PERFEITO!");
        }

        string[] armas = { "Espada", "Arco", "Machado", "Cajado", "Adaga" };
        // int RandomArma = UnityEngine.Random.Range(0, armas.Length);

        //Debug.Log(armas[RandomArma]);
        for(int i = 0; i < armas.Length; i++)
        {
            if (armas[i] == "Machado")
            {
                armas[i] = "Martelo";
                Debug.Log("O index " + i + " foi substituido por um martelo");
            }
        }


    }  
}
