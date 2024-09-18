using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxmovement : MonoBehaviour
{

    private GameObject cam;
    void Start()
    {
        cam = GameObject.FindWithTag("MainCamera");
    }
    void Update()
    {
        basicMovement();
    }
    //basic movement but instead of rb, transform pos (because of mesh shape)
    void basicMovement()
    {
        bool check = cam.GetComponent<cameralookback>().check;
        var haxis = Input.GetAxis("Horizontal");
        var vaxis = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(check ? -haxis:haxis , 0f, check ? -vaxis:vaxis);
        transform.position += movement * 5 * Time.deltaTime;
    }
}
