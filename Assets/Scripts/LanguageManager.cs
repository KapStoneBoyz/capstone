using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    // Store translations for each language
    private Dictionary<string, Dictionary<string, string>> translations;

    // Current language
    private string currentLanguage = "en";

    // UI Text element for dialogue
    public TMP_Text dialogueText;

    void Start()
    {
        // Initialize translations
        translations = new Dictionary<string, Dictionary<string, string>>()
        {
            { "en", new Dictionary<string, string>()
                {
                    { "greeting", "Hello!" },
                    { "farewell", "Goodbye!" }
                }
            },
            { "es", new Dictionary<string, string>()
                {
                    { "greeting", "¡Hola!" },
                    { "farewell", "¡Adiós!" }
                }
            },
            { "fr", new Dictionary<string, string>()
                {
                    { "greeting", "Bonjour!" },
                    { "farewell", "Au revoir!" }
                }
            }
        };

        // Set default language
        UpdateDialogue("greeting");
    }

    // Method to switch language
    public void SwitchLanguage(string newLanguage)
    {
        if (translations.ContainsKey(newLanguage))
        {
            currentLanguage = newLanguage;
            UpdateDialogue("greeting"); // Update the dialogue with the new language
        }
        else
        {
            Debug.LogWarning("Language not found: " + newLanguage);
        }
    }

    // Method to update dialogue text
    private void UpdateDialogue(string key)
    {
        if (translations[currentLanguage].ContainsKey(key))
        {
            dialogueText.text = translations[currentLanguage][key]; 
        }
        else
        {
            Debug.LogWarning("Key not found in current language: " + key);
        }
    }
}