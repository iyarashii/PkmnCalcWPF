using PkmnCalcWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PkmnCalcWPF.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public static string Name { get; set; }
        public List<IPkmnType> PkmnTypeList { get; set; } = GeneratePkmnTypeList();
        public ICommand ClearTextCommand { get; set; }

        public MainWindowViewModel()
        {
            //ClearTextCommand = CommandsFactory.CreateClearTextCommand(this);
        }

        public static List<IPkmnType> GeneratePkmnTypeList()
        {
            List<IPkmnType> output = PkmnTypeFactory.CreatePkmnTypeList();

            output.Add(PkmnTypeFactory.CreateNormalPkmnType());
            output.Add(PkmnTypeFactory.CreateFightingPkmnType());
            output.Add(PkmnTypeFactory.CreateFlyingPkmnType());
            output.Add(PkmnTypeFactory.CreatePoisonPkmnType());
            output.Add(PkmnTypeFactory.CreateGroundPkmnType());
            output.Add(PkmnTypeFactory.CreateRockPkmnType());
            output.Add(PkmnTypeFactory.CreateBugPkmnType());
            output.Add(PkmnTypeFactory.CreateGhostPkmnType());
            output.Add(PkmnTypeFactory.CreateSteelPkmnType());
            output.Add(PkmnTypeFactory.CreateFirePkmnType());
            output.Add(PkmnTypeFactory.CreateWaterPkmnType());
            output.Add(PkmnTypeFactory.CreateGrassPkmnType());
            output.Add(PkmnTypeFactory.CreateElectricPkmnType());
            output.Add(PkmnTypeFactory.CreatePsychicPkmnType());
            output.Add(PkmnTypeFactory.CreateIcePkmnType());
            output.Add(PkmnTypeFactory.CreateDragonPkmnType());
            output.Add(PkmnTypeFactory.CreateDarkPkmnType());
            output.Add(PkmnTypeFactory.CreateFairyPkmnType());
            return output;
        }
    }
}
