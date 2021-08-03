﻿using System.Collections;
using UnityEngine;

namespace CraftingAnims
{
	public class ShowItem : MonoBehaviour
	{
		private CrafterController crafterController;

		public void Awake()
		{
			crafterController = GetComponent<CrafterController>();
		}

		public void ItemShow(string item, float waitTime)
		{
			StartCoroutine(_ItemShow(item, waitTime));
		}

		private IEnumerator _ItemShow(string item, float waitTime)
		{
			yield return new WaitForSeconds(waitTime);
			if (item == "none") {
				crafterController.hatchet.SetActive(false);
				crafterController.hammer.SetActive(false);
				crafterController.fishingpole.SetActive(false);
				crafterController.shovel.SetActive(false);
				crafterController.box.SetActive(false);
				crafterController.food.SetActive(false);
				crafterController.drink.SetActive(false);
				crafterController.saw.SetActive(false);
				crafterController.pickaxe.SetActive(false);
				crafterController.sickle.SetActive(false);
				crafterController.rake.SetActive(false);
				crafterController.chair.SetActive(false);
				crafterController.ladder.SetActive(false);
				crafterController.pushpull.SetActive(false);
				crafterController.lumber.SetActive(false);
				crafterController.sphere.SetActive(false);
				crafterController.cart.SetActive(false);
				crafterController.paintbrush.SetActive(false);
				crafterController.spear.SetActive(false);
			}
			else if (item == "axe") {
				crafterController.hatchet.SetActive(true);
				crafterController.hammer.SetActive(false);
				crafterController.fishingpole.SetActive(false);
				crafterController.shovel.SetActive(false);
				crafterController.box.SetActive(false);
				crafterController.food.SetActive(false);
				crafterController.drink.SetActive(false);
				crafterController.saw.SetActive(false);
				crafterController.pickaxe.SetActive(false);
				crafterController.sickle.SetActive(false);
				crafterController.rake.SetActive(false);
				crafterController.chair.SetActive(false);
				crafterController.ladder.SetActive(false);
				crafterController.pushpull.SetActive(false);
				crafterController.lumber.SetActive(false);
				crafterController.sphere.SetActive(false);
				crafterController.cart.SetActive(false);
				crafterController.paintbrush.SetActive(false);
				crafterController.spear.SetActive(false);
			}
			else if (item == "hammer") {
				crafterController.hatchet.SetActive(false);
				crafterController.hammer.SetActive(true);
				crafterController.fishingpole.SetActive(false);
				crafterController.shovel.SetActive(false);
				crafterController.box.SetActive(false);
				crafterController.food.SetActive(false);
				crafterController.drink.SetActive(false);
				crafterController.saw.SetActive(false);
				crafterController.pickaxe.SetActive(false);
				crafterController.sickle.SetActive(false);
				crafterController.rake.SetActive(false);
				crafterController.chair.SetActive(false);
				crafterController.ladder.SetActive(false);
				crafterController.pushpull.SetActive(false);
				crafterController.lumber.SetActive(false);
				crafterController.sphere.SetActive(false);
				crafterController.cart.SetActive(false);
				crafterController.paintbrush.SetActive(false);
				crafterController.spear.SetActive(false);
			}
			else if (item == "fishingpole") {
				crafterController.hatchet.SetActive(false);
				crafterController.hammer.SetActive(false);
				crafterController.fishingpole.SetActive(true);
				crafterController.shovel.SetActive(false);
				crafterController.box.SetActive(false);
				crafterController.food.SetActive(false);
				crafterController.drink.SetActive(false);
				crafterController.saw.SetActive(false);
				crafterController.pickaxe.SetActive(false);
				crafterController.sickle.SetActive(false);
				crafterController.rake.SetActive(false);
				crafterController.chair.SetActive(false);
				crafterController.ladder.SetActive(false);
				crafterController.pushpull.SetActive(false);
				crafterController.lumber.SetActive(false);
				crafterController.sphere.SetActive(false);
				crafterController.cart.SetActive(false);
				crafterController.paintbrush.SetActive(false);
				crafterController.spear.SetActive(false);
			}
			else if (item == "shovel") {
				crafterController.hatchet.SetActive(false);
				crafterController.hammer.SetActive(false);
				crafterController.fishingpole.SetActive(false);
				crafterController.shovel.SetActive(true);
				crafterController.box.SetActive(false);
				crafterController.food.SetActive(false);
				crafterController.drink.SetActive(false);
				crafterController.saw.SetActive(false);
				crafterController.pickaxe.SetActive(false);
				crafterController.sickle.SetActive(false);
				crafterController.rake.SetActive(false);
				crafterController.chair.SetActive(false);
				crafterController.ladder.SetActive(false);
				crafterController.pushpull.SetActive(false);
				crafterController.lumber.SetActive(false);
				crafterController.sphere.SetActive(false);
				crafterController.cart.SetActive(false);
				crafterController.paintbrush.SetActive(false);
				crafterController.spear.SetActive(false);
			}
			else if (item == "box") {
				crafterController.hatchet.SetActive(false);
				crafterController.hammer.SetActive(false);
				crafterController.fishingpole.SetActive(false);
				crafterController.shovel.SetActive(false);
				crafterController.box.SetActive(true);
				crafterController.food.SetActive(false);
				crafterController.drink.SetActive(false);
				crafterController.saw.SetActive(false);
				crafterController.pickaxe.SetActive(false);
				crafterController.sickle.SetActive(false);
				crafterController.rake.SetActive(false);
				crafterController.chair.SetActive(false);
				crafterController.ladder.SetActive(false);
				crafterController.pushpull.SetActive(false);
				crafterController.lumber.SetActive(false);
				crafterController.sphere.SetActive(false);
				crafterController.cart.SetActive(false);
				crafterController.paintbrush.SetActive(false);
				crafterController.spear.SetActive(false);
			}
			else if (item == "food") {
				crafterController.hatchet.SetActive(false);
				crafterController.hammer.SetActive(false);
				crafterController.fishingpole.SetActive(false);
				crafterController.shovel.SetActive(false);
				crafterController.box.SetActive(false);
				crafterController.food.SetActive(true);
				crafterController.drink.SetActive(false);
				crafterController.saw.SetActive(false);
				crafterController.pickaxe.SetActive(false);
				crafterController.sickle.SetActive(false);
				crafterController.rake.SetActive(false);
				crafterController.chair.SetActive(false);
				crafterController.ladder.SetActive(false);
				crafterController.pushpull.SetActive(false);
				crafterController.lumber.SetActive(false);
				crafterController.sphere.SetActive(false);
				crafterController.cart.SetActive(false);
				crafterController.paintbrush.SetActive(false);
				crafterController.spear.SetActive(false);
			}
			else if (item == "drink") {
				crafterController.hatchet.SetActive(false);
				crafterController.hammer.SetActive(false);
				crafterController.fishingpole.SetActive(false);
				crafterController.shovel.SetActive(false);
				crafterController.box.SetActive(false);
				crafterController.food.SetActive(false);
				crafterController.drink.SetActive(true);
				crafterController.saw.SetActive(false);
				crafterController.pickaxe.SetActive(false);
				crafterController.sickle.SetActive(false);
				crafterController.rake.SetActive(false);
				crafterController.chair.SetActive(false);
				crafterController.ladder.SetActive(false);
				crafterController.pushpull.SetActive(false);
				crafterController.lumber.SetActive(false);
				crafterController.sphere.SetActive(false);
				crafterController.cart.SetActive(false);
				crafterController.paintbrush.SetActive(false);
				crafterController.spear.SetActive(false);
			}
			else if (item == "saw") {
				crafterController.hatchet.SetActive(false);
				crafterController.hammer.SetActive(false);
				crafterController.fishingpole.SetActive(false);
				crafterController.shovel.SetActive(false);
				crafterController.box.SetActive(false);
				crafterController.food.SetActive(false);
				crafterController.drink.SetActive(false);
				crafterController.saw.SetActive(true);
				crafterController.pickaxe.SetActive(false);
				crafterController.sickle.SetActive(false);
				crafterController.rake.SetActive(false);
				crafterController.chair.SetActive(false);
				crafterController.ladder.SetActive(false);
				crafterController.pushpull.SetActive(false);
				crafterController.lumber.SetActive(false);
				crafterController.sphere.SetActive(false);
				crafterController.cart.SetActive(false);
				crafterController.paintbrush.SetActive(false);
				crafterController.spear.SetActive(false);
			}
			else if (item == "pickaxe") {
				crafterController.hatchet.SetActive(false);
				crafterController.hammer.SetActive(false);
				crafterController.fishingpole.SetActive(false);
				crafterController.shovel.SetActive(false);
				crafterController.box.SetActive(false);
				crafterController.food.SetActive(false);
				crafterController.drink.SetActive(false);
				crafterController.saw.SetActive(false);
				crafterController.pickaxe.SetActive(true);
				crafterController.sickle.SetActive(false);
				crafterController.rake.SetActive(false);
				crafterController.chair.SetActive(false);
				crafterController.ladder.SetActive(false);
				crafterController.pushpull.SetActive(false);
				crafterController.lumber.SetActive(false);
				crafterController.sphere.SetActive(false);
				crafterController.cart.SetActive(false);
				crafterController.paintbrush.SetActive(false);
				crafterController.spear.SetActive(false);
			}
			else if (item == "sickle") {
				crafterController.hatchet.SetActive(false);
				crafterController.hammer.SetActive(false);
				crafterController.fishingpole.SetActive(false);
				crafterController.shovel.SetActive(false);
				crafterController.box.SetActive(false);
				crafterController.food.SetActive(false);
				crafterController.drink.SetActive(false);
				crafterController.saw.SetActive(false);
				crafterController.pickaxe.SetActive(false);
				crafterController.sickle.SetActive(true);
				crafterController.rake.SetActive(false);
				crafterController.chair.SetActive(false);
				crafterController.ladder.SetActive(false);
				crafterController.pushpull.SetActive(false);
				crafterController.lumber.SetActive(false);
				crafterController.sphere.SetActive(false);
				crafterController.cart.SetActive(false);
				crafterController.paintbrush.SetActive(false);
				crafterController.spear.SetActive(false);
			}
			else if (item == "rake") {
				crafterController.hatchet.SetActive(false);
				crafterController.hammer.SetActive(false);
				crafterController.fishingpole.SetActive(false);
				crafterController.shovel.SetActive(false);
				crafterController.box.SetActive(false);
				crafterController.food.SetActive(false);
				crafterController.drink.SetActive(false);
				crafterController.saw.SetActive(false);
				crafterController.pickaxe.SetActive(false);
				crafterController.sickle.SetActive(false);
				crafterController.rake.SetActive(true);
				crafterController.chair.SetActive(false);
				crafterController.ladder.SetActive(false);
				crafterController.pushpull.SetActive(false);
				crafterController.lumber.SetActive(false);
				crafterController.sphere.SetActive(false);
				crafterController.cart.SetActive(false);
				crafterController.paintbrush.SetActive(false);
				crafterController.spear.SetActive(false);
			}
			else if (item == "chair") {
				crafterController.hatchet.SetActive(false);
				crafterController.hammer.SetActive(false);
				crafterController.fishingpole.SetActive(false);
				crafterController.shovel.SetActive(false);
				crafterController.box.SetActive(false);
				crafterController.food.SetActive(false);
				crafterController.drink.SetActive(false);
				crafterController.saw.SetActive(false);
				crafterController.pickaxe.SetActive(false);
				crafterController.sickle.SetActive(false);
				crafterController.rake.SetActive(false);
				crafterController.chair.SetActive(true);
				crafterController.ladder.SetActive(false);
				crafterController.pushpull.SetActive(false);
				crafterController.lumber.SetActive(false);
				crafterController.sphere.SetActive(false);
				crafterController.cart.SetActive(false);
				crafterController.paintbrush.SetActive(false);
				crafterController.spear.SetActive(false);
			}
			else if (item == "chaireat") {
				crafterController.hatchet.SetActive(false);
				crafterController.hammer.SetActive(false);
				crafterController.fishingpole.SetActive(false);
				crafterController.shovel.SetActive(false);
				crafterController.box.SetActive(false);
				crafterController.food.SetActive(true);
				crafterController.drink.SetActive(false);
				crafterController.saw.SetActive(false);
				crafterController.pickaxe.SetActive(false);
				crafterController.sickle.SetActive(false);
				crafterController.rake.SetActive(false);
				crafterController.chair.SetActive(true);
				crafterController.ladder.SetActive(false);
				crafterController.pushpull.SetActive(false);
				crafterController.lumber.SetActive(false);
				crafterController.sphere.SetActive(false);
				crafterController.cart.SetActive(false);
				crafterController.paintbrush.SetActive(false);
				crafterController.spear.SetActive(false);
			}
			else if (item == "drink") {
				crafterController.hatchet.SetActive(false);
				crafterController.hammer.SetActive(false);
				crafterController.fishingpole.SetActive(false);
				crafterController.shovel.SetActive(false);
				crafterController.box.SetActive(false);
				crafterController.food.SetActive(false);
				crafterController.drink.SetActive(true);
				crafterController.saw.SetActive(false);
				crafterController.pickaxe.SetActive(false);
				crafterController.sickle.SetActive(false);
				crafterController.rake.SetActive(false);
				crafterController.chair.SetActive(true);
				crafterController.ladder.SetActive(false);
				crafterController.pushpull.SetActive(false);
				crafterController.lumber.SetActive(false);
				crafterController.sphere.SetActive(false);
				crafterController.cart.SetActive(false);
				crafterController.paintbrush.SetActive(false);
				crafterController.spear.SetActive(false);
			}
			else if (item == "ladder") {
				crafterController.hatchet.SetActive(false);
				crafterController.hammer.SetActive(false);
				crafterController.fishingpole.SetActive(false);
				crafterController.shovel.SetActive(false);
				crafterController.box.SetActive(false);
				crafterController.food.SetActive(false);
				crafterController.drink.SetActive(false);
				crafterController.saw.SetActive(false);
				crafterController.pickaxe.SetActive(false);
				crafterController.sickle.SetActive(false);
				crafterController.rake.SetActive(false);
				crafterController.chair.SetActive(false);
				crafterController.ladder.SetActive(true);
				crafterController.pushpull.SetActive(false);
				crafterController.lumber.SetActive(false);
				crafterController.sphere.SetActive(false);
				crafterController.cart.SetActive(false);
				crafterController.paintbrush.SetActive(false);
				crafterController.spear.SetActive(false);
			}
			else if (item == "pushpull") {
				crafterController.hatchet.SetActive(false);
				crafterController.hammer.SetActive(false);
				crafterController.fishingpole.SetActive(false);
				crafterController.shovel.SetActive(false);
				crafterController.box.SetActive(false);
				crafterController.food.SetActive(false);
				crafterController.drink.SetActive(false);
				crafterController.saw.SetActive(false);
				crafterController.pickaxe.SetActive(false);
				crafterController.sickle.SetActive(false);
				crafterController.rake.SetActive(false);
				crafterController.chair.SetActive(false);
				crafterController.ladder.SetActive(false);
				crafterController.pushpull.SetActive(true);
				crafterController.lumber.SetActive(false);
				crafterController.sphere.SetActive(false);
				crafterController.cart.SetActive(false);
				crafterController.paintbrush.SetActive(false);
				crafterController.spear.SetActive(false);
			}
			else if (item == "lumber") {
				crafterController.hatchet.SetActive(false);
				crafterController.hammer.SetActive(false);
				crafterController.fishingpole.SetActive(false);
				crafterController.shovel.SetActive(false);
				crafterController.box.SetActive(false);
				crafterController.food.SetActive(false);
				crafterController.drink.SetActive(false);
				crafterController.saw.SetActive(false);
				crafterController.pickaxe.SetActive(false);
				crafterController.sickle.SetActive(false);
				crafterController.rake.SetActive(false);
				crafterController.chair.SetActive(false);
				crafterController.ladder.SetActive(false);
				crafterController.pushpull.SetActive(false);
				crafterController.lumber.SetActive(true);
				crafterController.sphere.SetActive(false);
				crafterController.cart.SetActive(false);
				crafterController.paintbrush.SetActive(false);
				crafterController.spear.SetActive(false);
			}
			else if (item == "sphere") {
				crafterController.hatchet.SetActive(false);
				crafterController.hammer.SetActive(false);
				crafterController.fishingpole.SetActive(false);
				crafterController.shovel.SetActive(false);
				crafterController.box.SetActive(false);
				crafterController.food.SetActive(false);
				crafterController.drink.SetActive(false);
				crafterController.saw.SetActive(false);
				crafterController.pickaxe.SetActive(false);
				crafterController.sickle.SetActive(false);
				crafterController.rake.SetActive(false);
				crafterController.chair.SetActive(false);
				crafterController.ladder.SetActive(false);
				crafterController.pushpull.SetActive(false);
				crafterController.lumber.SetActive(false);
				crafterController.sphere.SetActive(true);
				crafterController.cart.SetActive(false);
				crafterController.paintbrush.SetActive(false);
				crafterController.spear.SetActive(false);
			}
			else if (item == "cart") {
				crafterController.hatchet.SetActive(false);
				crafterController.hammer.SetActive(false);
				crafterController.fishingpole.SetActive(false);
				crafterController.shovel.SetActive(false);
				crafterController.box.SetActive(false);
				crafterController.food.SetActive(false);
				crafterController.drink.SetActive(false);
				crafterController.saw.SetActive(false);
				crafterController.pickaxe.SetActive(false);
				crafterController.sickle.SetActive(false);
				crafterController.rake.SetActive(false);
				crafterController.chair.SetActive(false);
				crafterController.ladder.SetActive(false);
				crafterController.pushpull.SetActive(false);
				crafterController.lumber.SetActive(false);
				crafterController.sphere.SetActive(false);
				crafterController.cart.SetActive(true);
				crafterController.paintbrush.SetActive(false);
				crafterController.spear.SetActive(false);
			}
			else if (item == "paintbrush") {
				crafterController.hatchet.SetActive(false);
				crafterController.hammer.SetActive(false);
				crafterController.fishingpole.SetActive(false);
				crafterController.shovel.SetActive(false);
				crafterController.box.SetActive(false);
				crafterController.food.SetActive(false);
				crafterController.drink.SetActive(false);
				crafterController.saw.SetActive(false);
				crafterController.pickaxe.SetActive(false);
				crafterController.sickle.SetActive(false);
				crafterController.rake.SetActive(false);
				crafterController.chair.SetActive(false);
				crafterController.ladder.SetActive(false);
				crafterController.pushpull.SetActive(false);
				crafterController.lumber.SetActive(false);
				crafterController.sphere.SetActive(false);
				crafterController.cart.SetActive(false);
				crafterController.paintbrush.SetActive(true);
				crafterController.spear.SetActive(false);
			}
			else if (item == "spear") {
				crafterController.hatchet.SetActive(false);
				crafterController.hammer.SetActive(false);
				crafterController.fishingpole.SetActive(false);
				crafterController.shovel.SetActive(false);
				crafterController.box.SetActive(false);
				crafterController.food.SetActive(false);
				crafterController.drink.SetActive(false);
				crafterController.saw.SetActive(false);
				crafterController.pickaxe.SetActive(false);
				crafterController.sickle.SetActive(false);
				crafterController.rake.SetActive(false);
				crafterController.chair.SetActive(false);
				crafterController.ladder.SetActive(false);
				crafterController.pushpull.SetActive(false);
				crafterController.lumber.SetActive(false);
				crafterController.sphere.SetActive(false);
				crafterController.cart.SetActive(false);
				crafterController.paintbrush.SetActive(false);
				crafterController.spear.SetActive(true);
			}
			yield return null;
		}
	}
}
