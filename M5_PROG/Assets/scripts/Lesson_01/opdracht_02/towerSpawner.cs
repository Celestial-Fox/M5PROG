using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class towerSpawner : MonoBehaviour /*IPointerDownHandler*/
{
    [SerializeField] private GameObject towerPrefab;

    private float r;
    private float g;
    private float b;

    Color randColor = new Color();
    Vector3 randPosition = new Vector3();
    void Update()
    {
        
    }

    /*public void OnPointerDown(PointerEventData pointerEventData)
    {
        Debug.Log("!!!");
    }*/

    void OnGUI()
    {
        Event m_Event = Event.current;

        if (m_Event.type == EventType.MouseDown)
        {
            CreateTower( randPosition);
        }
    }

    private GameObject CreateTower( Vector3 position)
    {
        GameObject tower = Instantiate(towerPrefab, position, Quaternion.identity);
        
        r = Random.Range(0f, 1f);
        g = Random.Range(0f, 1f);
        b = Random.Range(0f, 1f);
        randColor = new Color(r, g, b, 0);
        randPosition = new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5));

        return tower;
    }
}
