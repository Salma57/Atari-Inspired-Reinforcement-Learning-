using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick2P_2 : MonoBehaviour
{
    public int hits = 1;
    public int points = 100;
    public Vector3 rotator;
    public Material hitMaterial;

 
    Material _orgMaterial;
    Renderer _renderer;

    void Start()
    {
        transform.Rotate(rotator * (transform.position.x + transform.position.y) * 0.1f);

       
        _renderer = GetComponent<Renderer>();
        _orgMaterial = _renderer.sharedMaterial;
    }


    void Update()
    {
        transform.Rotate(rotator * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        hits--;
        if (hits <= 0)
        {
            GameManager.Instance.Score2 += points;
            Destroy(gameObject);
        }

        
        _renderer.sharedMaterial = hitMaterial;
        Invoke("RestoreMaterial", 0.05f);
    }

    
    void RestoreMaterial()
    {
        _renderer.sharedMaterial = _orgMaterial;
    }

}