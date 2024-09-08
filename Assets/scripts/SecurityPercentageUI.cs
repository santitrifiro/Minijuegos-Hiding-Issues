using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SecurityPercentageUI : MonoBehaviour
{

    public TextMeshProUGUI text;    
    // Start is called before the first frame update
    void Start()
    {
        text.text = "";
    }

    public void SetSecurityPercentage(int newPercentage)
    {
        text.text = newPercentage.ToString() + "%";
    }

    public void VoidSecurityPercentage()
    {
        text.text = "";
    }

    public void UnknownSecurityPercentage()
    {
        text.text = "???%";
    }
}

    