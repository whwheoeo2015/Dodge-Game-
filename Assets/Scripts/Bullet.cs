using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidbody;

    // Start is called before the first frame update
    void Start()
    {   
        //Assign Rigidbody to bulletRigidbody
        bulletRigidbody = GetComponent<Rigidbody>();

        //bullet move foward with the speed (Z direction)
        bulletRigidbody.velocity = transform.forward * speed;
        
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider other){

        if(other.tag == "Player"){

            PlayerController playerController = other.GetComponent<PlayerController>();

            if(playerController != null){
                playerController.Die();
            }
        }
    }
}
