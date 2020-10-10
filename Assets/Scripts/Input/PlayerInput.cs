using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public static event Action OnNextPhraseButtonClick; 
    
    public static event Action OnStartDialogButtonClick; 

    
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            OnNextPhraseButtonClick?.Invoke();
            OnStartDialogButtonClick?.Invoke();
        }
    }
}
