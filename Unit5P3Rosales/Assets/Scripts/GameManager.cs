using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float spwanRate = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnTarget()
    {
        while (true)
        {


            yield return new WaitForSeconds(spwanRate);
            int index = Random.Range(0, Target.Count);
            Instantiate(targets[index]);
        }
    }
}
