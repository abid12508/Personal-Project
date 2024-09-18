using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create : MonoBehaviour
{

    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision col){

        if(col.gameObject.tag == "enemy"){

            Instantiate(enemy, new Vector3(transform.position.x, 5, transform.position.z), Quaternion.identity);
        }
    }
}
