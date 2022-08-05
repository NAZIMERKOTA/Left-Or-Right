using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermi : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        Destroy(gameObject, 5);
        transform.Rotate(0, 0, 180);
    }

    void FixedUpdate()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
