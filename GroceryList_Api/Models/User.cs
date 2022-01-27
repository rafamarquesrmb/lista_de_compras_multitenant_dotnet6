﻿namespace GroceryList_Api.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public virtual List<GroceryList> GroceryLists { get; set; } = new List<GroceryList>();
        


    }
}