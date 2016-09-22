using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fearmeter : MonoBehaviour {
    public Scrollbar Fearbar;
    public float Fear = 100;

    public void Feared(float fearvalue)
    {
        Fear -= fearvalue;
        Fearbar.value = Fear / 100f;
    }
	// Update is called once per frame
	void Update () {
	
	}
}
