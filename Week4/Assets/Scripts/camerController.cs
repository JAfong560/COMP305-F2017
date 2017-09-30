using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerController : MonoBehaviour
{
    public float Offset = 3.0f;

    public Transform secondScreen;
    public Transform thirdScreen;
    public Transform playerPosition;
    //public Camera camcam;
    public float zoom = 5.0f;

    private Transform camTrans;

    // Use this for initialization
    void Start()
    {
        camTrans = this.transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerPosition.position.x >= secondScreen.position.x / 2 && playerPosition.position.x <= secondScreen.position.x * 1.5) //second screen
        {
            if (zoom < 8)
            { zoom += 0.02f; }
            else if (zoom >= 8.1)
            { zoom -= 0.02f; }
            camTrans.position = new Vector3(secondScreen.position.x, secondScreen.position.y, camTrans.position.z);
        }
        else if (playerPosition.position.x >= secondScreen.position.x * 1.5)
        {
            zoom = 16 - (playerPosition.position.x / 6);
            camTrans.position = new Vector3(thirdScreen.position.x - 10 + (playerPosition.position.x/5), thirdScreen.position.y + 1 - (playerPosition.position.x / 20), camTrans.position.z);
        }
        else
        {
            zoom = 5;
            camTrans.position = new Vector3(playerPosition.position.x, playerPosition.position.y + Offset, camTrans.position.z);
        }
        GetComponent<Camera>().orthographicSize = zoom;
    }
}
