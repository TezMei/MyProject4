using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teletransporte : MonoBehaviour
{
    void OnTriggerEnter(Collider c){
        if (c.gameObject.CompareTag("Player")){
            bool tieneLlave2 = c.gameObject.GetComponent<Inventario>().HasItem("Llave2");
            if (tieneLlave2){
                SceneManager.LoadScene("Interior");
            }
        }
    }
}
