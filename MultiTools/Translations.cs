namespace MultiTools
{
    using Exiled.API.Interfaces;

    public sealed class Translations : ITranslation
    {
        public string CheaterHint { get; private set; } = $"You are being checked for cheats!\nYou must report the player [Admin.Nickname]([Admin.DisplayNickname]) on your discord.\nYou have [time] seconds left before an automatic ban!\nWhen you leave the server you will receive a ban.";
        public string AdminReportHint { get; private set; } = $"The player [target] received a complaint from [player] for the reason:\n[reason]!!!";
        public string ReportHint { get; private set; } = $"Successfully sent a report to player [target]!";
        public string TargetCuffHint { get; private set; } = $"You are tied up, do not move for [time] seconds!";
        public string PlayerCuffHint { get; private set; } = $"You cuff player [target] do not move for [time] seconds!";
        public string CuffError { get; private set; } = $"You need to hold a weapon in your hands to do this.";
        public string CallBroadcast { get; private set; } = $"Admins!\n Player [player] calling you!";
        public string NTFCall { get; private set; } = "Mobile Task Force Unit Epsilon 11 Designated .g5 .g5 .g5 **** has entered the facility about t minus 2 minutes";
        public string ChaosHint { get; private set; } = "You were spawned as a Chaos Insurgency Spy";
        
        public string ClassD { get; set; } = "<color=orange>Класс-Д</color>";
        public string Scientist { get; set; } = "<color=#F0E827>Учёный</color>";
        public string FacilityGuard { get; set; } = "<color=#505050>Служба безопасности</color>";
        public string ChaosConscript { get; set; } = "<color=#1F620A>Повстанец хаоса - Новобранец</color>";
        public string ChaosMarauder { get; set; } = "<color=#1F620A>Повстанец хаоса - Марадёр</color>";
        public string ChaosRepressor { get; set; } = "<color=#1F620A>Повстанец хаоса - Устремитель</color>";
        public string ChaosRifleman { get; set; } = "<color=#1F620A>Повстанец хаоса - Стрелок</color>";
        public string NtfPrivate { get; set; } = "<color=#05B1C3>Рядовой мобильной оперативной группы</color>";
        public string NtfSergeant { get; set; } = "<color=#056AC3>Сержант мобильной оперативной группы</color>";
        public string NtfSpecialist { get; set; } = "<color=#056AC3>Специалист мобильной оперативной группы</color>";
        public string NtfCaptain { get; set; } = "<color=#0B39EE>Капитан мобильной оперативной группы</color>";
        public string Scp173 { get; set; } = "<color=red>SCP-173</color>";
        public string Scp106 { get; set; } = "<color=red>SCP-106</color>";
        public string Scp049 { get; set; } = "<color=red>SCP-049</color>";
        public string Scp3114 { get; set; } = "<color=red>SCP-3114 💀</color>";
        public string Scp939 { get; set; } = "<color=red>SCP-939</color>";
        public string Scp0492 { get; set; } = "<color=red>SCP-049-2</color>";
        public string Scp079 { get; set; } = "<color=red>SCP-079</color>";
        public string Scp096 { get; set; } = "<color=red>SCP-096</color>";
        public string Tutorial { get; set; } = "<color=#ff00b0>Обучение</color>";
    }
}
