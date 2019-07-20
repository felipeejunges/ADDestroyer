using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Monetization;

public class MeteorScript : MonoBehaviour
{
    public int shootingAutoDestroy = 10;
    public MeteorModel meteor = MeteorStrategy.getMeteorByColor("blue");
    public ParticleSystem explosion;
    
    // Start is called before the first frame update
    void Start()
    {

        Monetization.Initialize("3228130", false);
        Destroy(this.gameObject, shootingAutoDestroy);
    }

    private void OnCollisionEnter(Collision col)
    {
  
        if (col.gameObject.tag == "Lose")
        {
            ShowAd(meteor.getPlacement());
            SceneManager.LoadScene("EndScene");
        }
    }

    public void ShowAd(string placement)
    {
        if (placement != "")
        {
            StartCoroutine(ShowAdWhenReady(placement));
        }
    }

    private IEnumerator ShowAdWhenReady(string placement)
    {
        while (!Monetization.IsReady(placement))
        {
            yield return new WaitForSeconds(0.25f);
        }

        ShowAdPlacementContent ad = null;
        ad = Monetization.GetPlacementContent(placement) as ShowAdPlacementContent;

        if (ad != null)
        {
            ad.Show();
        }
    }

}
