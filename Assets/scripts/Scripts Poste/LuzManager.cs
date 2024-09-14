using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzManager : MonoBehaviour
{
    
    public PosteManager pm;

    void Start()
    {
        
        Debug.Log(ToString());

        if (CompareTag("luz1") && !pm.isOn(0)) {

            this.gameObject.SetActive(false);

        }

        if (CompareTag("luz2") && !pm.isOn(1)) {

            this.gameObject.SetActive(false);

        }

        if (CompareTag("luz3") && !pm.isOn(2)) {

            this.gameObject.SetActive(false);

        }

        if (CompareTag("luz4") && !pm.isOn(3)) {

            this.gameObject.SetActive(false);

        }

        if (CompareTag("luz5") && !pm.isOn(4)) {

            this.gameObject.SetActive(false);

        }

        if (CompareTag("luz6") && !pm.isOn(5)) {

            this.gameObject.SetActive(false);

        }

        if (CompareTag("luz7") && !pm.isOn(6)) {

            this.gameObject.SetActive(false);

        }

        if (CompareTag("luz8") && !pm.isOn(7)) {

            this.gameObject.SetActive(false);

        }

    }

    void Update()
    {

    }
}
