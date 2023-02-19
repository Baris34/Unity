using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class İfelse : MonoBehaviour
{
    /* karşılaştırma operatörleri
     
        < küçükse
        > büyükse
        >= büyükse ve eşitse
        <= küçükse ve eşitse
        == eşitse
        != eşit değilse

     */
    int sayi1 = 5;
    int sayi2= 10;
    int sayi3= 3;  


    void Start()
    {
        if (sayi1>sayi2)
        {
            Debug.Log("1.kosul");
        }
        else if (sayi1>sayi3)
        {
            Debug.Log("2.kosul");
        }
        else
        {
            Debug.Log("Hayır değil");
        }



        /*if (kosul)
        {
            // bu koşul sağlanırsa burası çalışır
        }
        else if (kosul2)
        {

        }
        else
        {
            // koşul sağlanmazsa burası çalışır
        }
        */

    }

}
