using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class HighScoreManager : MonoBehaviour
{
    public Text textSkor1;
    public Text textSkor2;
    public Text textSkor3;

    private const string KEY_HS1 = "highscore1";
    private const string KEY_HS2 = "highscore2";
    private const string KEY_HS3 = "highscore3";
    private const string KEY_LAST_PROCESSED = "lastScoreProcessed";
    private const string KEY_CURRENT_SCORE = "skor";

    void Start()
    {
        TryProcessLastScore();
        UpdateDisplay();
    }

    void TryProcessLastScore()
    {
        int sudah = PlayerPrefs.GetInt(KEY_LAST_PROCESSED, 0);
        if (sudah == 1) return;

        int skorTerakhir = PlayerPrefs.GetInt(KEY_CURRENT_SCORE, 0);

        if (skorTerakhir > 0)
        {
            SubmitNewScore(skorTerakhir);
        }

        PlayerPrefs.SetInt(KEY_LAST_PROCESSED, 1);
        PlayerPrefs.Save();
    }

    public void SubmitNewScore(int skorBaru)
    {
        int s1 = PlayerPrefs.GetInt(KEY_HS1, 0);
        int s2 = PlayerPrefs.GetInt(KEY_HS2, 0);
        int s3 = PlayerPrefs.GetInt(KEY_HS3, 0);

        List<int> list = new List<int> { s1, s2, s3, skorBaru };
        list.Sort((a, b) => b.CompareTo(a));

        int new1 = list.Count > 0 ? list[0] : 0;
        int new2 = list.Count > 1 ? list[1] : 0;
        int new3 = list.Count > 2 ? list[2] : 0;

        PlayerPrefs.SetInt(KEY_HS1, new1);
        PlayerPrefs.SetInt(KEY_HS2, new2);
        PlayerPrefs.SetInt(KEY_HS3, new3);
        PlayerPrefs.Save();

        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        if (textSkor1 != null) textSkor1.text = PlayerPrefs.GetInt(KEY_HS1, 0).ToString();
        if (textSkor2 != null) textSkor2.text = PlayerPrefs.GetInt(KEY_HS2, 0).ToString();
        if (textSkor3 != null) textSkor3.text = PlayerPrefs.GetInt(KEY_HS3, 0).ToString();
    }

    public void ResetHighScores()
    {
        PlayerPrefs.DeleteKey(KEY_HS1);
        PlayerPrefs.DeleteKey(KEY_HS2);
        PlayerPrefs.DeleteKey(KEY_HS3);
        PlayerPrefs.DeleteKey(KEY_LAST_PROCESSED);
        PlayerPrefs.Save();
        UpdateDisplay();
    }
}
