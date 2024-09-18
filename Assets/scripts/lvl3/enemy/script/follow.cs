using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    //get the amount of seconds the movement should be delayed
    [SerializeField] private float delay;
    //set the speed of the enemy
    [SerializeField] private float speed;
    
    void Update()
    {
        DoDelayAction();
    }
    //get the gameobject with player and move towards the player
    void movement()
    {
        GameObject player = GameObject.FindWithTag("Player");
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed);
        
    }
    //start a coroutine to delay the enemy movement
    void DoDelayAction()
    {
        StartCoroutine(DelayAction());
    }
    //wait 3 seconds for the animation to end
    IEnumerator DelayAction()
    {
        float delayseconds = delay;
        yield return new WaitForSeconds(delayseconds);
        movement();
    }


        
}
    
