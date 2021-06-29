using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayUI : MonoBehaviour
{
   public GameObject OnCreateBlueprint(GameObject blueprintPrefab)
   {
        GameObject clone = Instantiate<GameObject>(blueprintPrefab);
        return clone;
   }
}
