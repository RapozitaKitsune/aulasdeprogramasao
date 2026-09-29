using JetBrains.Annotations;
using UnityEngine;

public class EnumStudy : MonoBehaviour
{
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
    enum RaioPlanetas
    {
        Mercurio = 2439,
        Venus = 6851,
        Terra = 6371,
        Marte = 3389,
        Jupiter = 69911,
        Saturno = 58232,
        Urano = 25362,
        Netuno = 24622
    }
    void Start()
    {
        Planetas CurrentPlaneta = Planetas.Venus;
        int index = (int)CurrentPlaneta;
        /*
        Debug.Log("Planeta: " + PlanetaName);
        Debug.Log(" O raio de " + PlanetaName + " é : " + PlanetaRaio + "km");
        
        Debug.Log(Planetas.Mercurio + " é o planeta numero " + (int)Planetas.Mercurio);
        Debug.Log(Planetas.Venus + " é o planeta numero " + (int)Planetas.Venus);
        Debug.Log(Planetas.Terra + " é o planeta numero " + (int)Planetas.Terra);
        Debug.Log(Planetas.Marte + " é o planeta numero " + (int)Planetas.Marte);
        Debug.Log(Planetas.Jupiter + " é o planeta numero " + (int)Planetas.Jupiter);
        Debug.Log(Planetas.Saturno + " é o planeta numero " + (int)Planetas.Saturno);
        Debug.Log(Planetas.Urano + " é o planeta numero " + (int)Planetas.Urano);
        Debug.Log(Planetas.Netuno + " é o planeta numero " + (int)Planetas.Netuno);
        */
        for(int i = 1; i <= 8; i++)
        {
            Debug.Log("Planeta: " + (Planetas)i);
        }
       
        switch (CurrentPlaneta)
        {
            case Planetas.Mercurio:
                Debug.Log("O foguete pousou em Mercurio");
                break;
            case Planetas.Venus:
                Debug.Log("O foguete pousou em Venus");
                break;
            case Planetas.Terra:
                Debug.Log("O foguete pousou na Terra");
                break;
            case Planetas.Marte:
                Debug.Log("O foguete pousou em Marte");
                break;
            case Planetas.Jupiter:
                Debug.Log("O planeta pousou em Jupiter");
                break;
            case Planetas.Saturno:
                Debug.Log("O foguete pousou em Saturno");
                break;
            case Planetas.Urano:
                Debug.Log("O foguete pousou em Urano");
                break;
            case Planetas.Netuno:
                Debug.Log("O foguete pousou em Netuno");
                break;

        }

    }

   
}
