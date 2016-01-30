using UnityEngine;
using System.Collections;

public class testVR : MonoBehaviour {

    Vector3 target;
    Ray ray;
    RaycastHit hit;
    public Animator anim;
    GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindWithTag("Player");
        anim = player.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        //ray = new Ray(transform.position, transform.forward);
        //if (Physics.Raycast(ray, out hit, 50)){
        //    if (hit.transform.CompareTag("White"))
        //    {
        //        anim.Play("jump");
        //        Debug.Log("hit");
        //       Vector3.Lerp(transform.position, hit.transform.position, 0.1f);
        //    }
        //}
	}

 
}
