using UnityEngine;

public class towerMeasure : MonoBehaviour
{
    private float randX;
    private float randY;
    private float randZ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randX = Random.Range(0, 1);
        randY = Random.Range(0, 1);
        randZ = Random.Range(0, 1);

        if (randX < 0.5)
        {
            randX = randX * 2;
        }
        if (randY < 0.5)
        {
            randY = randY * 2;
        } 
        if (randZ < 0.5)
        {
            randZ = randZ * 2;
        }

            transform.localScale = new Vector3(randX, randY, randZ);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
