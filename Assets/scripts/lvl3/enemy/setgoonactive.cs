using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setgoonactive : MonoBehaviour
{
    //get enemy gameobject
    [SerializeField] private GameObject enemy;


    //if player hits platform, then activate enemy
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {

            enemy.SetActive(true);

        }
    }

}
