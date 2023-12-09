using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    private int strawberries = 0;

    [SerializeField] private Text strawberriesText;
    [SerializeField] private AudioSource collectsoundEffect;

    //Item -> Is Trigger olarak ayarlandi
    private void OnTriggerEnter2D(Collider2D collision) //**method overriding
    {   
        //controlling the item tag 
        if(collision.gameObject.CompareTag("Strawberry"))
        {
            Destroy(collision.gameObject);//alinan itemi siler
            strawberries++; //topladigimiz cilek sayisini 1 arttirir.
            strawberriesText.text = "Strawberries: " + strawberries; // Ekranda toplanilan cilek sayisini gostermek icin.
            collectsoundEffect.Play();
            //Debug.Log("Cilek: " + strawberries);
        }

        //!* Prefabs: nesneleri hizli cogaltma. Nesneyi soldan assets klasorune dogru surukleyerek prefabs olusur.
        //Olusan prefab -> ekrana surukleriz.


        //Google Fonts-> Font dosyamizi ayikladiktan sonra assets icindeki fonts klasorune atarak kullanabiliriz.


    }


}
