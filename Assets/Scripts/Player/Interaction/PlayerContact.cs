using System;
using UnityEngine;


public class PlayerContact : MonoBehaviour
{
    public static event Action<House> OnHouseContactZoneEnter;
    
    public static event Action<House> OnHouseContactZoneExit;
    
    public static event Action<Character> OnCharacterContactZoneEnter;
    
    public static event Action<Character> OnCharacterContactZoneExit;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("House"))
        {
            OnHouseContactZoneEnter?.Invoke(other.GetComponent<House>());
        }
        else if (other.CompareTag("Character"))
        {
            OnCharacterContactZoneEnter?.Invoke(other.GetComponent<Character>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("House"))
        {
            OnHouseContactZoneExit?.Invoke(other.GetComponent<House>());
        }
        else if (other.CompareTag("Character"))
        {
            OnCharacterContactZoneExit?.Invoke(other.GetComponent<Character>());
        }
    }
}
