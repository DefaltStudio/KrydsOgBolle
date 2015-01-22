using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MouseHover : MonoBehaviour {

	List<int> crosses = new List<int>();
	public bool IsOccupied;
	public Texture2D textureCross;
    public Texture2D textureCircle;

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
        if (!IsOccupied)
        {
            if (MainScript.CrossCricle == 0) {
                renderer.material.mainTexture = textureCross;
                IsOccupied = true;
                MainScript.CrossCricle++;
            }
            else if (MainScript.CrossCricle == 1)
            {
                renderer.material.mainTexture = textureCircle;
                IsOccupied = true;
                MainScript.CrossCricle--;
            }

            
        }
	}
}