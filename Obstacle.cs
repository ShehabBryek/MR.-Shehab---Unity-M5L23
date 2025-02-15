using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Obstacle : MonoBehaviour
{
    public float scaleMax = 1.3f;
    public float scaleMin = 0.7f;
 
    public float rotationMax = 180f;
    public float rotationMin = 0f;
 
    public GameObject explosionPlayer;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Player player = collision.GetComponent<Player>();
            GameObject effect = Instantiate(explosionPlayer, player.transform.position, player.transform.rotation);
            Destroy(effect, 5);
            Destroy(collision.gameObject);
        }
    }
 
    private void Start()
    {
        randomSize();
        randomRotation();
    }
 
    void randomSize()
    {
        float scaleFactor = Random.Range(scaleMin, scaleMax);
        transform.localScale = (Vector2)transform.localScale * scaleFactor;
    }
 
 
    void randomRotation()
    {
        float rotationFactor = Random.Range(rotationMin, rotationMax);
        transform.localEulerAngles = Vector3.forward * rotationFactor;
    }
}




