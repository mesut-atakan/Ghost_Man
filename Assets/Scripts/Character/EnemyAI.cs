using UnityEngine;



namespace Character
{
    internal class EnemyAI : CharacterProperties
    {

#region ||~~~~~~~~~~|| X ||~~~~~~~~~~|| SERIALIZE FIELDS ||~~~~~~~~~~|| X ||~~~~~~~~~~||

        [Header("Enemy Other Properties")]

        [Tooltip("Enter the enemy's maximum tracking distance!")]
        [SerializeField] [Range(1, 20)] private float targetArea = 6;


        [Tooltip("Maximum distance that the enemy character can approach the player character")]
        [SerializeField] [Range(0,5)] float minDistance = 1.5f;


        [Tooltip("Player Character Transform compoennt")]
        [SerializeField] Transform playerTransform;



        [Header("Classes")]

        [Tooltip("Get game manager class")]
        [SerializeField] private GameManager gameManager;

#endregion ||~~~~~~~~~~|| X ||~~~~~~~~~~|| XXXX ||~~~~~~~~~~|| X ||~~~~~~~~~~||


        internal override void Move()
        {
            // ~~ Variables ~~
            float _playerDistance;
            short _playerDirection;


            _playerDistance = this.transform.position.x - this.playerTransform.position.x;
            _playerDirection = HowPLayerDirection(_playerDistance);
            Debug.Log($"Player Distance: {_playerDistance}\nPlayer Direction: {_playerDirection}");

            _playerDistance = Mathf.Abs(_playerDistance);


            if (_playerDistance <= this.targetArea && _playerDistance > minDistance)
            {
                this.transform.Translate(new Vector2(this.characterMoveSpeed * _playerDirection * Time.deltaTime, 0));
            }
        }



        internal override void Attack(CharacterProperties character)
        {

        }


        internal override void TakeDamage()
        {

        }







        /// <summary>
        /// With this method you will find out which direction the player's character is in!
        /// </summary>
        /// <param name="distance">Enter the distance of this character from the player's character!</param>
        /// <returns>It will mathematically return whether the character is on the right or left side.!</returns>
        internal short HowPLayerDirection(float distance)
        {
            if (distance < 0)
            {
                return +1;
            }
            else if (distance > 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}