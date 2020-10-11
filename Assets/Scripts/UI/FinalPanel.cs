using System;
using UnityEngine;

public class FinalPanel : MonoBehaviour
{
    public GameObject panel;
    
    public static FinalPanel Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void Show()
    {
        panel.SetActive(true);
    }
}