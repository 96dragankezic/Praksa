using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbPalindrom.Models
{
    public partial class Palindrome
    {
        [Key]
        public string Text { get; set; }
    }
}
