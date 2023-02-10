using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizantalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
           transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
           transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizantalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizantalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown)(keyCode.Space))
        {
            // Launch a projectile from the player
        }
    }
}
