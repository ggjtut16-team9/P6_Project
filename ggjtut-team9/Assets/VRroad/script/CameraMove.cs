using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

    public float speed;
    public GameObject core;
    public Vector3 pos;
    private bool hit = false;
    private float upDownAngle = 0;

    private int count = 0;

    ScoreSave scoresave;
    public GameObject save;

    private bool startSide = true;

    public GameObject spawn;

    public int score = 0;

	// Use this for initialization
	void Start () {
        scoresave = save.GetComponent<ScoreSave>();

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow)) transform.Rotate(Vector3.up*Time.deltaTime*speed);
        if (Input.GetKey(KeyCode.LeftArrow)) transform.Rotate(-Vector3.up * Time.deltaTime*speed);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            upDownAngle += -Time.deltaTime * speed;
            if (upDownAngle < -70.0f) upDownAngle = -70.0f;
            else
            core.transform.Rotate(-Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            upDownAngle += Time.deltaTime * speed;
            if (upDownAngle > 70.0f) upDownAngle = 70.0f;
            else
            core.transform.Rotate(Vector3.right * Time.deltaTime * speed);
        }
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)))
        {
            if (hit)
            {
                Vector3 cameraFront = GameObject.FindWithTag("MainCamera").transform.forward;
                cameraFront.y = 0;
                cameraFront = Vector3.Normalize(cameraFront);

                cameraFront.y = 2.0f;
                cameraFront = Vector3.Normalize(cameraFront);
                this.GetComponent<Rigidbody>().AddForce(cameraFront * 5.0f, ForceMode.Impulse);
                count = 0;
				AudioManager.Instance.PlaySE (0);
            }
            else
            {
				if (count < 3) {
					this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 3.0f, 0), ForceMode.Impulse);
					AudioManager.Instance.PlaySE (0);
				}
                count++;
            }
        }
        hit = false;
        Debug.Log(score);
        dead();
    }
    void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag != "ErectricPorn")
            hit = true;

        if (collision.collider.tag == "StartPos" && !startSide)
        {
            startSide = true;
            score += 1;
            AudioManager.Instance.PlaySE(3);
        }
        else if (collision.collider.tag == "EndPos" && startSide)
        {
            startSide = false;
            score += 1;
            AudioManager.Instance.PlaySE(3);
        }
    }

	void OnCollisionEnter(Collision collision){
		if (collision.collider.tag == "ground" || 
			collision.collider.tag == "StartPos" ||
			collision.collider.tag == "EncPos") {
			AudioManager.Instance.PlaySE (1);
		}
	}

    public bool PlayerGoEnd()
    {
        return startSide;
    }

    void dead()
    {
        if (transform.position.y <= -50)
        {
            //transform.position = spawn.transform.position;
            //transform.rotation = spawn.transform.rotation;
            save.SendMessage("Save_Score", score);

            Application.LoadLevel("test");

        }
    }
}
