using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Sources")]
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource sfxSource;

    [Header("Background Music")]
    [SerializeField] private AudioClip mainMenuMusic; 
    [SerializeField] private AudioClip levelSelectionMusic;
    [SerializeField] private AudioClip quizMusic;

    [Header("Sound Effects")]
    [SerializeField] private AudioClip checkpointSound;
    [SerializeField] private AudioClip failedSound;
    [SerializeField] private AudioClip inspectseatSound;
    [SerializeField] private AudioClip opendoorSound;
    [SerializeField] private AudioClip extinguishSound;
    [SerializeField] private AudioClip oxygenSound;
    [SerializeField] private AudioClip buckleSound;

    static AudioManager instance;

    public static AudioManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<AudioManager>();
                if (instance == null)
                {
                    GameObject obj = new GameObject("AudioManager");
                    instance = obj.AddComponent<AudioManager>();
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

        SceneManager.sceneLoaded += OnSceneLoaded; //Subscribe from the sceneLoaded event

    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded; //Unsubscribe from the sceneLoaded event
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "MainMenu" || scene.name == "About")
        {
            if (!musicSource.isPlaying || musicSource.clip != mainMenuMusic)
            {
                PlayBackgroundMusic(mainMenuMusic);
            }
        }
        else if (scene.name == "Level Modules")
        {
            musicSource.Stop();
            if (!musicSource.isPlaying || musicSource.clip != levelSelectionMusic)
            {
                PlayBackgroundMusic(levelSelectionMusic);
            }
        }

        else if (scene.name == "0_QuestionsScene (HTP)" || scene.name == "1_QuestionsScene (LOP)" || scene.name == "2_QuestionsScene (Fire)" || scene.name == "3_QuestionsScene (Ditching)")
        {
            if (!musicSource.isPlaying || musicSource.clip != quizMusic)
            {
                PlayBackgroundMusic(quizMusic);
            }
        }
    }

    private void PlayBackgroundMusic(AudioClip clip)
    {
        if (clip != null)
        {
            musicSource.clip = clip;
            musicSource.loop = true;
            musicSource.Play();
        }
        else
        {
            Debug.LogWarning("Background music clip is null.");
        }
    }

    public void PlayCheckpointSound()
    {
        PlaySound(checkpointSound, sfxSource);
    }

    public void PlayFailedSound()
    {
        PlaySound(failedSound, sfxSource);
    }
    public void PlayInspectSound()
    {
        PlaySound(inspectseatSound, sfxSource);
    }

    public void PlayDoorSound()
    {
        PlaySound(opendoorSound, sfxSource);
    }

    public void PlayExtinguishSound()
    {
        PlaySound(extinguishSound, sfxSource);
    }

    public void PlayOxygenSound()
    {
        PlaySound(oxygenSound, sfxSource);
    }

    public void PlayBuckleSound()
    {
        PlaySound(buckleSound, sfxSource);
    }

    public void PlaySound(AudioClip clip, AudioSource source)
    {
        if (clip != null && source != null)
        {
            source.PlayOneShot(clip);
        }
    }
}
