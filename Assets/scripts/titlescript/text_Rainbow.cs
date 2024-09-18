using System.Collections;
using static UnityEngine.Random;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class text_Rainbow : MonoBehaviour
{

    public Text text;

    int r  = Random.Range(0, 100);
    int g  = Random.Range(0, 100);
    int b  = Random.Range(0, 100);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.color = new Color(Random.Range(0, 100)/100, Random.Range(0, 100)/100, Random.Range(0, 100)/100, 1);
        
    }
}
