using System;
using System.Threading;

namespace SloppyJoeMenuGenerator
{
	public class MenuItem
	{
        // Declare fields.
		public MenuOptions MenuOptionsObject; // Menu options object
		public string Protein { get; private set; } // Protein for menu item
		public string Condiment { get; private set; } // Condiment for menu item
		public string Bread { get; private set; } // Bread for menu item
		public string Description = ""; // Description for menu item
		public string Price; // Price for menu item

		/// <summary>
		/// Default constructor uses default MenuOptions object and randomly selects values for the fields describing the menu item.
		/// </summary>
		public MenuItem()
		{
			MenuOptionsObject = new MenuOptions(); // Create a default MenuOptions object.
            GenerateAndSetRandomMenuItem(); // Randomly select values to describe the menu item.
        }

        /// <summary>
        /// Assign a specific MenuOptions object, then randomly select values for the fields describing the menu item.
        /// </summary>
        /// <param name="menuOptions"></param>
        public MenuItem(MenuOptions menuOptions)
		{
			MenuOptionsObject = menuOptions; // Set MenuOptions object to specific MenuOptions object.
            GenerateAndSetRandomMenuItem(); // Randomly select values to describe the menu item.
        }

		/// <summary>
		/// Set the fields describing the menu item to randomly selected values.
		/// </summary>
		public void GenerateAndSetRandomMenuItem()
		{
			// Set parts of menu item fields.
			Protein = MenuOptions.GetRandomOption(MenuOptionsObject.Proteins);
			Condiment = MenuOptions.GetRandomOption(MenuOptionsObject.Condiments);
			Bread = MenuOptions.GetRandomOption(MenuOptionsObject.Breads);

			// Set description and price fields.
			Description = $"{Protein} with {Condiment} on {Bread}";
			Price = GenerateMenuItemPrice().ToString("c");
        }

		public static decimal GenerateMenuItemPrice()
		{
			return MenuOptions.Randomizer.Next(2, 5) + (MenuOptions.Randomizer.Next(1, 99) * 0.1M);

        }
	}
}

