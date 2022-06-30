using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learn521 : MonoBehaviour
{
    [SerializeField]
    private float BallSpeed;

    [SerializeField]
    private Rigidbody rigidBody;

    private void Awake()
    {
        //rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        //スペースを押したらバウンド止まる
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // rigidBody.constraints = RigidbodyConstraints.FreezeAll;
            rigidBody.velocity = Vector3.up ;
        }
    }
}
