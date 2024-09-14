using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPosteManager : MonoBehaviour
{

    public PosteManager pm;
    public GameObject tmp_pos;

    // Start is called before the first frame update
    void Start()
    {
        tmp_pos.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape)) {

            tmp_pos.SetActive(false);

        }

    }

    public void setInputText (string s) {

        try {

            int v_input = int.Parse(s);

            tmp_pos.SetActive(pm.number == v_input);

        } catch (Exception e) {


        }

    }

}
