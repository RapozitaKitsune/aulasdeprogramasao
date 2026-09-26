using UnityEngine;

public class VariablesCarol : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string CharacterName;
        int CharacterLife;
        float JumpHeight;
        int CharacterStrength;
        char CharacterSex;
        bool CharacterAlive;

        CharacterName = "Rapozita";
        CharacterLife = 10;
        JumpHeight = 7.0f;
        CharacterStrength = 50;
        CharacterSex = 'f';
        CharacterAlive = false;


        // int temp = CharacterStrength - CharacterLife;

        //Debug.Log(temp.ToString());
        Debug.Log("Valor sem operador: " + CharacterLife);
        Debug.Log("Valor com operador antes: " + ++CharacterLife);
        Debug.Log("Valor com operador depois: " + CharacterLife++);
        string[] InventorySlot string[10];
        InventorySlot[1] = "Pombo";
        InventorySlot[2] = "Cartola";


    }
}
