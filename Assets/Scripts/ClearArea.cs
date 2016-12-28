using UnityEngine;
using System.Collections;

public class ClearArea : MonoBehaviour
{
    private float timeSinceLastTrigger = 0;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastTrigger += Time.deltaTime;

        if (timeSinceLastTrigger > 10f)
        {
            Debug.Log("In clear area");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        timeSinceLastTrigger = 0f;

    }
}
