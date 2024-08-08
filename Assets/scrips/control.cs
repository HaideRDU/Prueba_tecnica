using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    [SerializeField] private float V_bala = 20f;
    [SerializeField] private float V_bala_2 = 20f;
    [SerializeField] private float V_bala_p = 20f;

    [SerializeField] private float fuerzaGravitacional = 50.0f;
    [SerializeField] private float radioGrabitacional = 20.0f;

    [SerializeField] private float fuerzaRepulsion = 50.0f;
    [SerializeField] private float radioRepulsion = 20.0f;

    [SerializeField] private float fuerzaAtraccion = 50.0f;
    [SerializeField] private float radioAtraccion = 20.0f;

    public float V_b_1
    {
        get { return V_bala; }
        set { V_bala = value; }
    }

    public float V_b_2
    {
        get { return V_bala_2; }
        set { V_bala_2 = value; }
    }

    public float V_b_p
    {
        get { return V_bala_p; }
        set { V_bala_p = value; }
    }

    public float fuerzaG
    {
        get { return fuerzaGravitacional; }
        set { fuerzaGravitacional = value; }
    }

    public float radioG
    {
        get { return radioGrabitacional; }
        set { radioGrabitacional = value; }
    }

    public float fuerzaR
    {
        get { return fuerzaRepulsion; }
        set { fuerzaRepulsion = value; }
    }

    public float radioR
    {
        get { return radioRepulsion; }
        set { radioRepulsion = value; }
    }

    public float fuerzaA
    {
        get { return fuerzaAtraccion; }
        set { fuerzaAtraccion = value; }
    }

    public float radioA
    {
        get { return radioAtraccion; }
        set { radioAtraccion = value; }
    }
}