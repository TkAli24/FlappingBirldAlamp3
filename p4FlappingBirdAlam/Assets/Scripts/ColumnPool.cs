using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{

    public int columPoolsize = 5;
    public GameObject Meteorprefab;
    public float spawnRate = 4f;
    public float meteorMin = -1f;
    public float meteorMax = 3.5f;


    private GameObject[] meteors;
    private float timeSinceLastSpawned;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private int currentMeteor = 0;
    private float spawnXPosition;
    // Start is called before the first frame update
    void Start()
    {
        meteors = new GameObject[columPoolsize];
        for (int i = 0; i< columPoolsize; i++)
        {
            meteors [i] = (GameObject)Instantiate (Meteorprefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;
        if (GameControl.instrance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range (meteorMin, meteorMax);
            meteors[currentMeteor].transform.position = new Vector2(spawnXPosition, spawnYPosition);

            currentMeteor++;
            {
                currentMeteor = 0;
            }
        }
    }
}
