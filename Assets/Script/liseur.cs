using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class liseur : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Ecriveur ecriveur;

    void Start()
    {
        inputField.ActivateInputField();
        inputField.onValueChanged.AddListener(OnTextChanged);
        inputField.Select();   
    }

    public void OnTextChanged(string texte)
    {
        foreach (char c in texte) {
            ecriveur.OnNewCharacter(c);
        }
        inputField.text = "";
    }
}
