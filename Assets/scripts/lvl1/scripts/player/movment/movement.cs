using UnityEngine;

public class movement : MonoBehaviour
{
    //get speed
    private float speed = 350f;

    // initialize camera gameobject
    private GameObject cam;

    //grab the rb
    private Rigidbody rb;
    private Vector3 velocity = Vector3.zero;

    //set rb & find cam
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        cam = GameObject.FindWithTag("MainCamera");
    }

    //move the ball with WASD and apply smooth dampening
    private void Update()
    {
        bool check = cam.GetComponent<cameralookback>().check;
        Vector3 force = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) force += new Vector3(0f, 0f, check? -speed:speed);
        if (Input.GetKey(KeyCode.S)) force += new Vector3(0f, 0f, check? speed:-speed);
        if (Input.GetKey(KeyCode.A)) force += new Vector3(check? speed:-speed, 0f, 0f);
        if (Input.GetKey(KeyCode.D)) force += new Vector3(check? -speed:speed, 0f, 0f);

        rb.AddForce(force * Time.deltaTime);
    }
}
