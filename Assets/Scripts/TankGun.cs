using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankGun : MonoBehaviour
{
    public float shootPower = 10;
    public float shootDamage = 50;

    [SerializeField] private Transform shootPoint;
    [SerializeField] public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Shoot();
        }
    }

    void Shoot()
    {

        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);

        bullet.GetComponent<Damager>().damage = shootDamage;

        TankSoundManager.Instance.PlayShootSound();

        bullet.GetComponent<Rigidbody>().AddForce(shootPoint.forward * shootPower + shootPoint.forward * GetComponentInParent<Rigidbody>().velocity.z, ForceMode.Impulse);
        Destroy(bullet, 20);
    }
}
