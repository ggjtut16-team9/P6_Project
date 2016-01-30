using UnityEngine;
using System.Collections;

public class StageCreate : MonoBehaviour {
    [SerializeField]
    GameObject whiteLine;
    [SerializeField]
    float interbal;
	// Use this for initialization
	void Start () {
        for (var i = 0; i < 10; i++)
        {
            Instantiate(whiteLine, new Vector3(0, 0, 0) + new Vector3(0, 0, interbal) * i, new Quaternion(0, 0, 0, 0));
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
