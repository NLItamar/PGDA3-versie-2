using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class feared : MonoBehaviour {
    public GameObject go;
    public GameObject scroll;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay(Collider other)
    {
       if(other.name == go.name)
        {
            if (gameObject.transform.GetChild(0).GetComponent<ClickLightButton>().clicked)
            {
            scroll.transform.GetComponent<Fearmeter>().Feared(0.3f);
        
            }
        }
    }
}
