using UnityEngine;

public class destroyGameObject : MonoBehaviour
{
    [SerializeField] private float timeToDestroy;
    void Start()
    {
        
    }

    void Update()
    {
        timeToDestroy += Time.deltaTime;
        if (timeToDestroy >= 3)
        {
            Destroy(gameObject);
            timeToDestroy = 0;
        }   
    }
}
