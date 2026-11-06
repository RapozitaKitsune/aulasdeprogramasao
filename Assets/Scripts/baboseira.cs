using UnityEngine;

public class baboseira : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool Meupai = true;
        bool Eu = true;
        bool Coroa = true;
        bool Novinha = false;

        if (Meupai && Eu) 
        {
            Debug.Log("Meu pai é foda e eu sou fodinha");
        }
        if (Meupai && Eu && Coroa && Novinha)
        {
            Debug.Log("Meu pai pega as coroa e eu pego as novinha");
        }
        else if (Meupai && Eu && Coroa)
        {
            Debug.Log ("Meu pai pega as coroa e eu tenho esquizofrenia");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
