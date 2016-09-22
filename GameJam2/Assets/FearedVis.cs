using UnityEngine;
using System.Collections;

public class FearedVis : MonoBehaviour {
    public GameObject go;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name == go.name)
        {
            Destroy(go);
        }
    }
}
