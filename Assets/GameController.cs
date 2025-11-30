using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private const string KEY_CURRENT_SCORE = "skor";
    private const string KEY_LAST_PROCESSED = "lastScoreProcessed";

    public void StartGame(string levelSceneName)
    {
        PlayerPrefs.SetInt(KEY_CURRENT_SCORE, 0);
        PlayerPrefs.SetInt(KEY_LAST_PROCESSED, 0);
        PlayerPrefs.Save();

        SceneManager.LoadScene(levelSceneName);
    }

    public void FinishAndShowHighscore(string highscoreSceneName)
    {
        PlayerPrefs.Save();
        PlayerPrefs.SetInt(KEY_LAST_PROCESSED, 0);
        PlayerPrefs.Save();

        SceneManager.LoadScene(highscoreSceneName);
    }
}
