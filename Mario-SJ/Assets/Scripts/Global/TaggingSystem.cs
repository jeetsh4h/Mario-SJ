using System.Collections;                                               // THIS WILL CHANGE THE UI DROP DOWN IN UNITY ITSELF
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tag", menuName = "Tags/New Tag")]      // this is what we will see if we right click on the objects in unity
public class TilesScripts : ScriptableObject                            // allow it to change tile behavior
{
    public string Name => name;
}
