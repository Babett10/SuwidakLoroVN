using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

    public TextMeshProUGUI musicValue;
    public AudioMixer musicMixer;
    public TextMeshProUGUI soundsValue;
    public AudioMixer soundsMixer;

    private Animator animator;
    private int _window = 0;

    public void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void CloseSetting()
    {
         animator.SetTrigger("HideOptions");
            _window = 0;
    }

    public void Intro()
    {
        SceneManager.LoadScene("Intro");
    }

    public void Chapter1()
    {
        SceneManager.LoadScene("Game");
    }

    public void Chapter2()
    {
        SceneManager.LoadScene("Game 2");
    }
    public void Chapter3()
    {
        SceneManager.LoadScene("Game 3");
    }


    public void ShowOptions()
     {
         animator.SetTrigger("ShowOptions");
        _window = 1;
     }

    public void Quit()
    {
        Application.Quit();
    }
    
    public void OnMusicChanged(float value)
    {
        musicValue.SetText(value + "%");
        musicMixer.SetFloat("volume", -50 + value / 2);
    }
    
    public void OnSoundsChanged(float value)
    {
        soundsValue.SetText(value + "%");
        soundsMixer.SetFloat("volume", -50 + value / 2);
    }
}
