using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HideOpcionText : MonoBehaviour
{
    public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        // Si el canvas no esta asignado, obtenemos el primero que encontremos en la escena
        if (canvas == null)
        {
            canvas = FindObjectOfType<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceCamera;
        }

        // Crear un nuevo objeto de texto dentro del Canvas
        GameObject nuevoTextoObj = new GameObject("TextoMeshPro");
        nuevoTextoObj.transform.SetParent(canvas.transform);

        // Agregar el componente TextMeshPro al objeto recien creado
        TextMeshProUGUI textMeshPro = nuevoTextoObj.AddComponent<TextMeshProUGUI>();

        // Configurar las propiedades del TextMeshPro
        textMeshPro.text = "Press H to hide";
        textMeshPro.fontSize = 36;
        textMeshPro.color = Color.white;

        // Ajustar la posicion del texto dentro del Canvas
        RectTransform rectTransform = textMeshPro.GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(500, 100); // Tamanio del rectangulo
        rectTransform.anchoredPosition = new Vector2(0, 0); // Centrado en la pantalla

        canvas.gameObject.SetActive(false);
    }

    public void Show_Option ()
    {
        if (canvas != null)
        {
            canvas.gameObject.SetActive(true);
        }
    }

    public void Hide_Option ()
    {
        if (canvas != null)
        {
            canvas.gameObject.SetActive(false);
        }
    }

}
