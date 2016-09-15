using UnityEngine;
using System.Collections;
using UnityEditor;

public class NavMeshUpdate : MonoBehaviour {

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0))
        {
            NavMeshBuilder.BuildNavMesh();
        }
    }
}
