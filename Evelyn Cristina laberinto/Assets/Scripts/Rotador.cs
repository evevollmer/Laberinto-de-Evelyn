using UnityEngine;

public class Rotador : MonoBehaviour
{
    [SerializeField]
    float rotacionY = 10f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, rotacionY * Time.deltaTime, 0.0f, Space.World);
       // transform.Rotate(0.0f,rotacionY * Time.deltaTime, 0.0f);
        
    }
}
