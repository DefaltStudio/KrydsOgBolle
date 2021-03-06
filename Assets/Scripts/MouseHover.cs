﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MouseHover : MonoBehaviour 

{
	List<int> crosses = new List<int>();
	public bool IsOccupied;

	public Texture2D textureCross;
    public Texture2D textureCircle;

	public static bool IsCross;
	public static bool IsCircle;

	void Start () {
		renderer.material.color = new Color (15.0F, 0, 0);
		IsOccupied = false;
        MainScript.Tiles.Add(gameObject); // få arrangeret tiles i descenderende orden, så den kan bruges til at finde ud af om der er 3 på stribe.
	}

	void Update() {
		RaycastHit hit;
		Ray ray = new Ray (transform.position, transform.up * 10);
		Debug.DrawRay (transform.position, transform.up * 10, Color.green);
		if (Physics.Raycast (ray, out hit)) {
			if (hit.collider.gameObject.tag == "Cross")
				IsCross = true;
			else if (hit.collider.gameObject.tag == "Circle")
				IsCircle = true;
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

	void Check ()
	{
		if (gameObject.tag == "Cross") 
		{
			if(IsCross == true)
			{

			}
		}
	}
	
}