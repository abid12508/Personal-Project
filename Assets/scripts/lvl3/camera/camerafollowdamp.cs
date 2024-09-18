using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollowdamp : MonoBehaviour
{
    //damping scaler
    [SerializeField] private float damping;
    //camfollow vector
    private Vector3 velocity = Vector3.zero;
    //check if cam animation is done
    private bool animationdone;
    //grab booleen from cameralookback
    [SerializeField] private cameralookback clb;


    void Update()
    {
        //keep lifting camera until y = 10 and then follow player
        if (transform.position.y <= 11f && !animationdone)
        {
            transform.position += new Vector3(0f, 1f, .1f) * Time.deltaTime * 6f;
        } else {
            animationdone = true;
        }
        if(animationdone)
        {
            followplayer();
        }


    }
    //follow player using smoothdamp
    void followplayer()
    {
        bool checka = clb.check;
        GameObject player = GameObject.FindWithTag("Player");
        Vector3 movePosition = player.transform.position + new Vector3(0f, 10f, checka ? 5f : -5f);
        transform.position = Vector3.SmoothDamp(new Vector3(transform.position.x, transform.position.y, transform.position.z), movePosition, ref velocity, damping);
    }


}
