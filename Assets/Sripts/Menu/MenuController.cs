using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuController : MonoBehaviour
{

    private enum Open{
        None,
        Phone,
        Dialogue
    }

    [Header("HP UI")]
    [SerializeField] private GameObject[] PanelHp;
    [SerializeField] private GameObject PanelHpUtama;
    [SerializeField] private GameObject UI;

    [Header("Dialogue UI")]
    public GameObject DialogueUI;
    public DialogueBox DialogueBox;
    public DialogueCharacter CharacterImg;
    public TextMeshProUGUI Name;
    public TextMeshProUGUI DialogueTxt;


    Open MenuOpened;
    public void OpenClosePhone(InputAction.CallbackContext context)
    {
        if(context.started && MenuOpened == Open.None)
        {
            if (UI.activeInHierarchy)
            {
                UI.SetActive(false);
            }
            else
            {
                UI.SetActive(true);
                PanelHpUtama.SetActive(true);
                foreach (GameObject panel in PanelHp)
                {
                    panel.SetActive(false);
                }
            }
        }
    }

    public void OpenCloseDialogue(InputAction.CallbackContext context)
    {
        if(context.started && MenuOpened == Open.None)
        {
            // TO DO: MAKE A DIALOGUEMANAGER CLASS AND CALL WHAT SHOULD BE DONE.
        }
    }

    void closeAll()
    {
        UI.SetActive(false);
        // TODO: DIALOGUE CLOSE ALL.
    }
}
