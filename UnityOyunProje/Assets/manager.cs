using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    public GameObject chair, blocks, jar, toyCar, varlik,
        k_chair, k_blocks, k_jar, k_toyCar, k_varlik;

    Vector2 chairInitialPos, blocksInitialPos, jarInitialPos,
            toyCarInitialPos, varlikInitialPos;

     void Start()
    {
        chairInitialPos = chair.transform.position;
        blocksInitialPos = blocks.transform.position;
        jarInitialPos = jar.transform.position;
        toyCarInitialPos = toyCar.transform.position;
        varlikInitialPos = varlik.transform.position;
    }

    //Tutma

    public void DragChair()
    {
        chair.transform.position = Input.mousePosition;
    }

    public void DragBlocks()
    {
        blocks.transform.position = Input.mousePosition;
    }

    public void DragJar()
    {
        jar.transform.position = Input.mousePosition;
    }

    public void DragToyCar()
    {
        toyCar.transform.position = Input.mousePosition;
    }

    public void DragVarlik()
    {
        varlik.transform.position = Input.mousePosition;
    }

    //Bırakma

    public void DropChair()
    {
        float distance = Vector3.Distance(chair.transform.position,
            k_chair.transform.position);
        if (distance<50)
        {
            chair.transform.position = k_chair.transform.position;
        }
        else
        {
            chair.transform.position = chairInitialPos;
        }
    }

    public void DropBlocks()
    {
        float distance = Vector3.Distance(blocks.transform.position,
            k_blocks.transform.position);
        if (distance < 50)
        {
            blocks.transform.position = k_blocks.transform.position;
        }
        else
        {
            blocks.transform.position = blocksInitialPos;
        }
    }

    public void DropJar()
    {
        float distance = Vector3.Distance(jar.transform.position,
            k_jar.transform.position);
        if (distance < 50)
        {
            jar.transform.position = k_jar.transform.position;
        }
        else
        {
            jar.transform.position = jarInitialPos;
        }
    }

    public void DropToyCar()
    {
        float distance = Vector3.Distance(toyCar.transform.position,
            k_toyCar.transform.position);
        if (distance < 50)
        {
            toyCar.transform.position = k_toyCar.transform.position;
        }
        else
        {
            toyCar.transform.position = toyCarInitialPos;
        }
    }

    public void DropVarlik()
    {
        float distance = Vector3.Distance(varlik.transform.position,
            k_varlik.transform.position);
        if (distance < 50)
        {
            varlik.transform.position = k_varlik.transform.position;
        }
        else
        {
            varlik.transform.position = varlikInitialPos;
        }
    }

}
