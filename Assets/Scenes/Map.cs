using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
	public Camera camera1;
	public Camera camera2;
	bool flag = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if( Input.GetKeyUp( KeyCode.M ) ) {
			if(flag) {
				camera1.enabled = false;
				camera2.enabled = true;
				flag = false;
			}
			else {
				camera1.enabled = true;
				camera2.enabled = false;
				flag = true;
			}
			
		}
    }
}
