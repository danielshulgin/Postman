using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class HousePopUp : MonoBehaviour
{
    [SerializeField] private GameObject popUpGameObject;
    
    [SerializeField] private TextMeshProUGUI popUpText;
    
    [SerializeField] private Vector3 offset;
    
    private House _contactHouse;

    private void Awake()
    {
        PlayerContact.OnHouseContactZoneEnter += HandleHouseContactZoneEnter;
        PlayerContact.OnHouseContactZoneExit += HandleHouseContactZoneExit;
    }

    private void OnDestroy()
    {
        PlayerContact.OnHouseContactZoneEnter -= HandleHouseContactZoneEnter;
        PlayerContact.OnHouseContactZoneExit -= HandleHouseContactZoneExit;
    }
    
    private void HandleHouseContactZoneEnter(House house)
    {
        _contactHouse = house;
        PlayerInput.OnStartDialogButtonClick += HandleStartDialogButtonClick;
    }
    
    private void HandleHouseContactZoneExit(House house)
    {
        PlayerInput.OnStartDialogButtonClick -= HandleStartDialogButtonClick;
        Hide();
    }

    private void HandleStartDialogButtonClick()
    {
        if (_contactHouse.target)
        {
            FinalPanel.Instance.Show();
        }
        else if (popUpGameObject.activeSelf)
        {
            Hide();
        }
        else
        {
            Show();
        }
    }

    private void Show()
    {
        popUpGameObject.SetActive(true);
        popUpGameObject.transform.position = _contactHouse.transform.position + offset;
        popUpText.text = _contactHouse.Info;
    }

    private void Hide()
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
