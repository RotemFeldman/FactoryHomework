using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Item
{
    List<Item> DependentItems = new();

    private bool _found;

    private bool _canBeUsed;
    public bool CanBeUsed 
    {
        get
        {
            if(UpdateCanBeUsed() && _found)
            {
                _canBeUsed = true;
            }
        
            return _canBeUsed;
        }

        private set { _canBeUsed = value; } 
    }



    public void Subscribe(Item item)
    {
        DependentItems.Add(item);
    }

    bool UpdateCanBeUsed()
    {
        if(DependentItems.Count == 0)
        {
            return true;
        }

        foreach(var item in DependentItems)
        {
            if (item.CanBeUsed)
            {
                continue;
            }

            return false;
        }

        return true;
    }

    void Found()
    {
        _found = true;
    }
}

