using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KungligaOperanAnsokan.Models
{
    public class ChoirApplication : Application
    {
        public Range VocalRange { get; set; }
    }

    public enum Range
    {
        Soprano,
        Mezzosoprano,
        Contralto,
        Countertenor,
        Tenor,
        Baritone,
        Bass
    }
}
