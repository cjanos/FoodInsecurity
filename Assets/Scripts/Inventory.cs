using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Item> items = new List<Item>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddItem(Item aItem)
    {
        items.Add(aItem);
    }
    public void AddItem()
    {
        Item aItem = new Item();
        items.Add(aItem);
    }

    public Item GetItem()
    {
        Item temp = items[0];
        items.Remove(items[0]);
        return temp;
    }
}
