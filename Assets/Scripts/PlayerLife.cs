using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // leveli tekrar baslatmak icin gerekli


public class PlayerLife : MonoBehaviour
{
    private Animator anim; // state durumlarini ayarlamak icin gerekli.
    private Rigidbody2D rb; //oldukten sonra haraket edemesin diye.

    [SerializeField] private AudioSource deathsoundEffect;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //collision yapilan obje tag-> Trap ise: 
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die(); //Trap degdiyse karakteri oldurecek.
            
        }
    }

    private void Die()
    {
        deathsoundEffect.Play();
        //animator kisminde trigger tipinde ayarlanan degiskenimsi sey
        anim.SetTrigger("death"); //karakterimizi animasyonunu death e cevirdi.
        rb.bodyType = RigidbodyType2D.Static; // player-> static ayarlayarak haraket etmesini engeller.

    }


    private void RestartLevel() //leveli bastan baslatmak icin.
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //var olan leveli tekrar baslatir.
    }
    //diger ayarlamalar: olum animasyonunun kayýt tusu -> bir sure ilerisine restart func. select.



}
