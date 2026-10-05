using UnityEngine;

public class PassouOuNao : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // essa variável diz o nome do aluno
        string AlunoName = "Maria Flor";
        // essa variável diz qual a porcentagem depresença do aluno
        float PresensaAluno = 67f;
        // essas 3 variáveis são as notas que ele tirou em cada atividade
        int NotaAtividade1 = 8;
        int NotaAtivide2 = 6;
        int NotaAtividade3 = 5;
        // essa variável calcula a média final do aluno com base nas atividades das 3 notas
        float MediaFinal = (NotaAtividade1 + NotaAtivide2 + NotaAtividade3) / 3f;
        // essa variável diz qual a porcentagem de presença necessária para aprovação
        float PresensaFinal = 75f;
        //essa variável calcula se o aluno cumpre os requisitos para ser aprovado
        bool PassouDeAno = MediaFinal >= 5 && PresensaAluno > PresensaFinal;

        Debug.Log("A aluna " + AlunoName + " passou de ano? " + PassouDeAno);
    }
}
     