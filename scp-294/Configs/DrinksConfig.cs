using Exiled.API.Enums;
using PlayerRoles;
using scp_294.Items;
using scp_294.Items.DrinkFeatures;
using System.Collections.Generic;

namespace scp_294.Configs
{
    public class DrinksConfig
    {
        public List<Drink> Drinks { get; set; } =
        [
            new Drink()
            {
                Id = 1,
                Name = "Bir şişe boşluk",
                Aliases = { "nothing", "drink of cup", "drink of emptiness", "drink of vacuum", "HL3", "Half Life 3" },
                Description = "Şişenin içinde hiçbir şey yok.",
            },
            new Drink()
            {
                Id= 2,
                Name = "scp içeceği",
                Description = "Seni rastgele bir Scp gibi gösterir.",
                AppearanceOptions =
                {
                    ChangePlayerAppearance = true,
                    PossibleRoles = new()
                    {
                        RoleTypeId.Scp173,
                        RoleTypeId.Scp049,
                        RoleTypeId.Scp096,
                        RoleTypeId.Scp0492,
                        RoleTypeId.Scp106,
                        RoleTypeId.Scp939,
                        RoleTypeId.Scp3114
                    },
                    Duration = 10,
                    DisguiseMessage = "Şuan $new_role_name gibi görünüyorsun. Normale dönmek için <color=#ff0000>$time_left</color> saniyen var.",
                    NoLongerInDisguise = "Artık normal halindesin"
                }
            },
            new Drink()
            {
                Id=3,
                Name = "173'ün kanlı dışkısı",
                Aliases = { "drink of 173" },
                Description = "REEEEEEEEEEEEEEEEE.",
                Effects =
                {
                    new Effect()
                    {
                    Type = EffectType.MovementBoost,
                    İntensity = new() { FixedAmount = 50 },
                    Duration = 30f,
                    Chance = 100
                    },
                }
            },
            new Drink()
            {
                Id = 4,
                Name = "106 nın salyası",
                Aliases = { "drink of 106" },
                Description = "106 gibi kokuyor. Mmmhh lezziz!",
                ExtraEffects = { TeleportToPocketDimension = true }
            },
            new Drink()
            {
                Id = 5,
                Name = "Bi şişe cum",
                Aliases = { "cum" },
                Description = "Beyaz ve yapışkan bir sıvı Iğhk sanırım?",
                ExtraEffects = { PlaceTantrum = true }
            },
            new Drink()
            {
                Id = 6,
                Name = "End meyvesi",
                Aliases = { "teleport drink" },
                Description = "Hiç minecraft oynadın mı? O zaman ne işe yaradığını biliyorsun.",
                TeleportManager =
                {
                    PlayerTeleport = true,
                    CanPlayerEscapePocketDimension = false,
                    MessagePreventingPocketTeleport = "You are prevented by a magical force from being teleported out of the pocket dimension",
                    Zone = ZoneType.Unspecified,
                    Room = RoomType.Unknown
                }
            },
            new Drink()
            {
                Id = 7,
                Name = "Şeker içeceği",
                Aliases = { "candy" },
                Description = "Çok çekici bir kokusu var. Acaba tadı neye benziyor?",
                Effects =
                {
                    new Effect()
                    {
                        Type = EffectType.Vitality,
                        İntensity = new() { FixedAmount = 3 },
                        Duration = 40f,
                        Chance = 100
                    },
                    new Effect()
                    {
                        Type = EffectType.DamageReduction,
                        İntensity = new() { FixedAmount = 40 },
                        Duration = 30f,
                        Chance = 50
                    },
                    new Effect()
                    {
                        Type = EffectType.RainbowTaste,
                        İntensity = new() { FixedAmount = 1 },
                        Duration = 20f,
                        Chance = 50
                    },
                    new Effect()
                    {
                        Type = EffectType.Invigorated,
                        İntensity = new() { FixedAmount = 1 },
                        Duration = 10f,
                        Chance = 50
                    },
                    new Effect()
                    {
                        Type = EffectType.BodyshotReduction,
                        İntensity = new() { FixedAmount = 1 },
                        Duration = 0,
                        Chance = 50
                    },
                    new Effect()
                    {
                        Type = EffectType.MovementBoost,
                        İntensity = new() { FixedAmount = 10 },
                        Duration = 20f,
                        Chance = 50
                    }
                },
                ExtraEffects = { AhpGain = 20, HealAmount = 90 }
            },
            new Drink()
            {
                Id = 8,
                Name = "Gökkuşağı içeceği",
                Description = "Tüm o aromaları içinde hisset.",
                Effects =
                {
                    new Effect()
                    {
                        Type = EffectType.Invigorated,
                        İntensity = new() { FixedAmount = 1 },
                        Duration = 10f,
                        Chance = 100
                    },
                    new Effect()
                    {
                        Type = EffectType.RainbowTaste,
                        İntensity = new() { FixedAmount = 1 },
                        Duration = 20f,
                        Chance = 100
                    },
                    new Effect()
                    {
                        Type = EffectType.BodyshotReduction,
                        İntensity = new() { FixedAmount = 1 },
                        Duration = 0,
                        Chance = 100
                    }
                },
                ExtraEffects = { AhpGain = 40, HealAmount = 30 }
            },
            new Drink()
            {
                Id = 9,
                Name = "Sarı içecek",
                Description = "Limon kokusu o kadar güçlü ki yüzün ekşiyor.",
                Effects =
                {
                    new Effect()
                    {
                        Type = EffectType.Invigorated,
                        İntensity = new() { FixedAmount = 1 },
                        Duration = 20f,
                        Chance = 100
                    },
                    new Effect()
                    {
                        Type = EffectType.MovementBoost,
                        İntensity = new() { FixedAmount = 10 },
                        Duration = 20f,
                        Chance = 100
                    }
                }
            },
            new Drink()
            {
                Id = 10,
                Name = "Mor içecek",
                Description = "Hmm üzümlü gibi görünüyor. Ağzının suları aktı.",
                Effects =
                {
                    new Effect()
                    {
                        Type = EffectType.DamageReduction,
                        İntensity = new() { FixedAmount = 40 },
                        Duration = 30f,
                        Chance = 100
                    }
                },
                ExtraEffects = { Regeneration = { Rate = 1.5f, Duration = 20f } }
            },
            new Drink()
            {
                Id = 11,
                Name = "Kırmızı içecek",
                Description = "Güçlü kiraz kokusu odayı dolduruyor. Biraz ... fazla güçlü.",
                ExtraEffects = { Regeneration = { Rate = 9f, Duration = 10f } }
            },
            new Drink()
            {
                Id = 12,
                Name = "Yeşil içecek",
                Description = "Meyve suyu gibi ama kötü bir koku yayılıyor.",
                Effects =
                {
                    new Effect()
                    {
                        Type = EffectType.Vitality,
                        İntensity = new() { FixedAmount = 1 },
                        Duration = 45f,
                        Chance = 100
                    }
                },
                ExtraEffects = { Regeneration = { Rate = 2.25f, Duration = 80f } }
            },
            new Drink()
            {
                Id = 13,
                Name = "Mavi içecek",
                Description = "Hafif tatlı bir kokusu var, marshmallow gibi bir şey.",
                ExtraEffects = { AhpGain = 60 }
            },
            new Drink()
            {
                Id = 14,
                Name = "Pembe içecek",
                Description = "Şişenin içi sürekli titriyor ayrıca üstünde patlayıcı uyarısı var içmesen iyi edersin.",
                ExtraEffects = { PlayerExplode = true }
            },
            new Drink()
            {
                Id = 15,
                Name = "Bir şişe kan",
                Description = "Çok yorgun hissediyorsun san- sanki bir şey kanını çekmiş gibi.",
                ExtraEffects = { DamageAmount = 30 }
            },
            new Drink()
            {
                Id = 16,
                Name = "Yaşam içeceği",
                Description = "Yenilenmiş ve yenilmez hissediyorsun!",
                ExtraEffects = { HealAmount = 100 }
            },
            new Drink()
            {
                Id = 17,
                Name = "Anti madde?",
                Aliases = { "anti-matter", "void" },
                Description = "Sanki içecek seni içine çekiyor?",
                ExtraEffects = { DamageAmount = 99 }
            },
            new Drink()
            {
                Id = 18,
                Name = "Messi kolası ",
                Description = "Aman tanrım, saf yetenek ama hangi yönden?",
                ExtraEffects = { MaxHealAmount = 60f },
                ScalingOptions =
                {
                    ChangePlayerSize = true,
                    x = 0.6f,
                    y = 0.6f,
                    z = 0.6f,
                },
            },
            new Drink()
            {
                Id = 19,
                Name = "Kaos içeceği",
                Description = "Şişenin içinde yeşil ve mavi sıvı dönüp duruyor sanırım yeşil kazanıyor",
                RoleManagerOptions =
                {
                    PlayerChangeRoles = true,
                    Roles =
                    {
                        RoleTypeId.ChaosRifleman,
                        RoleTypeId.ChaosMarauder,
                        RoleTypeId.ChaosConscript,
                        RoleTypeId.ChaosRepressor,
                    }
                },
                ExtraEffects = { DamageAmount = 80 }
            }
        ];
    }
}
