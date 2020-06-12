using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    Animator anim;
        public float speed = 4f;

    public float Vertical, Horizontal;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        Vertical = Input.GetAxis("Vertical");
        Horizontal = Input.GetAxis("Horizontal");

        if(Vertical > 0)
        {
            anim.SetBool("up", true);
            anim.SetBool("down", false);
        }
        else if(Vertical<0){
            anim.SetBool("up", false);
            anim.SetBool("down", true);
        }
        else
        {
            anim.SetBool("up", false);
            anim.SetBool("down", false);
        }

        if (Horizontal > 0)
        {
            anim.SetBool("right", true);
            anim.SetBool("left", false);
        }
        else if (Horizontal < 0)
        {
            anim.SetBool("right", false);
            anim.SetBool("left", true);
        }
        else
        {
            anim.SetBool("right", false);
            anim.SetBool("left", false);
        }


    }
    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.fixedDeltaTime * Vertical);
        transform.Translate(Vector2.right * speed * Time.fixedDeltaTime * Horizontal);


    }
}
