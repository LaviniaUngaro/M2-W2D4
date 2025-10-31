using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio1 : MonoBehaviour
{
    public int index;
    public int num;

    // Start is called before the first frame update
    void Start()
    {
        while (index > 0)
        {
            Debug.Log(num);
            num++;
            index--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
