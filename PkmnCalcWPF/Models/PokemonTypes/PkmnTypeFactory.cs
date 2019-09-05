using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PkmnCalcWPF.Models
{
    public static class PkmnTypeFactory
    {
        public static List<IPkmnType> CreatePkmnTypeList()
        {
            return new List<IPkmnType>();
        }

        public static IPkmnType CreateNormalPkmnType()
        {
            return new NormalPkmnType();
        }

        public static IPkmnType CreateFightingPkmnType()
        {
            return new FightingPkmnType();
        }

        public static IPkmnType CreateFlyingPkmnType()
        {
            return new FlyingPkmnType();
        }

        public static IPkmnType CreatePoisonPkmnType()
        {
            return new PoisonPkmnType();
        }

        public static IPkmnType CreateGroundPkmnType()
        {
            return new GroundPkmnType();
        }

        public static IPkmnType CreateRockPkmnType()
        {
            return new RockPkmnType();
        }

        public static IPkmnType CreateBugPkmnType()
        {
            return new BugPkmnType();
        }

        public static IPkmnType CreateGhostPkmnType()
        {
            return new GhostPkmnType();
        }

        public static IPkmnType CreateSteelPkmnType()
        {
            return new SteelPkmnType();
        }

        public static IPkmnType CreateFirePkmnType()
        {
            return new FirePkmnType();
        }

        public static IPkmnType CreateWaterPkmnType()
        {
            return new WaterPkmnType();
        }

        public static IPkmnType CreateGrassPkmnType()
        {
            return new GrassPkmnType();
        }

        public static IPkmnType CreateElectricPkmnType()
        {
            return new ElectricPkmnType();
        }

        public static IPkmnType CreatePsychicPkmnType()
        {
            return new PsychicPkmnType();
        }
        public static IPkmnType CreateIcePkmnType()
        {
            return new IcePkmnType();
        }
        public static IPkmnType CreateDragonPkmnType()
        {
            return new DragonPkmnType();
        }
        public static IPkmnType CreateDarkPkmnType()
        {
            return new DarkPkmnType();
        }
        public static IPkmnType CreateFairyPkmnType()
        {
            return new FairyPkmnType();
        }
    }
}
