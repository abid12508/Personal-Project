using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class place_Holder : MonoBehaviour
{
    public Text placeholder;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        placeholder.text = $"{cam.fieldOfView}";
        
    }
}
