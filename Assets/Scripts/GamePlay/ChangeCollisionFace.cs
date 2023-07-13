using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCollisionFace : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var getComponentDirt = other.GetComponent<EmptyDirt>();
        if (other.CompareTag(NameTag.GROUND_ATTACH) && getComponentDirt != null)
        {
            GamePlayController.Instance.GroundAttach(getComponentDirt);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(NameTag.GROUND_ATTACH))
        {
            
        }
    }
}
