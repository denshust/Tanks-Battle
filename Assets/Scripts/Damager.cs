using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{
    public float damage;


    private void OnCollisionEnter(Collision collision)
    {
        //HealthSystem healthSystem = collision.gameObject.GetComponent<HealthSystem>();

        if (collision.gameObject.TryGetComponent<HealthSystem>(out HealthSystem hp))
        {
            hp.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
