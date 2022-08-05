using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isDead;
    public GameManager managerGame;
    public GameObject DeathScreen;
    public GameObject Atesshoot;
    public Transform atesNoktasi;
    public float AtisHizi;
    public float Sayac;
    
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Sayac -= Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Physics2D.gravity = new Vector2(-9.81f, 0f);

            //transform.Rotate(0, 0, 15);
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Physics2D.gravity = new Vector2(9.81f, 0f);

            //transform.Rotate(0, 0, -15);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = transform.position + new Vector3(0, 0.2f , 0);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = transform.position + new Vector3(0, -0.2f , 0);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Sayac <= 0)
            {
                shoot();
                Sayac = 1f;
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore();  
        }
        if(collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;

            DeathScreen.SetActive(true);
        }
        

    }
    public void RightButton()
    {
        Physics2D.gravity = new Vector2(9.81f, 0f);

        //transform.Rotate(0, 0, -15);
    }

    public void LeftButton()
    {
        Physics2D.gravity = new Vector2(-9.81f, 0f);

        //transform.Rotate(0, 0, 15);
    }

    public void MiddleButton()
    {
        if (Sayac <= 0)
        {
            shoot();
            Sayac = 1f;
        }
    }

    public void shoot()
    {
        GameObject shoott= Instantiate(Atesshoot, atesNoktasi.position, Quaternion.identity);
        shoott.GetComponent<Rigidbody2D>().velocity = new Vector2(0, AtisHizi * Time.deltaTime);
    }

    

}
