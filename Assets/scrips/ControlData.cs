using UnityEngine;

[CreateAssetMenu(fileName = "NewControlData", menuName = "Control/ControlData")]
public class ControlData : ScriptableObject
{
    public float V_bala = 20f;
    public float V_bala_2 = 20f;
    public float V_bala_p = 20f;

    public int tiempoDespawn_bala = 7;
    

    public float fuerzaGravitacional = 50.0f;
    public float radioGrabitacional = 20.0f;

    public float tiempoRepulsion = 0.5f;
    public float fuerzaRepulsion = 50.0f;
    public float radioRepulsion = 20.0f;

    public float tiempoAtraccion = 4.0f;
    public float fuerzaAtraccion = 50.0f;
    public float radioAtraccion = 20.0f;
}