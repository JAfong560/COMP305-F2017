using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScrollController : MonoBehaviour
{

    public float parallaxSpeed = 0.0f;

    private Transform mainCamera;

    // Use this for initialization
    void Start()
    {
        mainCamera = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // this.transform.position = mainCamera.transform.position * parallaxSpeed;
        this.transform.position = new Vector3(mainCamera.position.x, mainCamera.position.y, this.transform.position.z) * parallaxSpeed;
    }
}
