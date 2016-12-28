using UnityEngine;
using System.Collections;

public class Eyes : MonoBehaviour
{
    private Camera eyes;


    // Use this for initialization
    void Start()
    {
        eyes = GetComponent<Camera>();
    }

    void ZoomIn()
    {
        eyes.fieldOfView /= 1.5f;
    }

    void ZoomOut()
    {
        eyes.ResetFieldOfView();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Zoom"))
        {
            ZoomIn();
        }
        else if (Input.GetButtonUp("Zoom"))
        {
            ZoomOut();
        }
    }
}
