﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearManager : MonoBehaviour {

    public static ClearManager instance;
    public List<Door> doors = new List<Door>();
    public bool alCleared;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void EnterRoom()
    {

    }
}
