using UnityEngine;

public class Castle : Tower
{
    public GameObject goVictory;
    public GameObject goDefeat;
    public AudioClip soundVictory;
    public AudioClip soundDefeat;
    public bool isEnemy;

    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    protected override void Dead()
    {
        base.Dead();

        if (isEnemy)
        {
            goVictory.SetActive(true);
            aud.PlayOneShot(soundVictory, 1.2f);
        }
        else
        {
            goDefeat.SetActive(true);
            aud.PlayOneShot(soundDefeat, 1.2f);
        }
    }
}
