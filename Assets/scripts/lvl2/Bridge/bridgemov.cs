using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridgemov : MonoBehaviour
{
    private bool movingup;
    private bool movingdown;
    void Start() {
        movingup = true;
    }
    void Update() {
        if (movingup == true) {
            transform.position += new Vector3(0f, 0.1f, 0f);
            if (transform.position.y >= 3){
                movingup = false;
                movingdown = true;
            } 
        }
        if(movingdown == true) {
            transform.position += new Vector3(0f, 0.2f, 0f);
            if (transform.position.y <= -3){
                movingup = true;
                movingdown = false;
            }
        }
    }
}
