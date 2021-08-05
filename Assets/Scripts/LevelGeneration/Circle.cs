using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] private Vector3 position;
    
    public void Initialisation(Vector3 position)
    {
        this.position = position;
        transform.position = position;
    }
}
