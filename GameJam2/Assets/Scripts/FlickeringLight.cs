/*using UnityEngine;
using System.Collections;

public class FlickeringLight : MonoBehaviour {
        public int count = 0;
        public bool clicked = false;

	// Update is called once per frame
	void FixedUpdate ()
    {
        //enabled = !enabled;
        gameObject.light.intensity = 0; 

        if (clicked)
        {
            count++;
            if (count % 5 == 0 && count < 60)
            {
                //this.enabled = !this.enabled;
            }
        


            if (count >= 60)
            {
                count = 0;
                clicked = false;
            }
        }
	}
}*/
