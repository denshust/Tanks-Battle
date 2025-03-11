using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankVariationController : MonoBehaviour
{
    //public float moveSpeed = 50;
    //public float rotateSpeed = 1;
    //public float minAngle = -45;
    //public float maxAngle = 45;
    //public float shootPower = 200;
    //public float shootDamage = 50;
    //public GameObject bulletPrefab;
    //public Mesh bodyMesh;
    //public Mesh headMesh;
    //public Vector3 scale = new Vector3(10, 10, 10);

    public TankData[] tankDatas;

    private TankMovement tankMovement;
    private TankTurretController tankTurretController;
    private TankGun tankGun;
    private MeshFilter tankBodyMeshFilter;
    private MeshFilter tankHeadMeshFilter;

    private int tankIndex;
    //private Transform transform;

    void Start()
    {
        InitializeComponents();
        SetComponentsData();
    }

    public void InitializeComponents()
    {
        tankMovement = GetComponent<TankMovement>();
        tankTurretController = GetComponentInChildren<TankTurretController>();
        tankGun = GetComponentInChildren<TankGun>();
        tankBodyMeshFilter = GetComponent<MeshFilter>();
        tankHeadMeshFilter = transform.GetChild(0).GetComponent<MeshFilter>();
    }
    public void SetComponentsData()
    {
        TankData tankData = tankDatas[tankIndex];

        tankMovement.moveSpeed = tankData.moveSpeed;
        tankMovement.rotateSpeed = tankData.rotateSpeed;

        tankTurretController.minRotationAngle = tankData.minAngle;
        tankTurretController.maxRotationAngle = tankData.maxAngle;

        tankGun.shootPower = tankData.shootPower;
        tankGun.shootDamage = tankData.shootDamage;
        tankGun.bulletPrefab = tankData.bulletPrefab;

        tankBodyMeshFilter.mesh = tankData.bodyMesh;
        tankHeadMeshFilter.mesh = tankData.headMesh;

        transform.localScale = tankData.scale;

        tankIndex++;
        if (tankIndex >= tankDatas.Length)
        {
            tankIndex = 0;
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            SetComponentsData();
        }
    }
}
