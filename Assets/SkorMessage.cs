using UnityEngine;
using UnityEngine.UI;

public class SkorMessage : MonoBehaviour
{
    public Text pesanText;
    public AudioSource audioSource;
    public AudioClip sfx_win;
    public AudioClip sfx_lose;

    void Start()
    {
        int skor = PlayerPrefs.GetInt("skor", 0);

        if (pesanText != null)
        {
            if (skor >= 70)
            {
                pesanText.text = "Selamat! Kamu mendapatkan skor tinggi!";
                PlaySfx(sfx_win);
            }
            else
            {
                pesanText.text = "Tetap semangat! Kamu bisa mencoba lagi.";
                PlaySfx(sfx_lose);
            }
        }
    }

    void PlaySfx(AudioClip clip)
    {
        if (clip == null) return;

        if (audioSource != null)
        {
            audioSource.PlayOneShot(clip);
        }
        else
        {
            AudioSource.PlayClipAtPoint(clip, Camera.main != null ? Camera.main.transform.position : Vector3.zero);
        }
    }
}
