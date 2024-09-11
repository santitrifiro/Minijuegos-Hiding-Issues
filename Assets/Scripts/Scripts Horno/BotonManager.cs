using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BotonManager : MonoBehaviour
{

    public HornoManager hm;
    public PuertaManager pm;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown () {

        if (hm.done()) {

            if (!pm.gameObject.IsDestroyed()) {

                Destroy(pm.gameObject);

            }

        }

    }

}
