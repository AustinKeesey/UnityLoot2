using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public SpriteRenderer WeaponRenderer;
    public List <GameObject> ProjectileWeapons = new List<GameObject>();
    public List <GameObject> MeleeWeapons = new List<GameObject>();

    public void OnClickButton (GameObject sprite)
    {
        /// <summary>
        /// A method is called when the user clicks any button and then unity prints a sprite on the users interface.
        /// </summary>
        /// <param name ="newSprite"></param>
        /// 
        SetWeapon(sprite);
    }
    public void SetWeapon(GameObject newSprite)
    {
        /// <summary>
        /// This is method checks if there is an image to be and if not, the system throws an exception.
        /// then all other weapons are turned off and are not displayed except the singular range or melee game object that gets called.
        /// <param namer="newSprite"></param>
        if (newSprite == null )
        {
            throw new System.Exception("QUACK");
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