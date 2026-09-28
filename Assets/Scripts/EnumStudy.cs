using UnityEngine;

public class EnumStudy : MonoBehaviour
{
    enum Planetas
    {
        Mercurio,
        Terra,
        Marte,
        Venus,
        Jupiter,
        Saturno,
        Urano,
        Netuno
    }
    void Start()
    {
        Debug.Log(Planetas.Terra + " é um planeta");
    }

   
}
