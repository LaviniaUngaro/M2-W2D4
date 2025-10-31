using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    [SerializeField] int[] array = new int[4];
    int somma;
    int prodotto = 1;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < array.Length; i++)
        {
            somma = somma + array[i];
            prodotto = prodotto * array[i];
        }
        Debug.Log(somma);   
        Debug.Log(prodotto);
    }

    // Update is called once per frame
    void Update()
    {

    }
}