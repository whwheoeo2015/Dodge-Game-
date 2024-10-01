using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRigidbody;
    public float speed = 8f;

    void Start() {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update() {
        // assign input values of X and Z direction
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // assign the calculation of X direction and Z direction
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // creating Vectir3 soeed
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

        // Assign to platerRigidBody with newVelocity
        playerRigidbody.velocity = newVelocity;
    }

    public void Die(){
        gameObject.SetActive(false);

        GameManager gameManager = FindObjectOfType<GameManager>();

        gameManager.EndGame();
    }
}
