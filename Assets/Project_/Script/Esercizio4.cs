using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    [SerializeField] int startNumber;
    [SerializeField] int amount;

    // Start is called before the first frame update
    void Start()
    {
        while (amount >= 0)
        {
            Debug.Log(startNumber);
            startNumber++;
            amount--;
        }

        /* for (int i=0; i <=amount; i++)
        {
            int number = startNumber + i;
            Debug.Log(number);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {

    }
}
 // stampa a schermo numero di partenza e tanti numeri successivi in base ad amount
 // es. se start=5 e amount=3 dovrà stampare 5,6,7,8