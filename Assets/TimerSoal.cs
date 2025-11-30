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

    void Start()
    {
        waktu = durasiDetik;

        if (panelSelesai != null)
            panelSelesai.SetActive(false);

        if (panelSoal != null)
            panelSoal.SetActive(true);

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
        Debug.Log("Waktu habis - menampilkan panel selesai");

        if (panelSoal == null)
        {
            Debug.LogWarning("panelSoal belum diassign di Inspector!");
            if (panelSelesai != null) panelSelesai.SetActive(true);
            return;
        }

        for (int i = 0; i < panelSoal.transform.childCount; i++)
        {
            Transform child = panelSoal.transform.GetChild(i);
            string nama = child.name.ToLower();

            if (nama == "selesai")
            {
                child.gameObject.SetActive(true);
            }
            else if (nama == "skor")
            {
                child.gameObject.SetActive(true);
            }
            else
            {
                child.gameObject.SetActive(false);
            }
        }

        if (panelSelesai != null && panelSelesai.transform.parent != panelSoal.transform)
        {
            panelSelesai.SetActive(true);
        }
    }

    public void StopTimer()
    {
        timerOn = false;
    }

    public void ResetAndStartTimer()
    {
        waktu = durasiDetik;
        timerOn = true;
        UpdateTimerText();
    }
}
