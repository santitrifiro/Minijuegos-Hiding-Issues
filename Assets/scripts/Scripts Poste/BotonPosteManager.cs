using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonPosteManager : MonoBehaviour
{

    public GameObject tmp;

    // Start is called before the first frame update
    void Start()
    {
        tmp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape)) {

            tmp.SetActive(false);

        }

    }

    private void OnMouseDown () {

        tmp.SetActive(true);

    }

}
