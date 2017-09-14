using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colour_change : MonoBehaviour {

    public GameObject shirt;
    public Color newColor;
    public Material mat;

    void OnMouseDown()
    {
        SpriteRenderer colour = shirt.GetComponent<SpriteRenderer>();
        //colour.color = newColor;
        colour.color = mat.color;
        Debug.Log("New Shirt");
    }
}
