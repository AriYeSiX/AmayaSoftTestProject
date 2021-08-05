using System;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    private float _nextClick = 0.0f;
    
    private float _clickReload = 1.0f;
    
    [SerializeField] private GameStatusData _gameStatusData;

    private void Start()
    {
       _gameStatusData = FindObjectOfType<GameStatusData>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown (0)) {
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            RaycastHit2D[] hits = Physics2D.GetRayIntersectionAll (ray, Mathf.Infinity);
            foreach (var hit in hits) {
                if (hit.collider.name == name && Time.time > _nextClick)
                {
                    _nextClick = Time.time + _clickReload;
                    _gameStatusData.CurrentGameObject = gameObject;
                }
            }
        }
    }
}
