using UnityEngine;
using System.Collections;

public class videoPopUp : MonoBehaviour {

	// Use this for initialization
	public void videoPop () {
		Handheld.PlayFullScreenMovie ("malinche.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
	}
}
