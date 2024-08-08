using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida_balas : MonoBehaviour
{
    [SerializeField] private ControlData controlData;

    private int vida = 0;

    void Start()
    {
        StartCoroutine(Contar());
    }

    IEnumerator Contar()
    {
        while (vida <= controlData.tiempoDespawn_bala)
        {
            Debug.Log(vida);
            vida++;
            
            yield return new WaitForSeconds(1);
        }
        Destroy(gameObject);
    }
}
