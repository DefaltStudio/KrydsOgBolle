using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MouseHover : MonoBehaviour 

{

	List<int> crosses = new List<int>();
	public bool IsOccupied;

	public bool IsCross;
	public bool IsCircle;

	public Texture2D textureCross;
    public Texture2D textureCircle;



	void Start () {
		renderer.material.color = new Color (15.0F, 0, 0);
		IsOccupied = false;
	}

	void Update ()
	{
		RaycastHit hit;

		Ray ray = new Ray(transform.position, transform.up * 10);
		Debug.DrawRay (transform.position, transform.up * 10, Color.green);

		if(Physics.Raycast(ray, out hit))
		   {
			if(hit.collider.gameObject.tag == "Cross")
			{
				IsCross = true;
				IsCircle = false;

			}

			if(hit.collider.gameObject.tag == "Circle")
			{
				IsCross = false;
				IsCircle = true;
			}
		}

	}

	void OnMouseEnter() {
		renderer.material.color = new Color (5.0F, 5.0F, 0);
	}

	void OnMouseExit () {
		renderer.material.color = new Color (5.0F, 0, 0);
	}

	void OnMouseDown () 
	{
        if (!IsOccupied)
        {
            if (MainScript.CrossCricle == 0) {
                renderer.material.mainTexture = textureCross;
				gameObject.tag = "Cross";
                IsOccupied = true;
                MainScript.CrossCricle++;
            }
            else if (MainScript.CrossCricle == 1)
            {
                renderer.material.mainTexture = textureCircle;
				gameObject.tag = "Circle";
                IsOccupied = true;
                MainScript.CrossCricle--;
            }

            
        }
	}
}