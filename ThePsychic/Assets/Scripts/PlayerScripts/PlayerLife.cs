using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] private Stat _life;
    [SerializeField] private LifePlayerData _lifeData;

    private void Start()
    {
        InitialiseLife();
    }

    private void InitialiseLife()
    {
        _life = new Stat(_life.ValueMax);
        _lifeData.life = new Stat(_life.ValueMax);
    }

    public void AddLife(float value)
    {
        _life.AddValue(value);
    }

    public void LessLife(float value)
    {
        _life.LessValue(value);
    }
}
