using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootttt : MonoBehaviour
{
    public GameObject patlama;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "DeathArea")
        {
            Destroy(gameObject);
            GameObject abc = Instantiate(patlama, transform.position, Quaternion.identity) as GameObject;
            Destroy(abc, 0.45f);
        }
    }
}
