using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovNave : MonoBehaviour
{

    [SerializeField] float desplSpeed;

    // Start is called before the first frame update
    void Start()
    {
        desplSpeed = 25f;
    }

    // Update is called once per frame
    void Update()
    {
    
        float desplH = Input.GetAxis("Horizontal");
        float desplV = Input.GetAxis("Vertical");


        transform.Translate(Vector3.right * Time.deltaTime * desplH * desplSpeed, Space.World);
        transform.Translate(Vector3.up * Time.deltaTime * desplV * desplSpeed, Space.World);
    }
}

