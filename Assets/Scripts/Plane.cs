using UnityEngine;

public class Plane : MonoBehaviour
{
    public float speed = 10f; // Ўвидк≥сть л≥така

    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
