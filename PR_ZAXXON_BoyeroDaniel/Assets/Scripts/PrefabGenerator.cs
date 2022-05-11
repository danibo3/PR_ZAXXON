using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    [SerializeField] GameObject myPrefab;
    [SerializeField] Transform initPos;
    [SerializeField] float intervalo;
    Vector3 NewPos;
    // Start is called before the first frame update
    void Start()
    { /*  for (int n = 0; n < 10; n++)
        Instantiate(MyPrefab, InitPos.position, Quaternion. identity);
    */
        StartCoroutine("Instanciar");
    }

IEnumerator Instanciar()
    {

        for (; ; )
        {
            Vector3 spawnHor = new Vector3(Random.Range(-40f, 40f), 2f, initPos.position.z);


            Instantiate(myPrefab, spawnHor, Quaternion.identity);

       

            yield return new WaitForSeconds(intervalo);
        }

    }
}
