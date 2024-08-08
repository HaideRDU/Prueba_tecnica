using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coger_armas : MonoBehaviour
{
    public static coger_armas arma;

    public GameObject letrero;

    static public int NumArma;
    private void Start()
    {
        letrero.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            letrero.SetActive(true);
            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (this.CompareTag("arma1"))
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    NumArma = 1;
                }
            }

            if (this.CompareTag("arma2"))
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    NumArma = 2;
                }
            }

            if (this.CompareTag("arma3"))
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    NumArma = 3;
                }
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            letrero.SetActive(false);

            
        }


    }

    
}
