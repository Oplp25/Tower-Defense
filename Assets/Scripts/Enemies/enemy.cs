using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class enemy : MonoBehaviour
{
    
    public int healthTotal;
    public int healthCurrent;
    public int damage;
    public int range;
    public int drops;
    public int speed;
    public bool attacking = false;
    public Vector3 coordHeadingTo;
    public Vector3[] levelCoords;
    public string[] targetList = { "castle", "defenders", "any", "rangedTwo", "rangedOne", "melee" };
    private string PreferredTargets;

    /*private void Awake()
    {
        this.Init();
    }*/
    public string preferredTargets
    {
        get { return PreferredTargets; }
        set { 
            
            if (targetList.Contains(PreferredTargets))
                {
                    PreferredTargets = value;  
                }
            else
                {
                    PreferredTargets = "any";
                }

            }
    }
    public void canAttack() { }
    public void move() { }
    public void attack() { }
    public void takeDamage() { }
    public void reachedCastle() { }
    public void death() { }
    public void Update()
    {
        canAttack();
        move();
    }
}
