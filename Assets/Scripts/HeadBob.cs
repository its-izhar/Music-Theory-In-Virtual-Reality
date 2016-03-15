using UnityEngine;
using System.Collections;

public class HeadBob : MonoBehaviour {

	private float timer = 0.0f;
	public float bobbingSpeed = 0.18f;
	public float bobbingAmount = 0.2f;
	public float midpoint = 2.0f;

	void Update()
	{
		float waveslice = 0.0f;
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		Vector3 cSharpConversion = gameObject.transform.position; 

		if (GameObject.Find ("CardboardMain").GetComponent<Cam> ().isWalking == false) {
			timer = 0.0f;
		}
		else {
			waveslice = Mathf.Sin(timer);
			timer = timer + bobbingSpeed;
			if (timer > Mathf.PI * 2) {
				timer = timer - (Mathf.PI * 2);
			}
		}
		if (waveslice != 0) {
			float translateChange = waveslice * bobbingAmount;
			float totalAxes = Mathf.Abs(horizontal) + Mathf.Abs(vertical);
			totalAxes = Mathf.Clamp (totalAxes, 1.5f, 1.0f);
			translateChange = totalAxes * translateChange;
			cSharpConversion.y = midpoint + translateChange;
		}
		else {
			cSharpConversion.y = midpoint;
		}

		gameObject.transform.position = cSharpConversion;
	}
}