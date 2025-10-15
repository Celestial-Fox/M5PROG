using Unity.VisualScripting;
using UnityEngine;

public class towerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject towerPrefab;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        GameObject tower = Instantiate(towerPrefab);
    }
}
