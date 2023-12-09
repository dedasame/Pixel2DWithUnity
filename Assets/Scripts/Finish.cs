using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Sahne ayarlarinda kullaniyoruz.


public class Finish : MonoBehaviour
{
    private AudioSource finishsoundEffect; //yalnizca 1 tane ses efektimiz old. icin serializefield yapmadik?
    private bool levelcompleted  = false;

    private void Start()
    {
        finishsoundEffect = GetComponent<AudioSource>(); //tek ses efekti old icin get comp. ile aldik.

    }

    //boxcolliderimizi trigger olarak isaretledigimiz icin:

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelcompleted) //player isimli nesne etkilesime gecerse
        {
            finishsoundEffect.Play(); //finish sesini cal
            levelcompleted = true; // tekrar tekrar sesi caldirmasini engeller.
            Invoke("CompleteLevel", 2f); // 2s delay ekleyerek fonk. cagirir.          

        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //var olan levelin buildindex'ini +1 level atlatmak
        //son level icin ozel bir bitis sahnesi daha olusturmak gerekli.



    }


}
