using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaChangeController : MonoBehaviour
{
    [SerializeField] private Material myMaterial;
    [SerializeField] private Renderer myModel;

    private void Start()
    {
        /*
        Color color = myMaterial.color;
        color.a = 0;
        myMaterial.color = color;
        */
       // Color color = myModel.material.color;
       // color.a = 1;
       // myModel.material.color = color;
    }

    public void SetAlpha(float alpha)
    {
        Color color = myModel.material.color;
        color.a = alpha;
        myModel.material.color = color;
    }

    public void AlphaSlider(float slider) {
        Color color = myModel.material.color;
        color.a = slider;
        myModel.material.color = color;
    }

    private void OnDestroy()
    {
        Destroy(myModel.material);
    }
}
