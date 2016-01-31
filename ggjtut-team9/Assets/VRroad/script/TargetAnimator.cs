using UnityEngine;
using System.Collections;

public class TargetAnimator : MonoBehaviour {

	private Renderer[] renderers;
	private Color emissionColor;
	private float increment = 0.005f;
	private float min = 0.2f;
	private float max = 0.5f;

	// Use this for initialization
	void Start () {
		renderers = gameObject.GetComponentsInChildren<Renderer> ();
		for (int i = 0; i < renderers.Length; i++) {
			renderers [i].material.EnableKeyword ("_EMISSION");
		}
		float center = ((max - min) / 2.0f) + min;
		Debug.Log (center);
		emissionColor = new Color (center, center, center);
	}
	
	// Update is called once per frame
	void Update () {
		if (emissionColor.r < min || emissionColor.r > max) {
			increment *= -1.0f;
		}
		emissionColor.r += increment;
		emissionColor.g += increment;
		emissionColor.b += increment;
		for (int i = 0; i < renderers.Length; i++) {
			renderers [i].material.SetColor ("_EmissionColor", emissionColor);
		}
	}
}

