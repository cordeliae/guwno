using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruch : MonoBehaviour
{
    public SoulsManager sm;
    // Update is called once per frame
    void FixedUpdate()
    {
       if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * 0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * 0.1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 0.1f);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("soul"))
        {
            other.gameObject.SetActive(false);
            sm.soulCount++;
        }
    }
}
