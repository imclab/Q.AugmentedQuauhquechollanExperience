using UnityEngine;
using System.Collections;

public class panelAwake : MonoBehaviour {
	public GameObject panel;
	// Use this for initialization
	void Start () {
		panel.SetActive(false);
	}
}
