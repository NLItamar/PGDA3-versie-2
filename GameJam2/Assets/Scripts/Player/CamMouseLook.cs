using UnityEngine;
using System.Collections;

public class CamMouseLook : MonoBehaviour {

    GameObject Player;

	void Start ()
    {
        Player = this.transform.parent.gameObject;
        
	}
	
	void Update ()
    {
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");
        transform.Rotate(v, h, 0);
    }
}
