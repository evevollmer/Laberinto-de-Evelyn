using UnityEngine;

public class Rotador : MonoBehaviour
{
    [SerializeField]
    float rotacionY = 20f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotacionY * Time.deltaTime, 0.0f, 0.0f);
    }
}
