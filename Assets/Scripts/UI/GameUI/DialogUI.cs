using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogUI : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    
    [SerializeField] private GameObject characterPopUpGameObject;
    
    [SerializeField] private GameObject playerPopUpGameObject;
    
    [SerializeField] private TextMeshProUGUI characterPopUpText;
    
    [SerializeField] private TextMeshProUGUI playerPopUpText;
    
    [SerializeField] private Vector3 offset;

    private int _currentPhraseIndex;
    
    private List<Phrase> _dialog;
    
    private Character _conatctCharacter;


    private void Awake()
    {
        PlayerContact.OnCharacterContactZoneEnter += HandleCharacterContactZoneEnter;
        PlayerContact.OnCharacterContactZoneExit += HandleCharacterContactZoneExit;
    }

    private void OnDestroy()
    {
        PlayerContact.OnCharacterContactZoneEnter -= HandleCharacterContactZoneEnter;
        PlayerContact.OnCharacterContactZoneExit -= HandleCharacterContactZoneExit;
    }
    
    
    private void Update()
    {
        var cameraRotation = Camera.main.transform.rotation.eulerAngles;
        cameraRotation = new Vector3(0f, cameraRotation.y, 0f);
        characterPopUpGameObject.transform.rotation = Quaternion.Euler(cameraRotation);
        playerPopUpGameObject.transform.rotation = Quaternion.Euler(cameraRotation);
    }

    private void HandleCharacterContactZoneEnter(Character character)
    {
        _conatctCharacter = character;
        PlayerInput.OnStartDialogButtonClick += HandleStartDialogButtonClick;
    }
    
    private void HandleCharacterContactZoneExit(Character character)
    {
        PlayerInput.OnStartDialogButtonClick -= HandleStartDialogButtonClick;
    }

    private void HandleStartDialogButtonClick()
    {
        PlayerInput.OnStartDialogButtonClick -= HandleStartDialogButtonClick;
        characterPopUpGameObject.transform.position = _conatctCharacter.transform.position + offset;
        playerPopUpGameObject.transform.position = playerTransform.transform.position + offset;
        _currentPhraseIndex = 0;
        
        if (_conatctCharacter.Quest == null || PlayerJournal.Instance.IsQuestComplete(_conatctCharacter.Quest))
        {
            _dialog = _conatctCharacter.DialogBeforeQuest;
        }
        else
        {
            _dialog = _conatctCharacter.DialogAfterQuest;
        }
        PlayerInput.OnNextPhraseButtonClick += HandlePressNextButton;
    }

    private void HandlePressNextButton()
    {
        if (_dialog.Count <= _currentPhraseIndex)
        {
            EndDialog();
            return;
        }
        var currentPhrase = _dialog[_currentPhraseIndex];
        if (currentPhrase.playerPhrase)
        {
            playerPopUpGameObject.SetActive(true);
            characterPopUpGameObject.SetActive(false);
            playerPopUpText.text = currentPhrase.text;
        }
        else
        {
            playerPopUpGameObject.SetActive(false);
            characterPopUpGameObject.SetActive(true);
            characterPopUpText.text = currentPhrase.text;
        }
        ++_currentPhraseIndex;
    }

    private void EndDialog()
    {
        PlayerInput.OnNextPhraseButtonClick -= HandlePressNextButton;
        playerPopUpGameObject.SetActive(false);
        characterPopUpGameObject.SetActive(false);
    }
}
