using System;
using UnityEngine;

public class SingleSoundPlayer : MonoBehaviour
{
    private void Awake()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }
}