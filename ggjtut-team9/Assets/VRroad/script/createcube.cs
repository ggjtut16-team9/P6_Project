using UnityEngine;
using System.Collections;

public class createcube : MonoBehaviour {

    Ray ray;
    Vector3 pos;
    public GameObject cube;
    public GameObject sphere;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        ray = new Ray(transform.position, transform.forward);

        pos=ray.GetPoint(10);
        if (Input.GetMouseButtonDown(0)) Instantiate(cube, pos, new Quaternion(0, 0, 0, 0));
        if (Input.GetKeyDown(KeyCode.Escape)) Instantiate(sphere, pos, new Quaternion(0, 0, 0, 0));
	
	}
}
