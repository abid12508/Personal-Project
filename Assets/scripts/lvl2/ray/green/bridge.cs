using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridge : MonoBehaviour
{

    public toblue tb;

    public GameObject bridgeobj;

    private bool bridgemake = false;

    void OnCollisionEnter(Collision other){

        if(tb.g == true && bridgemake == false){

            Debug.Log("works");

            Instantiate(bridgeobj, new Vector3(2.09f, -1.4852f, 11.0765f), Quaternion.identity);

            bridgemake = true;
        }

    }
}
