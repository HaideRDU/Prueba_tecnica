using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bala_3 : MonoBehaviour
{
    [SerializeField] private ControlData controlData;

    Rigidbody rb;
    Collider acollider;
    public atraccion atraccion;
    public repulsion repulsion;
    
    private void Start()
    {
        acollider = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
        atraccion = GetComponent<atraccion>();
        repulsion = GetComponent<repulsion>();
        
    }

    public void OnTriggerEnter(Collider other)
    {
        rb.isKinematic = true;
        StartCoroutine(Inicio());
    }
    IEnumerator Inicio()
    {
        acollider.isTrigger = false;
        atraccion.enabled = !atraccion.enabled;
        
        yield return new  WaitForSeconds(controlData.tiempoAtraccion);
        
        StartCoroutine(FInal());
    }

    IEnumerator FInal()
    {
        atraccion.enabled = !atraccion.enabled;
        repulsion.enabled = !repulsion.enabled;
        yield return new WaitForSeconds(controlData.tiempoRepulsion);
        Destroy(gameObject);
    }
}
