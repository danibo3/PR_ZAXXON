using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
  
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * GameManager.speed); 

        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            GameManager.speed = 0f;
        }
    }
}
