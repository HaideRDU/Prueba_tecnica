using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_bala2 : MonoBehaviour
{
    [SerializeField] private ControlData controlData;

    private Vector3 direction;

    private float balaV2;

    private void Start()
    {
        //control vel_bala = FindObjectOfType<control>();
        balaV2 = controlData.V_bala_2;

    }
    public void bala_2(Vector3 initialDirection)
    {
        direction = initialDirection.normalized;
    }

    void Update()
    {
       
        transform.Translate(direction * balaV2 * Time.deltaTime, Space.World); 
    }
}
