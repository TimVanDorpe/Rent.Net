using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Item")]
public class Item
    {
      
        [Key]
        public int item_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }

    public Item()
    {

    }

}
