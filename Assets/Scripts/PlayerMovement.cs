using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables
    private Rigidbody2D rb; //only this script can change + use + access
    private Animator anim;
    private SpriteRenderer sprite; //karakterimizin yururken diger tarafa donmesi icin.
    private BoxCollider2D coll; // kutulari algilayip ziplamayi engellemek icin.

    [SerializeField] private LayerMask jumpableGround; //ziplanabilir yerler icin.

    private float dirX = 0f;
    
    [SerializeField] private float moveSpeed = 7f; //SerializeField : Unity de bu degerleri gorebilmemizi saglar.
    [SerializeField] private float jumpForce = 14f;
    // public float deneme = 15; // bu sekilde de Unity de gorulebilirdi. SerializeField -> daha guvenli.

    private enum MovementState { Idle, Run, Jump, Fall } // idle:0,run:1,jump:2,fall:3

    [SerializeField] private AudioSource jumpsoundEffect;


    // Start is called before the first frame update: baslangýc kodlari
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //sadece baslangicta bir kere cagirarak verim sagladik.
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame :kontrol kodlari
    private void Update()
    {
        //saga ve sola gitmesi icin hazir Horizontal
        dirX = Input.GetAxisRaw("Horizontal"); // GetAxis -> GetAxisRaw: yurumeyi kestigin anda durur ilerlemez.
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y); //ziplarken yurursek mevcut y alir.

        //ziplama hazir Jump
        if (Input.GetButtonDown("Jump") && IsGrounded() ) //jump + ziplanabilir yer
        {
            //ctrl+k then ctrl+d : kodlari duzenler.
            rb.velocity = new Vector3(rb.velocity.x, jumpForce); //zipladigindaki koordinat farki : 3d olursa 3. bir degisken var
            jumpsoundEffect.Play(); //zipladiginda ses cikar.
        }

        UpdateAnimationUpdate(); // duzenli olmasý icin fonksiyona yazdik.
    }

    private void UpdateAnimationUpdate() //animasyon kontrolu
    {
        MovementState state;

        if (dirX > 0f) //saga giderken
        {
            state = MovementState.Run;
            sprite.flipX = false; // tekrar saga donmesi icin
        }
        else if (dirX < 0f) //sola giderken
        {
            state = MovementState.Run;
            sprite.flipX = true; // karakterin yuzunu sola cevirir.
        }
        else // dirX = 0
        {
            state = MovementState.Idle; //idle
        }

        if(rb.velocity.y > .1f) // y buyuyorsa jump
        {
            state = MovementState.Jump;
        } 
        else if(rb.velocity.y < -.1f) // y kuculuyorsa fall
        {
            state = MovementState.Fall;
        }

        anim.SetInteger("state",(int)state);

    }

    //Bir carpisma var mi kontrol eder ve ona gore ziplamayi yapar.
    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f,jumpableGround);
            //coll.bounds-> karakteri cevreleyen bir kare olusturmak icin (2. bir kutu)
            //0f 

            
    }




}
