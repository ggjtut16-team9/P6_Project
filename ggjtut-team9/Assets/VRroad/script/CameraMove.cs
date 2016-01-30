using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

    public float speed;
    public GameObject core;
    public Vector3 pos;
    private bool hit = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow)) transform.Rotate(Vector3.up*Time.deltaTime*speed);
        if (Input.GetKey(KeyCode.LeftArrow)) transform.Rotate(-Vector3.up * Time.deltaTime*speed);

        if (Input.GetKey(KeyCode.UpArrow)) core.transform.Rotate(-Vector3.right * Time.deltaTime*speed);
        if (Input.GetKey(KeyCode.DownArrow)) core.transform.Rotate(Vector3.right * Time.deltaTime*speed);
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && hit)
        {
            this.GetComponent<Rigidbody>().AddForce(GameObject.FindWithTag("MainCamera").transform.forward * 7.5f, ForceMode.Impulse);
        }
        hit = false;
    }
    void OnCollisionStay(Collision collision)
    {
        hit = true;
    }

}
