using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaPerdiste;

    public float timer = 0;

    public Text textoTimer;

    //public TextMeshProUGUI textoTimerPro;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        textoTimer.text= "" + timer.ToString("f0");

        //textoTimerPro.text = "" + timer.ToString("f0"); 

        

        if (timer < 0)
        {
            pantallaPerdiste.SetActive(true);
            GetComponent<MovimientoJugador>().enabled = false;


        }
    }
}
