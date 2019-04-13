using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenScript : MonoBehaviour
{
    private Inventory inventory;
    private List<bool> order = new List<bool>();
    // Start is called before the first frame update
    void Start()
    {
        inventory = GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < order.Count; i++)
        {
            if (Time.time > 5 * i && order[i] == false)
            {
                order[i] = true;
                inventory.AddItem();
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Inventory>() != null)
        {
            collision.gameObject.GetComponent<Inventory>().AddItem(inventory.GetItem());
        }
    }
}
