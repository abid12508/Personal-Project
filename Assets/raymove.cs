using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raymove : MonoBehaviour
{
    private bool movingLeft = true;
    private bool movingRight;

    public GameObject player;

    void Update() {
        if (movingLeft == true) {
            transform.position += new Vector3(0f, 0f, -0.06f);
            if (transform.position.z <= 5){
                movingLeft = false;
                movingRight = true;
            } 
        }
        if(movingRight == true) {
            transform.position += new Vector3(0f, 0f, 0.06f);
            if (transform.position.z >= 17f){
                movingLeft = true;
                movingRight = false;
            }
        }
    }

    void OnCollisionEnter(Collision col){

        if(col.gameObject.tag == "Player"){

            if(movingLeft){
                player.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, -20f), ForceMode.Impulse);
                player.GetComponent<Rigidbody>().mass = 0.1f;
            }
            else{
                player.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, 20f), ForceMode.Impulse);
                player.GetComponent<Rigidbody>().mass = 0.1f;
            }
        }
    }

    void OnCollisionExit(Collision col){

        if(col.gameObject.tag == "Player"){

            player.GetComponent<Rigidbody>().mass = 1;
            
        }
    }
}

