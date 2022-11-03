using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; //vehicle
    // This is the camera's position
    private Vector3 offset = new Vector3(0, 5, -8); 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset the camera behind the player by adding it to the player's position.
        transform.position = player.transform.position + offset;
    }
}
