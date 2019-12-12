using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SAInfo : MonoBehaviour
{
    private bool displayMessage = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnGUI()
    {
        if (displayMessage)
        {
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 200, 200), "Testing");
        }
    }


}
