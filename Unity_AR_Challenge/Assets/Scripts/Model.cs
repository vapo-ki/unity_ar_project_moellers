﻿using PolyToolkit;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class Model : MonoBehaviour
{
    public PolyAsset polyAsset;
    public Material selectedMaterial;
    public ModelManager modelManager;

    private bool isSelected;

    public void SetSelected()
    {
        isSelected = true;
        Material[] materialList = new Material[2];
        materialList[0] = GetComponent<MeshRenderer>().materials[0];
        materialList[1] = selectedMaterial;

        GetComponent<MeshRenderer>().materials = materialList;
    }

    public void SetUnselected()
    {
        isSelected = false;
        Material[] materialList = new Material[1];
        materialList[0] = GetComponent<MeshRenderer>().materials[0];
        GetComponent<MeshRenderer>().materials = materialList;
    }

    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject()) {
            print("Touched! " + gameObject.name);
            modelManager.SelectModel(gameObject);
        }
        
    }
}
