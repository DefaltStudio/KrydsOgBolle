using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MouseHover : MonoBehaviour {

	List<int> crosses = new List<int>();
	public bool IsOccupied;
	public Texture2D crossTransform;

	void Start () {
		renderer.material.color = new Color (15.0F, 0, 0);
		IsOccupied = false;

	}

	void OnMouseEnter() {
		renderer.material.color = new Color (5.0F, 5.0F, 0);
	}

	void OnMouseExit () {
		renderer.material.color = new Color (5.0F, 0, 0);
	}

	void OnMouseDown () 
	{
        Instantiate(crossTransform, this.transform.position, Quaternion.identity);
		//crossTransform.transform.parent = cross;
	}
}