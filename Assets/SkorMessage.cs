using UnityEngine;
using UnityEngine.UI;

public class SkorMessage : MonoBehaviour
{
    public Text pesanText;

    void Start()
    {
        int skor = PlayerPrefs.GetInt("skor", 0);

        if (pesanText == null) return;

        if (skor >= 70)
        {
            pesanText.text = "Selamat! Kamu mendapatkan skor tinggi!";
        }
        else
        {
            pesanText.text = "Tetap semangat! Kamu bisa mencoba lagi.";
        }
    }
}
