using System;
using System.Collections.Generic;
using System.Text;
using GVMP;
using Crimelife;
using GTANetworkAPI;
namespace Crimelife.Module.AntiOnePunch
{
    class ZKey
    {
        [RemoteEvent("crmnlcheater")]
        public void dujude(Player p)
        {
            DbPlayer dbPlayer = p.GetPlayer();
            WebhookSender.SendMessage("AntiCheat", "Der Spieler " + dbPlayer.Name + " hat warscheinlich den Onehit cheat benutzt!", Webhooks.crmnlwarscheinlich, "Admin");
        }
    }
}
