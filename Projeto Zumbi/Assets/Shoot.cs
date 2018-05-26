using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public Camera myCam;
    int gunDamage;
    [SerializeField] private GameObject gun;
    [SerializeField] private Material[] GunMaterial = new Material[3];
    [SerializeField] private AudioSource[] GunAudio = new AudioSource[3];
    [SerializeField] private AudioClip[] GunClips = new AudioClip[3];
    int selectedClip = 0;

    // Use this for initialization
    void Start () {
        gunDamage = 20;
        gun.GetComponent<Renderer>().material = GunMaterial[0];
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown ("Fire1"))
        {
           // Debug.Log("Shot!");
            Fire();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            gunDamage = 20;
            ChangeWeapon(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            gunDamage = 50;
            ChangeWeapon(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            gunDamage = 100;
            ChangeWeapon(2);
        }

    }
    private void Fire()
    {
        RaycastHit hit;
        if (Physics.Raycast(myCam.transform.position, myCam.transform.forward, out hit))
        {
            TakeHit take = hit.transform.GetComponent<TakeHit>();
            if (take != null)
            {
                take.Hit(gunDamage);
            }
        }

        foreach(AudioSource a in GunAudio)
        {
            if (!a.isPlaying)
            {
                a.PlayOneShot(GunClips[selectedClip]);
                break;
            }
        }

    }

    private void ChangeWeapon(int mat)
    {
        gun.GetComponent<Renderer>().material = GunMaterial[mat];
        selectedClip = mat;
    }
}
