using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	namespace SA
	{
	public class Helper : MonoBehaviour {
		[Range(0,1)] public float vertical;

		public string animName;
		public bool	playAnim;

		public bool twoHanded;

		Animator anim;


		void Start () {
			anim = GetComponent<Animator> ();
		}

		void Update () {
			anim.SetBool ("two_handed", twoHanded);

			if (playAnim) {
				vertical = 0;
				anim.CrossFade (animName,0.2f);
				playAnim = false;	
			}

			anim.SetFloat ("vertical", vertical);
		}
   }
}