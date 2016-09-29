using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public float spawnTime;
    float reset;

    public GameObject A1U1;
    public GameObject A2U1;

	void Start()
    {
        reset = spawnTime;
    }
	// Update is called once per frame
	void Update () {
        spawnTime -= Time.deltaTime;
        if(spawnTime < 0)
        {
            Instantiate(A1U1, transform.parent);
            spawnTime = reset;
        }
	}
}
