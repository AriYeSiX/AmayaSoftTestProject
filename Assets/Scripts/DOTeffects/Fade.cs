using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Fade : MonoBehaviour
{
    [SerializeField] private Text questTargetFadeIn;
    
    public Text QuestTargetFadeIn
    {
        get => questTargetFadeIn;
        set => questTargetFadeIn = value;
    }

    [SerializeField] private Image _restartBackground;
    
    public void FadeIn()
    {
        questTargetFadeIn.DOFade(1.0f, 5.5f);
    }

    public void FadeInRestart()
    {
        _restartBackground.DOFade(0.6f, 4.0f);
    }

    public void FadeOutRestart()
    {
        _restartBackground.DOFade(0.0f, 4.0f);
    }
}
