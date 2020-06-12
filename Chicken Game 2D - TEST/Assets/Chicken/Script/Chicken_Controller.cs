using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Chicken_Controller : MonoBehaviour
{
    public float Vertical, Horizontal;
    Animator anim;


    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()

    {
        Vertical = Input.GetAxis("Vertical");
        Horizontal = Input.GetAxis("Horizontal");
        Debug.Log(Vertical);
        Debug.Log(Horizontal);  

        if (Vertical > 0)
        {
            anim.SetBool("Up", true);
            anim.SetBool("Down", false);
        }
        else if(Vertical < 0)
        {
            anim.SetBool("Up", false);
            anim.SetBool("Down", true);
        }
        else
        {
            anim.SetBool("Up", false);
            anim.SetBool("Down", false);
        }

        if (Horizontal > 0)
        {
            anim.SetBool("Right", true);
            anim.SetBool("Left", false);
        }
        else if(Horizontal < 0)
        {
            anim.SetBool("Right", false);
            anim.SetBool("Left", true);
        }
        else
        {
            anim.SetBool("Right", false);
            anim.SetBool("Left", false);
        }
    }
}
