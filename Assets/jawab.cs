using System.Collections;
using UnityEngine;

public class Jawab : MonoBehaviour
{
    public GameObject feed_benar;
    public GameObject feed_salah;

    private const string KEY_CURRENT_SCORE = "skor";

    public void jawaban(bool jawab)
    {
        if (jawab)
        {
            if (feed_benar != null)
            {
                feed_benar.SetActive(false);
                feed_benar.SetActive(true);
            }

            int skor = PlayerPrefs.GetInt(KEY_CURRENT_SCORE, 0) + 10;
            PlayerPrefs.SetInt(KEY_CURRENT_SCORE, skor);
            PlayerPrefs.Save();
        }
        else
        {
            if (feed_salah != null)
            {
                feed_salah.SetActive(false);
                feed_salah.SetActive(true);
            }
        }

        StartCoroutine(ProceedAfterDelay());
    }

    private IEnumerator ProceedAfterDelay()
    {
        yield return new WaitForSeconds(1f);

        gameObject.SetActive(false);

        Transform parent = transform.parent;
        int idx = transform.GetSiblingIndex();
        if (parent != null && idx + 1 < parent.childCount)
        {
            parent.GetChild(idx + 1).gameObject.SetActive(true);
        }
    }
}
