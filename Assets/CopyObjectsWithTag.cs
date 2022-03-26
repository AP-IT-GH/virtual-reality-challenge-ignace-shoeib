using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyObjectsWithTag : MonoBehaviour
{
    public void CopyObjects(string tag)
    {
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject targetObject in taggedObjects)
        {
            var dupe = Instantiate(targetObject);
            for (int i = 0; i < targetObject.GetComponent<TrailRenderer>().positionCount; i++)
            {
                dupe.GetComponent<TrailRenderer>().AddPosition(targetObject.GetComponent<TrailRenderer>().GetPosition(i)+new Vector3(1.5f,1,0));
                dupe.GetComponent<TrailRenderer>().startWidth /= 2;
                dupe.GetComponent<TrailRenderer>().endWidth /= 2;
                dupe.tag = "Untagged";
            }
        }
    }
}