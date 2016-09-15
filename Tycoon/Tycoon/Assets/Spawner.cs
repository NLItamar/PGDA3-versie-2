using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public GameObject go;
    public int time = 0;
    public int interval = 180;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per tick
    void FixedUpdate()
    {
        time++;
        if (time % interval == 0)
        {
            Instantiate(go, gameObject.transform.position, Quaternion.identity);
        }

    }
}

