using UnityEngine;
using DG.Tweening;

public class Bounce : MonoBehaviour
{
    [SerializeField] private Transform circleChild;

    public Transform CircleChild
    {
        get => circleChild;
        set => circleChild = value;
    }

    public void SpriteBounce()
    {
        var bounce = DOTween.Sequence();
        bounce.Append(circleChild.DOScale(0, 0.5f));
        bounce.Append(circleChild.DOScale(1.2f,0.5f));
        bounce.Append(circleChild.DOScale(0.95f,0.5f));
        bounce.Append(circleChild.DOScale(1,0.5f));
        circleChild = null;
    }

}
