using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Tank Data", menuName = "Custom/Tank Data")]
public class TankData : ScriptableObject
{
    public float moveSpeed = 50;
    public float rotateSpeed = 1;
    public float minAngle = -45;
    public float maxAngle = 45;
    public float shootPower = 200;
    public float shootDamage = 50;
    public GameObject bulletPrefab;
    public Mesh bodyMesh;
    public Mesh headMesh;
    public Vector3 scale = new Vector3(10,10,10);
}
