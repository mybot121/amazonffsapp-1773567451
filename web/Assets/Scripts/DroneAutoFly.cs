
using UnityEngine;

public class DroneAutoFly : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate(0,20 * Time.deltaTime,0);
    }
}
