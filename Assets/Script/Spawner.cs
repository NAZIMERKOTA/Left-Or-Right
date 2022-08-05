using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Player PlayerScript;
    public GameObject Engeller;
    public GameObject Mermiler;
    public float height;
    public float heightM;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator SpawnObject(float time)
    {
        while (!PlayerScript.isDead)
        {
            Instantiate(Engeller, new Vector3( Random.Range(-height, height),6, 0), Quaternion.identity);
            Instantiate(Mermiler, new Vector3(Random.Range(-heightM, heightM), 7, 0), Quaternion.identity);
            Instantiate(Mermiler, new Vector3(Random.Range(-heightM, heightM), 7, 0), Quaternion.identity);

            yield return new WaitForSeconds(time);
        }

    }
}
