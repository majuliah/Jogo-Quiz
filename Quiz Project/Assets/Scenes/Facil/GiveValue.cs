using System;
using System.Collections;
using System.Collections.Generic;
using Globals;
using UnityEngine;
using UnityEngine.UI;

public class GiveValue : MonoBehaviour
{
    [SerializeField] public Text meuPonto;

    public void Start()
    {
        string novoPonto = Pontos.valueToKeep;
        meuPonto.text = novoPonto;
    }
}
