using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SinglePet : MonoBehaviour
{
    GameObject Spawner;
    GameObject ground;
    GameObject sound;
    GameObject dname;
    SoundManager soundManager;
    NameManager nameManager;
    public AudioSource lose;
    void Start()
    {
        StartCoroutine(Selfdestroyed());
    }

    void OnMouseDown()
    {
        sound = GameObject.Find("SoundManager");
        dname = GameObject.Find("nameManager");
        soundManager = (SoundManager)sound.GetComponent(typeof(SoundManager));
        nameManager = (NameManager)dname.GetComponent(typeof(NameManager));
        soundManager.Playvoice(gameObject.tag);
        nameManager.DisplayName(gameObject.tag);
        Destroy(gameObject);
    }

    IEnumerator Selfdestroyed()
    {
        yield return new WaitForSeconds(3);
        SpriteRenderer m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = Color.green;
        yield return new WaitForSeconds(0.5f);
        lose.Play();
        m_SpriteRenderer.color = Color.red;
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
