using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSphereMovement : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 pVelocity;
    public float playerSpeed = 1f;
    public float gravity = -9.81f;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            controller.Move(pVelocity * Time.deltaTime);
            pVelocity.y = 0f;
        }  
    }

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    private void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if(move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        pVelocity.y += gravity * Time.deltaTime;
        controller.Move(pVelocity * Time.deltaTime);
    }
}
