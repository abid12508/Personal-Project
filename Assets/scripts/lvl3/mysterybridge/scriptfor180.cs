using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptfor180 : MonoBehaviour
{
    //get the typewritter effect script
    [SerializeField] private typewriter typewriterEffect;
    
    //grab the panel and text
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject text;

    //resume game
    private bool resume = false;

    //check to see if collision already happened then resume game
    void Update()
    {
        if (Input.GetKey(KeyCode.S) && resume == true)
            {
                
                panel.SetActive(false);
                text.SetActive(false);
                while (Time.timeScale <= 1)
                {
                    Time.timeScale += .05f;
                }
            }
    }
    //make the message and typewrite it
    void twe()
    {
        string message = "Press Space to turn around ... Press S to continue";
        typewriterEffect.StartTypewriterEffect(message);
    }
    //on collision enable panel and text, then if user presses space, resume
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Time.timeScale = 0.6f;
            panel.SetActive(true);
            twe();
            resume = true;

        }
    }

}
