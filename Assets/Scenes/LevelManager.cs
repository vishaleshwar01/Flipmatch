using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Button[] levelButtons;

    void Start()
    {
        int levelUnlocked = PlayerPrefs.GetInt("levelUnlocked", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            // Enable only unlocked levels
            levelButtons[i].interactable = (i + 1) <= levelUnlocked;
        }
    }

    public void OpenLevel(int levelIndex)
    {
        SceneManager.LoadScene("Level" + levelIndex);
    }
}


