using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public bool enableRespawns;
    public GameObject playerSpawnPoints;

    private bool alive = false;

    // Use this for initialization
    void Start()
    {

    }

    public Transform Respawn()
    {
        Transform[] childTransforms = playerSpawnPoints.GetComponentsInChildren<Transform>();
        return childTransforms[Random.Range(0, childTransforms.Length - 1)];
    }

    // Update is called once per frame
    void Update()
    {
        if (!alive && enableRespawns)
        {
            alive = true;
            this.transform.position = Respawn().position;
        }
    }
}
