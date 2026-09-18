using UnityEngine;

public class Variables : MonoBehaviour
{

    enum Itens { Espada, Escudo, Pocao, Luva, Armadura, Bota };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Itens currentItem = Itens.Bota;
        int index = (int)currentItem;

        if(currentItem == Itens.Espada)
        {
            Debug.Log("Personagem usa espada");
        }
        else if (currentItem == Itens.Escudo)
        {
            Debug.Log("Personagem usa escudo");
        }
        else if (currentItem == Itens.Armadura)
        {
            Debug.Log("Personagem usa armadura");
        }

        char teste = 'a';
        switch (teste)
        {
            case 'a':
                {
                    string nomePersonagem = "Cesar";
                    Debug.Log("Personagem " + nomePersonagem + " usa Espada");
                }
                break;
            case 'b':
            case 'c':
            case 'd':
                Debug.Log("Agora b, c e d possuem o mesmo código!!!"); 
                break;
            case 'e':
                Debug.Log("Personagem usa Armadura");
                break;
            case 'f':
                Debug.Log("Personagem usa Bota");
                break;
            default:
                break;
        }





        int myNumber;
        float myDecimal;
        double myDouble = 1.5;
        bool myBool;
        string myString;
        char myChar;

        myNumber = 10;


        string characterName = "Josezinho do Gral";
        int characterHitPoint = 10;
        float jumpHeight = 1.75f;
        int characterStregth = 50;
        char characterSex = 'm';
        bool isHurt = false;

        int temp = characterHitPoint + characterStregth;
        //int tempsub = characterStregth - 1;

        //characterHitPoint += 2;
        //characterHitPoint = characterHitPoint + 2;
        
        //Debug.Log("Valor sem operador: " + characterHitPoint);


        //Debug.Log("Valor com operador antes: " + ++characterHitPoint);
        //Debug.Log("Valor com operador depois: " + characterHitPoint++);
        //Debug.Log("Valor sem alterar nada: " + characterHitPoint);

        string catastrofeName = "Camila ";

        //bool eh_igual = characterHitPoint < characterStregth;

        // Para passar de ano, a media deve ser igual ou superior a 5
        // E a presenca superior a 75%
        int catastrofeNota = 7;
        float catastrofePresenca = 35f;

        bool passou_de_ano = catastrofeNota >= 5 || catastrofePresenca >= 75;

        Debug.Log(catastrofeName + "Passou de ano? " + passou_de_ano);

        string inventorySlot1 = "Espada";
        string inventorySlot2 = "Escudo";
        string inventorySlot3 = "Armadura";
        string inventorySlot4 = "Tocha";
        string inventorySlot5 = "Botas";
        string inventorySlot6 = "Poção de Cura";
        string inventorySlot7 = "Poção de Cura";
        string inventorySlot8 = "Luvas";

        inventorySlot1 = "Escudo";
        inventorySlot2 = "Espada";


        string[] inventorySlot = new string[10];
        inventorySlot[0] = "Fim do Mundo";

        int size = inventorySlot.Length;

        char[] meuNomeBruto = new char[5];

        string meuNome = "Cesar";
        char letra = meuNome[1];


        /*
         gfdgdfgdfg
        gdfgdfgdfgdf
         gdfgfdgdfgdfg
        gfdgdfgdfgd
         */

        int aleatorio = Random.Range(0, 15);
        float aleatorio2 = Random.Range(0.0f, 15.0f);
        

        string[] inventario = { "Espada", "Escudo", "Armadura", "Luva", "Bota", 
                               "Elmo", "Pocao", "Adaga", "Kit Medico", "Livro" };

        Random.Range(0, inventario.Length);


        for (int i = 0; i < inventario.Length; i++)
        {
            if(inventario[i] == "Armadura de Prata")
            {
                Debug.Log("Este inventario possui um arma mitica!!!");
                break;
            }
            //Debug.Log(inventario[i]);
        }





    }
}
