using UnityEngine;

public class FInalGradeRemake : MonoBehaviour
{
    void Start()
    {
        string AlunoName = "RapozinhaGameplays";
        float PresensaNecessaria = 75.0f;
        int MediaNecessaria = 5;
        float PresensaAluno = 80.0f;
        int NotaAtividade1 = 6;
        int NotaAtividade2 = 8;
        int NotaAtividade3 = 9;
        float MediaAtividades = (NotaAtividade1 + NotaAtividade2 + NotaAtividade3) /3f;
        bool PassouDeAno = PresensaAluno >= PresensaNecessaria && MediaAtividades >= MediaNecessaria;

        Debug.Log("A aluna " + AlunoName + " foi aprovada? " + PassouDeAno);
    }
}
