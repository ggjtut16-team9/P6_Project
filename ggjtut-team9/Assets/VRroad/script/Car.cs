using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {

    private bool left = true;
    private AudioSource[] source;
    [SerializeField]
    private float speed;
    [SerializeField]
    Texture[] tex;
	// Use this for initialization
	void Start () {
        this.GetComponent<MeshRenderer>().material.mainTexture = tex[Random.Range(0,4)];
	}
	
	// Update is called once per frame
	void Update () {
        if (left)
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            if (transform.position.x > 50.0f) Destroy(this.gameObject);
        }
        else
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
            if (transform.position.x < -50.0f) Destroy(this.gameObject);
        }
	}

    public void SetLeft(bool flag){
        left = flag;
    }

    public bool ReturnLeft()
    {
        return left;
    }
}
