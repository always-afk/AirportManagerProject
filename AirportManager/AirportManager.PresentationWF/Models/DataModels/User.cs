using System;
using System.Collections.Generic;

#nullable disable

namespace AirportManager.PresentationWF.Models.DataModels
{
    public partial class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual staff IdNavigation { get; set; }
    }
}
