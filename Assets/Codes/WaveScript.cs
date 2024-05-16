using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveScript : MonoBehaviour
{
    public List<Transform> spawnPoints = new List<Transform>();

    public List<GameObject> enemiesList = new List<GameObject>();

   [SerializeField] public int wave;

    public int enemiesAlive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemiesAlive <= 0)
        {
            wave++;
            Waves();
        }
    }
    void Waves()
    {
        List<GameObject> Enemies = new List<GameObject>();

        if (wave >= 5)
        {
            for (int i = 0; i < wave - 4; i++)
            {
                Enemies.Add(enemiesList[1]);
            }
        }

        int numberOfEnemies =  (int) Mathf.Round(Mathf.Pow(wave, 1.5f));

        for (int i = 0; i < numberOfEnemies; i++)
        {
            Enemies.Add(enemiesList[0]);
        }

        foreach (GameObject enemie in Enemies)
        {
            Instantiate(enemie, spawnPoints[Random.Range(0, spawnPoints.Count)]);
            enemiesAlive++;
        }
    }


}
