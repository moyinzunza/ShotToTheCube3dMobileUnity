using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTNT : MonoBehaviour {

    private Collider[] hitColliders;
    public GameObject particulas;
    public float blastRadius;
    public float explosionPower;
    public LayerMask explosionLayers;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "bullet" || collider.gameObject.tag == "Suelo" || collider.gameObject.tag == "SueloAntigravedad")
        {

            particulas.SetActive(true);
            Explotar(collider.contacts[0].point);
            Destroy(gameObject);

        }
    }
    void Explotar(Vector3 explosionPoint)
    {
        hitColliders = Physics.OverlapSphere(explosionPoint, blastRadius, explosionLayers);
        foreach(Collider hitCol in hitColliders){
            if (hitCol.GetComponent<Rigidbody>() != null) {
                hitCol.GetComponent<Rigidbody>().isKinematic = false;
                hitCol.GetComponent<Rigidbody>().AddExplosionForce(explosionPower, explosionPoint, blastRadius, 1, ForceMode.Impulse);
            }
        }
        //this.gameObject.SetActive(false);

    }
}
