using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string nextLevelName;

    private void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Brick").Length == 0)
        {
            SceneManager.LoadScene(nextLevelName);
        }
    }
}