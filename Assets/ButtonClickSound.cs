using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonClickSound : MonoBehaviour
{
    private Button button;
    private static AudioSource audioSource;

    void Awake()
    {
        button = GetComponent<Button>();

        if (audioSource == null)
        {
            GameObject go = new GameObject("ButtonClickAudio");
            audioSource = go.AddComponent<AudioSource>();
            DontDestroyOnLoad(go);
        }

        button.onClick.AddListener(PlayClickSound);
    }

    public void PlayClickSound()
    {
        if (ButtonSoundManager.Instance != null)
            ButtonSoundManager.Instance.PlaySound();
    }
}
