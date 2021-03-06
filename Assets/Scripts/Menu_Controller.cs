using UnityEngine;
using System.Collections;

public class Menu_Controller : MonoBehaviour {
	private VRTK.VRTK_ControllerEvents controller;
	public Transform tf;
	public GameObject menu;
	float lastPressed;
	bool menuActive = false;

	// Use this for initialization
	void Start () {
		controller = this.GetComponent<VRTK.VRTK_ControllerEvents>();
		menu.SetActive(menuActive); //make visible
		lastPressed = Time.time;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		try{
			//Debug.Log(menu.GetComponent<RectTransform>().position);
			//Debug.Log(tf.position);
			menu.GetComponent<RectTransform>().position = tf.position;
			menu.GetComponent<RectTransform>().rotation = tf.rotation;
			menu.GetComponent<RectTransform>().Rotate(45, 0, 0);
			if (controller.menuPressed && Time.time - lastPressed > 0.5)
			{
				Debug.Log("hi");
				lastPressed = Time.time;
				menuActive = !menuActive;
				menu.SetActive(menuActive);
			}
		}
		catch {
		}
	}
}
