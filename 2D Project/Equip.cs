using UnityEngine;
using System.Collections;

public class Equip : AbstractBehavior {
	private int      currentItem = 0;
	private Animator animator;

	public int CurrentItem{
		get { return currentItem; }
		set {
			currentItem = value;
			animator.SetInteger("EquippedItem", currentItem);
		}
	}

	protected override void Awake() {
		base.Awake();
		animator = GetComponent<Animator>();
	}

}
