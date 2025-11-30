using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class SkorDisplay : MonoBehaviour
{
    private const string KEY_CURRENT_SCORE = "skor";
    private Text txt;

    void Awake()
    {
        txt = GetComponent<Text>();
    }

    void Update()
    {
        if (txt != null)
            txt.text = PlayerPrefs.GetInt(KEY_CURRENT_SCORE, 0).ToString();
    }
}
