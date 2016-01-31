using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {
    private CameraMove cameraMove;
	private float timer;
	private bool once;
	private bool once_old;

	// Use this for initialization
	void Start () {
        cameraMove = GameObject.FindWithTag("Player").GetComponent<CameraMove>();
		timer = 0;
		once = false;
		once_old = false;
	}
	
	// Update is called once per frame
	void Update () {
		once = cameraMove.PlayerGoEnd ();
        if (once)
        {
            transform.position = new Vector3(0, 0.3f, 5.0f);
            transform.rotation = new Quaternion(0,0,0,0);
        }
        else
        {
            transform.position = new Vector3(0, 0.3f, -25.0f);
            transform.rotation = new Quaternion(0,1,0,0);
        }
		if (once != once_old) {
			// process once
			once_old = once;
			timer = 0;
		}
		timer += Time.deltaTime;
		if (timer > 3.0f) {
			ParticleSystem particle = FindObjectOfType<ParticleSystem> ();
			particle.transform.position = transform.position;
		}
	}
}
