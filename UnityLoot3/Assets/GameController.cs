using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
     public SpriteRenderer WeaponRenderer;
    public List <GameObject> ProjectileWeapons = new List<GameObject>();
    public List <GameObject> MeleeWeapons = new List<GameObject>();

    public void SetWeapon(GameObject newSprite)
    {
        if (newSprite == null )
        {
            throw new System.Exception("bro where the object at");
        }

        
        foreach (GameObject weapon in MeleeWeapons)
        {
            weapon.SetActive(false);
        }
        System.Random generator = new System.Random();
        int index = generator.Next(0, MeleeWeapons.Count);
        MeleeWeapons[index].SetActive(true);
        // newSprite.SetActive(true);

        foreach (GameObject weapon in ProjectileWeapons)
        {
            weapon.SetActive(false);
        }

        int index1 = generator.Next(0, ProjectileWeapons.Count);
        ProjectileWeapons[index1].SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
       foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Weapon"))
       {
           MeleeWeapons.Add(obj);
       }

        foreach(GameObject obj in GameObject.FindGameObjectsWithTag("Projectile"))
        {
            ProjectileWeapons.Add(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}