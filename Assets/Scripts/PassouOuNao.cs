using UnityEngine;

public class FinalGrade : MonoBehaviour
{
    void Start()
    {
        float PresensaAluno = 67f;
        int NotaAtividade1 = 8;
        int NotaAtividade2 = 6;
        int NotaAtividade3 = 5;
        float MediaFinal = (NotaAtividade1 + NotaAtividade2 + NotaAtividade3) / 3f;
        float PresensaFinal = 75f;
        bool PassouDeAno = MediaFinal >= 5 && PresensaAluno > 75;

        Debug.Log("O aluno passou de ano?" + PassouDeAno);
    }
}
     