using UnityEngine;

public class Array_Fill_Amount : MonoBehaviour
{
    float m_ArrayAmount { get { return fillObjs.Length - 1; } }

    [SerializeField] GameObject[] fillObjs;

    public void SetFillAmount(float fillAmount)
    {
        //Debug.Log("Set fill amount >> fillAmount: " + fillAmount);
        //Debug.Log("Set fill amount >> m_ArrayAmount: " + m_ArrayAmount);

        for (int i = 0; i < fillObjs.Length; i++)
        {
            float c = Mathf.Clamp(i / m_ArrayAmount, 0.01f, 1.0f);

            //Debug.Log("Set fill amount >> i: " + i + ", c: " + c);

            if (fillAmount >= c)
                fillObjs[i].SetActive(true);
            else
                fillObjs[i].SetActive(false);
        }
    }
}
