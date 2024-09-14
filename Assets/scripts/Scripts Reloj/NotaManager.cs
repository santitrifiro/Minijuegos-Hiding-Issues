using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NotaManager : MonoBehaviour
{
    
    public ClockGameManager gm;
    public GameObject nota;
    public TextMeshProUGUI text;

    private bool nota_visible = false;

    void Start()
    {
        nota.SetActive(false);
        text.text = "m - h = " + (gm.y - gm.x);
    }   

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape)) {

            nota.SetActive(false);
            nota_visible = false;

        }

    }

    private void OnMouseDown () {

        nota.SetActive(!nota_visible);
        nota_visible = !nota_visible;

    }
}
