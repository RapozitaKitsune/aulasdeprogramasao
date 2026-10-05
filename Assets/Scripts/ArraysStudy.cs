using UnityEngine;

public class ArraysStudy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] numbers = new int[1000];
        /*
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        Debug.Log(numbers[0]);
        Debug.Log(numbers[1]);
        Debug.Log(numbers[2]);
        

        // Um array pode ser feito com qualquer tipo de dado, a variável define o tipo de dado que será armazenado no array.
        // For loop é o jeito mais prático de percorrer e  exibir todos os valores de um array sem precisar atribui-los individualmente

    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i * 10;
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }
        */
        string[] Animais =  {"gato", "cachorro", "raposa", "cavalo", "coelho", "peixe", "urso", "veado", "onca", "lobo", "aguia", "girafa", "zebra", "leao","leopardo", "foca", "cobra", "ovelha", "cabra", "galinha", "papagaio", "pato" };
      for(int i = 0; i < Animais.Length; i++) 
        {
            Debug.Log(Animais[i]);
        }
    }

}
