using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables

    private Rigidbody2D rb; //only this script can change + use + access
    private Animator anim;
    

    // Start is called before the first frame update: baslangýc kodlari
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //sadece baslangicta bir kere cagirarak verim sagladik.
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame :kontrol kodlari
    private void Update()
    {
        //saga ve sola gitmesi icin hazir Horizontal
        float dirX = Input.GetAxisRaw("Horizontal"); // GetAxis -> GetAxisRaw: yurumeyi kestigin anda durur ilerlemez.
        rb.velocity = new Vector2(dirX * 7f,rb.velocity.y); //ziplarken yurursek mevcut y alir.

        //ziplama hazir Jump
        if (Input.GetButtonDown("Jump"))
        {
            //ctrl+k then ctrl+d : kodlari duzenler.
            rb.velocity = new Vector3(rb.velocity.x, 14f); //zipladigindaki koordinat farki : 3d olursa 3. bir degisken var
        }


        if (dirX > 0f) //saga giderken
        {
            anim.SetBool("run", true);
        }
        else if (dirX < 0f) //sola giderken
        {
            anim.SetBool("run", false);
        }
        else // dirX = 0
        {
            anim.SetBool("run", false);
        }
        

    }
}
