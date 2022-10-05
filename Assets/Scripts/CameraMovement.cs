using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject chef;
    void Start()
    {
        chef = GameObject.Find("Chef");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(chef.transform.position.x,chef.transform.position.y,transform.position.z);
    }
}
