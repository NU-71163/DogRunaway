using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class meter : MonoBehaviour
{
    public Image UIobj;
    public bool roop;
    public float countTime = 5.0f;

    public ObjectSpawner objectSpawner;

    // Start is called before the first frame update
    void Start()
    {
        UIobj.enabled = false;
    }

    public IEnumerator ReduceFillAmount(int keyIndex)
    {
        UIobj.enabled = true;
        // fillAmount‚ª0‚É‚È‚é‚Ü‚ÅŒ¸­‚ğ‘±‚¯‚é
        while (UIobj.fillAmount > 0)
        {
            UIobj.fillAmount -= 1.0f / countTime * Time.deltaTime;
            yield return null; // Ÿ‚ÌƒtƒŒ[ƒ€‚Ü‚Å‘Ò‹@
        }

        UIobj.fillAmount = 1;
        UIobj.enabled = false;

        objectSpawner.EnableKey(keyIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
