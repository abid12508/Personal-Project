using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackboxscript : MonoBehaviour
{

    //switch color to red
    [SerializeField] private Material red;
    //get player gameobject
    [SerializeField] private GameObject player;


    //When player collides with box, destroy it
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.SetActive(false);
            gameObject.AddComponent<fal>();
            gameObject.AddComponent<boxmovement>();
            gameObject.tag = "Player";

        }
    }
}
