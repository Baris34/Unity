using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public float jump;

    Rigidbody rb;
    public GameObject splashPrefab;
    private GameManager gm;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        gm=GameObject.FindObjectOfType<GameManager>();
    }

    

    private void OnCollisionEnter(Collision collision)
    {
        GameObject splash = Instantiate(splashPrefab, transform.position+new Vector3(0,-0.2f,0), transform.rotation);

        splash.transform.SetParent(collision.gameObject.transform);


        if (collision.gameObject.tag=="siyah") 
        {
            rb.velocity = Vector3.up * jump;
        }
        else if (collision.gameObject.tag=="sarý")
        {
            gm.RestartGame();
        }
        else if (collision.gameObject.tag=="zemin")
        {
            gm.GameOver();
        }
        
    }

}
