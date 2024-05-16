using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveScript : MonoBehaviour
{
    public List<GameObject> enemiesList;
   [SerializeField] public int wave;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void Waves()
    {
        List<GameObject> Enemies = new List<GameObject>;

        for (int i = 0; i < wave; i++)
        {
            Enemies.Add(enemiesList[1]);
        }
    }


}
