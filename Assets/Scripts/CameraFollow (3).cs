using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Transform target;
    public float translateSpeed;
    public float rotateSpeed;
    private Vector3 newoffset;

    private void Start()
    {
        //offset = transform.position - target.position;
    }

    private void FixedUpdate()
    {
        HandleRotation();
        HandleTranslation();
    }

    private void HandleTranslation()
    {
        if (Input.GetAxis("Vertical") < 0)
        { 
           //newoffset = new Vector3(offset.x, offset.y, 5);
        }
        else
            newoffset = offset;
        var targetPosition = target.TransformPoint(newoffset);
        transform.position = Vector3.Lerp(transform.position, targetPosition, translateSpeed * Time.deltaTime);
    }
    private void HandleRotation()
    {
        var direction = target.position - transform.position;
        var rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotateSpeed * Time.deltaTime);
    }
}
