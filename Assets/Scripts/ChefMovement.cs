using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChefMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + Input.GetAxis("Horizontal") * speed, transform.position.y + Input.GetAxis("Vertical") * speed); ; ;
    }
}
