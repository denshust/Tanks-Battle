using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 100f;
    public float gravityForce = 3000;

    public bool isMovingSoundPlaying;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Обнулення вертикальної складової для вектора руху вперед
        Vector3 forwardDirection = transform.forward;
        forwardDirection.y = 0;
        forwardDirection.Normalize();

        Vector3 moveDirection = forwardDirection * vertical * moveSpeed;


        if (moveDirection.magnitude > 0.1f && !isMovingSoundPlaying)
        {
            TankSoundManager.Instance.PlayMoveSound(true);
            isMovingSoundPlaying = true;
        }
        else if (moveDirection.magnitude < 0.1f && isMovingSoundPlaying)
        {
            TankSoundManager.Instance.PlayMoveSound(false);
            isMovingSoundPlaying = false;
        }

        rb.velocity = new Vector3(moveDirection.x, rb.velocity.y, moveDirection.z);

        if (horizontal != 0)
        {
            //rb.AddTorque
            transform.Rotate(Vector3.up, horizontal * rotateSpeed );
        }

        
        rb.AddForce(Vector3.down * gravityForce);
    }
}
