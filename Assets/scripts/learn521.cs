using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learn521 : MonoBehaviour
{
    [SerializeField]
    private int count;

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
        //�X�y�[�X����������o�E���h�~�܂�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
