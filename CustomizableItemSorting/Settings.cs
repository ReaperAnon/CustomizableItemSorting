using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomizableItemSorting
{
    public class WeaponSortingEntry
    {
        [SettingName("Keys")]
        [Tooltip("Items that match any of these text snippets will be a part of the selected category.")]
        public List<string> StringKeys { get; set; } = new();


        [SettingName("Keywords")]
        [Tooltip("Items that have any of these keywords will be a part of the selected category.")]
        public List<IFormLinkGetter<IKeywordGetter>> Keywords { get; set; } = new();


        [SettingName("Editor IDs")]
        [Tooltip("Items that correspond to any of the selected editor IDs will be a part of the selected category.")]
        public List<IFormLink<IWeaponGetter>> EDIDS { get; set; } = new();


        [SettingName("Keys To Remove")]
        [Tooltip("The text snippets that should be removed from the names of items that belong to the selected category.")]
        public List<string> StringsToRemove { get; set; } = new();
    }

    public class ArmorSortingEntry
    {
        [SettingName("Keys")]
        [Tooltip("Items that match any of these text snippets will be a part of the selected category.")]
        public List<string> StringKeys { get; set; } = new();


        [SettingName("Keywords")]
        [Tooltip("Items that have any of these keywords will be a part of the selected category.")]
        public List<IFormLinkGetter<IKeywordGetter>> Keywords { get; set; } = new();


        [SettingName("Editor IDs")]
        [Tooltip("Items that correspond to any of the selected editor IDs will be a part of the selected category.")]
        public List<IFormLink<IArmorGetter>> EDIDS { get; set; } = new();


        [SettingName("Keys To Remove")]
        [Tooltip("The text snippets that should be removed from the names of items that belong to the selected category.")]
        public List<string> StringsToRemove { get; set; } = new();
    }

    public class MagicSortingEntry
    {
        [SettingName("Keys")]
        [Tooltip("Items that match any of these text snippets will be a part of the selected category.")]
        public List<string> StringKeys { get; set; } = new();


        [SettingName("Keywords")]
        [Tooltip("Items that have any of these keywords will be a part of the selected category.")]
        public List<IFormLinkGetter<IKeywordGetter>> Keywords { get; set; } = new();


        [SettingName("Editor IDs")]
        [Tooltip("Items that correspond to any of the selected editor IDs will be a part of the selected category.")]
        public List<IFormLink<ISpellGetter>> EDIDS { get; set; } = new();


        [SettingName("Keys To Remove")]
        [Tooltip("The text snippets that should be removed from the names of items that belong to the selected category.")]
        public List<string> StringsToRemove { get; set; } = new();
    }

    public class ConsumableSortingEntry
    {
        [SettingName("Keys")]
        [Tooltip("Items that match any of these text snippets will be a part of the selected category.")]
        public List<string> StringKeys { get; set; } = new();


        [SettingName("Keywords")]
        [Tooltip("Items that have any of these keywords will be a part of the selected category.")]
        public List<IFormLinkGetter<IKeywordGetter>> Keywords { get; set; } = new();


        [SettingName("Editor IDs")]
        [Tooltip("Items that correspond to any of the selected editor IDs will be a part of the selected category.")]
        public List<IFormLink<IIngestibleGetter>> EDIDS { get; set; } = new();


        [SettingName("Keys To Remove")]
        [Tooltip("The text snippets that should be removed from the names of items that belong to the selected category.")]
        public List<string> StringsToRemove { get; set; } = new();
    }

    public class ScrollSortingEntry
    {
        [SettingName("Keys")]
        [Tooltip("Items that match any of these text snippets will be a part of the selected category.")]
        public List<string> StringKeys { get; set; } = new();


        [SettingName("Keywords")]
        [Tooltip("Items that have any of these keywords will be a part of the selected category.")]
        public List<IFormLinkGetter<IKeywordGetter>> Keywords { get; set; } = new();


        [SettingName("Editor IDs")]
        [Tooltip("Items that correspond to any of the selected editor IDs will be a part of the selected category.")]
        public List<IFormLink<IScrollGetter>> EDIDS { get; set; } = new();


        [SettingName("Keys To Remove")]
        [Tooltip("The text snippets that should be removed from the names of items that belong to the selected category.")]
        public List<string> StringsToRemove { get; set; } = new();
    }

    public class IngredientSortingEntry
    {
        [SettingName("Keys")]
        [Tooltip("Items that match any of these text snippets will be a part of the selected category.")]
        public List<string> StringKeys { get; set; } = new();


        [SettingName("Keywords")]
        [Tooltip("Items that have any of these keywords will be a part of the selected category.")]
        public List<IFormLinkGetter<IKeywordGetter>> Keywords { get; set; } = new();


        [SettingName("Editor IDs")]
        [Tooltip("Items that correspond to any of the selected editor IDs will be a part of the selected category.")]
        public List<IFormLink<IIngredientGetter>> EDIDS { get; set; } = new();


        [SettingName("Keys To Remove")]
        [Tooltip("The text snippets that should be removed from the names of items that belong to the selected category.")]
        public List<string> StringsToRemove { get; set; } = new();
    }

    public class BookSortingEntry
    {
        [SettingName("Keys")]
        [Tooltip("Items that match any of these text snippets will be a part of the selected category.")]
        public List<string> StringKeys { get; set; } = new();


        [SettingName("Keywords")]
        [Tooltip("Items that have any of these keywords will be a part of the selected category.")]
        public List<IFormLinkGetter<IKeywordGetter>> Keywords { get; set; } = new();


        [SettingName("Editor IDs")]
        [Tooltip("Items that correspond to any of the selected editor IDs will be a part of the selected category.")]
        public List<IFormLink<IBookGetter>> EDIDS { get; set; } = new();


        [SettingName("Keys To Remove")]
        [Tooltip("The text snippets that should be removed from the names of items that belong to the selected category.")]
        public List<string> StringsToRemove { get; set; } = new();
    }

    public class MiscSortingEntry
    {
        [SettingName("Keys")]
        [Tooltip("Items that match any of these text snippets will be a part of the selected category.")]
        public List<string> StringKeys { get; set; } = new();


        [SettingName("Keywords")]
        [Tooltip("Items that have any of these keywords will be a part of the selected category.")]
        public List<IFormLinkGetter<IKeywordGetter>> Keywords { get; set; } = new();


        [SettingName("Editor IDs")]
        [Tooltip("Items that correspond to any of the selected editor IDs will be a part of the selected category.")]
        public List<IFormLink<IMiscItemGetter>> EDIDS { get; set; } = new();


        [SettingName("Keys To Remove")]
        [Tooltip("The text snippets that should be removed from the names of items that belong to the selected category.")]
        public List<string> StringsToRemove { get; set; } = new();
    }

    public class Weapons
    {
        [SettingName("Format")]
        [Tooltip("The form which the name of the sorted item should have. You can use $type to add the name of the category and $name to add the name of the item.")]
        public string Formatting { get; set; } = "$type $name";


        [SettingName("Entries")]
        [Tooltip("Here you can add new sorting types.")]
        public Dictionary<string, WeaponSortingEntry> SortingEntries { get; set; } = new();
    }

    public class Armors
    {
        [SettingName("Format")]
        [Tooltip("The form which the name of the sorted item should have. You can use $type to add the name of the category and $name to add the name of the item.")]
        public string Formatting { get; set; } = "$type $name";


        [SettingName("Entries")]
        [Tooltip("Here you can add new sorting types.")]
        public Dictionary<string, ArmorSortingEntry> SortingEntries { get; set; } = new();
    }

    public class Magic
    {
        [SettingName("Format")]
        [Tooltip("The form which the name of the sorted item should have. You can use $type to add the name of the category and $name to add the name of the item.")]
        public string Formatting { get; set; } = "$type $name";


        [SettingName("Entries")]
        [Tooltip("Here you can add new sorting types.")]
        public Dictionary<string, MagicSortingEntry> SortingEntries { get; set; } = new();
    }

    public class Consumables
    {
        [SettingName("Format")]
        [Tooltip("The form which the name of the sorted item should have. You can use $type to add the name of the category and $name to add the name of the item.")]
        public string Formatting { get; set; } = "$type $name";


        [SettingName("Entries")]
        [Tooltip("Here you can add new sorting types.")]
        public Dictionary<string, ConsumableSortingEntry> SortingEntries { get; set; } = new();
    }

    public class Scrolls
    {
        [SettingName("Format")]
        [Tooltip("The form which the name of the sorted item should have. You can use $type to add the name of the category and $name to add the name of the item.")]
        public string Formatting { get; set; } = "$type $name";


        [SettingName("Entries")]
        [Tooltip("Here you can add new sorting types.")]
        public Dictionary<string, ScrollSortingEntry> SortingEntries { get; set; } = new();
    }

    public class Ingredients
    {
        [SettingName("Format")]
        [Tooltip("The form which the name of the sorted item should have. You can use $type to add the name of the category and $name to add the name of the item.")]
        public string Formatting { get; set; } = "$type $name";


        [SettingName("Entries")]
        [Tooltip("Here you can add new sorting types.")]
        public Dictionary<string, IngredientSortingEntry> SortingEntries { get; set; } = new();
    }

    public class Books
    {
        [SettingName("Format")]
        [Tooltip("The form which the name of the sorted item should have. You can use $type to add the name of the category and $name to add the name of the item.")]
        public string Formatting { get; set; } = "$type $name";


        [SettingName("Entries")]
        [Tooltip("Here you can add new sorting types.")]
        public Dictionary<string, BookSortingEntry> SortingEntries { get; set; } = new();
    }

    public class Misc
    {
        [SettingName("Format")]
        [Tooltip("The form which the name of the sorted item should have. You can use $type to add the name of the category and $name to add the name of the item.")]
        public string Formatting { get; set; } = "$type $name";


        [SettingName("Entries")]
        [Tooltip("Here you can add new sorting types.")]
        public Dictionary<string, MiscSortingEntry> SortingEntries { get; set; } = new();
    }



    public class Settings
    {
        public Weapons Weapons { get; set; } = new();


        public Armors Armors { get; set; } = new();


        public Magic Magic { get; set; } = new();


        public Consumables Consumables { get; set; } = new();


        public Scrolls Scrolls { get; set; } = new();


        public Ingredients Ingredients { get; set; } = new();


        public Books Books { get; set; } = new();


        public Misc Misc { get; set; } = new();
    }
}
