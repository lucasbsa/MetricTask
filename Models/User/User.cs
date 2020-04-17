using System;
using System.Collections.Generic;
using System.Text;

namespace Models.MoldelUser
{
    public class User
    {
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime? DataInclusao { get; set; }

        

    }
}
