using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ViewManager : MonoBehaviour,IViewManager
{

    // Start is called before the first frame update
    ViewData viewManagerInstance = GameObject.Find("ViewManager").GetComponent<ViewData>();
    public void OnClickStart() {

        viewManagerInstance.joinHostPanel.transform.DOMove(new Vector3(150, 150), 2);
        
    }
    public void OnClickJoin() {
        
        
    }
    public void OnClickHost() {
    }

}
