using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CaretCanvas : MonoBehaviour
{
    // UI elements.
    [SerializeField] private InputField caretInputField;
    [SerializeField] private Button setCaretPositionButton;
    [SerializeField] private Text caretPositionText;

    // Caret members.
    private int caretPosition;
    
    /// <summary>
    /// Input field click per code.
    /// </summary>
    private void ClickInputField()
    {
        EventSystem current;
        (current = EventSystem.current).SetSelectedGameObject(caretInputField.gameObject, null);
        caretInputField.OnPointerClick(new PointerEventData(current));
    }

    /// <summary>
    /// Default initializing.
    /// </summary>
    private void Awake()
    {
        // Set input field text.
        caretInputField.text = "Hello World";
    }

    /// <summary>
    /// Action initializing.
    /// </summary>
    private void Start()
    {
        // Add listeners.
        setCaretPositionButton.onClick.AddListener(OnSetCaretPositionClick);
        
        // Input field click.
        ClickInputField();
    }

    /// <summary>
    /// Change UI element values.
    /// </summary>
    private void LateUpdate()
    {
        // Change caret position.
        caretInputField.caretPosition = caretPosition;
    }

    /// <summary>
    /// Set random caret position.
    /// </summary>
    private void OnSetCaretPositionClick()
    {
        // Input field click.
        ClickInputField();
        
        // Change caret position from random number.
        var randomCaretPosition = Random.Range(0, caretInputField.text.Length);
        caretPositionText.text = randomCaretPosition.ToString();
        caretPosition = randomCaretPosition;
    }
}