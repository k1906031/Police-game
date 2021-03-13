using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgrounf : MonoBehaviour
{

    float Scrollspeed = -5f; //this is the varible for the speed of the back ground and the objects 
    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position; // this allows to objects to move
        
    }

    // Update is called once per frame
    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * Scrollspeed, 30); //this is how it moves
        transform.position = startPos + Vector2.right * newPos;
    }
}
