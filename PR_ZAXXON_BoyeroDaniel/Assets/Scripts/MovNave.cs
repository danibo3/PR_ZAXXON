using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovNave : MonoBehaviour
{[SerializeField] float desplSpeed;
    [SerializeField] float SpeedDeafult = 40f;

    float limiteR = 45;
    float limiteL = -45;
    float limiteU = 50;
    float limiteS = 19;



    // Start is called before the first frame update
    void Start()
    {
        GameManager.speed = 30f;



    }

    // Update is called once per frame
    void Update()
    { 
        float desplH = Input.GetAxis("Horizontal");
        float desplV = Input.GetAxis("Vertical");
        float rot = Input.GetAxis("Horizontal");

        float posX = transform.position.x;
        float posY = transform.position.y;


        if ((posX > limiteR && desplH > 0)||(posX < limiteL && desplH < 0))
        { 
            desplSpeed = 0f;
        }
        else if ((posY > limiteU && desplV > 0) || (posY < limiteS && desplV < 0))
        {
            desplSpeed = 0f;
        }
        else
        { 
            desplSpeed = SpeedDeafult;
        }



        transform.Translate(Vector3.right * Time.deltaTime * desplH * desplSpeed, Space.World);
        transform.Translate(Vector3.up * Time.deltaTime * desplV * desplSpeed, Space.World);
        transform.Rotate(Vector3.back * Time.deltaTime * rot * 15f);

    }
    public void OnTriggerEnter(Collider other)
    { if (other.gameObject.layer == 6) {
            GameManager.speed = 0f;
            SpeedDeafult = 0f;
            Invoke("Morir", 2f);

            
        }



    }
    public void Morir()
    { 
        SceneManager.LoadScene(2); }
}

