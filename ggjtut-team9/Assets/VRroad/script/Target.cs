using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {
    private CameraMove cameraMove;
	// Use this for initialization
	void Start () {
        cameraMove = GameObject.FindWithTag("Player").GetComponent<CameraMove>();
	}
	
	// Update is called once per frame
	void Update () {
        if (cameraMove.PlayerGoEnd())
        {
            transform.position = new Vector3(0, 0.3f, 5.0f);
            transform.rotation = new Quaternion(0,0,0,0);
        }
        else
        {
            transform.position = new Vector3(0, 0.3f, -25.0f);
            transform.rotation = new Quaternion(0,1,0,0);
        }

	}
}
