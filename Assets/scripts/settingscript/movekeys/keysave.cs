using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keysave : MonoBehaviour
{

    public static bool arrow = false;
    public static bool wasd = true;

    public void for_WASD(){

        wasd = true;
        arrow = false;
    }

    public void for_ARROW(){

        arrow = true;
        wasd = false;

    }




}
