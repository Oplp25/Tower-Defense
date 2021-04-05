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
    public float moveSpeed;
    public int vectorOn = 0;
    public bool attacking = false;
    public Vector3 coordHeadingTo;
    public List<Vector3> levelCoords;
    public Vector3 moveDirection;
    public string[] targetList = { "castle", "defenders", "any", "rangedTwo", "rangedOne", "melee" };
    private string PreferredTargets;

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
    public void move() 
    {
        this.transform.position = new Vector3(Mathf.Round(this.transform.position.x*100f)/100f, Mathf.Round(this.transform.position.y*100f)/100f);
        this.moveDirection = transform.position - this.coordHeadingTo;
        if (this.moveDirection.x==0.0)
        {
            if (this.moveDirection.y >= 0.0)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - this.moveSpeed);
            }
            else if(this.moveDirection.y < 0.0)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + this.moveSpeed);
            }
        }
        else if (this.moveDirection.y==0.0)
        {
            if (moveDirection.x >= 0.0)
            {
                transform.position = new Vector3(transform.position.x - this.moveSpeed, transform.position.y);
            }
            else if (this.moveDirection.x < 0.0)
            {
                transform.position = new Vector3(transform.position.x + this.moveSpeed, transform.position.y);
            }
        }
    }
    public void attack() { }
    public void takeDamage() { }
    public void reachedCastle() 
    {
        Destroy(gameObject);
    }
    public void death() { }
    public void Update()
    {
        if (this.transform.position==this.coordHeadingTo)
        {
            this.vectorOn++;
            if (this.vectorOn > this.levelCoords.Count)
            {
                reachedCastle();
            }
            this.coordHeadingTo = this.levelCoords[this.vectorOn];
        }
        canAttack();
        move();
    }
}
