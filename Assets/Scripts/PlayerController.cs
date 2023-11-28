using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables
    //private float speed = 5.0f;
    [SerializeField] private float horsePower = 0;
    private float turnSpeed = 20;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRb;
    [SerializeField] GameObject centerOfMass;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //move the vehicle
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //move forward and backward
        // transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
        //turn left and right
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
