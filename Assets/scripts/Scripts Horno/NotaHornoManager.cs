using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;

public class NotaHornoManager : MonoBehaviour
{
    
    public HornoManager hm;

    public GameObject nota;

    public TextMeshProUGUI nota_text;

    private bool nota_active = false;

    private string text;

    void Start()
    {
        text = hm.n1.ToString() + hm.n2.ToString() + hm.n3.ToString() + hm.n4.ToString();
        nota_text.text = text;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {

            nota.SetActive(false);
            nota_active = false;

        }
    }

    private void OnMouseDown () {

        nota.SetActive(!nota_active);

    }

}
