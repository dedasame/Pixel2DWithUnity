using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{

    //OnCollisionEnter2D:  bir nesne bir nesneyle etkilesime girerse tetiklenir.
    //OnTriggerEnter2D: bir nesne bir nesnenin icine girerse tetiklenir.
    //Player Platformun ustune ciktigi zaman hareket etsin diye. Ustune cikinca platformun icinde bir nesne olarak gozukuyor!!

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);
        }

    }

    private void OnTriggerExit2D (Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }


    

}
