using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ActivatorManager : MonoBehaviour
{
  
    public GameManager gm;
    public GameObject tmp;

    private bool activable = true;

    void Start()
    {
        tmp.SetActive(false);
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape)) {

            tmp.SetActive(false);

        }

    }

    private void OnTriggerEnter (Collider other) {

        Debug.Log("potato2");

        if (other.CompareTag("player") || other.CompareTag("MainCamera") && activable && gm.isSolved()) {

            activable = false;
            tmp.SetActive(true);

        }

    }

    private void OnTriggerExit (Collider other) {

        if (other.CompareTag("player") || other.CompareTag("MainCamera") && activable && gm.isSolved()) {

            tmp.SetActive(false);

        }

    }

}
