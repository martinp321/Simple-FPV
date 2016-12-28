using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour
{

    private AudioSource comingAudio;
    private bool called = false;

    // Use this for initialization
    void Start()
    {
        comingAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!called && Input.GetButtonDown("CallHeli"))
        {
            called = true;
            Debug.Log("Helicopter Called");
            comingAudio.Play();
        }
    }
}
