using DG.Tweening;
using UnityEngine;

public class EaseIn : MonoBehaviour
{
    [SerializeField] private Transform _easeInImage;
    
    [SerializeField] private GameStatusData _gameStatusData;
    
    public Transform EaseInImage
    {
        get => _easeInImage;
        set => _easeInImage = value;
    }

    private Vector3 _imageLocation;
    
    [Range(1.0f, 10.0f), SerializeField] private float _moveDuration = 0.2f;
    
    [SerializeField] private Ease _moveEase = Ease.InOutBounce;
    
    public void EaseInStart()
    {
        _imageLocation.y = _gameStatusData.CurrentGameObject.transform.position.y;
        _imageLocation.x = _gameStatusData.CurrentGameObject.transform.position.x-0.5f;
        var Ease = DOTween.Sequence();
        Ease.Append(_easeInImage.DOMove(_imageLocation, _moveDuration).SetEase(_moveEase));
        _imageLocation.x = _gameStatusData.CurrentGameObject.transform.position.x+0.5f;
        Ease.Append(_easeInImage.DOMove(_imageLocation, _moveDuration).SetEase(_moveEase));
        _imageLocation = _gameStatusData.CurrentGameObject.transform.position;
        Ease.Append(_easeInImage.DOMove(_imageLocation, _moveDuration).SetEase(_moveEase));
       
        _easeInImage = null;
        _gameStatusData.CurrentGameObject = null;
        _imageLocation = Vector3.zero;
    }
}
