using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class HousePopUp : MonoBehaviour
{
    [SerializeField] private GameObject popUpGameObject;
    
    [SerializeField] private TextMeshProUGUI popUpText;
    
    [SerializeField] private Vector3 offset;


    private void Awake()
    {
        PlayerContact.OnHouseContactZoneEnter += Show;
        PlayerContact.OnHouseContactZoneExit += Hide;
    }

    private void OnDestroy()
    {
        PlayerContact.OnHouseContactZoneEnter -= Show;
        PlayerContact.OnHouseContactZoneExit -= Hide;
    }

    private void Show(House house)
    {
        popUpGameObject.SetActive(true);
        popUpGameObject.transform.position = house.transform.position + offset;
        popUpText.text = house.Info;
    }

    private void Hide(House house)
    {
        popUpGameObject.SetActive(false);
    }

    private void Update()
    {
        var cameraRotation = Camera.main.transform.rotation.eulerAngles;
        cameraRotation = new Vector3(0f, cameraRotation.y, 0f);
        popUpGameObject.transform.rotation = Quaternion.Euler(cameraRotation);
    }
}
