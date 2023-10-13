using UnityEngine;



namespace Character
{
    internal class PlayerController : CharacterProperties
    {
#region  ||~~~~~~~~~~|| X ||~~~~~~~~~~|| SERIALIZE FIELDS ||~~~~~~~~~~|| X ||~~~~~~~~~~||
        [Header("Character Other Properties")]


        [Tooltip("Character Jump Force")]
        [SerializeField] private float jumpForce = 5;






        [Header("Components")]

        [Tooltip("Get Character Rigidbody Component")]
        [SerializeField] private Rigidbody2D rb;



        [Tooltip("Chracter Ground Transform")]
        [SerializeField] private Transform groundTransform;



        [Tooltip("Ground Layer Mask")]
        [SerializeField] private LayerMask groundLayerMask;




#endregion ||~~~~~~~~~~|| X ||~~~~~~~~~~|| XXXX ||~~~~~~~~~~|| X ||~~~~~~~~~~||




#region ||~~~~~~~~~~|| X ||~~~~~~~~~~|| CONST FIELDS ||~~~~~~~~~~|| X ||~~~~~~~~~~||

        private const string groundLayerMaskString = "Ground";

#endregion ||~~~~~~~~~~|| X ||~~~~~~~~~~|| XXXX ||~~~~~~~~~~|| X ||~~~~~~~~~~||





        /// <summary>
        /// Method that allows the character to move
        /// </summary>
        internal override void Move()
        {
            // ~~ Variables ~~
            float _horizontal;

            _horizontal = Input.GetAxis("Horizontal");



            rb.velocity = new Vector2(_horizontal * this.characterMoveSpeed, this.rb.velocity.y);


        }




        /// <summary>
        /// Method that allows the character to deal damage!
        /// </summary>
        /// <param name="character">Enter the character as a parameter to reduce the health of the character we damaged!</param>
        internal override void Attack(CharacterProperties character)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("ATTACCK!");
            }   
        }


        internal override void TakeDamage()
        {
            
        }







        internal void Jump()
        {
            if (Input.GetButton("Jump"))
            {
                // ~~ variables ~~
                bool _isGrounded;

                _isGrounded = Physics2D.OverlapCapsule(this.groundTransform.position, new Vector2(0.3f, 0.1f), CapsuleDirection2D.Horizontal, 0, this.groundLayerMask);
                Debug.Log(_isGrounded);
                if (_isGrounded)
                {
                    this.rb.velocity = new Vector2(this.rb.velocity.x, this.jumpForce);
                }
            }
        }
    }
}