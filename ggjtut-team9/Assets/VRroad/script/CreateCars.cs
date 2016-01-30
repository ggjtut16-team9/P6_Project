using UnityEngine;
using System.Collections;

public class CreateCars : MonoBehaviour {
    [SerializeField]
    GameObject car;
    float count = 11;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        count += Time.deltaTime;
        if (count > 3)
        {
            if (Random.Range(0, 2) > 0)
            {
                GameObject obj = Instantiate(car, new Vector3(-34, -1.6f, Random.Range(-1, -7)), new Quaternion(0, 0.7f, 0, 0.7f)) as GameObject;
                obj.GetComponent<Car>().SetLeft(true);
            }
            else
            {
                GameObject obj = Instantiate(car, new Vector3(34, -1.6f, Random.Range(-18, -13)), new Quaternion(0, -0.7f, 0, 0.7f)) as GameObject;
                obj.GetComponent<Car>().SetLeft(false);
            }
            count = 0;
        }
	}
}
