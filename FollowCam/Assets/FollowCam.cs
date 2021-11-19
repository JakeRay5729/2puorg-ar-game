using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public GameObject player;
    private Vector3 cameraPosition;
    public bool gameView = false;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        ChangeView();
        if (gameView)
        {
            cameraPosition = new Vector3(player.transform.position.x, player.transform.position.y + 5, player.transform.position.z - 10);
            transform.position = cameraPosition;
            transform.rotation = Quaternion.Euler(30, 0, 0);
        }
        else
        {
            cameraPosition = new Vector3(0, 10, -30);
  
            transform.position = cameraPosition;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
    void ChangeView()
    {
        if (gameView)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift)) gameView = false;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.LeftShift)) gameView = true;
        }
    }
}
