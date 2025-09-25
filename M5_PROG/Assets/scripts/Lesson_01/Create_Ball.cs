using UnityEngine;

public class Create_Ball : MonoBehaviour
{
    [SerializeField]private GameObject prefab;
    private float elapsedTime;

    //creates variable for the following script
    private float r;
    private float g;
    private float b;

    Color randColor = new Color();
    Vector3 randPosition = new Vector3 ();

    void Start()
    {
        //randomizes values at the start
        r = Random.Range(0f, 1f);
        g = Random.Range(0f, 1f);
        b = Random.Range(0f, 1f);

        randColor = new Color(r, g, b, 0);
        randPosition = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));
        //Calls upon CreateBall() 100 times
        for (int i = 0; i <100 ; i++)
        {
            CreateBall(randColor, randPosition);
        }
    }

    private void Update()
    {
        //Creates a random color every frame
        /*r = Random.Range(0f,1f);
        g = Random.Range(0f,1f);
        b = Random.Range(0f,1f);
        randColor = new Color(r, g, b, 1f);

        Vector3 randPosition = new Vector3(Random.Range(5,5), Random.Range(-5, 5), Random.Range(-5, 5));*/

        //Creates a ball every second
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {
            CreateBall(randColor, randPosition);
            elapsedTime = 0f;
        }

        
    }

    //Function to instantiate a prefab
    private GameObject CreateBall(Color c, Vector3 position)
    {
        GameObject ball = Instantiate(prefab, position, Quaternion.identity);
        Material material = ball.GetComponent<MeshRenderer>().material;

        if (material.shader.name == "Universal Render Pipeline/Lit")
        {
            material.SetColor("_BaseColor", c);
        }
        r = Random.Range(0f, 1f);
        g = Random.Range(0f, 1f);
        b = Random.Range(0f, 1f);
        randColor = new Color(r, g, b, 0);
        randPosition = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));

        return ball;
    }
}
