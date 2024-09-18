using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallmove : MonoBehaviour
{
    private bool movingLeft = true;
    private bool movingRight;

    public GameObject player;

    void Update() {
        if (movingLeft == true) {
            transform.position += new Vector3(0f, 0f, -0.08f);
            if (transform.position.z <= 5){
                movingLeft = false;
                movingRight = true;
            } 
        }
        if(movingRight == true) {
            transform.position += new Vector3(0f, 0f, 0.08f);
            if (transform.position.z >= 17f){
                movingLeft = true;
                movingRight = false;
            }
        }
    }

    void OnCollisionEnter(Collision col){

        if(col.gameObject.tag == "Player"){

            if(movingLeft){
                player.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, -10f), ForceMode.Impulse);
            }
            else{
                player.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, 10f), ForceMode.Impulse);
            }
        }
    }
}
