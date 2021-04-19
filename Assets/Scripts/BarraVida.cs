using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // com ele eu consigo utlizar toda a biblioteca de interface

public class BarraVida : MonoBehaviour
{
    public float Vida; // valor entre 0 e 100
    public Image Barra; // Image é da biblioteca  using UnityEngine.UI

    void Start()
    {
        
    }

    
    void Update()
    {
            
        Barra.fillAmount = Vida / 100;
    }
}
