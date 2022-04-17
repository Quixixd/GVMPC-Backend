using System;
using System.Collections.Generic;
using System.Text;
using GVMP;
using Crimelife;
using GTANetworkAPI;
namespace Crimelife.Module.AntiOnePunch
{
    class Ati
    {
        [RemoteEvent("onehitcheat")]
        public void antiHS(Player p)
        {
            DbPlayer dbPlayer = p.GetPlayer();
            WebhookSender.SendMessage("AntiCheat", "Der Spieler " + dbPlayer.Name + " hat warscheinlich den Onehit cheat benutzt!", Webhooks.aclogs, "Admin");
            p.Kick("OnehitSchlag");
        }
    }
}
