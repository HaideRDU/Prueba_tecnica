using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_anim : MonoBehaviour
{

    public Animator animator;

    void Start()
    {
       if (seleccion_personaje.anim == 1)
        {
            animator.SetFloat("anim", 0f);
        } else if(seleccion_personaje.anim  == 2) 
        {
            animator.SetFloat("anim", 0.5f);
        }
        else if (seleccion_personaje.anim == 3)
        {
            animator.SetFloat("anim", 1f);
        } else
        {
            animator.SetFloat("anim", 1.5f);
        }

    }

}
