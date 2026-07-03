using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TechnozoicJourney.Content.Items.TreasureBags
{
    public class StarterBox : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Content.Items.TreasureBags";

        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 0;
        }

        public override void SetDefaults()
        {
            Item.width = Item.height = 16;
            Item.maxStack = Item.CommonMaxStack;
            Item.rare = ItemRarityID.Blue;
            Item.value = Item.sellPrice();
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void ModifyItemLoot(ItemLoot itemLoot)
        {
            
        }
    }
}