using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Fade2Black : MonoBehaviour
{

    public UnityEngine.UI.Image fade;
    private bool fading = false;
    // Start is called before the first frame update
    void Start()
    {
        fade.color = new Color(fade.color.r, fade.color.g, fade.color.b, 0);
    }

    private void Update()
    {
        const float alpha_step = 0.01f;
        if (fading) {
            float new_alpha = fade.color.a + alpha_step >= 1f ? 1f : fade.color.a + alpha_step;
            fade.color = new Color(fade.color.r, fade.color.g, fade.color.b, new_alpha);
            fading = new_alpha != 1f;
        }
    }

    public void SlowFade()
    {
        fading = true;
    }

    public void ResetFade()
    {
        fade.color = new Color(fade.color.r, fade.color.g, fade.color.b, 0);
        fading = false;
    }
}
