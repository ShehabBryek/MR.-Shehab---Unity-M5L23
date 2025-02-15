

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Item : MonoBehaviour
{
 
    public GameObject pickupEffect;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Player player = collision.GetComponent<Player>();
            player.points++;
            GameObject effect = Instantiate(pickupEffect, transform.position, transform.rotation);
            Destroy(effect, 5);
            Destroy(this.gameObject);
        }
    }
}
