using System.ComponentModel.DataAnnotations;

namespace TiltonToys.Models
{
    /* The CartItem class contains the schema that will define each 
     * product a user adds to the shopping cart.
     * 
     * The CartId property specifies the ID of the user that is 
     * associated with the item to purchase.
     */
    public class CartItem
    {
        [Key]
        public string ItemId { get; set; }

        public string CartId { get; set; }

        public int Quantity { get; set; }

        public System.DateTime DateCreated { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}