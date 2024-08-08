using UnityEngine;

[CreateAssetMenu(fileName = "NewControlData", menuName = "Control/ControlData")]
public class ControlData : ScriptableObject
{
    public float V_bala = 28f;
    public float V_bala_2 = 8f;
    public float V_bala_p = 30f;

    public int tiempoDespawn_bala = 7;
    

    public float fuerzaGravitacional = 75.0f;
    public float radioGrabitacional = 20.0f;

    public float tiempoRepulsion = 0.5f;
    public float fuerzaRepulsion = 200.0f;
    public float radioRepulsion = 15.0f;

    public float tiempoAtraccion = 4.0f;
    public float fuerzaAtraccion = 200.0f;
    public float radioAtraccion = 20.0f;
}
