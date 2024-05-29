using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WitSolutions.ViewModels
{
    public class ClientQueryVM
    {
      
        public string Name { get; set; }

        [EmailAddress]
        public string email { get; set; }
        public string subject { get; set; }
        public string message { get; set; }


    }

}
