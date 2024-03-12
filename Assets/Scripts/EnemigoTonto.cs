using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemigoTonto : MonoBehaviour
{
    public float speed;
    public float minAngle;
    public float maxAngle;

    public GameObject suelo;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
    void OnColisionEnter(Collider c)
    {
        if (c.gameObject.name != suelo.name)
        {
            transform.Rotate(0, Random.Range(minAngle, maxAngle), 0);

        }
    }
}
