using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private Platform _nextPlatform;
    private GameObject _item;
    
    public bool ProcessItem(GameObject item){
        if(_item != null || _nextPlatform == null) return false;

        _item = item;
        StartCoroutine(MoveItem(_item));
        return true;
    }

    private IEnumerator MoveItem(GameObject item){
        while(item.transform.position != _nextPlatform.transform.position){
            item.transform.position = Vector3.MoveTowards(item.transform.position, _nextPlatform.transform.position, 0.01f);
            yield return null;
        }
        _nextPlatform.ProcessItem(item);
        _item = null;
    }


}
