using System;
namespace SloppyJoeMenuGenerator
{
    public class MenuOptions
    {
        // Fields
        public static Random Randomizer = new Random(); // Random number generator
        public string[][] menuItemParts { get; private set; } // Different kinds of menu item parts (each item an array of options for a kind of menu item part)
        public string[] Proteins { get; private set; } // Array of protein options
        public string[] Condiments { get; private set; } // Array of condiment options
        public string[] Breads { get; private set; } // Array of bread options

        // Default menu item parts arrays
        public static string[] DefaultProteins { get; private set; } = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu" }; // Array of default protein options
        public static string[] DefaultCondiments { get; private set; } = { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" }; // Array of default condiment options
        public static string[] DefaultBreads { get; private set; } = { "rye", "white", "wheat", "pumpernickel", "a roll" }; // Array of default bread options

        /// <summary>
        /// Default constructor sets menu option arrays to default arrays.
        /// </summary>
        public MenuOptions()
        {
            // Initialize menu item parts options arrays to default arrays.
            Proteins = DefaultProteins;
            Condiments = DefaultCondiments;
            Breads = DefaultBreads;

            // Initialize an array for different kinds of menu item parts.
            InitializeMenuItemPartsArray();
        }

        /// <summary>
        /// Set menu option arrays to specific arrays of options.
        /// </summary>
        /// <param name="proteins">Array of protein options.</param>
        /// <param name="condiments">Array of condiment options.</param>
        /// <param name="breads">Array of bread options.</param>
        public MenuOptions(string[] proteins, string[] condiments, string[] breads)
        {
            // Initialize menu item parts options arrays to values passed in.
            Proteins = proteins;
            Condiments = condiments;
            Breads = breads;

            // Initialize an array for different kinds of menu item parts.
            InitializeMenuItemPartsArray();
        }

        /// <summary>
        /// Initialize an array for different kinds of menu item parts (each item an array of options for a kind of menu item part).
        /// </summary>
        private void InitializeMenuItemPartsArray()
        {
            menuItemParts = new string[][] { Proteins, Condiments, Breads };
        }

        /// <summary>
		/// Randomly select an option from the array provided.
		/// </summary>
		/// <param name="options">Array of options</param>
		/// <returns>An option</returns>
		public static string GetRandomOption(string[] options)
        {
            return options[Randomizer.Next(options.Length)];
        }
    }
}

