using Character;
using UnityEngine;



internal class GameManager : MonoBehaviour
{

#region ||~~~~~~~~~~|| X ||~~~~~~~~~~|| SERIALIZE FIELDS ||~~~~~~~~~~|| X ||~~~~~~~~~~||

    [Header("Classes")]

    [Tooltip("Get Player Controller Class")]
    [SerializeField] private PlayerController playerController;

    [Tooltip("Maps All Enemys")]
    [SerializeField] private EnemyAI[] allEnemys;

#endregion ||~~~~~~~~~~|| X ||~~~~~~~~~~|| XXXX ||~~~~~~~~~~|| X ||~~~~~~~~~~||





    private void Update() {
        playerController.Attack(null);

    }


    private void FixedUpdate() 
    {
        // ~~ Player
        playerController.Move();
        playerController.Jump();

        // ~~ ENEMY 

        EnemyController();
    }





    /// <summary>
    /// All enemies on the map will be able to move with this function!
    /// </summary>
    private void EnemyController()
    {
        foreach(EnemyAI enemy in this.allEnemys)
        {
            enemy.Move();
        }
    }
}