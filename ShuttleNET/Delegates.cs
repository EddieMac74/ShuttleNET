using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuttleNET
{
    public delegate void Shuttle_Move(object sender, ShuttleEventArgs e);
    public delegate void Button_Click(object sender, ButtonClickEventArgs e);
    public delegate void Jog_Move(object sender, JogEventArgs e);
}
