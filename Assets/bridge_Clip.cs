using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridge_Clip : MonoBehaviour
{

    public GameObject bridge;

    void OnCollisionEnter(Collision col){

        Physics.IgnoreLayerCollision(gameObject.layer, bridge.layer, true);

    }
}
