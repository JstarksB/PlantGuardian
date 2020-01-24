using System;

using PlantGuardian.Models;

namespace PlantGuardian.ViewModels
{
   public class ItemDetailViewModel : BaseViewModel
   {
      public Item Item { get; set; }
      public ItemDetailViewModel(Item item = null)
      {
         Title = item?.Text;
         Item = item;
      }
   }
}
