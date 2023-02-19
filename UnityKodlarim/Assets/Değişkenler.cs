using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Değişkenler : MonoBehaviour
{
    /*
     string //metinsel verileri içerir.
     int    // sayısal değerleri
     float  // kayan sayılar 3.10
     double // daha büyük kayan sayılar 3.214141
     Boolean// herhangi bir şeyi aktif veya pasif olmasını kontrol eder. true/false
     */

    /*
        // class içerisinde değer tanımlama
    string metnim = "Merhaba Unity";
    int yas = 80;
    float kusurat = 3.10f;
    double kusurat2 = 3.2120;
    bool acikmi = false; 
        // class içerisinde değer tanımlama
    */

    // sadece değişkenlerin isimlerini ve türlerini belirledim.
    string metnim;
    int yas;
    float kusurat;
    double kusurat2;
    bool acikmi;
    // sadece değişkenlerin isimlerini ve türlerini belirledim.
    void Start()
    {
        //işlemler yaptım sorgular yaptım ve değişkenin değeri şu an oluştu
        metnim = "içeriden";


        Debug.Log(metnim);
        Debug.Log(yas);
        Debug.Log(kusurat);
        Debug.Log(kusurat2);
        Debug.Log(acikmi);
    }

    
}
