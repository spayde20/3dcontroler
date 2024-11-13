using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Controler3d : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float jumpFofce;
    [SerializeField] private KeyCode jumpKey;

    private Rigidbody _rd;

    private void Awake()
    {
        _rd = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float moveForward = Input.GetAxis("Vertical");
        float rotate = Input.GetAxis("Horizontal");

        Move(moveForward);
        Rotate(rotate);

        if (Input.GetKeyDown(jumpKey))
        {
            Jump();
        }
    }

    private void Move(float value)
    {
        _rd.velocity =
         new Vector3(0, _rd.velocity.y, value * moveSpeed);

        _rd.velocity = transform.forward * moveSpeed * value;
    }

    private void Jump()
    {
        _rd.AddForce(Vector3.up * jumpFofce, ForceMode.Impulse);
    }

    private void Rotate(float value)
    {
        //TOOO rotate rigidbody or transform with value
        transform.Rotate(Vector3.up, value * rotationSpeed);
    }

}
