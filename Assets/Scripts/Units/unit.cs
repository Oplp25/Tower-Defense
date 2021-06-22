using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class unit : MonoBehaviour
{
    public int healthTotal;
    public int healthCurrent;
    public int damage;
    public int range;
    public int cost;
    public Vector3[] cellsAround;
    public bool positioning;
    public void attack(enemy target)
    {
        target.takeDamage(this.damage);
        //animation
    }
    public void takeDamage() { }

    public void getCellsAround()
    {
        Vector3 p1 = new Vector3(this.transform.position.x - 2, this.transform.position.y);
        Vector3 p2 = new Vector3(this.transform.position.x, this.transform.position.y + 2);
        Vector3 p3 = new Vector3(this.transform.position.x + 2, this.transform.position.y + 2);
        Vector3 p4 = new Vector3(this.transform.position.x + 2, this.transform.position.y);
        Vector3 p5 = new Vector3(this.transform.position.x + 2, this.transform.position.y - 2);
        Vector3 p6 = new Vector3(this.transform.position.x, this.transform.position.y - 2);
        Vector3 p7 = new Vector3(this.transform.position.x - 2, this.transform.position.y - 2);
        Vector3 p8 = new Vector3(this.transform.position.x - 2, this.transform.position.y + 2);
        this.cellsAround =new Vector3[8]{ p1, p2, p3, p4, p5, p6, p7, p8 };
        foreach (Vector3 i in this.cellsAround)
        {
            Debug.Log(i);
        }
    }
    public void loopedCanAttack(GameObject toCheck)
    {
        if (this.cellsAround.Contains(toCheck.transform.position))
        {
            attack(toCheck.GetComponentInChildren<enemy>(true));
        }
    }
    public void canAttack()
    {
        levelParent.enemiesCurrentlySpawned.ForEach(loopedCanAttack);
    }
    public void death()
    {
        Destroy(gameObject);
    }
    public void checkIfOnRoad()
    {
       foreach (GameObject i in GameObject.FindGameObjectsWithTag("road"))
       {
           if (i.transform.position.x == transform.position.x & i.transform.position.y == transform.position.y)
           {
               death();
           }
        }
    }
    public void positioningMethod()
    {
        if (positioning)
        {
            Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
            objectPos.x = Input.mousePosition.x;
            objectPos.y = Input.mousePosition.y;
            transform.position = Camera.main.ScreenToWorldPoint(objectPos);
            if (Input.GetMouseButtonUp(0))
            {
                positioning = false;
                transform.position = new Vector3(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y), transform.position.z);
                if (transform.position.y % 2f == 0f)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
                }
                if (!(transform.position.x % 2f == 0f))
                {
                    transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
                    
                }
                getCellsAround();
                checkIfOnRoad();
            }
        }
    }

    public void Update()
    {
        canAttack();
        positioningMethod();
    }
}
