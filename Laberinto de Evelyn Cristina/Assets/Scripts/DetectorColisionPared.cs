using UnityEngine;

public class DetectorColisionPared : MonoBehaviour
{
    [SerializeField]
    Material materialParedPordDefecto;

    [SerializeField]
    Material materialParedTocada;

    bool paredRoja = false;

    float tiempoEnRojo = 5f;

    //funcion que se ejecuta por cada fotograma del juego 

    private void Update()
    {
        if(paredRoja == true)
        {
            tiempoEnRojo = tiempoEnRojo - Time.deltaTime;
            if(tiempoEnRojo < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = materialParedPordDefecto;
            paredRoja = false;
            tiempoEnRojo = 5f;
            }
        }
    }

    //funcion que se ejecuta al chocar un objeto con este GameObject.

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player") 
        {
            gameObject.GetComponent<MeshRenderer>().material = materialParedTocada;
            paredRoja = true;
        }   
    } 
}
