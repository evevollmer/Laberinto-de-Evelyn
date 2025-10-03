using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjZ;

    public float velocidadDeMovimiento = 2f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        movimientoEjeX =  Input.GetAxis("Horizontal") * Time.deltaTime * velocidadDeMovimiento;
        movimientoEjZ =  Input.GetAxis("Vertical") * Time.deltaTime * velocidadDeMovimiento;
        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjZ);
    }
}
