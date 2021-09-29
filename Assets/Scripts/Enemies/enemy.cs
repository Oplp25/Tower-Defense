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
    public SpriteRenderer sprite;
    public string[] targetList = { "castle", "defenders", "any", "rangedTwo", "rangedOne", "melee" };
    private string PreferredTargets;
    private bool redColour;
    private float startedDamage;

    public void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
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
        this.transform.position = new Vector3(Mathf.Round(this.transform.position.x*1000f)/1000f, Mathf.Round(this.transform.position.y*1000f)/1000f);
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
    public void takeDamage(int damage)
    {
        if (!this.redColour)
        {
            sprite.color = new Color(1, 0, 0, 1);
            this.redColour = true;
            startedDamage = Time.time;
            this.healthCurrent -= damage;
            Debug.Log("Taken Damage, " + this.healthCurrent);
        } 
    }

    public void reachedCastle() 
    {
        death();
    }
    public void death()
    {
        levelParent.enemiesCurrentlySpawned.Remove(gameObject);
        orcSpawner.orcsCurrentlySpawned.Remove(gameObject);
        Destroy(gameObject);
    }
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
        if (this.redColour)
        {
            if (Time.time - startedDamage>=1.0f)
            {
                sprite.color = new Color(1,1,1,1);
                this.redColour = false;
            }
        }
        if (this.healthCurrent <= 0)
        {
            death();
        }
        canAttack();
        move();
    }
}
