using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class ParedGameManager : MonoBehaviour
{
    
    private const int n = 20;

    public bool[] paredes;

    public GameObject pared;

    void Start()
    {
        
        paredes = new bool[n];

        System.Random random = new System.Random();

        for (int i = 0; i < n; i++) {

            int random_value = random.Next(0, 2);

            if (random_value == 1) {

                paredes[i] = true;

            } else {

                paredes[i] = false;

            }

        }

        StartCoroutine(lanzarParedes());

    }

    void Update()
    {
        
    }

    private IEnumerator lanzarParedes () {

        for (int i = 0; i < n; i++) {
            
            GameObject pared = Instantiate(this.pared);

            Renderer pared_renderer = pared.GetComponent<Renderer>();

            if (paredes[i]) {

                pared_renderer.material.color = Color.red;
                pared.tag = "move";

            } else {

                pared_renderer.material.color = Color.blue;
                pared.tag = "still";

            }

            pared.SetActive(true);

            float speed = 10f;
            float time = 2f;

            pared.GetComponent<Rigidbody>().velocity = new Vector3(speed + i, 0, 0);

            yield return new WaitForSeconds((speed * time) / (speed + i));

            Destroy(pared);

        }

    }

}
