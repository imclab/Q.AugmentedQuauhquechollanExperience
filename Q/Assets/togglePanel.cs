using UnityEngine;
using System.Collections;

public class togglePanel : MonoBehaviour {

	public GameObject ui, slidr;

	public void TogglePanel () {

		var animation = slidr.GetComponent<Animator> ();

		if (animation.GetBool ("Normal")) {
			animation.SetBool ("Normal", false);
			animation.SetBool ("Pressed", true);
		} else if (animation.GetBool ("Pressed")) {
			animation.SetBool ("Pressed", false);
			animation.SetBool ("fromPressed", true);
		}

	}

	public void Update () {
		var animation = slidr.GetComponent<Animator> ();
		var normal = slidr.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("Normal");

		if (normal) {
			animation.SetBool("Normal", true);
			animation.SetBool("fromPressed", false);
		}
		if (slidr.GetComponent<RectTransform> ().anchoredPosition.y == 18) {
			ui.SetActive (false);
		} else {
			ui.SetActive(true);
		}
	}
}
