using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SAObject : MonoBehaviour
{
    private bool displayMessage;
    public string infoCountry;
    public GameObject toHide;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed primary button.");
            displayMessage = true;
            //OnGUI();
            //StartCoroutine(timeDelay());
        }
            

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Mouse Button Up.");
            displayMessage = false;
        }

    }

    void OnMouseOver()
    {
        toHide.SetActive(true);
          
          //  StartCoroutine(timeDelay());
        
        }
    void OnMouseExit() {
        toHide.SetActive(false);
    }

    IEnumerator timeDelay()
    {
        yield return new WaitForSeconds(5);
    }


}
