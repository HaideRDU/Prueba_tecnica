using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class seleccion_personaje : MonoBehaviour
{

    #region Variables

    public Animator animator;
    static public int anim = 0;

    #endregion

    
    #region Botones
    public void Anim1()
    {
        animator.SetFloat("anim",0f);
        anim = 1;
    }

    public void Anim2()
    {
        animator.SetFloat("anim", 0.5f);
        anim = 2;
    }

    public void Anim3()
    {
        animator.SetFloat("anim", 1f);
        anim = 3;
    }

    public void NextEscene()
    {
        if(anim == 1)
        {
            SceneManager.LoadScene("inicio");
        } else if(anim == 2)
        {
            SceneManager.LoadScene("inicio");
        } else if (anim == 3) 
        {
            SceneManager.LoadScene("inicio");
        }else{

        }
    }

    #endregion
}
