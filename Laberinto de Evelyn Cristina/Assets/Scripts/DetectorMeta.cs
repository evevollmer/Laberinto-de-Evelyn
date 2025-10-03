using UnityEngine;
using TMPro;

public class DetectorMeta : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaFinal;

    [SerializeField]
    TextMeshProUGUI textLabelTime;

    float tiempoDePartida = 0.0f;
    bool estaJugando = true;

    private void Update()
    {
        if(estaJugando == true)
        {
            tiempoDePartida = tiempoDePartida + Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            pantallaFinal.SetActive(true);
            other.GetComponent<MovimientoJugador>().enabled = false;
            other.GetComponent<Timer>().enabled = false;
            estaJugando = false;
            textLabelTime.text = tiempoDePartida.ToString();
        } 
    }
}
