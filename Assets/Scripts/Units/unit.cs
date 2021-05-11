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
    public bool positioning;
    public void attack() { }
    public void takeDamage() { }
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
                checkIfOnRoad();
            }
        }
    }
}
