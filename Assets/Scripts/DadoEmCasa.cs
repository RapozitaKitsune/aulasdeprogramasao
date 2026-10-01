using UnityEngine;

public class Random : MonoBehaviour
{
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
     int RandNum1 = UnityEngine.Random.Range(1,7);
     int RandNum2 = UnityEngine.Random.Range(1, 7);
     int RandNum3 = UnityEngine.Random.Range(1, 7);
     int TotalRand = RandNum1 + RandNum2 + RandNum3;
     float MediaRand = (RandNum1 + RandNum2 + RandNum3) / 3f;

      Debug.Log("Numeros: " + RandNum1 + ", " + RandNum2 + " e " + RandNum3);
      Debug.Log("Soma: " + TotalRand);
      Debug.Log("Média: " + MediaRand.ToString("F2"));
    }   
}
