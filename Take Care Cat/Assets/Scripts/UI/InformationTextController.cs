using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformationTextController : MonoBehaviour
{
    public Text informTxt;
    public bool isExplanation;


    public IEnumerator TextAnimation(string explanation)
    {
        isExplanation = true;
        for (int i = 0; i < explanation.Length; i++)
        {
            SystemManager.Instance.InformationTextController.informTxt.text += explanation[i];
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(0.1f);
        SystemManager.Instance.InformationTextController.informTxt.text = "";
        isExplanation = false;
    }
}
