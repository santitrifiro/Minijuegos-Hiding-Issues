using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomManager : MonoBehaviour
{
    
    public bool activa;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnTriggerEnter (Collider other) {

        print(other.transform.name);

        if (other.transform.CompareTag("monster") && this.activa) {
        
            SceneManager.LoadScene("GameOver");

        } else {

            this.activa = true;

        }

    }

    public void OnTriggerExit (Collider other) {

        this.activa = false;

    }

}
