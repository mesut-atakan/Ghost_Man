using Unity.VisualScripting;
using UnityEngine;



namespace Character
{
    internal abstract class CharacterProperties : MonoBehaviour
    {
#region ||~~~~~~~~~~|| X ||~~~~~~~~~~|| SERIALIZE FIELDS ||~~~~~~~~~~|| X ||~~~~~~~~~~||

        [Header("Charcter Main Properties")]

        [Tooltip("Character Move Speed")]
        [SerializeField] protected float characterMoveSpeed;




        [Tooltip("Character health amount")]
        [SerializeField] protected short characterHealth;


#endregion ||~~~~~~~~~~|| X ||~~~~~~~~~~|| XXXX ||~~~~~~~~~~|| X ||~~~~~~~~~~||








#region ||~~~~~~~~~~|| X ||~~~~~~~~~~|| PROPERTIES ||~~~~~~~~~~|| X ||~~~~~~~~~~||

        internal float _characterMoveSpeed
        {
            get { return this.characterMoveSpeed; }
        }


        internal short _characterHealth
        {
            get { return this.characterHealth; }
            set { this.characterHealth = value; }
        }

#endregion ||~~~~~~~~~~|| X ||~~~~~~~~~~|| XXXX ||~~~~~~~~~~|| X ||~~~~~~~~~~||






        internal abstract void Move();


        internal abstract void Attack(CharacterProperties character);


        internal abstract void TakeDamage();
    }
}