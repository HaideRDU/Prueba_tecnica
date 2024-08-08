using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    [SerializeField] private ControlData controlData;

    public GameObject normalBulletPrefab;
    public GameObject kinematicBulletPrefab;
    public GameObject specialBulletPrefab;

    public Transform firePoint;
    public Camera mainCamera;

    public GameObject arma1;
    public GameObject arma2;
    public GameObject arma3;

    private float balaV1;
    //private float balaV2;
    private float balaVp;

    private void Start()
    {
        //control vel_bala = FindObjectOfType<control>();
        //balaV1 = vel_bala.V_b_1;
        //balaV2 = vel_bala.V_b_2;      
        //balaVp = vel_bala.V_b_2;
        arma1.SetActive(false);
        arma2.SetActive(false);
        arma3.SetActive(false);

    }
    void Update()
    {
        //control vel_bala = FindObjectOfType<control>();
        balaV1 = controlData.V_bala;
        //balaV2 = vel_bala.V_b_2;      
        //balaV2 = vel_bala.V_b_2;
        balaVp = controlData.V_bala_p;

        if (Input.GetButtonDown("Fire1"))
        {
            if (arma1.activeSelf)
            {
                disparo1();
            } else if (arma2.activeSelf)
            {
                disparo2();
            } else if (arma3.activeSelf)
            {
                disparo3();
            }
            else
            {
                disparo0();
            }
            
        }

        if (coger_armas.NumArma == 1)
        {
                arma1.SetActive(true);
                arma2.SetActive(false);
                arma3.SetActive(false);           
        } else if (coger_armas.NumArma == 2)
        {
            arma1.SetActive(false);
            arma2.SetActive(true);
            arma3.SetActive(false);
        }
        else if (coger_armas.NumArma == 3)
        {
            arma1.SetActive(false);
            arma2.SetActive(false);
            arma3.SetActive(true);
        }
        else
        {

        }
    }

    void disparo0()
    {
        
    }
    void disparo1()
    {
        GameObject bullet = Instantiate(normalBulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = mainCamera.transform.forward * balaV1;
    }

    void disparo2()
    {
        GameObject bullet = Instantiate(kinematicBulletPrefab, firePoint.position, firePoint.rotation);
        mov_bala2 movBala = bullet.GetComponent<mov_bala2>();

        Vector3 cameraDirection = mainCamera.transform.forward;
        movBala.bala_2(cameraDirection);
    }

    void disparo3()
    {
        GameObject bullet = Instantiate(specialBulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = mainCamera.transform.forward * balaVp;
    }


}