using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class InventoryBase : MonoBehaviour
{
    public List<GameObject> myObjects;

    public float delayBetweenObjects = .1f;
    public float animationDuration = .5f;

    [Header("Animation")]
    public Animator animator;

    public string triggerShow = "Show";
    public string triggerHide = "Hide";

    private bool _isShowing = false; 

    private void Awake()
    {
        GetObjects();
        Hide();
    }

    private void GetObjects()
    {
        foreach(Transform t in GetComponentsInChildren<Transform>())
        {
            if (t != null)
                myObjects.Add(t.gameObject);
        }
    }

    private void Hide()
    {
        _isShowing = false;
        foreach(GameObject g in myObjects)
        {
            g.SetActive(false);
        }
    }

    public void ShowItens()
    {
        if(!_isShowing)
        {
            gameObject.SetActive(true);
            //Hide();
            animator.SetTrigger(triggerShow);
            StartCoroutine(Show());
            _isShowing = true;
        }
        else
        {
            animator.SetTrigger(triggerHide);
            _isShowing = false;
            StartCoroutine(DelayedHide());


        }
          
    }

    private IEnumerator DelayedHide()
    {
        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);
    }

    IEnumerator Show()
    {
        foreach (GameObject g in myObjects)
        {
            yield return new WaitForSeconds(delayBetweenObjects);
            g.SetActive(true);
            g.transform.DOScale(0, animationDuration).From();
            
        }
    }

    
   
}
