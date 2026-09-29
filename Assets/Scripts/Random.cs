using UnityEngine;

public class Random : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = UnityEngine.Random.Range(1, 7);

        Debug.Log(num);

    }
}
