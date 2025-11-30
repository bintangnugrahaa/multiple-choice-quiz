using UnityEngine;
using UnityEngine.UI;

public class TimerSoal : MonoBehaviour
{
    public Text timerText;
    public GameObject panelSoal;
    public GameObject panelSelesai;

    public float durasiDetik = 120f;

    private float waktu;
    private bool timerOn = false;

    private const string KEY_CURRENT_SCORE = "skor";

    void Start()
    {
        waktu = durasiDetik;

        if (panelSelesai != null) panelSelesai.SetActive(false);
        if (panelSoal != null) panelSoal.SetActive(true);

        timerOn = true;
        UpdateTimerText();
    }

    void Update()
    {
        if (!timerOn) return;

        waktu -= Time.deltaTime;

        if (waktu <= 0f)
        {
            waktu = 0f;
            timerOn = false;
            UpdateTimerText();
            WaktuHabis();
        }
        else
        {
            UpdateTimerText();
        }
    }

    void UpdateTimerText()
    {
        if (timerText == null) return;

        int menit = Mathf.FloorToInt(waktu / 60f);
        int detik = Mathf.FloorToInt(waktu % 60f);

        timerText.text = menit.ToString("00") + ":" + detik.ToString("00");

        if (waktu <= 10f)
            timerText.color = Color.red;
    }

    void WaktuHabis()
    {
        int finalScore = PlayerPrefs.GetInt(KEY_CURRENT_SCORE, 0);
        SimpanKeHighscore(finalScore);

        if (panelSoal != null) panelSoal.SetActive(false);
        if (panelSelesai != null) panelSelesai.SetActive(true);
    }

    void SimpanKeHighscore(int skor)
    {
        int s1 = PlayerPrefs.GetInt("highscore1", 0);
        int s2 = PlayerPrefs.GetInt("highscore2", 0);
        int s3 = PlayerPrefs.GetInt("highscore3", 0);

        int[] arr = new int[] { s1, s2, s3, skor };
        System.Array.Sort(arr);

        PlayerPrefs.SetInt("highscore1", arr[3]);
        PlayerPrefs.SetInt("highscore2", arr[2]);
        PlayerPrefs.SetInt("highscore3", arr[1]);

        PlayerPrefs.Save();
    }
}
