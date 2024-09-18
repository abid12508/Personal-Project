using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridge_Movement : MonoBehaviour
{
    private bool movingup;
    private bool movingdown;
    void Start() {

        transform.position = new Vector3(30f, 1f, 9.25f);
        movingup = true;
    }
    void Update() {

        if (transform.position.y <= -3){
            movingup = true;
            movingdown = false;
        }
        if (transform.position.y >= 3){
                movingup = false;
                movingdown = true;
        }
        if (movingup == true && movingdown == false) {
            transform.position += new Vector3(0f, 6f * Time.deltaTime, 0f);
        }
        if(movingdown == true && movingup == false) {
            transform.position -= new Vector3(0f, 6f * Time.deltaTime, 0f);
        }
 
    }
}
