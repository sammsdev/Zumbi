using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeHit : MonoBehaviour {

    int health;
    [SerializeField] private ParticleSystem myDead;

	// Use this for initialization
	void Start () {
		health = 100;
        myDead = GetComponentInChildren<ParticleSystem>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Hit(int damage)
    {
        health -= damage;
       
        VerifyIfDead();
    }
    private void VerifyIfDead()
    {
        if
         (health <= 0)
        {
          
            myDead.Play();
            GetComponent<MeshFilter>().mesh = null;
            GetComponent<CapsuleCollider>().isTrigger = true;
            Destroy(gameObject, myDead.duration);
        }
    }
}
