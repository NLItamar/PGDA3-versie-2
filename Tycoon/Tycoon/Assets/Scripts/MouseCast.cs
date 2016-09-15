using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Collections.Generic;

public class MouseCast : MonoBehaviour {
    public GameObject Shop1;
    public GameObject Shop2;
    public List<GameObject> shopps = new List<GameObject>();
    public int shopstotal;
	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        // Casts the ray and get the first game object hit
        Physics.Raycast(ray, out hit);
        if (Input.GetKeyUp("1")) {
            
            
            shopps.Add(Instantiate(Shop1, hit.point, Quaternion.identity) as GameObject);
            shopstotal = shopps.Count;
            NavMeshBuilder.BuildNavMesh();

        }
        if (Input.GetKeyUp("2"))
        {


            shopps.Add(Instantiate(Shop2, hit.point, Quaternion.identity) as GameObject);
            shopstotal = shopps.Count;
            NavMeshBuilder.BuildNavMesh();

        }
    }
}
