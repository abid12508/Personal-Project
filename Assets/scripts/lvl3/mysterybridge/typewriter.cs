using System.Collections;
using TMPro;
using UnityEngine;

public class typewriter : MonoBehaviour
{
    private float typingSpeed = 0.01f; // Time between each character
    private TextMeshProUGUI textMeshPro; // Reference to the TextMeshPro component

    private void Awake()
    {
        // Get the TextMeshProUGUI component
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    public void StartTypewriterEffect(string message)
    {
        // Start the typewriter effect coroutine
        StartCoroutine(TypeText(message));
    }

    private IEnumerator TypeText(string message)
    {
        // Set the text to an empty string initially
        textMeshPro.text = "";

        foreach (char letter in message.ToCharArray())
        {
            textMeshPro.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
