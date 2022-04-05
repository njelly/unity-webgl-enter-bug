using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Example : MonoBehaviour
{
    public Text textComponent;
    
    private void Start()
    {
        Keyboard.current.onTextInput += OnTextInput;
    }

    private void OnDestroy()
    {
        Keyboard.current.onTextInput -= OnTextInput;
    }

    private void OnTextInput(char c)
    {
        textComponent.text += c;
    }
}
