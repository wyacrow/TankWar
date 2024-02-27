using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float moveSpeed;
    [SerializeField] private float xInput;
    private float yInput;

    [SerializeField] private bool isLevel;

    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        isLevel = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2 (xInput * moveSpeed, yInput * moveSpeed);
    }

    private void rotate()
    {
        
    }
}
