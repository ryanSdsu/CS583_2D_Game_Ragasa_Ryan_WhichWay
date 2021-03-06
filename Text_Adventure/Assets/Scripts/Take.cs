﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputActions/Take")]
public class Take : InputAction {

	public Dictionary<string, string> inventoryDictionary = new Dictionary<string, string> ();


	public override void RespondToInput (GameController controller, string[] separatedInputWords)
	{
		Dictionary<string, string> takeDictionary = controller.interactableItems.Take (separatedInputWords);

		if (takeDictionary != null) {

			controller.LogStringWithReturn (controller.TestVerbDictionarywithNoun (takeDictionary, separatedInputWords [0], separatedInputWords [1]));
			controller.PlayClip ("take");

		}
	}

}
