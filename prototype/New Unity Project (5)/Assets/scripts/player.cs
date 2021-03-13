using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    

        ///[SerializeField] private LayerMask platformsLayerMask;
        /// private Player_Base playerBase;
        private Rigidbody2D rigidbody2d;
        private BoxCollider2D boxCollider2d;


        private void Awake()
        {
            //playerBase = gameObject.GetComponent<Player_Base>();
            rigidbody2d = transform.GetComponent<Rigidbody2D>();
            boxCollider2d = transform.GetComponent<BoxCollider2D>();
        }
    private void OnTriggeEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("coin 1"))
        {
            Destroy(other.gameObject);
        }
    }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                float jumpVelocity = 10f;
                rigidbody2d.velocity = Vector2.up * jumpVelocity;
            }


        }
    }



