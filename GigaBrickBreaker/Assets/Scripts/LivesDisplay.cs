using TMPro;
using UnityEngine;

public class LivesDisplay : MonoBehaviour
{
    public GameData gameData; // Reference to the GameData instance
    public TextMeshProUGUI livesText; // Public variable for the TextMeshProUGUI component

    private void Update()
    {
        livesText.text = "Lives: " + gameData.lives.ToString();
    }
}