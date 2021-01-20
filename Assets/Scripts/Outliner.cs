using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Outliner : MonoBehaviour
{
    [SerializeField] private Outline outline;
    private float alpha;
    private bool isOulined;
    [SerializeField] private float alphaKoef;
    private void Start()
    {
        if (outline == null)
        {
            outline = gameObject.GetComponent<Outline>();
        }
        outline.effectColor = new Color(0f, 0f, 0f, 0f);
    }

    private void Update()
    {
        
        if (outline.effectColor.a >= 1)
        {
            isOulined = true;   
        }
        else if (outline.effectColor.a <= 0) 
        {
            isOulined = false;
        }

        if (!isOulined)
        {          
            alpha += alphaKoef;
        }
        else
        {  
            alpha -= alphaKoef;
        }

        outline.effectColor = new Color(0f, 0f, 0f, alpha/255);
    }
}
